
namespace PrimeirosFontes
{
    partial class FormComissao
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
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblCálculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(110, 213);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 20);
            this.txtResultado2.TabIndex = 22;
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(110, 101);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(100, 20);
            this.txtVendas.TabIndex = 21;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(122, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(127, 187);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 13);
            this.lblResultado.TabIndex = 19;
            this.lblResultado.Text = "Valor Líquido";
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Location = new System.Drawing.Point(116, 76);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(90, 13);
            this.lblVendas.TabIndex = 18;
            this.lblVendas.Text = "Valor das Vendas";
            // 
            // lblCálculo
            // 
            this.lblCálculo.AutoSize = true;
            this.lblCálculo.Location = new System.Drawing.Point(116, 41);
            this.lblCálculo.Name = "lblCálculo";
            this.lblCálculo.Size = new System.Drawing.Size(92, 13);
            this.lblCálculo.TabIndex = 17;
            this.lblCálculo.Text = "Cálculo de Salário";
            // 
            // FormComissão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 279);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.lblCálculo);
            this.Name = "FormComissão";
            this.Text = "FormComissão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.TextBox txtVendas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Label lblCálculo;
    }
}