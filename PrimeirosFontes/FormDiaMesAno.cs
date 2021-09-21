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
    public partial class FormDiaMesAno : Form
    {
        public FormDiaMesAno()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string dia = txtDia.Text;
            string mes = txtMes.Text;
            string ano = txtAno.Text;

            MessageBox.Show("Olá, hoje é dia " + dia + " de " + mes + " de " + ano);
        }
    }
}
