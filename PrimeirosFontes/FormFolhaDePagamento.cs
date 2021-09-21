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
    public partial class FormFolhaDePagamento : Form
    {
        public FormFolhaDePagamento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vHoras = double.Parse(txtValorHora.Text);
            double qHorasTrabalhadas = double.Parse(txtHorasTrabalhadas.Text);
            double vSalario = 0;

            if (qHorasTrabalhadas > 8)
            {
                vSalario = (vHoras * qHorasTrabalhadas) + (qHorasTrabalhadas - 8) * (vHoras * 2);
            }
            else
            {
                vSalario = vHoras * qHorasTrabalhadas;
            }

            txtSalário.Text = vSalario.ToString("C2"); 
        }
    }
}
