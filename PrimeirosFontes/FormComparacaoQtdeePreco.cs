using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormExercício3 : Form
    {
        public FormExercício3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string quantidade = txtCompra.Text;
            
            double q1 = double.Parse(quantidade);
            
            if (q1 >=12)
            {
                MessageBox.Show("O preço é de : " + q1.ToString("C2"));
            }
            else
            {
                double novoPreco = q1 * 1.3;
                MessageBox.Show("O preco é de : " + novoPreco.ToString("C2"));
            }
            


        }
    }
}
