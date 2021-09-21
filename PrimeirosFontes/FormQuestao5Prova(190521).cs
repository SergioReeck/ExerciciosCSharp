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
    public partial class FormQuestao5Prova : Form
    {
        public FormQuestao5Prova()
        {
            InitializeComponent();
        }

        //QUESTAO 5 - Crie um programa que calcule o IMC de um usuário.
        //O programa deve pedir a massa e a altura do usuário.
        //A fórmula do IMC é MASSA/ALTURA². Se o IMC for menor de 19, o programa deve imprimir "ABAIXO DO PESO".
        //Se o IMC estiver entre 20 e 24, o programa deve imprimir "NORMAL". Caso o IMC ultrapasse 24,
        //o programa deve imprimir "ACIMA DO PESO". 

        
        private void button1_Click(object sender, EventArgs e)
        {
            double massa = double.Parse(txtMassa.Text);
            double altura = double.Parse(txtAltura.Text);
            double resultado = 0;

            resultado = massa / (altura * altura);

            if (resultado < 19)
            {
                MessageBox.Show("Abaixo do peso!");
            }
            else if (resultado > 24)
            {
                MessageBox.Show("Acima do Peso!");
            }
            MessageBox.Show("Normal");
            
        }
    }
}
