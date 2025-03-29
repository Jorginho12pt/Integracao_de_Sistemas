namespace AplicacaoDesktop
{
    partial class Form
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
            this.textBox_DataHora = new System.Windows.Forms.TextBox();
            this.textBox_CodigoPreco = new System.Windows.Forms.TextBox();
            this.CodigoPeca = new System.Windows.Forms.Label();
            this.textBox_TempoProd = new System.Windows.Forms.TextBox();
            this.TempoProducao = new System.Windows.Forms.Label();
            this.RespostaTeste = new System.Windows.Forms.Label();
            this.button_SendButton = new System.Windows.Forms.Button();
            this.comboBox_RespostaTest = new System.Windows.Forms.ComboBox();
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
            // 
            // textBox_DataHora
            // 
            this.textBox_DataHora.Location = new System.Drawing.Point(101, 10);
            this.textBox_DataHora.Name = "textBox_DataHora";
            this.textBox_DataHora.ReadOnly = true;
            this.textBox_DataHora.Size = new System.Drawing.Size(220, 20);
            this.textBox_DataHora.TabIndex = 10;
            this.textBox_DataHora.TabStop = false;
            // 
            // textBox_CodigoPreco
            // 
            this.textBox_CodigoPreco.Location = new System.Drawing.Point(119, 36);
            this.textBox_CodigoPreco.MaxLength = 8;
            this.textBox_CodigoPreco.Name = "textBox_CodigoPreco";
            this.textBox_CodigoPreco.Size = new System.Drawing.Size(202, 20);
            this.textBox_CodigoPreco.TabIndex = 1;
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
            // textBox_TempoProd
            // 
            this.textBox_TempoProd.Location = new System.Drawing.Point(140, 62);
            this.textBox_TempoProd.MaxLength = 8;
            this.textBox_TempoProd.Name = "textBox_TempoProd";
            this.textBox_TempoProd.Size = new System.Drawing.Size(181, 20);
            this.textBox_TempoProd.TabIndex = 5;
            this.textBox_TempoProd.Text = "00:00:00";
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
            // button_SendButton
            // 
            this.button_SendButton.Location = new System.Drawing.Point(12, 121);
            this.button_SendButton.Name = "button_SendButton";
            this.button_SendButton.Size = new System.Drawing.Size(75, 23);
            this.button_SendButton.TabIndex = 8;
            this.button_SendButton.Text = "Enviar";
            this.button_SendButton.UseVisualStyleBackColor = true;
            this.button_SendButton.Click += new System.EventHandler(this.button_SendButton_ClickAsync);
            // 
            // comboBox_RespostaTest
            // 
            this.comboBox_RespostaTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RespostaTest.FormattingEnabled = true;
            this.comboBox_RespostaTest.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox_RespostaTest.Items.AddRange(new object[] {
            "Ok",
            "Falha na inspeção visual",
            "Falha na inspeção de resistência",
            "Falha na inspeção de dimensões",
            "Falha na inspeção de estanqueidade",
            "Desconhecido"});
            this.comboBox_RespostaTest.Location = new System.Drawing.Point(133, 88);
            this.comboBox_RespostaTest.Name = "comboBox_RespostaTest";
            this.comboBox_RespostaTest.Size = new System.Drawing.Size(188, 21);
            this.comboBox_RespostaTest.TabIndex = 11;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 154);
            this.Controls.Add(this.comboBox_RespostaTest);
            this.Controls.Add(this.button_SendButton);
            this.Controls.Add(this.RespostaTeste);
            this.Controls.Add(this.textBox_TempoProd);
            this.Controls.Add(this.TempoProducao);
            this.Controls.Add(this.textBox_CodigoPreco);
            this.Controls.Add(this.CodigoPeca);
            this.Controls.Add(this.textBox_DataHora);
            this.Controls.Add(this.DataHora);
            this.Name = "Form";
            this.Text = "DescktopApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataHora;
        private System.Windows.Forms.TextBox textBox_DataHora;
        private System.Windows.Forms.TextBox textBox_CodigoPreco;
        private System.Windows.Forms.Label CodigoPeca;
        private System.Windows.Forms.TextBox textBox_TempoProd;
        private System.Windows.Forms.Label TempoProducao;
        private System.Windows.Forms.Label RespostaTeste;
        private System.Windows.Forms.Button button_SendButton;
        private System.Windows.Forms.ComboBox comboBox_RespostaTest;
    }
}

