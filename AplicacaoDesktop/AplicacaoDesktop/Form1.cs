using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using static AplicacaoDesktop.EnumEx;
using Newtonsoft.Json;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client;
using System.Text;
using System.Diagnostics;

namespace AplicacaoDesktop
{
    public partial class Form: System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            textBox_DataHora.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        private string getFormInformationJsonSerializeObject()
        {
            DesktopTeste teste = new DesktopTeste();
            teste.DataHora = DateTime.Parse(textBox_DataHora.Text);
            teste.CodigoPeca = textBox_CodigoPreco.Text;

            teste.TempoProducao = int.Parse(textBox_TempoProd.Text);
            teste.ResultadoTeste = GetValueFromDescription<Resposta>(comboBox_RespostaTest.Text);
            return JsonConvert.SerializeObject(teste);
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

        private void TempoProducao_Click(object sender, EventArgs e)
        {

        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            const string chars = "ab";
            const string chars2 = "123456789";

            textBox_DataHora.Text = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss");
            textBox_CodigoPreco.Text = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray()) 
                + new string(Enumerable.Repeat(chars2, 6).Select(s => s[random.Next(s.Length)]).ToArray());
            textBox_TempoProd.Text = random.Next(10, 51).ToString();
            comboBox_RespostaTest.SelectedIndex = random.Next(6);
        }

        private async void button_SendRabbitMq_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(
                    queue: "AplicacaoWeb",
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

            string json = getFormInformationJsonSerializeObject();

            var body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(exchange: string.Empty, routingKey: "AplicacaoWeb", body: body);

            Debug.WriteLine($"{json}");
        }
    }
}
