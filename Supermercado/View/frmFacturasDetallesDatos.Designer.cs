namespace Supermercado.View
{
    partial class frmFacturasDetallesDatos
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
            this.txtbDescr_pago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbIva = new System.Windows.Forms.TextBox();
            this.txtbCosto_asoc = new System.Windows.Forms.TextBox();
            this.txtbDescr_factura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMedio_de_pago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtbDescr_pago
            // 
            this.txtbDescr_pago.Location = new System.Drawing.Point(31, 258);
            this.txtbDescr_pago.Name = "txtbDescr_pago";
            this.txtbDescr_pago.Size = new System.Drawing.Size(241, 20);
            this.txtbDescr_pago.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Medio de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Descripcion del Pago";
            // 
            // txtbIva
            // 
            this.txtbIva.Location = new System.Drawing.Point(31, 168);
            this.txtbIva.Name = "txtbIva";
            this.txtbIva.Size = new System.Drawing.Size(241, 20);
            this.txtbIva.TabIndex = 51;
            // 
            // txtbCosto_asoc
            // 
            this.txtbCosto_asoc.Location = new System.Drawing.Point(31, 123);
            this.txtbCosto_asoc.Name = "txtbCosto_asoc";
            this.txtbCosto_asoc.Size = new System.Drawing.Size(241, 20);
            this.txtbCosto_asoc.TabIndex = 50;
            // 
            // txtbDescr_factura
            // 
            this.txtbDescr_factura.Location = new System.Drawing.Point(31, 78);
            this.txtbDescr_factura.Name = "txtbDescr_factura";
            this.txtbDescr_factura.Size = new System.Drawing.Size(241, 20);
            this.txtbDescr_factura.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Costo Asociado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descripcion de la Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tipo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(114, 296);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbTipo.Location = new System.Drawing.Point(31, 33);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(241, 21);
            this.cbTipo.TabIndex = 57;
            // 
            // cbMedio_de_pago
            // 
            this.cbMedio_de_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedio_de_pago.FormattingEnabled = true;
            this.cbMedio_de_pago.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA CREDITO",
            "TARJETA DEBITO"});
            this.cbMedio_de_pago.Location = new System.Drawing.Point(31, 210);
            this.cbMedio_de_pago.Name = "cbMedio_de_pago";
            this.cbMedio_de_pago.Size = new System.Drawing.Size(241, 21);
            this.cbMedio_de_pago.TabIndex = 58;
            // 
            // frmFacturasDetallesDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 348);
            this.Controls.Add(this.cbMedio_de_pago);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbDescr_pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbIva);
            this.Controls.Add(this.txtbCosto_asoc);
            this.Controls.Add(this.txtbDescr_factura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmFacturasDetallesDatos";
            this.Text = "frmFacturasDetallesDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDescr_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbIva;
        private System.Windows.Forms.TextBox txtbCosto_asoc;
        private System.Windows.Forms.TextBox txtbDescr_factura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMedio_de_pago;
    }
}