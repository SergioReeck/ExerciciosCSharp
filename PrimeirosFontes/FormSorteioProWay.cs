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
    public partial class FormSorteioProWay : Form
    {
        public FormSorteioProWay()
        {
            InitializeComponent();
            Text = "Sorteio";
            //Quando o usuário pressionar ENTER, o botão btnCadastrar será "clicado".
            AcceptButton = btnCadastrar;
            this.txtCadastrar.TabIndex = 0;
        }

        List<string> nomes = new List<string>();
        Random rdm = new Random();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nomes.Add(txtCadastrar.Text);
            txtCadastrar.Clear();
            txtCadastrar.Focus();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            int numeroSorteado = rdm.Next(0, nomes.Count);
            string nome = nomes[numeroSorteado];
            nomes.RemoveAt(numeroSorteado);
            MessageBox.Show(nome);
            SincronizarListaComCaixaDeTexto();
        }

        void SincronizarListaComCaixaDeTexto()
        {
            txtNomes.Text = "";
            for (int i = 0; i < nomes.Count; i++)
            {
                txtNomes.Text = txtNomes.Text + nomes[i] + "\r\n";
            }
        }
    }
}
