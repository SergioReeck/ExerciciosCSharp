
namespace PrimeirosFontes
{
    partial class FormTicketCinema
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
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblDigiteSuaIdade = new System.Windows.Forms.Label();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.lblTipoCadeira = new System.Windows.Forms.Label();
            this.lblHorasFilme = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(60, 76);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 0;
            // 
            // lblDigiteSuaIdade
            // 
            this.lblDigiteSuaIdade.AutoSize = true;
            this.lblDigiteSuaIdade.Location = new System.Drawing.Point(69, 50);
            this.lblDigiteSuaIdade.Name = "lblDigiteSuaIdade";
            this.lblDigiteSuaIdade.Size = new System.Drawing.Size(83, 13);
            this.lblDigiteSuaIdade.TabIndex = 1;
            this.lblDigiteSuaIdade.Text = "Digite sua idade";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(64, 144);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbVip
            // 
            this.rbVip.AutoSize = true;
            this.rbVip.Location = new System.Drawing.Point(128, 144);
            this.rbVip.Name = "rbVip";
            this.rbVip.Size = new System.Drawing.Size(42, 17);
            this.rbVip.TabIndex = 3;
            this.rbVip.TabStop = true;
            this.rbVip.Text = "VIP";
            this.rbVip.UseVisualStyleBackColor = true;
            // 
            // lblTipoCadeira
            // 
            this.lblTipoCadeira.AutoSize = true;
            this.lblTipoCadeira.Location = new System.Drawing.Point(71, 115);
            this.lblTipoCadeira.Name = "lblTipoCadeira";
            this.lblTipoCadeira.Size = new System.Drawing.Size(82, 13);
            this.lblTipoCadeira.TabIndex = 4;
            this.lblTipoCadeira.Text = "Tipo de Cadeira";
            // 
            // lblHorasFilme
            // 
            this.lblHorasFilme.AutoSize = true;
            this.lblHorasFilme.Location = new System.Drawing.Point(58, 177);
            this.lblHorasFilme.Name = "lblHorasFilme";
            this.lblHorasFilme.Size = new System.Drawing.Size(106, 13);
            this.lblHorasFilme.TabIndex = 5;
            this.lblHorasFilme.Text = "Quantidade de horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(60, 208);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(74, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 39);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular ingresso";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormTicketCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 333);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblHorasFilme);
            this.Controls.Add(this.lblTipoCadeira);
            this.Controls.Add(this.rbVip);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.lblDigiteSuaIdade);
            this.Controls.Add(this.txtIdade);
            this.Name = "FormTicketCinema";
            this.Text = "FormTicketCinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblDigiteSuaIdade;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.Label lblTipoCadeira;
        private System.Windows.Forms.Label lblHorasFilme;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnCalcular;
    }
}