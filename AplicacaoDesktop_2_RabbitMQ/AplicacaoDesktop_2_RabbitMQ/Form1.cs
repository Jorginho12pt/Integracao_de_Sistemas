using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoDesktop_2_RabbitMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView_FailedPeca.AllowUserToAddRows = false;
            DataTable dtNew = new DataTable();
            dtNew.Columns.Add("Data e Hora", typeof(DateTime));
            dtNew.Columns.Add("Codigo da Peça", typeof(string));
            dtNew.Columns.Add("Tempo de Produção (segundos)", typeof(int));
            dtNew.Columns.Add("Resposta do Teste", typeof(string));

            dataGridView_FailedPeca.DataSource = dtNew;

            dataGridView_FailedPeca.Columns["Data e Hora"].Width = 150;
            dataGridView_FailedPeca.Columns["Codigo da Peça"].Width = 100;
            dataGridView_FailedPeca.Columns["Tempo de Produção (segundos)"].Width = 180;
            dataGridView_FailedPeca.Columns["Resposta do Teste"].Width = 250;
        }

        private void SafeUIInvoke(Action action)
        {
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute = field?
                .GetCustomAttribute<DescriptionAttribute>();

            return attribute?.Description ?? value.ToString();
        }

        public async void ApiWebCall(DesktopTeste info)
        {
            try
            {
                string json = JsonConvert.SerializeObject(info);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync("https://localhost:7252/Api/InsertTesteSP", content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseString);
                }
                if (!(info.ResultadoTeste==1) && !(info.ResultadoTeste==6))
                {
                    SafeUIInvoke(() =>
                    {
                        DataTable dt = dataGridView_FailedPeca.DataSource as DataTable;

                        DataRow row = dt.NewRow();
                        row[0] = info.DataHora;
                        row[1] = info.CodigoPeca;
                        row[2] = info.TempoProducao;
                        row[3] = GetEnumDescription((Resposta)info.ResultadoTeste);

                        dt.Rows.Add(row);
                    });
                }  
            }
            catch (Exception r)
            {
                MessageBox.Show("Error: " + r.Message);
            }
            
        }
    }
}
