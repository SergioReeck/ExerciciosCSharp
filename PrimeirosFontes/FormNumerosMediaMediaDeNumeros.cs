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
    public partial class FormNumerosMediaMediaDeNumeros : Form
    {
        public FormNumerosMediaMediaDeNumeros()
        {
            InitializeComponent();
        }

        List<double> numeros = new List<double>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadastrar.Text =="")
            {
                MessageBox.Show("Favor dígite um número");
                return;
            }
            numeros.Add(double.Parse(txtCadastrar.Text));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double soma = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                soma += numeros[i];
            }

            MessageBox.Show("Soma é " + soma);
            double media = soma / numeros.Count;
            MessageBox.Show("Média é " + media);
            int qtdeNumerosAbaixoMedia = 0;


            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < media) 
                {
                    qtdeNumerosAbaixoMedia++;
                }
                
            }
            MessageBox.Show("Quantidade números abaixo da média " + qtdeNumerosAbaixoMedia);
        }
        //OUTROS MÉTODOS!
        //
        //private void button3_Click(object sender, EventArgs e)
        //double soma = numeros.Sum();
        //double media = numeros.Average()
        
    }
}
