namespace AplicacaoManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_PecasProduzidas = new System.Windows.Forms.Label();
            textBox_PecasProduzidas = new System.Windows.Forms.TextBox();
            textBox_PecasSemFalhas = new System.Windows.Forms.TextBox();
            label_PecasSemFalhas = new System.Windows.Forms.Label();
            textBox_PecasOk = new System.Windows.Forms.TextBox();
            label_PecasOk = new System.Windows.Forms.Label();
            textBox_TempoMedioProducao = new System.Windows.Forms.TextBox();
            label_TempoMedioProducao = new System.Windows.Forms.Label();
            comboBox_TempoMedioProducao = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label_PecasProduzidas
            // 
            label_PecasProduzidas.AutoSize = true;
            label_PecasProduzidas.Location = new System.Drawing.Point(14, 10);
            label_PecasProduzidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_PecasProduzidas.Name = "label_PecasProduzidas";
            label_PecasProduzidas.Size = new System.Drawing.Size(101, 15);
            label_PecasProduzidas.TabIndex = 0;
            label_PecasProduzidas.Text = "Pecas produzidas:";
            // 
            // textBox_PecasProduzidas
            // 
            textBox_PecasProduzidas.Location = new System.Drawing.Point(127, 7);
            textBox_PecasProduzidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_PecasProduzidas.Name = "textBox_PecasProduzidas";
            textBox_PecasProduzidas.ReadOnly = true;
            textBox_PecasProduzidas.Size = new System.Drawing.Size(116, 23);
            textBox_PecasProduzidas.TabIndex = 1;
            textBox_PecasProduzidas.TabStop = false;
            // 
            // textBox_PecasSemFalhas
            // 
            textBox_PecasSemFalhas.Location = new System.Drawing.Point(366, 7);
            textBox_PecasSemFalhas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_PecasSemFalhas.Name = "textBox_PecasSemFalhas";
            textBox_PecasSemFalhas.ReadOnly = true;
            textBox_PecasSemFalhas.Size = new System.Drawing.Size(116, 23);
            textBox_PecasSemFalhas.TabIndex = 3;
            textBox_PecasSemFalhas.TabStop = false;
            // 
            // label_PecasSemFalhas
            // 
            label_PecasSemFalhas.AutoSize = true;
            label_PecasSemFalhas.Location = new System.Drawing.Point(251, 10);
            label_PecasSemFalhas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_PecasSemFalhas.Name = "label_PecasSemFalhas";
            label_PecasSemFalhas.Size = new System.Drawing.Size(99, 15);
            label_PecasSemFalhas.TabIndex = 2;
            label_PecasSemFalhas.Text = "Pecas sem falhas:";
            // 
            // textBox_PecasOk
            // 
            textBox_PecasOk.Location = new System.Drawing.Point(564, 7);
            textBox_PecasOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_PecasOk.Name = "textBox_PecasOk";
            textBox_PecasOk.ReadOnly = true;
            textBox_PecasOk.Size = new System.Drawing.Size(116, 23);
            textBox_PecasOk.TabIndex = 5;
            textBox_PecasOk.TabStop = false;
            // 
            // label_PecasOk
            // 
            label_PecasOk.AutoSize = true;
            label_PecasOk.Location = new System.Drawing.Point(490, 10);
            label_PecasOk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_PecasOk.Name = "label_PecasOk";
            label_PecasOk.Size = new System.Drawing.Size(58, 15);
            label_PecasOk.TabIndex = 4;
            label_PecasOk.Text = "Pecas Ok:";
            // 
            // textBox_TempoMedioProducao
            // 
            textBox_TempoMedioProducao.Location = new System.Drawing.Point(366, 61);
            textBox_TempoMedioProducao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_TempoMedioProducao.Name = "textBox_TempoMedioProducao";
            textBox_TempoMedioProducao.ReadOnly = true;
            textBox_TempoMedioProducao.Size = new System.Drawing.Size(116, 23);
            textBox_TempoMedioProducao.TabIndex = 7;
            textBox_TempoMedioProducao.TabStop = false;
            // 
            // label_TempoMedioProducao
            // 
            label_TempoMedioProducao.AutoSize = true;
            label_TempoMedioProducao.Location = new System.Drawing.Point(14, 66);
            label_TempoMedioProducao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_TempoMedioProducao.Name = "label_TempoMedioProducao";
            label_TempoMedioProducao.Size = new System.Drawing.Size(153, 15);
            label_TempoMedioProducao.TabIndex = 6;
            label_TempoMedioProducao.Text = "Tempo medio de producao:";
            // 
            // comboBox_TempoMedioProducao
            // 
            comboBox_TempoMedioProducao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_TempoMedioProducao.FormattingEnabled = true;
            comboBox_TempoMedioProducao.ImeMode = System.Windows.Forms.ImeMode.Disable;
            comboBox_TempoMedioProducao.Location = new System.Drawing.Point(181, 61);
            comboBox_TempoMedioProducao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_TempoMedioProducao.Name = "comboBox_TempoMedioProducao";
            comboBox_TempoMedioProducao.Size = new System.Drawing.Size(178, 23);
            comboBox_TempoMedioProducao.TabIndex = 8;
            comboBox_TempoMedioProducao.SelectedIndexChanged += comboBox_TempoMedioProducao_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(691, 103);
            Controls.Add(comboBox_TempoMedioProducao);
            Controls.Add(textBox_TempoMedioProducao);
            Controls.Add(label_TempoMedioProducao);
            Controls.Add(textBox_PecasOk);
            Controls.Add(label_PecasOk);
            Controls.Add(textBox_PecasSemFalhas);
            Controls.Add(label_PecasSemFalhas);
            Controls.Add(textBox_PecasProduzidas);
            Controls.Add(label_PecasProduzidas);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "ManagerApp";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label_PecasProduzidas;
        private System.Windows.Forms.TextBox textBox_PecasProduzidas;
        private System.Windows.Forms.TextBox textBox_PecasSemFalhas;
        private System.Windows.Forms.Label label_PecasSemFalhas;
        private System.Windows.Forms.TextBox textBox_PecasOk;
        private System.Windows.Forms.Label label_PecasOk;
        private System.Windows.Forms.TextBox textBox_TempoMedioProducao;
        private System.Windows.Forms.Label label_TempoMedioProducao;
        private System.Windows.Forms.ComboBox comboBox_TempoMedioProducao;
    }
}

