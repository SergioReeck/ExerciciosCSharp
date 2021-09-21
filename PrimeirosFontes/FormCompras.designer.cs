
namespace FormExercícioCasa1
{
    partial class FormCompras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.cbTV = new System.Windows.Forms.ComboBox();
            this.cbCelular = new System.Windows.Forms.ComboBox();
            this.cbPS5 = new System.Windows.Forms.ComboBox();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.chkCelular = new System.Windows.Forms.CheckBox();
            this.chkPS5 = new System.Windows.Forms.CheckBox();
            this.rbÀvista = new System.Windows.Forms.RadioButton();
            this.rbParcelado = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblQtde1 = new System.Windows.Forms.Label();
            this.lblQtde2 = new System.Windows.Forms.Label();
            this.lblQtde3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCompras.Location = new System.Drawing.Point(184, 29);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(91, 25);
            this.lblCompras.TabIndex = 0;
            this.lblCompras.Text = "Compras";
            this.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(134, 232);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(203, 25);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Forma de Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTV
            // 
            this.cbTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTV.Enabled = false;
            this.cbTV.FormattingEnabled = true;
            this.cbTV.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTV.Location = new System.Drawing.Point(244, 85);
            this.cbTV.Name = "cbTV";
            this.cbTV.Size = new System.Drawing.Size(121, 23);
            this.cbTV.TabIndex = 2;
            this.cbTV.SelectedIndexChanged += new System.EventHandler(this.cbTV_SelectedIndexChanged);
            // 
            // cbCelular
            // 
            this.cbCelular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCelular.Enabled = false;
            this.cbCelular.FormattingEnabled = true;
            this.cbCelular.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCelular.Location = new System.Drawing.Point(244, 133);
            this.cbCelular.Name = "cbCelular";
            this.cbCelular.Size = new System.Drawing.Size(121, 23);
            this.cbCelular.TabIndex = 3;
            this.cbCelular.SelectedIndexChanged += new System.EventHandler(this.cbCelular_SelectedIndexChanged);
            // 
            // cbPS5
            // 
            this.cbPS5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPS5.Enabled = false;
            this.cbPS5.FormattingEnabled = true;
            this.cbPS5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPS5.Location = new System.Drawing.Point(244, 179);
            this.cbPS5.Name = "cbPS5";
            this.cbPS5.Size = new System.Drawing.Size(121, 23);
            this.cbPS5.TabIndex = 4;
            this.cbPS5.SelectedIndexChanged += new System.EventHandler(this.cbPS5_SelectedIndexChanged);
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.Location = new System.Drawing.Point(131, 87);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(39, 19);
            this.chkTV.TabIndex = 5;
            this.chkTV.Text = "TV";
            this.chkTV.UseVisualStyleBackColor = true;
            this.chkTV.CheckedChanged += new System.EventHandler(this.chkTV_CheckedChanged);
            // 
            // chkCelular
            // 
            this.chkCelular.AutoSize = true;
            this.chkCelular.Location = new System.Drawing.Point(131, 135);
            this.chkCelular.Name = "chkCelular";
            this.chkCelular.Size = new System.Drawing.Size(63, 19);
            this.chkCelular.TabIndex = 6;
            this.chkCelular.Text = "Celular";
            this.chkCelular.UseVisualStyleBackColor = true;
            this.chkCelular.CheckedChanged += new System.EventHandler(this.chkCelular_CheckedChanged);
            // 
            // chkPS5
            // 
            this.chkPS5.AutoSize = true;
            this.chkPS5.Location = new System.Drawing.Point(131, 182);
            this.chkPS5.Name = "chkPS5";
            this.chkPS5.Size = new System.Drawing.Size(45, 19);
            this.chkPS5.TabIndex = 7;
            this.chkPS5.Text = "PS5";
            this.chkPS5.UseVisualStyleBackColor = true;
            this.chkPS5.CheckedChanged += new System.EventHandler(this.chkPS5_CheckedChanged);
            // 
            // rbÀvista
            // 
            this.rbÀvista.AutoSize = true;
            this.rbÀvista.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbÀvista.Enabled = false;
            this.rbÀvista.Location = new System.Drawing.Point(123, 279);
            this.rbÀvista.Name = "rbÀvista";
            this.rbÀvista.Size = new System.Drawing.Size(61, 19);
            this.rbÀvista.TabIndex = 8;
            this.rbÀvista.Text = "À Vista";
            this.rbÀvista.UseVisualStyleBackColor = true;
            this.rbÀvista.CheckedChanged += new System.EventHandler(this.rbÀvista_CheckedChanged);
            // 
            // rbParcelado
            // 
            this.rbParcelado.AutoSize = true;
            this.rbParcelado.Enabled = false;
            this.rbParcelado.Location = new System.Drawing.Point(266, 279);
            this.rbParcelado.Name = "rbParcelado";
            this.rbParcelado.Size = new System.Drawing.Size(77, 19);
            this.rbParcelado.TabIndex = 9;
            this.rbParcelado.Text = "Parcelado";
            this.rbParcelado.UseVisualStyleBackColor = true;
            this.rbParcelado.CheckedChanged += new System.EventHandler(this.rbParcelado_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(101, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Valor Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal2
            // 
            this.lblTotal2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal2.ForeColor = System.Drawing.Color.Red;
            this.lblTotal2.Location = new System.Drawing.Point(65, 411);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(173, 25);
            this.lblTotal2.TabIndex = 11;
            this.lblTotal2.Text = "R$ 0,00";
            this.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(196, 317);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblQtde1
            // 
            this.lblQtde1.AutoSize = true;
            this.lblQtde1.Location = new System.Drawing.Point(202, 88);
            this.lblQtde1.Name = "lblQtde1";
            this.lblQtde1.Size = new System.Drawing.Size(36, 15);
            this.lblQtde1.TabIndex = 13;
            this.lblQtde1.Text = "Qtde.";
            // 
            // lblQtde2
            // 
            this.lblQtde2.AutoSize = true;
            this.lblQtde2.Location = new System.Drawing.Point(202, 138);
            this.lblQtde2.Name = "lblQtde2";
            this.lblQtde2.Size = new System.Drawing.Size(36, 15);
            this.lblQtde2.TabIndex = 14;
            this.lblQtde2.Text = "Qtde.";
            // 
            // lblQtde3
            // 
            this.lblQtde3.AutoSize = true;
            this.lblQtde3.Location = new System.Drawing.Point(202, 183);
            this.lblQtde3.Name = "lblQtde3";
            this.lblQtde3.Size = new System.Drawing.Size(36, 15);
            this.lblQtde3.TabIndex = 15;
            this.lblQtde3.Text = "Qtde.";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Red;
            this.btnConfirmar.Location = new System.Drawing.Point(266, 395);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 31);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblQtde3);
            this.Controls.Add(this.lblQtde2);
            this.Controls.Add(this.lblQtde1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.rbParcelado);
            this.Controls.Add(this.rbÀvista);
            this.Controls.Add(this.chkPS5);
            this.Controls.Add(this.chkCelular);
            this.Controls.Add(this.chkTV);
            this.Controls.Add(this.cbPS5);
            this.Controls.Add(this.cbCelular);
            this.Controls.Add(this.cbTV);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblCompras);
            this.Name = "FormCompras";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cbTV;
        private System.Windows.Forms.ComboBox cbCelular;
        private System.Windows.Forms.ComboBox cbPS5;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkCelular;
        private System.Windows.Forms.CheckBox chkPS5;
        private System.Windows.Forms.RadioButton rbÀvista;
        private System.Windows.Forms.RadioButton rbParcelado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblQtde1;
        private System.Windows.Forms.Label lblQtde2;
        private System.Windows.Forms.Label lblQtde3;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

