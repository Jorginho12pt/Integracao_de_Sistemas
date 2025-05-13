using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<int> TempoMedioProducao = new List<int>();
        private List<string> CodigoPeca = new List<string>();

        public Form1()
        {
            InitializeComponent();
            TempoMedioProducao.Add(0);
            CodigoPeca.Add("");
            textBox_PecasProduzidas.Text = PecasProduzidas.ToString();
            textBox_PecasSemFalhas.Text = PecasSemFalhas.ToString();
            textBox_PecasOk.Text = PecasOk.ToString();
            textBox_TempoMedioProducao.Text= TempoMedioProducao[0].ToString();
        }

    }
}
