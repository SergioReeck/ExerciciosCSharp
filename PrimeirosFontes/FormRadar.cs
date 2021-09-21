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
    public partial class FormRadar : Form
    {
        public FormRadar()
        {
            InitializeComponent();
        }

        private void btnCalcularMulta_Click(object sender, EventArgs e)
        {
            //Até 50km/h - Isento
            //Entre 51km/h - 70km/h - R$ 300,00
            //Entre 71km/h - 100km/h - R$ 600,00
            //Mais de 100km/h - R$ 1.500,00

            double velocidade = double.Parse(txtVelocidade.Text);

            if (velocidade <= 50)
            {
                MessageBox.Show("Isento");
            }
            else if (velocidade <= 70)
            {
                MessageBox.Show("R$ 300,00");
            }
            else if (velocidade <= 100)
            {
                MessageBox.Show("R$ 600,00");
            }
            else
            {
                MessageBox.Show("R$ 1.500,00");
            }
        }
    }
}
