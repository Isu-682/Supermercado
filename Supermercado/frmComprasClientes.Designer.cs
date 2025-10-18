namespace Supermercado
{
    partial class frmComprasClientes
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
            this.dgvCompras_Clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras_Clientes
            // 
            this.dgvCompras_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras_Clientes.Location = new System.Drawing.Point(45, 41);
            this.dgvCompras_Clientes.Name = "dgvCompras_Clientes";
            this.dgvCompras_Clientes.Size = new System.Drawing.Size(702, 248);
            this.dgvCompras_Clientes.TabIndex = 9;
            // 
            // frmComprasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.dgvCompras_Clientes);
            this.Name = "frmComprasClientes";
            this.Text = "Compras Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras_Clientes;
    }
}