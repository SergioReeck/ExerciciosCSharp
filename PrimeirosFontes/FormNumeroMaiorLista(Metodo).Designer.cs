
namespace PrimeirosFontes
{
    partial class FormNumeroMaiorListaMetodo
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAddNumero = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(25, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAddNumero
            // 
            this.btnAddNumero.Location = new System.Drawing.Point(25, 12);
            this.btnAddNumero.Name = "btnAddNumero";
            this.btnAddNumero.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumero.TabIndex = 5;
            this.btnAddNumero.Text = "AddNumero";
            this.btnAddNumero.UseVisualStyleBackColor = true;
            this.btnAddNumero.Click += new System.EventHandler(this.btnAddNumero_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // FormNumeroMaiorListaMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 103);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddNumero);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "FormNumeroMaiorListaMetodo";
            this.Text = "FormNumeroMaiorListaMetodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAddNumero;
        private System.Windows.Forms.TextBox textBox1;
    }
}