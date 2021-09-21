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
    public partial class FormNumerosMultiplos : Form
    {
        public FormNumerosMultiplos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 0; i < 100; i++)
            {

                mensagem = mensagem + i + "\r\n";

            }
            MessageBox.Show(mensagem);
        }
    }
}
