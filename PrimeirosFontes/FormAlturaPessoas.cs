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
    public partial class FormAlturaPessoas : Form
    {
        public FormAlturaPessoas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 10;

            double alturaPessoa1 = 1.20;
            double alturaPessoa2 = 1.40;

            double crescimentoPessoa1 = 0.08;
            double crescimentoPessoa2 = 0.04;

            while (alturaPessoa2 > alturaPessoa1)
            {
                alturaPessoa1 += crescimentoPessoa1;
                alturaPessoa2 += crescimentoPessoa2;
                idade++;
            }

            MessageBox.Show(idade.ToString());

            MessageBox.Show(alturaPessoa1.ToString());
            MessageBox.Show(alturaPessoa2.ToString());
        }
    }
}
