
namespace PrimeirosFontes
{
    partial class FormComparacao
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNúmero2 = new System.Windows.Forms.Label();
            this.txtNúmero1 = new System.Windows.Forms.TextBox();
            this.txtNúmero2 = new System.Windows.Forms.TextBox();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(43, 21);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(53, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1";
            // 
            // lblNúmero2
            // 
            this.lblNúmero2.AutoSize = true;
            this.lblNúmero2.Location = new System.Drawing.Point(246, 21);
            this.lblNúmero2.Name = "lblNúmero2";
            this.lblNúmero2.Size = new System.Drawing.Size(53, 13);
            this.lblNúmero2.TabIndex = 1;
            this.lblNúmero2.Text = "Número 2";
            // 
            // txtNúmero1
            // 
            this.txtNúmero1.Location = new System.Drawing.Point(16, 51);
            this.txtNúmero1.Name = "txtNúmero1";
            this.txtNúmero1.Size = new System.Drawing.Size(100, 20);
            this.txtNúmero1.TabIndex = 2;
            // 
            // txtNúmero2
            // 
            this.txtNúmero2.Location = new System.Drawing.Point(222, 51);
            this.txtNúmero2.Name = "txtNúmero2";
            this.txtNúmero2.Size = new System.Drawing.Size(100, 20);
            this.txtNúmero2.TabIndex = 3;
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(120, 118);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 4;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(145, 92);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(55, 13);
            this.lblResultado1.TabIndex = 5;
            this.lblResultado1.Text = "Resultado";
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Location = new System.Drawing.Point(134, 163);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular1.TabIndex = 6;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.btnCalcular1_Click);
            // 
            // FormComparação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 214);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.txtNúmero2);
            this.Controls.Add(this.txtNúmero1);
            this.Controls.Add(this.lblNúmero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "FormComparação";
            this.Text = "FormComparação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNúmero2;
        private System.Windows.Forms.TextBox txtNúmero1;
        private System.Windows.Forms.TextBox txtNúmero2;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Button btnCalcular1;
    }
}