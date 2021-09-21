
namespace CâmadaInicial
{
    partial class FormDezNumeros1cs
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
            this.txtNumerosInformados = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblInformeNumeros = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumerosInformados
            // 
            this.txtNumerosInformados.Location = new System.Drawing.Point(39, 66);
            this.txtNumerosInformados.Name = "txtNumerosInformados";
            this.txtNumerosInformados.Size = new System.Drawing.Size(100, 20);
            this.txtNumerosInformados.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(52, 108);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblInformeNumeros
            // 
            this.lblInformeNumeros.AutoSize = true;
            this.lblInformeNumeros.Location = new System.Drawing.Point(40, 33);
            this.lblInformeNumeros.Name = "lblInformeNumeros";
            this.lblInformeNumeros.Size = new System.Drawing.Size(101, 13);
            this.lblInformeNumeros.TabIndex = 2;
            this.lblInformeNumeros.Text = "Informe os Números";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(52, 167);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // FormDezNumeros1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 226);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNumerosInformados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblInformeNumeros);
            this.Name = "FormDezNumeros1cs";
            this.Text = "FormDezNumeros1cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumerosInformados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblInformeNumeros;
        private System.Windows.Forms.Button btnMostrar;
    }
}