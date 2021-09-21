
namespace PrimeirosFontes
{
    partial class FormTemperatura
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblTemperaturaC = new System.Windows.Forms.Label();
            this.lblTemperaturaF = new System.Windows.Forms.Label();
            this.btnConverter1 = new System.Windows.Forms.Button();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.btnConverter2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(149, 27);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(175, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Escolha a Unidade de Temperatura";
            // 
            // lblTemperaturaC
            // 
            this.lblTemperaturaC.AutoSize = true;
            this.lblTemperaturaC.Location = new System.Drawing.Point(186, 67);
            this.lblTemperaturaC.Name = "lblTemperaturaC";
            this.lblTemperaturaC.Size = new System.Drawing.Size(18, 13);
            this.lblTemperaturaC.TabIndex = 1;
            this.lblTemperaturaC.Text = "C°";
            // 
            // lblTemperaturaF
            // 
            this.lblTemperaturaF.AutoSize = true;
            this.lblTemperaturaF.Location = new System.Drawing.Point(375, 68);
            this.lblTemperaturaF.Name = "lblTemperaturaF";
            this.lblTemperaturaF.Size = new System.Drawing.Size(17, 13);
            this.lblTemperaturaF.TabIndex = 2;
            this.lblTemperaturaF.Text = "F°";
            // 
            // btnConverter1
            // 
            this.btnConverter1.Location = new System.Drawing.Point(94, 100);
            this.btnConverter1.Name = "btnConverter1";
            this.btnConverter1.Size = new System.Drawing.Size(75, 23);
            this.btnConverter1.TabIndex = 3;
            this.btnConverter1.Text = "Converter";
            this.btnConverter1.UseVisualStyleBackColor = true;
            this.btnConverter1.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(80, 64);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(100, 20);
            this.txtResultado1.TabIndex = 5;
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(269, 64);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 20);
            this.txtResultado2.TabIndex = 8;
            // 
            // btnConverter2
            // 
            this.btnConverter2.Location = new System.Drawing.Point(284, 100);
            this.btnConverter2.Name = "btnConverter2";
            this.btnConverter2.Size = new System.Drawing.Size(75, 23);
            this.btnConverter2.TabIndex = 9;
            this.btnConverter2.Text = "Converter";
            this.btnConverter2.UseVisualStyleBackColor = true;
            this.btnConverter2.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 167);
            this.Controls.Add(this.btnConverter2);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.btnConverter1);
            this.Controls.Add(this.lblTemperaturaF);
            this.Controls.Add(this.lblTemperaturaC);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "FormTemperatura";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblTemperaturaC;
        private System.Windows.Forms.Label lblTemperaturaF;
        private System.Windows.Forms.Button btnConverter1;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Button btnConverter2;
    }
}