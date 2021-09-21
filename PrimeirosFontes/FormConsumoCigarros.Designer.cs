
namespace CâmadaInicial
{
    partial class FormConsumoCigarros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPrecoCarteira = new System.Windows.Forms.TextBox();
            this.txtAnosDeUso = new System.Windows.Forms.TextBox();
            this.txtQtdeCigarrosConsumidos = new System.Windows.Forms.TextBox();
            this.lblPrecoDaCarteira = new System.Windows.Forms.Label();
            this.lblQtdeDeCigarrosConsumidas = new System.Windows.Forms.Label();
            this.lblAnosDeUso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(52, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPrecoCarteira
            // 
            this.txtPrecoCarteira.Location = new System.Drawing.Point(15, 25);
            this.txtPrecoCarteira.Name = "txtPrecoCarteira";
            this.txtPrecoCarteira.Size = new System.Drawing.Size(169, 20);
            this.txtPrecoCarteira.TabIndex = 1;
            // 
            // txtAnosDeUso
            // 
            this.txtAnosDeUso.Location = new System.Drawing.Point(15, 119);
            this.txtAnosDeUso.Name = "txtAnosDeUso";
            this.txtAnosDeUso.Size = new System.Drawing.Size(169, 20);
            this.txtAnosDeUso.TabIndex = 3;
            // 
            // txtQtdeCigarrosConsumidos
            // 
            this.txtQtdeCigarrosConsumidos.Location = new System.Drawing.Point(15, 74);
            this.txtQtdeCigarrosConsumidos.Name = "txtQtdeCigarrosConsumidos";
            this.txtQtdeCigarrosConsumidos.Size = new System.Drawing.Size(169, 20);
            this.txtQtdeCigarrosConsumidos.TabIndex = 2;
            // 
            // lblPrecoDaCarteira
            // 
            this.lblPrecoDaCarteira.AutoSize = true;
            this.lblPrecoDaCarteira.Location = new System.Drawing.Point(12, 9);
            this.lblPrecoDaCarteira.Name = "lblPrecoDaCarteira";
            this.lblPrecoDaCarteira.Size = new System.Drawing.Size(112, 13);
            this.lblPrecoDaCarteira.TabIndex = 4;
            this.lblPrecoDaCarteira.Text = "Preço da Carteira (R$)";
            // 
            // lblQtdeDeCigarrosConsumidas
            // 
            this.lblQtdeDeCigarrosConsumidas.AutoSize = true;
            this.lblQtdeDeCigarrosConsumidas.Location = new System.Drawing.Point(12, 58);
            this.lblQtdeDeCigarrosConsumidas.Name = "lblQtdeDeCigarrosConsumidas";
            this.lblQtdeDeCigarrosConsumidas.Size = new System.Drawing.Size(172, 13);
            this.lblQtdeDeCigarrosConsumidas.TabIndex = 5;
            this.lblQtdeDeCigarrosConsumidas.Text = "Qtde de Cigarros Consumidos (Un.)";
            // 
            // lblAnosDeUso
            // 
            this.lblAnosDeUso.AutoSize = true;
            this.lblAnosDeUso.Location = new System.Drawing.Point(12, 103);
            this.lblAnosDeUso.Name = "lblAnosDeUso";
            this.lblAnosDeUso.Size = new System.Drawing.Size(68, 13);
            this.lblAnosDeUso.TabIndex = 6;
            this.lblAnosDeUso.Text = "Anos de Uso";
            // 
            // FormConsumoCigarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 195);
            this.Controls.Add(this.lblAnosDeUso);
            this.Controls.Add(this.lblQtdeDeCigarrosConsumidas);
            this.Controls.Add(this.lblPrecoDaCarteira);
            this.Controls.Add(this.txtQtdeCigarrosConsumidos);
            this.Controls.Add(this.txtAnosDeUso);
            this.Controls.Add(this.txtPrecoCarteira);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormConsumoCigarros";
            this.Text = "FormConsumoCigarros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPrecoCarteira;
        private System.Windows.Forms.TextBox txtAnosDeUso;
        private System.Windows.Forms.TextBox txtQtdeCigarrosConsumidos;
        private System.Windows.Forms.Label lblPrecoDaCarteira;
        private System.Windows.Forms.Label lblQtdeDeCigarrosConsumidas;
        private System.Windows.Forms.Label lblAnosDeUso;
    }
}