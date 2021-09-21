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
    public partial class Form5Vetores : Form
    {
        public Form5Vetores()
        {
            InitializeComponent();
        }

        //double[] numeros = { 10, 15, 20, 25, 30 };

        double[] numeros = new double[5];
        int i = 0;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double numeroDigitado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroDigitado)
                {
                    MessageBox.Show("Numero ja cadastrado");
                    return;
                }
            }

            if (i == 5)
            {
                MessageBox.Show("Limite atingido!");
                return;
            }
            numeros[i] = double.Parse(txtVetores.Text);
            txtVetores.Clear();
            i++;
        }
    }
}
