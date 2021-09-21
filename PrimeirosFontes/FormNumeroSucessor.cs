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
    public partial class FormNumeroSucessor : Form
    {
        public FormNumeroSucessor()
        {
            InitializeComponent();
        }

        //Questão: Leia um número e exiba seu sucessor.

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numeroAtual = int.Parse(txtNumero.Text) + 1;
            MessageBox.Show("O número sucessor é: " + numeroAtual);
        }
    }
}
