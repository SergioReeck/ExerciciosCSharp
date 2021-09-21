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
    public partial class FormTicketCinema : Form
    {
        public FormTicketCinema()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vIngresso = calcularValorIngresso(double.Parse(txtIdade.Text), rbVip.Checked, double.Parse(txtHoras.Text));
            MessageBox.Show("O valor do ingresso é de " + vIngresso.ToString("C2"));
        }

        double calcularValorIngresso(double idade, bool vip, double horas)
        {
            double valor = 50;

            if (idade < 18)
            {
                valor = valor - 5;
            }
            if (vip)
            {
                valor = valor + 12;
            }
            if (horas > 1)
            {
                valor = valor + (horas * 5) -5;
            }
            return valor;
        }
    }
}
