
namespace PrimeirosFontes
{
    partial class FormCompraComDesconto
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
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.rbAVista = new System.Windows.Forms.RadioButton();
            this.rbParcelado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(68, 91);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(54, 51);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 1;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(70, 21);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(70, 13);
            this.lblValorCompra.TabIndex = 2;
            this.lblValorCompra.Text = "Valor Compra";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(86, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(54, 205);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // rbAVista
            // 
            this.rbAVista.AutoSize = true;
            this.rbAVista.Location = new System.Drawing.Point(23, 144);
            this.rbAVista.Name = "rbAVista";
            this.rbAVista.Size = new System.Drawing.Size(58, 17);
            this.rbAVista.TabIndex = 5;
            this.rbAVista.TabStop = true;
            this.rbAVista.Text = "À Vista";
            this.rbAVista.UseVisualStyleBackColor = true;
            // 
            // rbParcelado
            // 
            this.rbParcelado.AutoSize = true;
            this.rbParcelado.Location = new System.Drawing.Point(108, 144);
            this.rbParcelado.Name = "rbParcelado";
            this.rbParcelado.Size = new System.Drawing.Size(73, 17);
            this.rbParcelado.TabIndex = 6;
            this.rbParcelado.TabStop = true;
            this.rbParcelado.Text = "Parcelado";
            this.rbParcelado.UseVisualStyleBackColor = true;
            // 
            // FormCompraComDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 250);
            this.Controls.Add(this.rbParcelado);
            this.Controls.Add(this.rbAVista);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormCompraComDesconto";
            this.Text = "FormCompraComDesconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rbAVista;
        private System.Windows.Forms.RadioButton rbParcelado;
    }
}