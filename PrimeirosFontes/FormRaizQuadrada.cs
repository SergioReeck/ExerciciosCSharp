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
    public partial class FormRaizQuadrada : Form
    {
        public FormRaizQuadrada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string vNúmero = txtCálculo.Text;
            double Número = double.Parse(vNúmero);


            double potencia = Math.Pow(Número, 2);
            double raizQuadrada = Math.Sqrt(Número);


            txtResultado1.Text = potencia.ToString();
            txtResultado2.Text = raizQuadrada.ToString();
            


            
        }
    }
}
