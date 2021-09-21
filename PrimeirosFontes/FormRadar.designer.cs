
namespace PrimeirosFontes
{
    partial class FormRadar
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
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularMulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(22, 46);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velocidade";
            // 
            // btnCalcularMulta
            // 
            this.btnCalcularMulta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcularMulta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcularMulta.Location = new System.Drawing.Point(28, 82);
            this.btnCalcularMulta.Name = "btnCalcularMulta";
            this.btnCalcularMulta.Size = new System.Drawing.Size(90, 44);
            this.btnCalcularMulta.TabIndex = 2;
            this.btnCalcularMulta.Text = "Calcular";
            this.btnCalcularMulta.UseVisualStyleBackColor = false;
            this.btnCalcularMulta.Click += new System.EventHandler(this.btnCalcularMulta_Click);
            // 
            // FormRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 157);
            this.Controls.Add(this.btnCalcularMulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVelocidade);
            this.Name = "FormRadar";
            this.Text = "FormRadar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularMulta;
    }
}