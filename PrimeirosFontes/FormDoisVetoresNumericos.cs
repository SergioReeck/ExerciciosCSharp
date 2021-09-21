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
    public partial class FormDoisVetoresNumericos : Form
    {
        public FormDoisVetoresNumericos()
        {
            InitializeComponent();
        }

        double[] vNumeros1 = new double[3];
        double[] vNumeros2 = new double[3];
        double[] vNumeros3 = new double[3];
        int indice = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Favor informar um valor");
                return;
            }

            if (indice == 3)
            {
                MessageBox.Show("Limite atingido!");
                return;
            }

            vNumeros1[indice] = double.Parse(textBox1.Text);
            vNumeros2[indice] = double.Parse(textBox2.Text);
            indice++;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //vNumeros1[vNumeros1.length - 1] = 10; (Acessa a última posição do vetor). 

            for (int i = 0; i < 3; i++)
            {
                vNumeros3[i] = vNumeros1[i] + vNumeros2[i];
            }

        }
    }
}
