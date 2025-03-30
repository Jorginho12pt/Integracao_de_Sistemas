using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using static AplicacaoDesktop.EnumEx;
using Newtonsoft.Json;
using System.Text;

namespace AplicacaoDesktop
{
    public partial class Form: System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            textBox_DataHora.Text = DateTime.UtcNow.ToString();
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
                    DesktopTeste teste = new DesktopTeste();

                    teste.DataHora = DateTime.Parse(textBox_DataHora.Text);
                    teste.CodigoPeca = textBox_CodigoPreco.Text;
                    teste.TempoProduco = TimeSpan.Parse(textBox_TempoProd.Text);
                    teste.ResultadoTeste = GetValueFromDescription<Resposta>(comboBox_RespostaTest.Text);

                    var json = JsonConvert.SerializeObject(teste);
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
            
            textBox_DataHora.Text = DateTime.UtcNow.ToString();
            textBox_CodigoPreco.Text = "";
            textBox_TempoProd.Text = "00:00:00";
            comboBox_RespostaTest.SelectedIndex = -1;
        }
    }
}
