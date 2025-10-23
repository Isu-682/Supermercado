namespace Supermercado
{
    partial class frmProveedores
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
            this.components = new System.ComponentModel.Container();
            this.txtbEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTipo_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mtxtbNro_tel_sec = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbNro_tel_princ = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbEmpresa
            // 
            this.txtbEmpresa.Location = new System.Drawing.Point(12, 64);
            this.txtbEmpresa.Name = "txtbEmpresa";
            this.txtbEmpresa.Size = new System.Drawing.Size(241, 20);
            this.txtbEmpresa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empresa";
            // 
            // txtbTipo_producto
            // 
            this.txtbTipo_producto.Location = new System.Drawing.Point(12, 113);
            this.txtbTipo_producto.Name = "txtbTipo_producto";
            this.txtbTipo_producto.Size = new System.Drawing.Size(241, 20);
            this.txtbTipo_producto.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo de Producto";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(12, 162);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(241, 20);
            this.txtbDireccion.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Direccion";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(12, 309);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(241, 20);
            this.txtbEmail.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Email";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.ContextMenuStrip = this.cmsMenu;
            this.dgvProveedores.Location = new System.Drawing.Point(301, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(477, 342);
            this.dgvProveedores.TabIndex = 47;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 366);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(88, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mtxtbNro_tel_sec
            // 
            this.mtxtbNro_tel_sec.Location = new System.Drawing.Point(12, 265);
            this.mtxtbNro_tel_sec.Mask = "000-000-0000";
            this.mtxtbNro_tel_sec.Name = "mtxtbNro_tel_sec";
            this.mtxtbNro_tel_sec.Size = new System.Drawing.Size(153, 20);
            this.mtxtbNro_tel_sec.TabIndex = 53;
            // 
            // mtxtbNro_tel_princ
            // 
            this.mtxtbNro_tel_princ.Location = new System.Drawing.Point(12, 212);
            this.mtxtbNro_tel_princ.Mask = "000-000-0000";
            this.mtxtbNro_tel_princ.Name = "mtxtbNro_tel_princ";
            this.mtxtbNro_tel_princ.Size = new System.Drawing.Size(151, 20);
            this.mtxtbNro_tel_princ.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numero Telefonico Secundario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Numero Telefonico Principal";
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditar,
            this.toolStripEliminar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(180, 22);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(180, 22);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.mtxtbNro_tel_sec);
            this.Controls.Add(this.mtxtbNro_tel_princ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbTipo_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbEmpresa);
            this.Controls.Add(this.label2);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Activated += new System.EventHandler(this.frmProveedores_Activated);
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTipo_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox mtxtbNro_tel_sec;
        private System.Windows.Forms.MaskedTextBox mtxtbNro_tel_princ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
    }
}