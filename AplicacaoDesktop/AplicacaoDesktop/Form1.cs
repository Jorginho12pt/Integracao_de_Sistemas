﻿using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using static AplicacaoDesktop.EnumEx;
using Newtonsoft.Json;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Stream.Client;
using RabbitMQ.Stream.Client.Reliable;
using System.Diagnostics;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AplicacaoDesktop
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            textBox_DataHora.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        private string getFormInformationJsonSerializeObject()
        {
            DesktopTeste info = new DesktopTeste();
            info.DataHora = DateTime.Parse(textBox_DataHora.Text);
            info.CodigoPeca = textBox_CodigoPreco.Text;

            info.TempoProducao = int.Parse(textBox_TempoProd.Text);
            info.ResultadoTeste = GetValueFromDescription<Resposta>(comboBox_RespostaTest.Text);
            return JsonConvert.SerializeObject(info);
        }

        private string getFormInformationString()
        {
            string info = textBox_DataHora.Text + ";"
                + textBox_CodigoPreco.Text + ";"
                + textBox_TempoProd.Text + ";"
                + GetValueFromDescription<Resposta>(comboBox_RespostaTest.Text).ToString();
            Debug.WriteLine($"{info}");
            return info;
        }

        private void SettBlock(bool b)
        {
            textBox_CodigoPreco.Enabled = b;
            textBox_TempoProd.Enabled = b;
            comboBox_RespostaTest.Enabled = b;

            button_SendButton.Enabled = b;
            button_SendRabbitMq.Enabled = b;
            button_SendRabbitMqStream.Enabled = b;
            button_Random.Enabled = b;
        }

        private int GetTempoProd()
        {
            Random random = new Random();
            return random.Next(10, 51);
        }

        private void SettRandom(int ? tempoProd = 0 )
        {
            Random random = new Random();
            const string chars = "ab";
            const string chars2 = "123456789";

            textBox_DataHora.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
            textBox_CodigoPreco.Text = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray())
                + new string(Enumerable.Repeat(chars2, 6).Select(s => s[random.Next(s.Length)]).ToArray());
            textBox_TempoProd.Text = tempoProd==0 ? random.Next(10, 51).ToString() : tempoProd.ToString();
            comboBox_RespostaTest.SelectedIndex = random.Next(6);
        }

        private async void RabbitMQCall()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                    queue: "AplicacaoDesktop",
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

            string json = getFormInformationJsonSerializeObject();

            var body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "AplicacaoDesktop", body: body);

            Debug.WriteLine($"{json}");
        }

        private async void RabbitMQStreamCall()
        {
            var streamSystem = await StreamSystem.Create(new StreamSystemConfig
            {
                UserName = "guest",
                Password = "guest",
                Endpoints = new List<EndPoint>() {
                    new IPEndPoint(IPAddress.Loopback, 5552)
                },
                VirtualHost = "/"
            });

            await streamSystem.CreateStream(new StreamSpec("Manager-Stream")
            {
                MaxLengthBytes = 5_000_000_000
            });

            var producer = await Producer.Create(new ProducerConfig(streamSystem, "Manager-Stream"));

            await producer.Send(new RabbitMQ.Stream.Client.Message(Encoding.UTF8.GetBytes(getFormInformationString())));
        }

        private async void button_SendButton_ClickAsync(object sender, EventArgs e)
        {
            if (this.Controls.Cast<Control>().Any(c => (c is System.Windows.Forms.TextBox || c is System.Windows.Forms.ComboBox) && string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("Rafa para de brincar!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string json = getFormInformationJsonSerializeObject();
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        var response = await client.PostAsync("https://localhost:7252/Api/InsertTesteSP", content);
                        var responseString = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseString);
                    }
                }
                catch (Exception r)
                {
                    MessageBox.Show("Error: " + r.Message);
                }
            }

            textBox_DataHora.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
            textBox_CodigoPreco.Text = "";
            textBox_TempoProd.Text = "";
            comboBox_RespostaTest.SelectedIndex = -1;
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            SettRandom();
        }

        private async void button_SendRabbitMq_Click(object sender, EventArgs e)
        {
            RabbitMQCall();
        }

        private async void button_SendRabbitMqStream_Click(object sender, EventArgs e)
        {
            RabbitMQStreamCall();
        }

        private async void checkBox_Auto_CheckedChanged(object sender, EventArgs e)
        {
            SettBlock(!checkBox_Auto.Checked);
            while (checkBox_Auto.Checked)
            {
                int tempoProd = GetTempoProd();
                Debug.WriteLine($"{tempoProd}");
                await Task.Delay((tempoProd * 1000));
                if (checkBox_Auto.Checked)
                {
                    SettRandom(tempoProd);
                    RabbitMQCall();
                    RabbitMQStreamCall();
                }  
            }
          
        }
    }
}
