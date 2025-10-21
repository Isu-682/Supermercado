namespace Supermercado
{
    partial class frmFacturas
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
            this.txtbImporte_total = new System.Windows.Forms.TextBox();
            this.txtbHora = new System.Windows.Forms.TextBox();
            this.txtbFecha = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbImporte_total
            // 
            this.txtbImporte_total.Location = new System.Drawing.Point(23, 244);
            this.txtbImporte_total.Name = "txtbImporte_total";
            this.txtbImporte_total.Size = new System.Drawing.Size(241, 20);
            this.txtbImporte_total.TabIndex = 27;
            // 
            // txtbHora
            // 
            this.txtbHora.Location = new System.Drawing.Point(23, 199);
            this.txtbHora.Name = "txtbHora";
            this.txtbHora.Size = new System.Drawing.Size(241, 20);
            this.txtbHora.TabIndex = 26;
            // 
            // txtbFecha
            // 
            this.txtbFecha.Location = new System.Drawing.Point(23, 154);
            this.txtbFecha.Name = "txtbFecha";
            this.txtbFecha.Size = new System.Drawing.Size(241, 20);
            this.txtbFecha.TabIndex = 25;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(23, 109);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(241, 20);
            this.txtbCodigo.TabIndex = 24;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(23, 64);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(241, 20);
            this.txtbNumero.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Importe Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha (YY/MM/DD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numero";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.ContextMenuStrip = this.cmsMenu;
            this.dgvFacturas.Location = new System.Drawing.Point(298, 21);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(490, 275);
            this.dgvFacturas.TabIndex = 48;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 306);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eToolStripMenuItem.Text = "Eliminar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(103, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.txtbImporte_total);
            this.Controls.Add(this.txtbHora);
            this.Controls.Add(this.txtbFecha);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbImporte_total;
        private System.Windows.Forms.TextBox txtbHora;
        private System.Windows.Forms.TextBox txtbFecha;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregar;
    }
}