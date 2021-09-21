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
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        //Questão: Lê o nome de um professor e um código de titulação e imprime
        //o nome do mesmo com o seu título, de  acordo   com  a  seguinte  tabela:
        //d   -   doutor,
        //m   -   mestre,
        //e   -   especialista,
        //l   -   licenciado,
        //b   -   bacharel.
        //O programa deve detectar um código inválido, isto é, um código que não consta nestatabela.

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeFormatado = FormatarNomeComTitulacao("Thiago", "d");
        }

        string FormatarNomeComTitulacao(string nome, string titulacao) 
        {
            if (titulacao == "B" || titulacao == "b")
            {
                return "Bacharel" + nome;
            }
            else if (titulacao == "M" || titulacao == "m") 
            {
                return "Mestre" + nome;
            }
            else if (titulacao == "E" || titulacao == "e") 
            {
                return "Especialista" + nome;
            }
            else if (titulacao == "L" || titulacao == "l") 
            {
                return "Licenciado" + nome;
            }
            else if (titulacao == "D" || titulacao == "d") 
            {
                return "Doutor" + nome;
            }
            return "Código Inválido";
        }
    }
}
