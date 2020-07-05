using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjetoFinal
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-EA9C1TG\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados." + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros Erros." + ex.Message);
            }
        }
        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmC = new frmCidade();
            frmC.MdiParent = this;
            frmC.WindowState = FormWindowState.Maximized;
            frmC.Show();
        }
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frmA = new frmAluno();
            frmA.MdiParent = this;
            frmA.WindowState = FormWindowState.Maximized;
            frmA.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Mateus Sponton Marques da Silva\nRA - 0030481921039");
        }
    }
}
