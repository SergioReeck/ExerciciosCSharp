
namespace PrimeirosFontes
{
    partial class FormHotelFuncao
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPessoas = new System.Windows.Forms.TextBox();
            this.lblPessoas = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdSuíte3 = new System.Windows.Forms.RadioButton();
            this.rdSuíte2 = new System.Windows.Forms.RadioButton();
            this.rdSuíte1 = new System.Windows.Forms.RadioButton();
            this.lblSuíte = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(142, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(130, 361);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(150, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 13);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total (R$)";
            // 
            // txtPessoas
            // 
            this.txtPessoas.Location = new System.Drawing.Point(126, 168);
            this.txtPessoas.Name = "txtPessoas";
            this.txtPessoas.Size = new System.Drawing.Size(100, 20);
            this.txtPessoas.TabIndex = 23;
            // 
            // lblPessoas
            // 
            this.lblPessoas.AutoSize = true;
            this.lblPessoas.Location = new System.Drawing.Point(110, 139);
            this.lblPessoas.Name = "lblPessoas";
            this.lblPessoas.Size = new System.Drawing.Size(137, 13);
            this.lblPessoas.TabIndex = 22;
            this.lblPessoas.Text = "Nº de pessoas hospedadas";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(126, 100);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 21;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(107, 73);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(135, 13);
            this.lblDias.TabIndex = 20;
            this.lblDias.Text = "Nº de dias de hospedagem";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 246);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // rdSuíte3
            // 
            this.rdSuíte3.AutoSize = true;
            this.rdSuíte3.Location = new System.Drawing.Point(263, 242);
            this.rdSuíte3.Name = "rdSuíte3";
            this.rdSuíte3.Size = new System.Drawing.Size(79, 17);
            this.rdSuíte3.TabIndex = 18;
            this.rdSuíte3.TabStop = true;
            this.rdSuíte3.Text = "Super Luxo";
            this.rdSuíte3.UseVisualStyleBackColor = true;
            // 
            // rdSuíte2
            // 
            this.rdSuíte2.AutoSize = true;
            this.rdSuíte2.Location = new System.Drawing.Point(153, 242);
            this.rdSuíte2.Name = "rdSuíte2";
            this.rdSuíte2.Size = new System.Drawing.Size(48, 17);
            this.rdSuíte2.TabIndex = 17;
            this.rdSuíte2.TabStop = true;
            this.rdSuíte2.Text = "Luxo";
            this.rdSuíte2.UseVisualStyleBackColor = true;
            // 
            // rdSuíte1
            // 
            this.rdSuíte1.AutoSize = true;
            this.rdSuíte1.Location = new System.Drawing.Point(23, 242);
            this.rdSuíte1.Name = "rdSuíte1";
            this.rdSuíte1.Size = new System.Drawing.Size(68, 17);
            this.rdSuíte1.TabIndex = 16;
            this.rdSuíte1.TabStop = true;
            this.rdSuíte1.Text = "Standard";
            this.rdSuíte1.UseVisualStyleBackColor = true;
            // 
            // lblSuíte
            // 
            this.lblSuíte.AutoSize = true;
            this.lblSuíte.Location = new System.Drawing.Point(136, 207);
            this.lblSuíte.Name = "lblSuíte";
            this.lblSuíte.Size = new System.Drawing.Size(83, 13);
            this.lblSuíte.TabIndex = 15;
            this.lblSuíte.Text = "Escolha a Suíte";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(43, 22);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(279, 29);
            this.lblCheckOut.TabIndex = 14;
            this.lblCheckOut.Text = "Faça seu check-out aqui!";
            // 
            // FormHotelFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPessoas);
            this.Controls.Add(this.lblPessoas);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rdSuíte3);
            this.Controls.Add(this.rdSuíte2);
            this.Controls.Add(this.rdSuíte1);
            this.Controls.Add(this.lblSuíte);
            this.Controls.Add(this.lblCheckOut);
            this.Name = "FormHotelFuncao";
            this.Text = "FormHotelFuncao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPessoas;
        private System.Windows.Forms.Label lblPessoas;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdSuíte3;
        private System.Windows.Forms.RadioButton rdSuíte2;
        private System.Windows.Forms.RadioButton rdSuíte1;
        private System.Windows.Forms.Label lblSuíte;
        private System.Windows.Forms.Label lblCheckOut;
    }
}