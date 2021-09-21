
namespace PrimeirosFontes
{
    partial class FormHotel
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
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblSuíte = new System.Windows.Forms.Label();
            this.rdSuíte1 = new System.Windows.Forms.RadioButton();
            this.rdSuíte2 = new System.Windows.Forms.RadioButton();
            this.rdSuíte3 = new System.Windows.Forms.RadioButton();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.lblPessoas = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckOut.Location = new System.Drawing.Point(13, 21);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(279, 29);
            this.lblCheckOut.TabIndex = 0;
            this.lblCheckOut.Text = "Faça seu check-out aqui!";
            // 
            // lblSuíte
            // 
            this.lblSuíte.AutoSize = true;
            this.lblSuíte.Location = new System.Drawing.Point(101, 172);
            this.lblSuíte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuíte.Name = "lblSuíte";
            this.lblSuíte.Size = new System.Drawing.Size(85, 15);
            this.lblSuíte.TabIndex = 2;
            this.lblSuíte.Text = "Escolha a Suíte";
            // 
            // rdSuíte1
            // 
            this.rdSuíte1.AutoSize = true;
            this.rdSuíte1.Location = new System.Drawing.Point(38, 190);
            this.rdSuíte1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdSuíte1.Name = "rdSuíte1";
            this.rdSuíte1.Size = new System.Drawing.Size(72, 19);
            this.rdSuíte1.TabIndex = 3;
            this.rdSuíte1.TabStop = true;
            this.rdSuíte1.Text = "Standard";
            this.rdSuíte1.UseVisualStyleBackColor = true;
            // 
            // rdSuíte2
            // 
            this.rdSuíte2.AutoSize = true;
            this.rdSuíte2.Location = new System.Drawing.Point(118, 190);
            this.rdSuíte2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdSuíte2.Name = "rdSuíte2";
            this.rdSuíte2.Size = new System.Drawing.Size(51, 19);
            this.rdSuíte2.TabIndex = 4;
            this.rdSuíte2.TabStop = true;
            this.rdSuíte2.Text = "Luxo";
            this.rdSuíte2.UseVisualStyleBackColor = true;
            // 
            // rdSuíte3
            // 
            this.rdSuíte3.AutoSize = true;
            this.rdSuíte3.Location = new System.Drawing.Point(177, 190);
            this.rdSuíte3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdSuíte3.Name = "rdSuíte3";
            this.rdSuíte3.Size = new System.Drawing.Size(84, 19);
            this.rdSuíte3.TabIndex = 5;
            this.rdSuíte3.TabStop = true;
            this.rdSuíte3.Text = "Super Luxo";
            this.rdSuíte3.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(68, 68);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(149, 15);
            this.lblDias.TabIndex = 7;
            this.lblDias.Text = "Nº de dias de hospedagem";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(68, 86);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(149, 23);
            this.txtDias.TabIndex = 8;
            // 
            // txtPessoas
            // 
            this.txtPessoas.Location = new System.Drawing.Point(68, 142);
            this.txtPessoas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(149, 23);
            this.txtPessoas.TabIndex = 10;
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Location = new System.Drawing.Point(68, 124);
            this.lblPessoas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(147, 15);
            this.lblPessoas.TabIndex = 9;
            this.lblPessoas.Text = "Nº de pessoas hospedadas";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(84, 276);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 23);
            this.txtTotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 258);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total (R$)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(98, 224);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 27);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 319);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPessoas);
            this.Controls.Add(this.lblPessoas);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.rdSuíte3);
            this.Controls.Add(this.rdSuíte2);
            this.Controls.Add(this.rdSuíte1);
            this.Controls.Add(this.lblSuíte);
            this.Controls.Add(this.lblCheckOut);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblSuíte;
        private System.Windows.Forms.RadioButton rdSuíte1;
        private System.Windows.Forms.RadioButton rdSuíte2;
        private System.Windows.Forms.RadioButton rdSuíte3;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Label lblPessoas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
    }
}