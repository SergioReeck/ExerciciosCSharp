
namespace PrimeirosFontes
{
    partial class FormRaizQuadrada
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
            this.txtCálculo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.lblCálculo = new System.Windows.Forms.Label();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(221, 217);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 20);
            this.txtResultado2.TabIndex = 15;
            // 
            // txtCálculo
            // 
            this.txtCálculo.Location = new System.Drawing.Point(159, 97);
            this.txtCálculo.Name = "txtCálculo";
            this.txtCálculo.Size = new System.Drawing.Size(100, 20);
            this.txtCálculo.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(172, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(183, 187);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // lblNúmero
            // 
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Location = new System.Drawing.Point(166, 72);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(85, 13);
            this.lblNúmero.TabIndex = 11;
            this.lblNúmero.Text = "Dígite o Número";
            // 
            // lblCálculo
            // 
            this.lblCálculo.AutoSize = true;
            this.lblCálculo.Location = new System.Drawing.Point(187, 36);
            this.lblCálculo.Name = "lblCálculo";
            this.lblCálculo.Size = new System.Drawing.Size(42, 13);
            this.lblCálculo.TabIndex = 10;
            this.lblCálculo.Text = "Cálculo";
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(97, 217);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 16;
            // 
            // FormRaizQuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 270);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtCálculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNúmero);
            this.Controls.Add(this.lblCálculo);
            this.Name = "FormRaizQuadrada";
            this.Text = "FormRaizQuadrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.TextBox txtCálculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.Label lblCálculo;
        private System.Windows.Forms.TextBox txtResultado1;
    }
}