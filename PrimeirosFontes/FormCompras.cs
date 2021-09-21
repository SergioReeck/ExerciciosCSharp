using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExercícioCasa1
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preçoTV = 1800;
            double preçoCelular = 1500;
            double preçoPS5 = 5000;

            double qtdeTV = 0;

            if (cbTV.Text != "")
            {
                qtdeTV = double.Parse(cbTV.Text);
            }

            double qtdeCelular = 0;

            if (cbCelular.Text != "")
            {
                qtdeCelular = double.Parse(cbCelular.Text);
            }

            double qtdePS5 = 0;

            if (cbPS5.Text != "")
            {
                qtdePS5 = double.Parse(cbPS5.Text);
            }

            double total = (qtdeTV * preçoTV) + (qtdeCelular * preçoCelular) + (qtdePS5 * preçoPS5);

            if (rbÀvista.Checked)
            {
                total = total * 0.9;
            }

            lblTotal2.Text = total.ToString("C2");
            lblTotal2.Visible = true;

            if (total == 0)
            {
                btnConfirmar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
        }

        private void chkTV_CheckedChanged(object sender, EventArgs e)
        {
            cbTV.Enabled = chkTV.Checked;
            if (!chkTV.Checked)
            {
                cbTV.Text = null;
            }
            
            if (chkTV.Checked)
            {
                lblTotal2.Text = 0.00.ToString("C2");

            }
            else
            {
                lblTotal2.Text = 0.00.ToString("C2");
            }
        }

        private void chkCelular_CheckedChanged(object sender, EventArgs e)
        {
            cbCelular.Enabled = chkCelular.Checked;
            if (!chkCelular.Checked)
            {
                cbCelular.Text = null;
            }

            if (chkCelular.Checked)
            {
                lblTotal2.Text = 0.00.ToString("C2");

            }
            else
            {
                lblTotal2.Text = 0.00.ToString("C2");
            }
        }


        
        private void chkPS5_CheckedChanged(object sender, EventArgs e)
        {
            cbPS5.Enabled = chkPS5.Checked;
            if (!chkPS5.Checked)
            {
                cbPS5.Text = null;
            }
        }

        private void cbTV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTV.Text == "")
            {
                rbÀvista.Enabled = false;
                rbParcelado.Enabled = false;
            }
            else
            {
                rbÀvista.Enabled = true;
                rbParcelado.Enabled = true;
            }
        }

        private void cbCelular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCelular.Text == "")
            {
                rbÀvista.Enabled = false;
                rbParcelado.Enabled = false;
            }
            else
            {
                rbÀvista.Enabled = true;
                rbParcelado.Enabled = true;
            }

        }

        private void cbPS5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPS5.Text == "")
            {
                rbÀvista.Enabled = false;
                rbParcelado.Enabled = false;
            }
            else
            {
                rbÀvista.Enabled = true;
                rbParcelado.Enabled = true;
            }
           

        }

        private void rbÀvista_CheckedChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = rbÀvista.Checked;

            if (!rbÀvista.Checked)
            {
                btnCalcular.Visible = false;
            }
            else
            {
                btnCalcular.Visible = true;
            }


        }

        private void rbParcelado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParcelado.Checked)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Seu pedido foi confirmado com sucesso!");
        }
    }
}
