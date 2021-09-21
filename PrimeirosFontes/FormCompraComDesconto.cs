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
    public partial class FormCompraComDesconto : Form
    {
        public FormCompraComDesconto()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double valorFinal = calcularDesconto(double.Parse(txtValorCompra.Text), rbAVista.Checked);
            txtTotal.Text = valorFinal.ToString("C2");

            string formaPagamento = "";
            if (rbAVista.Checked)
            {
                formaPagamento = "À Vista";
            }
            else
            {
                formaPagamento = "Parcelado";
            }

            double precoFinal = calcularDesconto2(double.Parse(txtValorCompra.Text), formaPagamento);

        }


        double calcularDesconto2(double valor, string formaPagamento)
        {
            if (valor > 1000.01)
            {
                valor = valor * 0.88;
            }
            if (formaPagamento == "À vista")
            {
                valor = valor * 0.94;
            }
            return valor;
        }


        double calcularDesconto (double valor, bool aVista) 
        {
            if (valor > 1000.01)
            {
                valor = valor * 0.88;
            }
            if (aVista)
            {
                valor = valor * 0.94;
            }
            return valor;
        }

       
    }
}
