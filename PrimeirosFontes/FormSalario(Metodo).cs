using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CâmadaInicial
{
    public partial class FormSalario_Metodo_ : Form
    {
        public FormSalario_Metodo_()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sBruto = double.Parse(txtSalario.Text);
            
            double sLiquido = CalcularSalario(sBruto);
            MessageBox.Show("O valor do seu salário é de " + sLiquido.ToString("C2"));
        }

        double CalcularSalario(double salario)
        {
            if (salario <= 600)
            {
                return salario;
            }
            else if (salario <= 1200)
            {
                return salario * 0.8;
                            }
            else if (salario <= 2000)
            {
                return salario * 0.75;
            }
            else
            {
                return salario * 0.7;
            }
        }
    }
}
