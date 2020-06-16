using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030481921039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            double totalGeral = 0;
            double[,] cofre = new double[9, 4];
            string message, tittle, defaultValue;
            string myValue;

            message = "Insira o total da semana nº";
            tittle = "Valores do mês nº";
            defaultValue = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myValue = Interaction.InputBox(message + (j + 1), tittle + (i + 1), defaultValue);

                    if ((string)myValue == defaultValue)
                    {
                        Interaction.MsgBox("Nenhum valor foi adicionado",
                        MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Erro");
                        j--;
                    }
                    else
                    {
                        if (Double.TryParse(myValue, out cofre[i, j]))
                        {
                            cofre[i, j] = Double.Parse(myValue);
                        }
                        else
                        {
                            Interaction.MsgBox("Não foi inserido um valor numerico",
                            MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Erro");
                            j--;
                        }
                    }
                }
            }
            listBoxRelatorio.BeginUpdate();
            for (int i = 0; i < 9; i++)
            {
                double temp = 0;
                for (int j = 0; j < 4; j++)
                {
                    listBoxRelatorio.Items.Add("Total do Mês :" + (i + 1) + "Total Semana" + (j + 1) + ":R$ " + cofre[i, j].ToString("N2"));
                    totalGeral += cofre[i, j];
                    temp += cofre[i, j];
                }
                listBoxRelatorio.Items.Add("Total do Mês" + (i + 1) + " : R$" + temp.ToString("N2"));
                listBoxRelatorio.Items.Add("_____________________________________________________________");
            }
            listBoxRelatorio.Items.Add("Total Geral: R$ " + totalGeral.ToString("N2"));
            listBoxRelatorio.Items.Add("______________________________________________________________");
            listBoxRelatorio.EndUpdate();
        }
    }
}

