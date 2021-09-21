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
    public partial class FormMaiorOuMenor10 : Form
    {
        public FormMaiorOuMenor10()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string resultado = txtResultado.Text;

            double valor = double.Parse(resultado);

            if (valor > 10)                
            {
                MessageBox.Show("O valor é maior que 10");
                return;
            }
            if (valor == 10)
            {
                MessageBox.Show("O valor é igual a 10");
                
            }
            else
            {
                MessageBox.Show("O valor não é maior que 10");
            }

           
                
                
                   
                

        }
    }
}
