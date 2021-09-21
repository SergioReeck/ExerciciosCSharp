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
    public partial class FormTemperatura : Form
    {
        public FormTemperatura()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string vTemperatura = txtResultado1.Text;

            double Temperatura = double.Parse(vTemperatura);
            double Resultado = 0;
            
            Resultado = (Temperatura * 1.8) + 32;
            MessageBox.Show("A temperatura é de " + Resultado.ToString() + " F°");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vTemperatura2 = txtResultado2.Text;

            double Temperatura2 = double.Parse(vTemperatura2);
            double Resultado2 = 0;

            Resultado2 = (Temperatura2 / 1.8) - 32;
            MessageBox.Show("A temperatura é de " + Resultado2.ToString("C0") + " C°");

        }
    }
}
