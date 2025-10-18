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
            this.txtbEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTipo_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbNro_tel_sec = new System.Windows.Forms.TextBox();
            this.txtbNro_tel_princ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
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
            // txtbNro_tel_sec
            // 
            this.txtbNro_tel_sec.Location = new System.Drawing.Point(12, 260);
            this.txtbNro_tel_sec.Name = "txtbNro_tel_sec";
            this.txtbNro_tel_sec.Size = new System.Drawing.Size(241, 20);
            this.txtbNro_tel_sec.TabIndex = 44;
            // 
            // txtbNro_tel_princ
            // 
            this.txtbNro_tel_princ.Location = new System.Drawing.Point(12, 211);
            this.txtbNro_tel_princ.Name = "txtbNro_tel_princ";
            this.txtbNro_tel_princ.Size = new System.Drawing.Size(241, 20);
            this.txtbNro_tel_princ.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Numero Telefonico Secundario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Numero Telefonico Principal";
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
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(301, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(477, 368);
            this.dgvProveedores.TabIndex = 47;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbNro_tel_sec);
            this.Controls.Add(this.txtbNro_tel_princ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbTipo_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbEmpresa);
            this.Controls.Add(this.label2);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
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
        private System.Windows.Forms.TextBox txtbNro_tel_sec;
        private System.Windows.Forms.TextBox txtbNro_tel_princ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}