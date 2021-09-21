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
    public partial class FormMetodo : Form
    {
        public FormMetodo()
        {
            InitializeComponent();
        }

        // Método 
        // string mensagem = EhPar(int.Parse(textBox1.Text)) ? "É par" : "É ímpar";
        // MessageBox.Show(mensagem);

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if (EhPar(int.Parse(textBox1.Text)));
            //{
            //    MessageBox.Show("É par");
            //}
            //else
            //{
            //    MessageBox.Show("É ímpar");
            //}

        }
        bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }

        //bool EhMultiploDeOito(int numero) 
        //{
        //    return numero % 8 == 0;
        //}
    }
}
