namespace P0030481921039
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
            this.listBoxRelatorio = new System.Windows.Forms.ListBox();
            this.btEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRelatorio
            // 
            this.listBoxRelatorio.FormattingEnabled = true;
            this.listBoxRelatorio.Location = new System.Drawing.Point(289, 12);
            this.listBoxRelatorio.Name = "listBoxRelatorio";
            this.listBoxRelatorio.Size = new System.Drawing.Size(394, 472);
            this.listBoxRelatorio.TabIndex = 0;
            // 
            // btEntrada
            // 
            this.btEntrada.CausesValidation = false;
            this.btEntrada.Location = new System.Drawing.Point(8, 8);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(275, 476);
            this.btEntrada.TabIndex = 1;
            this.btEntrada.Text = "Entrar com Valores";
            this.btEntrada.UseVisualStyleBackColor = true;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(695, 496);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.listBoxRelatorio);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listRelatorio;
        private System.Windows.Forms.Button bttEntrada;
        private System.Windows.Forms.ListBox listBoxRelatorio;
        private System.Windows.Forms.Button btEntrada;
    }
}

