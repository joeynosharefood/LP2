﻿namespace Atividade6
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEx1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEx1.Location = new System.Drawing.Point(12, 12);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(65, 65);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Exercicio 1";
            this.btnEx1.UseVisualStyleBackColor = false;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEx2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEx2.Location = new System.Drawing.Point(93, 12);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(65, 65);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "Exercicio 2";
            this.btnEx2.UseVisualStyleBackColor = false;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEx3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEx3.Location = new System.Drawing.Point(12, 93);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(65, 65);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Exercicio 3";
            this.btnEx3.UseVisualStyleBackColor = false;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEx4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEx4.Location = new System.Drawing.Point(93, 93);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(65, 65);
            this.btnEx4.TabIndex = 3;
            this.btnEx4.Text = "Exercicio 4";
            this.btnEx4.UseVisualStyleBackColor = false;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(175, 175);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
    }
}

