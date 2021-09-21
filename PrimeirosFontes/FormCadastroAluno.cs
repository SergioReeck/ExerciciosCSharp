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
    public partial class FormCadastroAluno : Form
    {
        public FormCadastroAluno()
        {
            InitializeComponent();

            ////Vetores
            //string[] nome = new string[3];
            //nome[0] = "Fabiano";
            //nome[1] = "Sérgio";
            //nome[2] = "Isadora";

            ////Listas
            //List<string> listaNomes = new List<string>();
            //listaNomes.Add("Fabiano");
            //listaNomes.Add("Sérgio");
            //listaNomes.Add("Isadora");

        }

        List<string> nomes = new List<string>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nomes.Add(txtCadastrarAlunos.Text);
            MessageBox.Show("Cadastro com sucesso");
            txtCadastrarAlunos.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
