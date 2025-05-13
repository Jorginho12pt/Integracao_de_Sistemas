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
            this.label_PecasProduzidas = new System.Windows.Forms.Label();
            this.textBox_PecasProduzidas = new System.Windows.Forms.TextBox();
            this.textBox_PecasSemFalhas = new System.Windows.Forms.TextBox();
            this.label_PecasSemFalhas = new System.Windows.Forms.Label();
            this.textBox_PecasOk = new System.Windows.Forms.TextBox();
            this.label_PecasOk = new System.Windows.Forms.Label();
            this.textBox_TempoMedioProducao = new System.Windows.Forms.TextBox();
            this.label_TempoMedioProducao = new System.Windows.Forms.Label();
            this.comboBox_TempoMedioProducao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_PecasProduzidas
            // 
            this.label_PecasProduzidas.AutoSize = true;
            this.label_PecasProduzidas.Location = new System.Drawing.Point(12, 9);
            this.label_PecasProduzidas.Name = "label_PecasProduzidas";
            this.label_PecasProduzidas.Size = new System.Drawing.Size(94, 13);
            this.label_PecasProduzidas.TabIndex = 0;
            this.label_PecasProduzidas.Text = "Pecas produzidas:";
            // 
            // textBox_PecasProduzidas
            // 
            this.textBox_PecasProduzidas.Location = new System.Drawing.Point(109, 6);
            this.textBox_PecasProduzidas.Name = "textBox_PecasProduzidas";
            this.textBox_PecasProduzidas.ReadOnly = true;
            this.textBox_PecasProduzidas.Size = new System.Drawing.Size(100, 20);
            this.textBox_PecasProduzidas.TabIndex = 1;
            this.textBox_PecasProduzidas.TabStop = false;
            // 
            // textBox_PecasSemFalhas
            // 
            this.textBox_PecasSemFalhas.Location = new System.Drawing.Point(314, 6);
            this.textBox_PecasSemFalhas.Name = "textBox_PecasSemFalhas";
            this.textBox_PecasSemFalhas.ReadOnly = true;
            this.textBox_PecasSemFalhas.Size = new System.Drawing.Size(100, 20);
            this.textBox_PecasSemFalhas.TabIndex = 3;
            this.textBox_PecasSemFalhas.TabStop = false;
            // 
            // label_PecasSemFalhas
            // 
            this.label_PecasSemFalhas.AutoSize = true;
            this.label_PecasSemFalhas.Location = new System.Drawing.Point(215, 9);
            this.label_PecasSemFalhas.Name = "label_PecasSemFalhas";
            this.label_PecasSemFalhas.Size = new System.Drawing.Size(93, 13);
            this.label_PecasSemFalhas.TabIndex = 2;
            this.label_PecasSemFalhas.Text = "Pecas sem falhas:";
            // 
            // textBox_PecasOk
            // 
            this.textBox_PecasOk.Location = new System.Drawing.Point(483, 6);
            this.textBox_PecasOk.Name = "textBox_PecasOk";
            this.textBox_PecasOk.ReadOnly = true;
            this.textBox_PecasOk.Size = new System.Drawing.Size(100, 20);
            this.textBox_PecasOk.TabIndex = 5;
            this.textBox_PecasOk.TabStop = false;
            // 
            // label_PecasOk
            // 
            this.label_PecasOk.AutoSize = true;
            this.label_PecasOk.Location = new System.Drawing.Point(420, 9);
            this.label_PecasOk.Name = "label_PecasOk";
            this.label_PecasOk.Size = new System.Drawing.Size(57, 13);
            this.label_PecasOk.TabIndex = 4;
            this.label_PecasOk.Text = "Pecas Ok:";
            // 
            // textBox_TempoMedioProducao
            // 
            this.textBox_TempoMedioProducao.Location = new System.Drawing.Point(314, 53);
            this.textBox_TempoMedioProducao.Name = "textBox_TempoMedioProducao";
            this.textBox_TempoMedioProducao.ReadOnly = true;
            this.textBox_TempoMedioProducao.Size = new System.Drawing.Size(100, 20);
            this.textBox_TempoMedioProducao.TabIndex = 7;
            this.textBox_TempoMedioProducao.TabStop = false;
            // 
            // label_TempoMedioProducao
            // 
            this.label_TempoMedioProducao.AutoSize = true;
            this.label_TempoMedioProducao.Location = new System.Drawing.Point(12, 57);
            this.label_TempoMedioProducao.Name = "label_TempoMedioProducao";
            this.label_TempoMedioProducao.Size = new System.Drawing.Size(137, 13);
            this.label_TempoMedioProducao.TabIndex = 6;
            this.label_TempoMedioProducao.Text = "Tempo medio de producao:";
            // 
            // comboBox_TempoMedioProducao
            // 
            this.comboBox_TempoMedioProducao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TempoMedioProducao.FormattingEnabled = true;
            this.comboBox_TempoMedioProducao.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox_TempoMedioProducao.Location = new System.Drawing.Point(155, 53);
            this.comboBox_TempoMedioProducao.Name = "comboBox_TempoMedioProducao";
            this.comboBox_TempoMedioProducao.Size = new System.Drawing.Size(153, 21);
            this.comboBox_TempoMedioProducao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 89);
            this.Controls.Add(this.comboBox_TempoMedioProducao);
            this.Controls.Add(this.textBox_TempoMedioProducao);
            this.Controls.Add(this.label_TempoMedioProducao);
            this.Controls.Add(this.textBox_PecasOk);
            this.Controls.Add(this.label_PecasOk);
            this.Controls.Add(this.textBox_PecasSemFalhas);
            this.Controls.Add(this.label_PecasSemFalhas);
            this.Controls.Add(this.textBox_PecasProduzidas);
            this.Controls.Add(this.label_PecasProduzidas);
            this.Name = "Form1";
            this.Text = "ManagerApp";
            this.ResumeLayout(false);
            this.PerformLayout();

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

