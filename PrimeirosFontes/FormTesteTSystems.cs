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
    public partial class FormTesteTSystems : Form
    {
        public FormTesteTSystems()
        {
            InitializeComponent();
        }

        
private void btnCalcular1_Click(object sender, EventArgs e)
        {
            string ladoA = txtLabel1.Text;
            string ladoB = txtLabel2.Text;
            string ladoC = txtLabel3.Text;

            double A = double.Parse(ladoA);
            double B = double.Parse(ladoB);
            double C = double.Parse(ladoC);

            if (A <= 0 || B <= 0 || C <= 0)
            {
                MessageBox.Show("Não é um tipo de triângulo");
                return;
            }      

            if (A == B && B == C)
            {
                MessageBox.Show("O Triângulo é EQUILÁTERO!");
            }
            else if (A == B || B == C || A == C)
            {
                MessageBox.Show("O Triângulo é ISÓSCELES!");
            }
            else 
            {
                MessageBox.Show("O Triângulo é ESCALENO!");
            }
        }
    }
}
