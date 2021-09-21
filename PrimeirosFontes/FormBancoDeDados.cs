using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeirosFontes
{
    public partial class FormBancoDeDados : Form
    {
        public FormBancoDeDados()
        {
            InitializeComponent();

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Trapped unhandled exception");
            sb.AppendLine(e.Exception.ToString());
            MessageBox.Show(sb.ToString());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Bairro = txtBairro.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.CPF = txtCPF.Text;
            c.DataDeNascimento = dtpDataDeNascimento.Value;
            c.Email = txtEmail.Text;
            c.EstadoCivil = cmbEstadoCivil.Text;
            c.Genero = cmbGenero.Text;
            c.Nome = txtNome.Text;
            c.Numero = txtNumero.Text;
            c.Rua = txtRua.Text;
            c.Cidade = txtCidade.Text;
            c.UF = cmbUF.Text;
            c.TelefoneCelular = txtTelefoneCelular.Text;
            ClientesDataBase cdb  = new ClientesDataBase();
            string mensagem = cdb.Cadastrar(c);
            MessageBox.Show(mensagem);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            try
            {
                c.ID = Convert.ToInt32(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um ID válido!");
                return;
            }

            c.ID = Convert.ToInt32(txtID.Text);
            c.Bairro = txtBairro.Text;
            c.CEP = txtCEP.Text;
            c.Complemento = txtComplemento.Text;
            c.CPF = txtCPF.Text;
            c.DataDeNascimento = dtpDataDeNascimento.Value;
            c.Email = txtEmail.Text;
            c.EstadoCivil = cmbEstadoCivil.Text;
            c.Genero = cmbGenero.Text;
            c.Nome = txtNome.Text;
            c.Numero = txtNumero.Text;
            c.Rua = txtRua.Text;
            c.Cidade = txtCidade.Text;
            c.UF = cmbUF.Text;
            c.TelefoneCelular = txtTelefoneCelular.Text;
            ClientesDataBase cdb = new ClientesDataBase();
            string mensagem = cdb.Editar(c);
            MessageBox.Show(mensagem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClientesDataBase cdb = new ClientesDataBase();
            cdb.Excluir(Convert.ToInt32(txtID.Text));
        }
    }
}
