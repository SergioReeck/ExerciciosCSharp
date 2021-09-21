
namespace PrimeirosFontes
{
    partial class FormCadastroAluno
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
            this.txtCadastrarAlunos = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCadastroAlunos = new System.Windows.Forms.Label();
            this.lblPesquisarAlunos = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisarAlunos = new System.Windows.Forms.TextBox();
            this.gpCadastroAlunos = new System.Windows.Forms.GroupBox();
            this.gpPesquisarAlunos = new System.Windows.Forms.GroupBox();
            this.gpListagem = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gpCadastroAlunos.SuspendLayout();
            this.gpPesquisarAlunos.SuspendLayout();
            this.gpListagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCadastrarAlunos
            // 
            this.txtCadastrarAlunos.Location = new System.Drawing.Point(75, 68);
            this.txtCadastrarAlunos.Name = "txtCadastrarAlunos";
            this.txtCadastrarAlunos.Size = new System.Drawing.Size(100, 20);
            this.txtCadastrarAlunos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(88, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastroAlunos
            // 
            this.lblCadastroAlunos.AutoSize = true;
            this.lblCadastroAlunos.Location = new System.Drawing.Point(105, 35);
            this.lblCadastroAlunos.Name = "lblCadastroAlunos";
            this.lblCadastroAlunos.Size = new System.Drawing.Size(35, 13);
            this.lblCadastroAlunos.TabIndex = 2;
            this.lblCadastroAlunos.Text = "Nome";
            // 
            // lblPesquisarAlunos
            // 
            this.lblPesquisarAlunos.AutoSize = true;
            this.lblPesquisarAlunos.Location = new System.Drawing.Point(105, 38);
            this.lblPesquisarAlunos.Name = "lblPesquisarAlunos";
            this.lblPesquisarAlunos.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisarAlunos.TabIndex = 5;
            this.lblPesquisarAlunos.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(89, 119);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisarAlunos
            // 
            this.txtPesquisarAlunos.Location = new System.Drawing.Point(75, 71);
            this.txtPesquisarAlunos.Name = "txtPesquisarAlunos";
            this.txtPesquisarAlunos.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisarAlunos.TabIndex = 3;
            // 
            // gpCadastroAlunos
            // 
            this.gpCadastroAlunos.Controls.Add(this.txtCadastrarAlunos);
            this.gpCadastroAlunos.Controls.Add(this.btnCadastrar);
            this.gpCadastroAlunos.Controls.Add(this.lblCadastroAlunos);
            this.gpCadastroAlunos.Location = new System.Drawing.Point(12, 34);
            this.gpCadastroAlunos.Name = "gpCadastroAlunos";
            this.gpCadastroAlunos.Size = new System.Drawing.Size(249, 165);
            this.gpCadastroAlunos.TabIndex = 6;
            this.gpCadastroAlunos.TabStop = false;
            this.gpCadastroAlunos.Text = "Cadastro de Alunos";
            // 
            // gpPesquisarAlunos
            // 
            this.gpPesquisarAlunos.Controls.Add(this.lblPesquisarAlunos);
            this.gpPesquisarAlunos.Controls.Add(this.txtPesquisarAlunos);
            this.gpPesquisarAlunos.Controls.Add(this.btnPesquisar);
            this.gpPesquisarAlunos.Location = new System.Drawing.Point(296, 34);
            this.gpPesquisarAlunos.Name = "gpPesquisarAlunos";
            this.gpPesquisarAlunos.Size = new System.Drawing.Size(245, 165);
            this.gpPesquisarAlunos.TabIndex = 7;
            this.gpPesquisarAlunos.TabStop = false;
            this.gpPesquisarAlunos.Text = "Pesquisa de Alunos";
            // 
            // gpListagem
            // 
            this.gpListagem.Controls.Add(this.btnListar);
            this.gpListagem.Location = new System.Drawing.Point(573, 34);
            this.gpListagem.Name = "gpListagem";
            this.gpListagem.Size = new System.Drawing.Size(245, 165);
            this.gpListagem.TabIndex = 8;
            this.gpListagem.TabStop = false;
            this.gpListagem.Text = "Listagem";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(87, 71);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Alunos";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 229);
            this.Controls.Add(this.gpListagem);
            this.Controls.Add(this.gpPesquisarAlunos);
            this.Controls.Add(this.gpCadastroAlunos);
            this.Name = "FormCadastroAluno";
            this.Text = "FormVetores";
            this.gpCadastroAlunos.ResumeLayout(false);
            this.gpCadastroAlunos.PerformLayout();
            this.gpPesquisarAlunos.ResumeLayout(false);
            this.gpPesquisarAlunos.PerformLayout();
            this.gpListagem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadastrarAlunos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastroAlunos;
        private System.Windows.Forms.Label lblPesquisarAlunos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisarAlunos;
        private System.Windows.Forms.GroupBox gpCadastroAlunos;
        private System.Windows.Forms.GroupBox gpPesquisarAlunos;
        private System.Windows.Forms.GroupBox gpListagem;
        private System.Windows.Forms.Button btnListar;
    }
}