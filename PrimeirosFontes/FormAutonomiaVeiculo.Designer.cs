
namespace PrimeirosFontes
{
    partial class FormAutonomiaVeiculo
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
            this.txtTempoViagem = new System.Windows.Forms.TextBox();
            this.txtVelocidadeMedia = new System.Windows.Forms.TextBox();
            this.lblTempoGasto = new System.Windows.Forms.Label();
            this.lblVelocidadeMedia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTempoViagem
            // 
            this.txtTempoViagem.Location = new System.Drawing.Point(49, 81);
            this.txtTempoViagem.Name = "txtTempoViagem";
            this.txtTempoViagem.Size = new System.Drawing.Size(100, 20);
            this.txtTempoViagem.TabIndex = 0;
            // 
            // txtVelocidadeMedia
            // 
            this.txtVelocidadeMedia.Location = new System.Drawing.Point(218, 81);
            this.txtVelocidadeMedia.Name = "txtVelocidadeMedia";
            this.txtVelocidadeMedia.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadeMedia.TabIndex = 1;
            // 
            // lblTempoGasto
            // 
            this.lblTempoGasto.AutoSize = true;
            this.lblTempoGasto.Location = new System.Drawing.Point(55, 59);
            this.lblTempoGasto.Name = "lblTempoGasto";
            this.lblTempoGasto.Size = new System.Drawing.Size(93, 13);
            this.lblTempoGasto.TabIndex = 2;
            this.lblTempoGasto.Text = "Tempo de Viagem";
            // 
            // lblVelocidadeMedia
            // 
            this.lblVelocidadeMedia.AutoSize = true;
            this.lblVelocidadeMedia.Location = new System.Drawing.Point(225, 59);
            this.lblVelocidadeMedia.Name = "lblVelocidadeMedia";
            this.lblVelocidadeMedia.Size = new System.Drawing.Size(92, 13);
            this.lblVelocidadeMedia.TabIndex = 3;
            this.lblVelocidadeMedia.Text = "Velocidade Média";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(146, 124);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormAutonomiaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 188);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVelocidadeMedia);
            this.Controls.Add(this.lblTempoGasto);
            this.Controls.Add(this.txtVelocidadeMedia);
            this.Controls.Add(this.txtTempoViagem);
            this.Name = "FormAutonomiaVeiculo";
            this.Text = "FormAutonomiaVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempoViagem;
        private System.Windows.Forms.TextBox txtVelocidadeMedia;
        private System.Windows.Forms.Label lblTempoGasto;
        private System.Windows.Forms.Label lblVelocidadeMedia;
        private System.Windows.Forms.Button btnCalcular;
    }
}