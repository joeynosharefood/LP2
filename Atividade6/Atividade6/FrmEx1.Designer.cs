﻿namespace Atividade6
{
    partial class FrmEx1
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
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnLetIguais = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblExpl = new System.Windows.Forms.Label();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBranco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBranco.Location = new System.Drawing.Point(502, 83);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(115, 65);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Contador Espaços Brancos";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnR.Location = new System.Drawing.Point(623, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(119, 65);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Contador de letras R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnLetIguais
            // 
            this.btnLetIguais.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetIguais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLetIguais.Location = new System.Drawing.Point(502, 12);
            this.btnLetIguais.Name = "btnLetIguais";
            this.btnLetIguais.Size = new System.Drawing.Size(115, 65);
            this.btnLetIguais.TabIndex = 3;
            this.btnLetIguais.Text = "Contador de Letras Iguais Seguidas";
            this.btnLetIguais.UseVisualStyleBackColor = false;
            this.btnLetIguais.Click += new System.EventHandler(this.btnLetIguais_Click);
            // 
            // txtContador
            // 
            this.txtContador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContador.Location = new System.Drawing.Point(623, 106);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(119, 20);
            this.txtContador.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContador.Location = new System.Drawing.Point(623, 83);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(122, 13);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "Contador de Caracteres:";
            // 
            // lblExpl
            // 
            this.lblExpl.AutoSize = true;
            this.lblExpl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpl.Location = new System.Drawing.Point(9, 9);
            this.lblExpl.Name = "lblExpl";
            this.lblExpl.Size = new System.Drawing.Size(243, 13);
            this.lblExpl.TabIndex = 6;
            this.lblExpl.Text = "Digite uma frase para analise(Max 100 caracteres)";
            // 
            // richTxt
            // 
            this.richTxt.Location = new System.Drawing.Point(12, 35);
            this.richTxt.MaxLength = 100;
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(484, 107);
            this.richTxt.TabIndex = 7;
            this.richTxt.Text = "";
            this.richTxt.TextChanged += new System.EventHandler(this.richTxt_TextChanged_1);
            // 
            // FrmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(752, 160);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.lblExpl);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.btnLetIguais);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBranco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmEx1";
            this.Text = "FrmEx1";
            this.Load += new System.EventHandler(this.FrmEx1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnLetIguais;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblExpl;
        private System.Windows.Forms.RichTextBox richTxt;
    }
}