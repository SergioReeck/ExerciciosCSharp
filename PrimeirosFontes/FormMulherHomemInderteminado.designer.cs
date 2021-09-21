
namespace PrimeirosFontes
{
    partial class FormMulherHomemInderteminado
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
            this.rdMulher = new System.Windows.Forms.RadioButton();
            this.rdHomem = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rdIndeterminado = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdMulher
            // 
            this.rdMulher.AutoSize = true;
            this.rdMulher.Location = new System.Drawing.Point(38, 115);
            this.rdMulher.Name = "rdMulher";
            this.rdMulher.Size = new System.Drawing.Size(57, 17);
            this.rdMulher.TabIndex = 1;
            this.rdMulher.TabStop = true;
            this.rdMulher.Text = "Mulher";
            this.rdMulher.UseVisualStyleBackColor = true;
            // 
            // rdHomem
            // 
            this.rdHomem.AutoSize = true;
            this.rdHomem.Location = new System.Drawing.Point(38, 149);
            this.rdHomem.Name = "rdHomem";
            this.rdHomem.Size = new System.Drawing.Size(61, 17);
            this.rdHomem.TabIndex = 3;
            this.rdHomem.TabStop = true;
            this.rdHomem.Text = "Homem";
            this.rdHomem.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(44, 223);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rdIndeterminado
            // 
            this.rdIndeterminado.AutoSize = true;
            this.rdIndeterminado.Location = new System.Drawing.Point(38, 181);
            this.rdIndeterminado.Name = "rdIndeterminado";
            this.rdIndeterminado.Size = new System.Drawing.Size(92, 17);
            this.rdIndeterminado.TabIndex = 5;
            this.rdIndeterminado.TabStop = true;
            this.rdIndeterminado.Text = "Indeterminado";
            this.rdIndeterminado.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(60, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Nome";
            // 
            // FormMulherHomemInderteminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 280);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rdIndeterminado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rdHomem);
            this.Controls.Add(this.rdMulher);
            this.Name = "FormMulherHomemInderteminado";
            this.Text = "FormMulherHomemInderteminado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdMulher;
        private System.Windows.Forms.RadioButton rdHomem;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rdIndeterminado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl1;
    }
}