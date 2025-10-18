namespace Supermercado
{
    partial class frmVentasProductos
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
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVentas_productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Location = new System.Drawing.Point(272, 39);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(241, 20);
            this.txtbCantidad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad";
            // 
            // dgvVentas_productos
            // 
            this.dgvVentas_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas_productos.Location = new System.Drawing.Point(50, 66);
            this.dgvVentas_productos.Name = "dgvVentas_productos";
            this.dgvVentas_productos.Size = new System.Drawing.Size(702, 248);
            this.dgvVentas_productos.TabIndex = 14;
            // 
            // frmVentasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.dgvVentas_productos);
            this.Controls.Add(this.txtbCantidad);
            this.Controls.Add(this.label2);
            this.Name = "frmVentasProductos";
            this.Text = "Ventas Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVentas_productos;
    }
}