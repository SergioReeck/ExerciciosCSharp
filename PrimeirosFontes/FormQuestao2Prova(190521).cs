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
    public partial class FormQuestao2Prova : Form
    {
        public FormQuestao2Prova()
        {
            InitializeComponent();
        }
        //QUESTÃO 2: Elabore um algoritmo que imprima os números múltiplos de 10, de 10 até 100.
        //Use o comando for para tal. Não é necessário criar um procedimento/método/função para resolução desta questão.

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 0; i <= 100; i = i + 10)
            {
                mensagem = mensagem + i + "\r\n";
            }
            MessageBox.Show(mensagem);
        }
    }
}
