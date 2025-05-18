namespace AplicacaoDesktop_2_RabbitMQ
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
            components = new System.ComponentModel.Container();
            dataGridView_FailedPeca = new System.Windows.Forms.DataGridView();
            desktopTesteBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_FailedPeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desktopTesteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_FailedPeca
            // 
            dataGridView_FailedPeca.AllowUserToOrderColumns = true;
            dataGridView_FailedPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_FailedPeca.Location = new System.Drawing.Point(12, 12);
            dataGridView_FailedPeca.Name = "dataGridView_FailedPeca";
            dataGridView_FailedPeca.Size = new System.Drawing.Size(776, 426);
            dataGridView_FailedPeca.TabIndex = 0;
            // 
            // desktopTesteBindingSource
            // 
            desktopTesteBindingSource.DataSource = typeof(DesktopTeste);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView_FailedPeca);
            Name = "Form1";
            Text = "Dexktop2App";
            ((System.ComponentModel.ISupportInitialize)dataGridView_FailedPeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)desktopTesteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_FailedPeca;
        private System.Windows.Forms.BindingSource desktopTesteBindingSource;
    }
}

