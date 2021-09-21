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
    public partial class FormConsumoCigarros : Form
    {
        public FormConsumoCigarros()
        {
            InitializeComponent();
        }

        //QUESTÃO: Calcular a quantidade dinheiro gasto por um fumante.
        //Dados: o número de anos que ele fuma, o nº de cigarros fumados
        //por dia e o preço de uma carteira.

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precoCarteira = double.Parse(txtPrecoCarteira.Text);
            double cigarrosConsumidos = double.Parse(txtQtdeCigarrosConsumidos.Text) / 20;
            double anosDeUso = double.Parse(txtAnosDeUso.Text) * 12;
            double dinheiroGasto = 0;

            dinheiroGasto = precoCarteira * cigarrosConsumidos * anosDeUso;
            MessageBox.Show("O valor total gasto é de: " + dinheiroGasto.ToString("C2"));
        }
    }
}
