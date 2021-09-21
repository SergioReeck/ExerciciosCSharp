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
    public partial class FormValoresImpressos : Form
    {
        public FormValoresImpressos()
        {
            InitializeComponent();
        }

        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double nDigitado = double.Parse(txtDigitarNumero.Text);
            string mensagem = "";
            
            for (int i = 0; i < nDigitado; i++)
            {
                mensagem = mensagem + i + "\r\n";
            }
            MessageBox.Show(mensagem);
        }
    }
}
