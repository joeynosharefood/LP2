namespace ProjetoFinal
{
    partial class frmAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.bnvAluno = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoAluno = new System.Windows.Forms.ToolStripButton();
            this.btnSalvarAluno = new System.Windows.Forms.ToolStripButton();
            this.btnAlterarAluno = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirAluno = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarAluno = new System.Windows.Forms.ToolStripButton();
            this.btnSairAluno = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcAlunoDados = new System.Windows.Forms.TabPage();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.tbcAlunoDetalhes = new System.Windows.Forms.TabPage();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.lblCidadeAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).BeginInit();
            this.bnvAluno.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbcAlunoDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.tbcAlunoDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvAluno
            // 
            this.bnvAluno.AddNewItem = null;
            this.bnvAluno.CountItem = this.bindingNavigatorCountItem;
            this.bnvAluno.DeleteItem = null;
            this.bnvAluno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovoAluno,
            this.btnSalvarAluno,
            this.btnAlterarAluno,
            this.btnExcluirAluno,
            this.btnCancelarAluno,
            this.btnSairAluno});
            this.bnvAluno.Location = new System.Drawing.Point(0, 0);
            this.bnvAluno.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvAluno.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvAluno.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvAluno.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvAluno.Name = "bnvAluno";
            this.bnvAluno.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvAluno.Size = new System.Drawing.Size(604, 25);
            this.bnvAluno.TabIndex = 0;
            this.bnvAluno.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAluno.Image")));
            this.btnNovoAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(23, 22);
            this.btnNovoAluno.Text = "toolStripButton1";
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvarAluno.Enabled = false;
            this.btnSalvarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAluno.Image")));
            this.btnSalvarAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(23, 22);
            this.btnSalvarAluno.Text = "toolStripButton2";
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarAluno.Image")));
            this.btnAlterarAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(23, 22);
            this.btnAlterarAluno.Text = "toolStripButton3";
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnAlterarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAluno.Image")));
            this.btnExcluirAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(23, 22);
            this.btnExcluirAluno.Text = "toolStripButton4";
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnCancelarAluno
            // 
            this.btnCancelarAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelarAluno.Enabled = false;
            this.btnCancelarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAluno.Image")));
            this.btnCancelarAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarAluno.Name = "btnCancelarAluno";
            this.btnCancelarAluno.Size = new System.Drawing.Size(23, 22);
            this.btnCancelarAluno.Text = "toolStripButton5";
            this.btnCancelarAluno.Click += new System.EventHandler(this.btnCancelarAluno_Click);
            // 
            // btnSairAluno
            // 
            this.btnSairAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSairAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnSairAluno.Image")));
            this.btnSairAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSairAluno.Name = "btnSairAluno";
            this.btnSairAluno.Size = new System.Drawing.Size(23, 22);
            this.btnSairAluno.Text = "toolStripButton6";
            this.btnSairAluno.Click += new System.EventHandler(this.btnSairAluno_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcAlunoDados);
            this.tabControl1.Controls.Add(this.tbcAlunoDetalhes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // tbcAlunoDados
            // 
            this.tbcAlunoDados.Controls.Add(this.dgvAluno);
            this.tbcAlunoDados.Location = new System.Drawing.Point(4, 22);
            this.tbcAlunoDados.Name = "tbcAlunoDados";
            this.tbcAlunoDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAlunoDados.Size = new System.Drawing.Size(596, 350);
            this.tbcAlunoDados.TabIndex = 0;
            this.tbcAlunoDados.Text = "Dados";
            this.tbcAlunoDados.UseVisualStyleBackColor = true;
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAluno.Location = new System.Drawing.Point(3, 3);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(590, 344);
            this.dgvAluno.TabIndex = 0;
            // 
            // tbcAlunoDetalhes
            // 
            this.tbcAlunoDetalhes.Controls.Add(this.cbxCidade);
            this.tbcAlunoDetalhes.Controls.Add(this.txtNomeAluno);
            this.tbcAlunoDetalhes.Controls.Add(this.txtRa);
            this.tbcAlunoDetalhes.Controls.Add(this.lblCidadeAluno);
            this.tbcAlunoDetalhes.Controls.Add(this.lblNomeAluno);
            this.tbcAlunoDetalhes.Controls.Add(this.lblRA);
            this.tbcAlunoDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbcAlunoDetalhes.Name = "tbcAlunoDetalhes";
            this.tbcAlunoDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAlunoDetalhes.Size = new System.Drawing.Size(792, 399);
            this.tbcAlunoDetalhes.TabIndex = 1;
            this.tbcAlunoDetalhes.Text = "Detalhes";
            this.tbcAlunoDetalhes.UseVisualStyleBackColor = true;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(191, 145);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(204, 21);
            this.cbxCidade.TabIndex = 5;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(191, 96);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(204, 20);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // txtRa
            // 
            this.txtRa.Enabled = false;
            this.txtRa.Location = new System.Drawing.Point(191, 44);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(204, 20);
            this.txtRa.TabIndex = 3;
            // 
            // lblCidadeAluno
            // 
            this.lblCidadeAluno.AutoSize = true;
            this.lblCidadeAluno.Location = new System.Drawing.Point(77, 145);
            this.lblCidadeAluno.Name = "lblCidadeAluno";
            this.lblCidadeAluno.Size = new System.Drawing.Size(85, 13);
            this.lblCidadeAluno.TabIndex = 2;
            this.lblCidadeAluno.Text = "Cidade do Aluno";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(77, 96);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(80, 13);
            this.lblNomeAluno.TabIndex = 1;
            this.lblNomeAluno.Text = "Nome do Aluno";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(77, 44);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(22, 13);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "RA";
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnvAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAluno";
            this.Text = "frmAluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvAluno)).EndInit();
            this.bnvAluno.ResumeLayout(false);
            this.bnvAluno.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbcAlunoDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.tbcAlunoDetalhes.ResumeLayout(false);
            this.tbcAlunoDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvAluno;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcAlunoDados;
        private System.Windows.Forms.TabPage tbcAlunoDetalhes;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label lblCidadeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.ToolStripButton btnNovoAluno;
        private System.Windows.Forms.ToolStripButton btnSalvarAluno;
        private System.Windows.Forms.ToolStripButton btnAlterarAluno;
        private System.Windows.Forms.ToolStripButton btnExcluirAluno;
        private System.Windows.Forms.ToolStripButton btnCancelarAluno;
        private System.Windows.Forms.ToolStripButton btnSairAluno;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtRa;
    }
}