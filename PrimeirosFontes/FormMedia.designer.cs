
namespace PrimeirosFontes
{
    partial class FormMedia
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
            this.txtNota1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGerarMédia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNota1
            // 
            this.txtNota1.AutoSize = true;
            this.txtNota1.Location = new System.Drawing.Point(92, 24);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(39, 13);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.Text = "Nota 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtNota2
            // 
            this.txtNota2.AutoSize = true;
            this.txtNota2.Location = new System.Drawing.Point(92, 83);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(39, 13);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.Text = "Nota 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtNota3
            // 
            this.txtNota3.AutoSize = true;
            this.txtNota3.Location = new System.Drawing.Point(92, 146);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(39, 13);
            this.txtNota3.TabIndex = 4;
            this.txtNota3.Text = "Nota 3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnGerarMédia
            // 
            this.btnGerarMédia.Location = new System.Drawing.Point(77, 216);
            this.btnGerarMédia.Name = "btnGerarMédia";
            this.btnGerarMédia.Size = new System.Drawing.Size(75, 23);
            this.btnGerarMédia.TabIndex = 6;
            this.btnGerarMédia.Text = "Gerar Média";
            this.btnGerarMédia.UseVisualStyleBackColor = true;
            this.btnGerarMédia.Click += new System.EventHandler(this.btnGerarMédia_Click);
            // 
            // FormMédia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 279);
            this.Controls.Add(this.btnGerarMédia);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNota1);
            this.Name = "FormMédia";
            this.Text = "FormMédia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNota1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtNota2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtNota3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGerarMédia;
    }
}