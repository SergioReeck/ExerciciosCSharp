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
    public partial class FormQuestao1Prova : Form
    {
        public FormQuestao1Prova()
        {
            InitializeComponent();
        }

        //QUESTÃO 1 - Elabore um algoritmo que imprima os número 0, 3, 6, 9 e 12 na tela.
        //Use o comando while para tal. Não é necessário criar um procedimento/método/função para resolução desta questão.

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            int i = 0;

            while (i <= 12)
            {
                mensagem = mensagem + i + "\r\n";
                i = i + 3;
            }
            MessageBox.Show(mensagem);
        }
    }
}
