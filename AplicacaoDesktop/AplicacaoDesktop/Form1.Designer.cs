namespace AplicacaoDesktop
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
            this.DataHora = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CodigoPeca = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TempoProducao = new System.Windows.Forms.Label();
            this.RespostaTeste = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataHora
            // 
            this.DataHora.AutoSize = true;
            this.DataHora.Location = new System.Drawing.Point(24, 13);
            this.DataHora.Name = "DataHora";
            this.DataHora.Size = new System.Drawing.Size(71, 13);
            this.DataHora.TabIndex = 0;
            this.DataHora.Text = "Data e Hora: ";
            this.DataHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // CodigoPeca
            // 
            this.CodigoPeca.AutoSize = true;
            this.CodigoPeca.Location = new System.Drawing.Point(24, 39);
            this.CodigoPeca.Name = "CodigoPeca";
            this.CodigoPeca.Size = new System.Drawing.Size(89, 13);
            this.CodigoPeca.TabIndex = 2;
            this.CodigoPeca.Text = "Codigo da Peça: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // TempoProducao
            // 
            this.TempoProducao.AutoSize = true;
            this.TempoProducao.Location = new System.Drawing.Point(24, 65);
            this.TempoProducao.Name = "TempoProducao";
            this.TempoProducao.Size = new System.Drawing.Size(110, 13);
            this.TempoProducao.TabIndex = 4;
            this.TempoProducao.Text = "Tempo de Produção: ";
            // 
            // RespostaTeste
            // 
            this.RespostaTeste.AutoSize = true;
            this.RespostaTeste.Location = new System.Drawing.Point(24, 91);
            this.RespostaTeste.Name = "RespostaTeste";
            this.RespostaTeste.Size = new System.Drawing.Size(103, 13);
            this.RespostaTeste.TabIndex = 6;
            this.RespostaTeste.Text = "Resposta do Teste: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(133, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 30);
            this.listBox1.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(246, 167);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 202);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RespostaTeste);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TempoProducao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CodigoPeca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label CodigoPeca;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TempoProducao;
        private System.Windows.Forms.Label RespostaTeste;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SendButton;
    }
}

