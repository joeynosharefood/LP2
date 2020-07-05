using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjetoFinal
{
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();
        public frmAluno()
        {
            InitializeComponent();
        }
        private void frmAluno_Load(object sender, EventArgs e)
        {
            try
            {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBAluno"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;
                txtRa.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");                
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["TbCidade"];
                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";
                cbxCidade.DataBindings.Add("SelectedValue", bnAluno, "cidade_id_cidade");               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            bnAluno.AddNew();
            txtRa.Enabled = true;
            txtRa.Text = "";
            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            txtNomeAluno.Focus();
            btnSalvarAluno.Enabled = true;
            btnAlterarAluno.Enabled = false;
            btnNovoAluno.Enabled = false;
            btnExcluirAluno.Enabled = false;
            btnCancelarAluno.Enabled = true;
            bInclusao = true;
        }
        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (txtRa.Text == "" || txtNomeAluno.Text == "")
            {
                MessageBox.Show("RA ou Nome inválido.");
            }
            else
            {
                Aluno RegAlu = new Aluno();
                RegAlu.Raaluno = Convert.ToInt16(txtRa.Text);
                RegAlu.Nomealuno = txtNomeAluno.Text;
                RegAlu.Cidadeidcidade = cbxCidade.SelectedIndex + 1;
                if (bInclusao)
                {
                    if (RegAlu.SalvarAluno() > 0)
                    {
                        MessageBox.Show("Cidade adicionada.");

                        btnSalvarAluno.Enabled = false;
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvarAluno.Enabled = false;
                        btnAlterarAluno.Enabled = true;
                        btnNovoAluno.Enabled = true;
                        btnExcluirAluno.Enabled = true;
                        btnCancelarAluno.Enabled = false;
                        bInclusao = false;

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBaluno"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar.");
                    }
                }
                else
                {
                    if (RegAlu.AlterarAluno() > 0)
                    {
                        MessageBox.Show("Aluno alterado.");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvarAluno.Enabled = false;
                        btnAlterarAluno.Enabled = true;
                        btnNovoAluno.Enabled = true;
                        btnExcluirAluno.Enabled = true;
                        btnCancelarAluno.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar.");
                    }
                }
            }
        }
        private void btnAlterarAluno_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            txtRa.Enabled = true;
            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            txtNomeAluno.Focus();
            btnSalvarAluno.Enabled = true;
            btnAlterarAluno.Enabled = false;
            btnNovoAluno.Enabled = false;
            btnExcluirAluno.Enabled = false;
            btnCancelarAluno.Enabled = true;
            bInclusao = false;
        }
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
           == DialogResult.Yes)
            {
                Aluno RegAlu = new Aluno();
                RegAlu.Raaluno = Convert.ToInt16(txtRa.Text);
                RegAlu.Nomealuno = txtNomeAluno.Text;
                RegAlu.Cidadeidcidade = cbxCidade.SelectedIndex + 1;
                if (RegAlu.ExcluirAluno() > 0)
                {
                    MessageBox.Show("Aluno excluído.");
                    Aluno A = new Aluno();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(A.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBAluno"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                }
            }
        }
        private void btnCancelarAluno_Click(object sender, EventArgs e)
        {
            bnAluno.CancelEdit();

            txtRa.Enabled = false;
            btnSalvarAluno.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidade.Enabled = false;
            btnAlterarAluno.Enabled = true;
            btnNovoAluno.Enabled = true;
            btnExcluirAluno.Enabled = true;
        }
        private void btnSairAluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
