using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoManager
{
    public partial class Form1 : Form
    {
        private int PecasProduzidas = 0;
        private int PecasSemFalhas =0;
        private int PecasOk = 0;
        private List<int> MedioCalc = new List<int>();
        private List<int> TempoMedioProducao = new List<int>();
        private List<string> CodigoPeca = new List<string>();

        public Form1()
        {
            InitializeComponent();
            MedioCalc.Add(0);
            TempoMedioProducao.Add(0);
            CodigoPeca.Add("");
            PopulateForm();
        }

        private void PopulateForm()
        {
            textBox_PecasProduzidas.Text = PecasProduzidas.ToString();
            textBox_PecasSemFalhas.Text = PecasSemFalhas.ToString();
            textBox_PecasOk.Text = PecasOk.ToString();
            // adicionar na list box e dar clear 
            //textBox_TempoMedioProducao.Text = TempoMedioProducao[0].ToString();
            //comboBox_TempoMedioProducao.Items
        }

        public void AddData(string message)
        {
            //[0] textBox_DataHora 
            //[1] textBox_CodigoPreco
            //[2] textBox_TempoProd 
            //[3] comboBox_RespostaTest ( 1..6)
            string[] parts = message.Split(';');

            if (parts.Length != 4)
            {
                MessageBox.Show("Rafa limpa o RabbitMQ Stream pá!", "Erro message invalida",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PecasProduzidas++;
            if ((parts[3]=="1") || (parts[3] == "6"))
            {
                PecasSemFalhas++;

                if ((parts[3] == "1"))
                {
                    PecasOk++;
                }
            }

            //só porque sou paranoico
            if (CodigoPeca.Count == TempoMedioProducao.Count && CodigoPeca.Count == MedioCalc.Count)
            {
                var flag = true;
                for (int i = 1; i < CodigoPeca.Count; i++)
                {
                    if (parts[1] == CodigoPeca[i])
                    {
                        MedioCalc[i]++;
                        TempoMedioProducao[i] = TempoMedioProducao[i] + int.Parse(parts[1]);
                        if (comboBox_TempoMedioProducao.Text == parts[1])
                        {
                            textBox_TempoMedioProducao.Text = (Math.Round((decimal)TempoMedioProducao[i] / MedioCalc[i], 3)).ToString();
                        }
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    MedioCalc.Add(1);
                    TempoMedioProducao.Add(int.Parse(parts[2]));
                    CodigoPeca.Add(parts[1]);
                }

                PopulateForm();
            }
            else {
                MessageBox.Show("Rafa para de brincar!", "Erro nas Listas",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
