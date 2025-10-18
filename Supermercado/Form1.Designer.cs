namespace Supermercado
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnComprasCli = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnVentasPro = new System.Windows.Forms.Button();
            this.btnFacturasDet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(25, 13);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(290, 23);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnComprasCli
            // 
            this.btnComprasCli.Location = new System.Drawing.Point(25, 63);
            this.btnComprasCli.Name = "btnComprasCli";
            this.btnComprasCli.Size = new System.Drawing.Size(290, 23);
            this.btnComprasCli.TabIndex = 1;
            this.btnComprasCli.Text = "COMPRAS CLIENTES";
            this.btnComprasCli.UseVisualStyleBackColor = true;
            this.btnComprasCli.Click += new System.EventHandler(this.btnComprasCli_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(25, 113);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(290, 23);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(25, 163);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(290, 23);
            this.btnFacturas.TabIndex = 3;
            this.btnFacturas.Text = "FACTURAS";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(25, 263);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(290, 23);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(25, 313);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(290, 23);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(25, 363);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(290, 23);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnVentasPro
            // 
            this.btnVentasPro.Location = new System.Drawing.Point(25, 413);
            this.btnVentasPro.Name = "btnVentasPro";
            this.btnVentasPro.Size = new System.Drawing.Size(290, 23);
            this.btnVentasPro.TabIndex = 7;
            this.btnVentasPro.Text = "VENTAS PRODUCTOS";
            this.btnVentasPro.UseVisualStyleBackColor = true;
            this.btnVentasPro.Click += new System.EventHandler(this.btnVentasPro_Click);
            // 
            // btnFacturasDet
            // 
            this.btnFacturasDet.Location = new System.Drawing.Point(25, 213);
            this.btnFacturasDet.Name = "btnFacturasDet";
            this.btnFacturasDet.Size = new System.Drawing.Size(290, 23);
            this.btnFacturasDet.TabIndex = 8;
            this.btnFacturasDet.Text = "FACTURAS DETALLES";
            this.btnFacturasDet.UseVisualStyleBackColor = true;
            this.btnFacturasDet.Click += new System.EventHandler(this.btnFacturasDet_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 449);
            this.Controls.Add(this.btnFacturasDet);
            this.Controls.Add(this.btnVentasPro);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnComprasCli);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnComprasCli;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnVentasPro;
        private System.Windows.Forms.Button btnFacturasDet;
    }
}

