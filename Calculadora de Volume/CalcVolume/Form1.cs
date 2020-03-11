using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verifyRaio, verifyAltura, volume, volumeFormat;
            if (Double.TryParse(textBox1.Text, out verifyRaio) && 
                Double.TryParse(textBox2.Text, out verifyAltura))
            {
                verifyRaio = Convert.ToDouble(textBox2.Text);
                verifyAltura = Convert.ToDouble(textBox1.Text);

                volume = Math.PI * (verifyRaio * verifyRaio) * verifyAltura;

                textBox3.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Não foi inserido um valor númerico");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
