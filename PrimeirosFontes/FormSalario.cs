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
    public partial class FormSalario : Form
    {
        public FormSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string vSalario = txtSalario.Text;

            double Salario = double.Parse(vSalario);
            double Desconto = 0;

            if (Salario <= 2000)    
            {
                MessageBox.Show("Não há desconto de imposto no seu salário" + ".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Salario <= 3800)
            {
                Desconto = Salario * 0.125;
                MessageBox.Show("O desconto de IR é de " + Desconto.ToString("C2") + ".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Salario <= 5000)
            {
                Desconto = Salario * 0.22;
                MessageBox.Show("O desconto de IR é de " + Desconto.ToString("C2") + ".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Desconto = Salario * 0.275;
                MessageBox.Show("O desconto de IR é de " + Desconto.ToString("C2") + ".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
