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
    public partial class FormComparacao : Form
    {
        public FormComparacao()
        {
            InitializeComponent();
        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            double vNumero1 = double.Parse(txtNúmero1.Text);
            double vNumero2 = double.Parse(txtNúmero2.Text);
            double Resultado = 0;

            if (vNumero1 == vNumero2)
            {
                Resultado = vNumero1 + vNumero2;
                
            }
            else
            {
                Resultado = vNumero1 * vNumero2;
            }
            txtResultado1.Text = Resultado.ToString();

        }
    }
}
