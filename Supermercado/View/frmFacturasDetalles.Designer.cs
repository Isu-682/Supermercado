namespace Supermercado
{
    partial class frmFacturasDetalles
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
            this.txtbIva = new System.Windows.Forms.TextBox();
            this.txtbCosto_asoc = new System.Windows.Forms.TextBox();
            this.txtbDescr_factura = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbDescr_pago = new System.Windows.Forms.TextBox();
            this.txtbMedio_de_pago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvFacturas_detalles = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbIva
            // 
            this.txtbIva.Location = new System.Drawing.Point(22, 212);
            this.txtbIva.Name = "txtbIva";
            this.txtbIva.Size = new System.Drawing.Size(241, 20);
            this.txtbIva.TabIndex = 37;
            // 
            // txtbCosto_asoc
            // 
            this.txtbCosto_asoc.Location = new System.Drawing.Point(22, 167);
            this.txtbCosto_asoc.Name = "txtbCosto_asoc";
            this.txtbCosto_asoc.Size = new System.Drawing.Size(241, 20);
            this.txtbCosto_asoc.TabIndex = 36;
            // 
            // txtbDescr_factura
            // 
            this.txtbDescr_factura.Location = new System.Drawing.Point(22, 122);
            this.txtbDescr_factura.Name = "txtbDescr_factura";
            this.txtbDescr_factura.Size = new System.Drawing.Size(241, 20);
            this.txtbDescr_factura.TabIndex = 35;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(22, 77);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(241, 20);
            this.txtbCodigo.TabIndex = 34;
            // 
            // txtbTipo
            // 
            this.txtbTipo.Location = new System.Drawing.Point(22, 32);
            this.txtbTipo.Name = "txtbTipo";
            this.txtbTipo.Size = new System.Drawing.Size(241, 20);
            this.txtbTipo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo Asociado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion de la Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo";
            // 
            // txtbDescr_pago
            // 
            this.txtbDescr_pago.Location = new System.Drawing.Point(22, 302);
            this.txtbDescr_pago.Name = "txtbDescr_pago";
            this.txtbDescr_pago.Size = new System.Drawing.Size(241, 20);
            this.txtbDescr_pago.TabIndex = 41;
            // 
            // txtbMedio_de_pago
            // 
            this.txtbMedio_de_pago.Location = new System.Drawing.Point(22, 257);
            this.txtbMedio_de_pago.Name = "txtbMedio_de_pago";
            this.txtbMedio_de_pago.Size = new System.Drawing.Size(241, 20);
            this.txtbMedio_de_pago.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Medio de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Descripcion del Pago";
            // 
            // dgvFacturas_detalles
            // 
            this.dgvFacturas_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas_detalles.Location = new System.Drawing.Point(285, 40);
            this.dgvFacturas_detalles.Name = "dgvFacturas_detalles";
            this.dgvFacturas_detalles.Size = new System.Drawing.Size(490, 263);
            this.dgvFacturas_detalles.TabIndex = 49;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 315);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmFacturasDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvFacturas_detalles);
            this.Controls.Add(this.txtbDescr_pago);
            this.Controls.Add(this.txtbMedio_de_pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbIva);
            this.Controls.Add(this.txtbCosto_asoc);
            this.Controls.Add(this.txtbDescr_factura);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.txtbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmFacturasDetalles";
            this.Text = "Facturas Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIva;
        private System.Windows.Forms.TextBox txtbCosto_asoc;
        private System.Windows.Forms.TextBox txtbDescr_factura;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbDescr_pago;
        private System.Windows.Forms.TextBox txtbMedio_de_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvFacturas_detalles;
        private System.Windows.Forms.Button btnCerrar;
    }
}