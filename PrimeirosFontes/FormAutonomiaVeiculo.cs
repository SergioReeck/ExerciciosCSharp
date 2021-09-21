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
    public partial class FormAutonomiaVeiculo : Form
    {
        public FormAutonomiaVeiculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tGasto = double.Parse(txtTempoViagem.Text);
            double vMedia = double.Parse(txtVelocidadeMedia.Text);
            double[] resultado = CalcularConsumoDoCarro(tGasto, vMedia);

            MessageBox.Show("Distancia: " + resultado[0]);
            MessageBox.Show("Qtde Litros: " + resultado[1]);
        }


        double[] CalcularConsumoDoCarro(double tempoGasto, double velocidadeMedia)
        {
            double[] valores = new double[2];
            double distancia = velocidadeMedia / (tempoGasto / 60);
            double qtdelitros = distancia / 12;

            valores[0] = distancia;
            valores[1] = qtdelitros;
            return valores;
        }
    }
}     
