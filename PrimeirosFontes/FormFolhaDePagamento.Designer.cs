
namespace PrimeirosFontes
{
    partial class FormFolhaDePagamento
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
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.lblSalário = new System.Windows.Forms.Label();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(264, 33);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(97, 13);
            this.lblHorasTrabalhadas.TabIndex = 5;
            this.lblHorasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(261, 55);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(183, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(96, 33);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(68, 13);
            this.lblValorHora.TabIndex = 2;
            this.lblValorHora.Text = "Valor p/Hora";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(79, 55);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 20);
            this.txtValorHora.TabIndex = 0;
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Location = new System.Drawing.Point(201, 98);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(39, 13);
            this.lblSalário.TabIndex = 9;
            this.lblSalário.Text = "Salário";
            // 
            // txtSalário
            // 
            this.txtSalário.Location = new System.Drawing.Point(169, 119);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(100, 20);
            this.txtSalário.TabIndex = 8;
            // 
            // FormFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 205);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.txtSalário);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorHora);
            this.Name = "FormFolhaDePagamento";
            this.Text = "FormFolhaDePagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.TextBox txtSalário;
    }
}