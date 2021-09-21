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
    public partial class FormTrianguloFuncao : Form
    {
        public FormTrianguloFuncao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l1 = int.Parse(textBox1.Text);
            int l2 = int.Parse(textBox2.Text);
            int l3 = int.Parse(textBox3.Text);

            

            if (VerificarIntegridadeTriangulo(l1, l2, l3))
            {
                string tipo = CalcularTipoTriangulo(l1, l2, l3);
                MessageBox.Show(tipo);
            }
            else
            {
                MessageBox.Show("Os lados não formam um triângulo válido!");
            }
        }

        bool VerificarIntegridadeTriangulo(int lado1, int lado2, int lado3)
        {
            //Solução em uma linha: return !(lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2);

            if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
            {
                return false;
            }
            return true;
        }

        string CalcularTipoTriangulo (int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isósceles";
            }
            return "Escaleno";
        }

    }
}
