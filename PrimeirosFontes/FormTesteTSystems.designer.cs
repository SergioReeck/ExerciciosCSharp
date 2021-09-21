
namespace PrimeirosFontes
{
    partial class FormTesteTSystems
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
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.txtLabel1 = new System.Windows.Forms.TextBox();
            this.txtLabel2 = new System.Windows.Forms.TextBox();
            this.txtLabel3 = new System.Windows.Forms.TextBox();
            this.lblInício1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(99, 113);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(41, 13);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Lado A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(256, 113);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(41, 13);
            this.lblLadoB.TabIndex = 1;
            this.lblLadoB.Text = "Lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(414, 113);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(41, 13);
            this.lblLadoC.TabIndex = 2;
            this.lblLadoC.Text = "Lado C";
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Location = new System.Drawing.Point(234, 247);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular1.TabIndex = 3;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.btnCalcular1_Click);
            // 
            // txtLabel1
            // 
            this.txtLabel1.Location = new System.Drawing.Point(64, 169);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.Size = new System.Drawing.Size(100, 20);
            this.txtLabel1.TabIndex = 4;
            // 
            // txtLabel2
            // 
            this.txtLabel2.Location = new System.Drawing.Point(222, 169);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(100, 20);
            this.txtLabel2.TabIndex = 5;
            // 
            // txtLabel3
            // 
            this.txtLabel3.Location = new System.Drawing.Point(382, 169);
            this.txtLabel3.Name = "txtLabel3";
            this.txtLabel3.Size = new System.Drawing.Size(100, 20);
            this.txtLabel3.TabIndex = 6;
            // 
            // lblInício1
            // 
            this.lblInício1.AutoSize = true;
            this.lblInício1.Location = new System.Drawing.Point(219, 54);
            this.lblInício1.Name = "lblInício1";
            this.lblInício1.Size = new System.Drawing.Size(113, 13);
            this.lblInício1.TabIndex = 7;
            this.lblInício1.Text = "Qual tipo de triângulo?";
            // 
            // FormTesteTSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.lblInício1);
            this.Controls.Add(this.txtLabel3);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.txtLabel1);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Name = "FormTesteTSystems";
            this.Text = "FormTesteTSystems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.TextBox txtLabel1;
        private System.Windows.Forms.TextBox txtLabel2;
        private System.Windows.Forms.TextBox txtLabel3;
        private System.Windows.Forms.Label lblInício1;
    }
}