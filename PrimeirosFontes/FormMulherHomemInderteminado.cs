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
    public partial class FormMulherHomemInderteminado : Form
    {
        public FormMulherHomemInderteminado()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tratamento = "";

            if (rdHomem.Checked)
            {
                tratamento = "Sr";
            }
            else if (rdMulher.Checked)
            {
                tratamento = "Sra";
            }
            else
            {
                tratamento = "Senhoria";
            } 

            MessageBox.Show(tratamento + " " + nome);
        }
    }
}
