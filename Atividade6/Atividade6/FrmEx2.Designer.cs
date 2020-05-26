namespace Atividade6
{
    partial class FrmEx2
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
            this.lblH = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F);
            this.lblH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblH.Location = new System.Drawing.Point(12, 81);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(57, 31);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "H =";
            this.lblH.Click += new System.EventHandler(this.lblH_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F);
            this.lblN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblN.Location = new System.Drawing.Point(12, 15);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(64, 31);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "N = ";
            this.lblN.Click += new System.EventHandler(this.lblN_Click);
            // 
            // txtBoxN
            // 
            this.txtBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxN.Location = new System.Drawing.Point(82, 12);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(180, 38);
            this.txtBoxN.TabIndex = 2;
            // 
            // txtBoxH
            // 
            this.txtBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxH.Location = new System.Drawing.Point(82, 78);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.ReadOnly = true;
            this.txtBoxH.Size = new System.Drawing.Size(180, 38);
            this.txtBoxH.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalc.Location = new System.Drawing.Point(279, 6);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(172, 110);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular H";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // FrmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(474, 138);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblH);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmEx2";
            this.Text = "FrmEx2";
            this.Load += new System.EventHandler(this.FrmEx2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.Button btnCalc;
    }
}