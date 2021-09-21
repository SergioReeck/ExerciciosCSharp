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
    public partial class FormPodeOuNaoPodeVotar : Form
    {
        public FormPodeOuNaoPodeVotar()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string anodenascimento = txtNascimento.Text;

            double a1 = double.Parse(anodenascimento);
            int valor = DateTime.Now.Year - 16;

            if (a1 >= valor)
            {
                MessageBox.Show("Você não pode votar neste ano");
            }
            else
            {
                MessageBox.Show("Você pode votar neste ano");
            }



       
        
        
        }  
    



        }

    }

