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
            DataHora = new System.Windows.Forms.Label();
            textBox_DataHora = new System.Windows.Forms.TextBox();
            textBox_CodigoPreco = new System.Windows.Forms.TextBox();
            CodigoPeca = new System.Windows.Forms.Label();
            textBox_TempoProd = new System.Windows.Forms.TextBox();
            TempoProducao = new System.Windows.Forms.Label();
            RespostaTeste = new System.Windows.Forms.Label();
            button_SendButton = new System.Windows.Forms.Button();
            comboBox_RespostaTest = new System.Windows.Forms.ComboBox();
            button_Random = new System.Windows.Forms.Button();
            button_SendRabbitMq = new System.Windows.Forms.Button();
            button_SendRabbitMqStream = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // DataHora
            // 
            DataHora.AutoSize = true;
            DataHora.Location = new System.Drawing.Point(14, 15);
            DataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DataHora.Name = "DataHora";
            DataHora.Size = new System.Drawing.Size(75, 15);
            DataHora.TabIndex = 0;
            DataHora.Text = "Data e Hora: ";
            // 
            // textBox_DataHora
            // 
            textBox_DataHora.Location = new System.Drawing.Point(104, 12);
            textBox_DataHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_DataHora.Name = "textBox_DataHora";
            textBox_DataHora.ReadOnly = true;
            textBox_DataHora.Size = new System.Drawing.Size(408, 23);
            textBox_DataHora.TabIndex = 10;
            textBox_DataHora.TabStop = false;
            // 
            // textBox_CodigoPreco
            // 
            textBox_CodigoPreco.Location = new System.Drawing.Point(125, 42);
            textBox_CodigoPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_CodigoPreco.MaxLength = 8;
            textBox_CodigoPreco.Name = "textBox_CodigoPreco";
            textBox_CodigoPreco.Size = new System.Drawing.Size(387, 23);
            textBox_CodigoPreco.TabIndex = 1;
            // 
            // CodigoPeca
            // 
            CodigoPeca.AutoSize = true;
            CodigoPeca.Location = new System.Drawing.Point(14, 45);
            CodigoPeca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CodigoPeca.Name = "CodigoPeca";
            CodigoPeca.Size = new System.Drawing.Size(96, 15);
            CodigoPeca.TabIndex = 2;
            CodigoPeca.Text = "Codigo da Peça: ";
            // 
            // textBox_TempoProd
            // 
            textBox_TempoProd.Location = new System.Drawing.Point(214, 72);
            textBox_TempoProd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_TempoProd.MaxLength = 2;
            textBox_TempoProd.Name = "textBox_TempoProd";
            textBox_TempoProd.Size = new System.Drawing.Size(298, 23);
            textBox_TempoProd.TabIndex = 5;
            // 
            // TempoProducao
            // 
            TempoProducao.AutoSize = true;
            TempoProducao.Location = new System.Drawing.Point(14, 75);
            TempoProducao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TempoProducao.Name = "TempoProducao";
            TempoProducao.Size = new System.Drawing.Size(182, 15);
            TempoProducao.TabIndex = 4;
            TempoProducao.Text = "Tempo de Produção (segundos): ";
            // 
            // RespostaTeste
            // 
            RespostaTeste.AutoSize = true;
            RespostaTeste.Location = new System.Drawing.Point(14, 105);
            RespostaTeste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RespostaTeste.Name = "RespostaTeste";
            RespostaTeste.Size = new System.Drawing.Size(107, 15);
            RespostaTeste.TabIndex = 6;
            RespostaTeste.Text = "Resposta do Teste: ";
            // 
            // button_SendButton
            // 
            button_SendButton.Location = new System.Drawing.Point(18, 133);
            button_SendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_SendButton.Name = "button_SendButton";
            button_SendButton.Size = new System.Drawing.Size(88, 27);
            button_SendButton.TabIndex = 8;
            button_SendButton.Text = "Enviar";
            button_SendButton.UseVisualStyleBackColor = true;
            button_SendButton.Click += button_SendButton_ClickAsync;
            // 
            // comboBox_RespostaTest
            // 
            comboBox_RespostaTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_RespostaTest.FormattingEnabled = true;
            comboBox_RespostaTest.ImeMode = System.Windows.Forms.ImeMode.Disable;
            comboBox_RespostaTest.Items.AddRange(new object[] { "Ok", "Falha na inspecao visual", "Falha na inspecao de resistencia", "Falha na inspecao de dimensoes", "Falha na inspecao de estanqueidade", "Desconhecido" });
            comboBox_RespostaTest.Location = new System.Drawing.Point(141, 102);
            comboBox_RespostaTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_RespostaTest.Name = "comboBox_RespostaTest";
            comboBox_RespostaTest.Size = new System.Drawing.Size(371, 23);
            comboBox_RespostaTest.TabIndex = 11;
            // 
            // button_Random
            // 
            button_Random.Location = new System.Drawing.Point(424, 131);
            button_Random.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_Random.Name = "button_Random";
            button_Random.Size = new System.Drawing.Size(88, 27);
            button_Random.TabIndex = 12;
            button_Random.Text = "Random";
            button_Random.UseVisualStyleBackColor = true;
            button_Random.Click += button_Random_Click;
            // 
            // button_SendRabbitMq
            // 
            button_SendRabbitMq.Location = new System.Drawing.Point(112, 133);
            button_SendRabbitMq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_SendRabbitMq.Name = "button_SendRabbitMq";
            button_SendRabbitMq.Size = new System.Drawing.Size(114, 27);
            button_SendRabbitMq.TabIndex = 13;
            button_SendRabbitMq.Text = "Enviar RabbitMQ";
            button_SendRabbitMq.UseVisualStyleBackColor = true;
            button_SendRabbitMq.Click += button_SendRabbitMq_Click;
            // 
            // button_SendRabbitMqStream
            // 
            button_SendRabbitMqStream.Location = new System.Drawing.Point(234, 133);
            button_SendRabbitMqStream.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_SendRabbitMqStream.Name = "button_SendRabbitMqStream";
            button_SendRabbitMqStream.Size = new System.Drawing.Size(146, 27);
            button_SendRabbitMqStream.TabIndex = 14;
            button_SendRabbitMqStream.Text = "Enviar RabbitMQ Stream";
            button_SendRabbitMqStream.UseVisualStyleBackColor = true;
            button_SendRabbitMqStream.Click += button_SendRabbitMqStream_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(525, 173);
            Controls.Add(button_SendRabbitMqStream);
            Controls.Add(button_SendRabbitMq);
            Controls.Add(button_Random);
            Controls.Add(comboBox_RespostaTest);
            Controls.Add(button_SendButton);
            Controls.Add(RespostaTeste);
            Controls.Add(textBox_TempoProd);
            Controls.Add(TempoProducao);
            Controls.Add(textBox_CodigoPreco);
            Controls.Add(CodigoPeca);
            Controls.Add(textBox_DataHora);
            Controls.Add(DataHora);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form";
            Text = "DesktopApp";
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button button_SendRabbitMq;
        private System.Windows.Forms.Button button_SendRabbitMqStream;
    }
}

