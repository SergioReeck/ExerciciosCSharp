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
    public partial class FormDezNumeros1cs : Form
    {
        public FormDezNumeros1cs()
        {
            InitializeComponent();
        }

        List<string> dados = new List<string>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (dados.Count == 10)
            {
                MessageBox.Show("Limite atingido!");
                return;
            }
        
            for (int i = 0; i < dados.Count; i++)
            {
                string numeroDaVez = dados[i];
                if (numeroDaVez == txtNumerosInformados.Text)
                {
                    MessageBox.Show("Já cadastrado!");
                    return;
                }
            }

            dados.Add(txtNumerosInformados.Text);
        }
    }
}
