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
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        private void btnGerarMédia_Click(object sender, EventArgs e)
        {
            string nota1 = textBox1.Text;
            string nota2 = textBox2.Text;
            string nota3 = textBox3.Text;

            double n1 = double.Parse(nota1);
            double n2 = double.Parse(nota2);
            double n3 = double.Parse(nota3);

            if (n1 < 0 || n1 > 10 || n2 < 0 || n2 > 10 || n3 < 0 || n3 > 10)
            {
                MessageBox.Show("Valor Inválido - As notas devem estar entre 0 e 10");
                //Encerra o método!
                return;
            }

            double media = (n1 + n2 + n3) / 3;

            MessageBox.Show(media.ToString("N2"));

            if (media >= 7)
            {
                MessageBox.Show("Aprovado(a)!");            
            }
            else if (media < 5)
            {
                MessageBox.Show("Reprovado(a)");
            }
            else
            {
                MessageBox.Show("Recuperação");
            }








            



        }

       
    }
}
