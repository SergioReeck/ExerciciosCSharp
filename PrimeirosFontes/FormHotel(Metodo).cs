using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeirosFontes
{
    public partial class FormHotelFuncao : Form
    {
        public FormHotelFuncao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dias = double.Parse(txtDias.Text);
            double pessoas = double.Parse(txtPessoas.Text);
            string tipoQuarto = "";

            if (rdSuíte1.Checked)
            {
                tipoQuarto = "Standard";
            }
            else if (rdSuíte2.Checked)
            {
                tipoQuarto = "Luxo";
            }
            else
            {
                tipoQuarto = "Superluxo";
            }

            double preco = CalcularValorDoCheckOut(dias, pessoas, tipoQuarto);
            txtTotal.Text = preco.ToString("C2");
        }

        double CalcularValorDoCheckOut(double nDias, double nHospedes, string tipoQuarto)
        {
            if (tipoQuarto == "Standard")
            {
                return nDias * nHospedes * 100;
            }
            if (tipoQuarto == "Luxo")
            {
                return nDias * nHospedes * 200;
            }
            return nDias * nHospedes * 400;

        }
    }
}
