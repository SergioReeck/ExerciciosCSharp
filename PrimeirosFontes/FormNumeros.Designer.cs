
namespace PrimeirosFontes
{
    partial class FormNumeros
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
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV3 = new System.Windows.Forms.Label();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(28, 61);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(40, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Valor 1";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(104, 61);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(40, 13);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Valor 2";
            // 
            // lblV3
            // 
            this.lblV3.AutoSize = true;
            this.lblV3.Location = new System.Drawing.Point(178, 61);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(40, 13);
            this.lblV3.TabIndex = 2;
            this.lblV3.Text = "Valor 3";
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Location = new System.Drawing.Point(62, 28);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(120, 13);
            this.lblTítulo.TabIndex = 3;
            this.lblTítulo.Text = "Insira os valores abaixo:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(27, 89);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(32, 20);
            this.txtValor1.TabIndex = 4;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(181, 89);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(32, 20);
            this.txtValor3.TabIndex = 5;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(105, 89);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(32, 20);
            this.txtValor2.TabIndex = 6;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(86, 139);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 7;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // FormNúmeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 203);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.lblV3);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Name = "FormNúmeros";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnComparar;
    }
}