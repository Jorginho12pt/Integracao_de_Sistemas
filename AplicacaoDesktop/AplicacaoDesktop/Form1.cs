using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoDesktop
{
    public partial class Form: System.Windows.Forms.Form
    {                                                // colocar o nome do vosso server
        public SqlConnection con = new SqlConnection(@"Server=DESKTOP-KMH9NTP\SQLEXPRESS;Database=SistemaDesktop;Integrated Security=True"); // Jorge
        enum Resposta
        {
            Ok = 1,
            Falha_na_inspeção_visual = 2,
            Falha_na_inspeção_de_resistência = 3,
            Falha_na_inspeção_de_dimensões = 4,
            Falha_na_inspeção_de_estanqueidade = 5,
            Desconhecido = 6
        }

        public Form()
        {
            InitializeComponent();
            textBox_DataHora.Text = DateTime.UtcNow.ToString();
            comboBox_RespostaTest.Items.AddRange(Enum.GetNames(typeof(Resposta)));
        }


        private void button_SendButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.Cast<Control>().Any(c => (c is System.Windows.Forms.TextBox || c is System.Windows.Forms.ComboBox) && string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("Rafa para de brincar!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (con)
                {
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO dbo.Teste (DataHora, CodigoPeca, TempoProducao, ResultadoTeste) VALUES (@DataHora,@CodigoPeca,@TempoProducao, @ResultadoTeste)"))
                        {
                            DateTime a;
                            DateTime.TryParse(textBox_DataHora.Text ,out a);

                            var aa = a;
                            var aaaaa = Enum.Parse(typeof(Resposta), comboBox_RespostaTest.Text);
                            var b = textBox_CodigoPreco.Text;
                            var c = textBox_TempoProd.Text;
                            var d = comboBox_RespostaTest.Text;
                            var gg = Enum.Parse(typeof(Resposta), comboBox_RespostaTest.Text);


                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@DataHora", DateTime.Parse(textBox_DataHora.Text));
                            cmd.Parameters.AddWithValue("@CodigoPeca", textBox_CodigoPreco.Text);
                            cmd.Parameters.AddWithValue("@TempoProducao", DateTime.Parse(textBox_TempoProd.Text));
                            cmd.Parameters.AddWithValue("@ResultadoTeste", Enum.Parse(typeof(Resposta), comboBox_RespostaTest.Text));

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Foi gravado na base de dados, amigo");
                            }
                            else
                            {
                                MessageBox.Show("Deu merda");
                            }
                        }
                    }
                    catch (Exception r)
                    {
                        MessageBox.Show("Error during insert: " + r.Message);
                    }
                }

                // CHamar API do Server
            }
            
            textBox_DataHora.Text = DateTime.UtcNow.ToString();
        }
    }
}
