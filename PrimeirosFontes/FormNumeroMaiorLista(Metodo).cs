using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeirosFontes
{
    public partial class FormNumeroMaiorListaMetodo : Form
    {
        public FormNumeroMaiorListaMetodo()
        {
            InitializeComponent();
        }

        List<double> listaNumeros = new List<double>(3);

        void AddNumero(double numero)
        {
            listaNumeros.Add(numero);
        }

        double EncontrarMaisNumero()
        {
            double maiorNumero = -999999999; 
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                double numeroDaVez = listaNumeros[i];

                if (numeroDaVez > maiorNumero)
                {
                    maiorNumero = numeroDaVez;
                }
            }
            return maiorNumero;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            double maiorNumero = EncontrarMaisNumero();
            MessageBox.Show("O maior número é " + maiorNumero);
        }

        private void btnAddNumero_Click(object sender, EventArgs e)
        {
            AddNumero(double.Parse(textBox1.Text));
            MessageBox.Show("Adicionado com sucesso!");
        }
    }
}
