
namespace PrimeirosFontes
{
    partial class FormNomeExiste_Metodo_
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
            this.gpPesquisar = new System.Windows.Forms.GroupBox();
            this.lblPesquisarNome = new System.Windows.Forms.Label();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpAdicionar = new System.Windows.Forms.GroupBox();
            this.txtAdicionarNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblAdicionarNome = new System.Windows.Forms.Label();
            this.gpPesquisar.SuspendLayout();
            this.gpAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPesquisar
            // 
            this.gpPesquisar.Controls.Add(this.lblPesquisarNome);
            this.gpPesquisar.Controls.Add(this.txtPesquisarNome);
            this.gpPesquisar.Controls.Add(this.btnPesquisar);
            this.gpPesquisar.Location = new System.Drawing.Point(141, 12);
            this.gpPesquisar.Name = "gpPesquisar";
            this.gpPesquisar.Size = new System.Drawing.Size(115, 121);
            this.gpPesquisar.TabIndex = 10;
            this.gpPesquisar.TabStop = false;
            this.gpPesquisar.Text = "Pesquisar";
            // 
            // lblPesquisarNome
            // 
            this.lblPesquisarNome.AutoSize = true;
            this.lblPesquisarNome.Location = new System.Drawing.Point(6, 46);
            this.lblPesquisarNome.Name = "lblPesquisarNome";
            this.lblPesquisarNome.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisarNome.TabIndex = 5;
            this.lblPesquisarNome.Text = "Nome";
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(6, 62);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarNome.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(9, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gpAdicionar
            // 
            this.gpAdicionar.Controls.Add(this.txtAdicionarNome);
            this.gpAdicionar.Controls.Add(this.btnAdicionar);
            this.gpAdicionar.Controls.Add(this.lblAdicionarNome);
            this.gpAdicionar.Location = new System.Drawing.Point(13, 12);
            this.gpAdicionar.Name = "gpAdicionar";
            this.gpAdicionar.Size = new System.Drawing.Size(114, 121);
            this.gpAdicionar.TabIndex = 9;
            this.gpAdicionar.TabStop = false;
            this.gpAdicionar.Text = "Adicionar";
            // 
            // txtAdicionarNome
            // 
            this.txtAdicionarNome.Location = new System.Drawing.Point(6, 62);
            this.txtAdicionarNome.Name = "txtAdicionarNome";
            this.txtAdicionarNome.Size = new System.Drawing.Size(100, 20);
            this.txtAdicionarNome.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 88);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblAdicionarNome
            // 
            this.lblAdicionarNome.AutoSize = true;
            this.lblAdicionarNome.Location = new System.Drawing.Point(6, 46);
            this.lblAdicionarNome.Name = "lblAdicionarNome";
            this.lblAdicionarNome.Size = new System.Drawing.Size(35, 13);
            this.lblAdicionarNome.TabIndex = 2;
            this.lblAdicionarNome.Text = "Nome";
            // 
            // FormNomeExiste_Metodo_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 146);
            this.Controls.Add(this.gpPesquisar);
            this.Controls.Add(this.gpAdicionar);
            this.Name = "FormNomeExiste_Metodo_";
            this.Text = "FormNomeExiste_Metodo_";
            this.gpPesquisar.ResumeLayout(false);
            this.gpPesquisar.PerformLayout();
            this.gpAdicionar.ResumeLayout(false);
            this.gpAdicionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPesquisar;
        private System.Windows.Forms.Label lblPesquisarNome;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gpAdicionar;
        private System.Windows.Forms.TextBox txtAdicionarNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblAdicionarNome;
    }
}