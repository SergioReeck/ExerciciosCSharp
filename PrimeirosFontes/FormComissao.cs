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
    public partial class FormComissao : Form
    {
        public FormComissao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string vVendas = txtVendas.Text;

            double Vendas = double.Parse(vVendas);
            double sBase = 1400;
            double vComissao = 0;
            double sFinal = 0;
            

            vComissao = Vendas * 0.03;
            sFinal = vComissao + sBase;

            if (vComissao > 10000)
            {
               sFinal = sFinal * 0.94;
                txtResultado2.Text = sFinal.ToString("N2");
            }
            else
            {
                txtResultado2.Text = sFinal.ToString("N2");
            }
        }
    }
    
}
