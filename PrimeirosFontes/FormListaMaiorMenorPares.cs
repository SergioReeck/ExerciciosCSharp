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
    public partial class FormListaMaiorMenorPares : Form
    {
        public FormListaMaiorMenorPares()
        {
            InitializeComponent();
        }

        List<double> numeros = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Informe um número");
                return;
            }
            numeros.Add(double.Parse(textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double maior = -999999;
            double menor = 999999;
            double qtdPares = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                //Em cada loop deste for, esta variável irá receber o número da vez!
                double numeroDaVez = numeros[i];

                if (numeroDaVez > maior)
                {
                    maior = numeroDaVez;
                }
                if (numeroDaVez < menor)
                {
                    menor = numeroDaVez;
                }
                if (numeroDaVez % 2 == 0)
                {
                    qtdPares++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double maior = numeros.Max();
            double menor = numeros.Min();
            double qtdNumerosPares = numeros.Count(c => c % 2 == 0);
        }
    }
}
