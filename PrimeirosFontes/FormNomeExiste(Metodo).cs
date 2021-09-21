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
    public partial class FormNomeExiste_Metodo_ : Form
    {
        public FormNomeExiste_Metodo_()
        {
            InitializeComponent();
        }

        List<string> nomes = new List<string>();

        string AdicionarNome(string nome) 
        {
            if (nome == "")
            {
                return "Nome deve ser informado.";
            }
            if (nomes.Count == 10)
            {
                return "A lista deve conter apenas 10 nomes.";
            }
            nomes.Add(nome);
            return "Nome adicionado";
        }

        bool PesquisarNome(string nome) 
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == nome)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdicionarNome(txtAdicionarNome.Text));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool Encontrado = PesquisarNome(txtPesquisarNome.Text);

            if (Encontrado)
            {
                MessageBox.Show("Nome encontrado");
            }
            else
            {
                MessageBox.Show("Nome não encontrado");
            }
        }
    }
}
