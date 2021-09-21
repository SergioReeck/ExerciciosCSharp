using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CâmadaInicial
{
    public partial class FormNumerosPares : Form
    {
        public FormNumerosPares()
        {
            InitializeComponent();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 0; i < 100; i = i + 2)
            {
                
                mensagem = mensagem + i + "\r\n";

            }
            MessageBox.Show(mensagem);
        }
    }
}
