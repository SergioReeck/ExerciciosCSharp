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
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string dias = txtDias.Text;
            string pessoas = txtPessoas.Text;

            double total = 0;
            double ndias = double.Parse(dias);
            double npessoas = double.Parse(pessoas);

            int standard = 100;
            int luxo = 220;
            int superluxo = 400;

            if (rdSuíte1.Checked)
            {
                total = ndias * npessoas * standard;
            }
            else if (rdSuíte2.Checked)
            {
                total = ndias * npessoas * luxo;
            }
            else if (rdSuíte3.Checked)
            {
                total = ndias * npessoas * superluxo;
            }
            else
            {
                MessageBox.Show("Favor selecionar sua suíte");
            }
            txtTotal.Text = total.ToString("C2");
        }
    }
}
