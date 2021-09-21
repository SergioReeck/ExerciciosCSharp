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
    public partial class Form100Posicoes : Form
    {
        public Form100Posicoes()
        {
            InitializeComponent();
        }

        double[] nVetores = new double[100];

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 0; i < nVetores.Length; i++)
            {
                nVetores[i] = i;
                mensagem = mensagem + i + Environment.NewLine;
            }
            MessageBox.Show(mensagem);
        }
    }
}
