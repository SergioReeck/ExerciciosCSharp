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
    public partial class FormPlacar : Form
    {
        public FormPlacar()
        {
            InitializeComponent();
        }

        int golTime1 = 0;
        int golTime2 = 0;

        private void btnGolTime1_Click(object sender, EventArgs e)
        {
            golTime1 = golTime1 + 1;
            lblPlacarTime1.Text = golTime1.ToString();
        }

        private void btnGolTime2_Click(object sender, EventArgs e)
        {
            golTime2 = golTime2 + 1;
            lblPlacarTime2.Text = golTime2.ToString();

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (golTime1 > golTime2)
            {
                MessageBox.Show(txtTime1.Text +" venceu por " + golTime1 + "x" + golTime2);
            }
            else if (golTime2 > golTime1)
            {
                MessageBox.Show(txtTime2.Text +" venceu por " + golTime2 + "x" + golTime2);
            }
            else
            {
                MessageBox.Show("Empate entre " + txtTime1.Text + "e" + txtTime2 + "com o placar de " + golTime1 + "x" + golTime2);
            }
        }

        private void btnAnularTime1_Click(object sender, EventArgs e)
        {
            golTime1--;
            if (golTime1 < 0)
            {
                golTime1 = 0;
            }
            lblPlacarTime1.Text = golTime1.ToString();
        }

        private void btnAnularTime2_Click(object sender, EventArgs e)
        {
            golTime2--;
            if (golTime2 < 0)
            {
                golTime2 = 0;
            }
            lblPlacarTime2.Text = golTime2.ToString();
        }

        private void btnFotoTime1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string localArquivo = ofd.FileName;
            pictureTime1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTime1.ImageLocation = localArquivo;
        }

        private void btnFotoTime2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string localArquivo = ofd.FileName;
            pictureTime2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTime2.ImageLocation = localArquivo;
                      
        }
    }
}
