namespace Supermercado
{
    partial class frmEmpleados
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
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbNro_tel_sec = new System.Windows.Forms.TextBox();
            this.txtbNro_tel_princ = new System.Windows.Forms.TextBox();
            this.txtbNro_doc = new System.Windows.Forms.TextBox();
            this.txtbTipo_doc = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbFecha_nac = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbCuil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbCargo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbSalario_anual = new System.Windows.Forms.TextBox();
            this.txtbFecha_ingreso = new System.Windows.Forms.TextBox();
            this.txtbAntiguedad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(12, 121);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(241, 20);
            this.txtbEmail.TabIndex = 29;
            // 
            // txtbNro_tel_sec
            // 
            this.txtbNro_tel_sec.Location = new System.Drawing.Point(536, 121);
            this.txtbNro_tel_sec.Name = "txtbNro_tel_sec";
            this.txtbNro_tel_sec.Size = new System.Drawing.Size(241, 20);
            this.txtbNro_tel_sec.TabIndex = 28;
            // 
            // txtbNro_tel_princ
            // 
            this.txtbNro_tel_princ.Location = new System.Drawing.Point(536, 71);
            this.txtbNro_tel_princ.Name = "txtbNro_tel_princ";
            this.txtbNro_tel_princ.Size = new System.Drawing.Size(241, 20);
            this.txtbNro_tel_princ.TabIndex = 27;
            // 
            // txtbNro_doc
            // 
            this.txtbNro_doc.Location = new System.Drawing.Point(279, 167);
            this.txtbNro_doc.Name = "txtbNro_doc";
            this.txtbNro_doc.Size = new System.Drawing.Size(241, 20);
            this.txtbNro_doc.TabIndex = 26;
            // 
            // txtbTipo_doc
            // 
            this.txtbTipo_doc.Location = new System.Drawing.Point(12, 167);
            this.txtbTipo_doc.Name = "txtbTipo_doc";
            this.txtbTipo_doc.Size = new System.Drawing.Size(241, 20);
            this.txtbTipo_doc.TabIndex = 25;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(279, 21);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(241, 20);
            this.txtbApellido.TabIndex = 24;
            this.txtbApellido.TextChanged += new System.EventHandler(this.txtbApellido_TextChanged);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(12, 21);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(241, 20);
            this.txtbNombre.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Numero Telefonico Secundario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numero del Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Numero Telefonico Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // txtbFecha_nac
            // 
            this.txtbFecha_nac.Location = new System.Drawing.Point(12, 71);
            this.txtbFecha_nac.Name = "txtbFecha_nac";
            this.txtbFecha_nac.Size = new System.Drawing.Size(241, 20);
            this.txtbFecha_nac.TabIndex = 34;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(536, 21);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(241, 20);
            this.txtbEdad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha de Nacimiento (YY/MM/DD)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Edad";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(279, 71);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(241, 20);
            this.txtbDireccion.TabIndex = 38;
            // 
            // txtbCuil
            // 
            this.txtbCuil.Location = new System.Drawing.Point(279, 121);
            this.txtbCuil.Name = "txtbCuil";
            this.txtbCuil.Size = new System.Drawing.Size(241, 20);
            this.txtbCuil.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cuil";
            // 
            // txtbCargo
            // 
            this.txtbCargo.Location = new System.Drawing.Point(536, 167);
            this.txtbCargo.Name = "txtbCargo";
            this.txtbCargo.Size = new System.Drawing.Size(241, 20);
            this.txtbCargo.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Cargo";
            // 
            // txtbSalario_anual
            // 
            this.txtbSalario_anual.Location = new System.Drawing.Point(536, 215);
            this.txtbSalario_anual.Name = "txtbSalario_anual";
            this.txtbSalario_anual.Size = new System.Drawing.Size(241, 20);
            this.txtbSalario_anual.TabIndex = 44;
            // 
            // txtbFecha_ingreso
            // 
            this.txtbFecha_ingreso.Location = new System.Drawing.Point(279, 215);
            this.txtbFecha_ingreso.Name = "txtbFecha_ingreso";
            this.txtbFecha_ingreso.Size = new System.Drawing.Size(241, 20);
            this.txtbFecha_ingreso.TabIndex = 43;
            // 
            // txtbAntiguedad
            // 
            this.txtbAntiguedad.Location = new System.Drawing.Point(12, 215);
            this.txtbAntiguedad.Name = "txtbAntiguedad";
            this.txtbAntiguedad.Size = new System.Drawing.Size(241, 20);
            this.txtbAntiguedad.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Fecha de Ingreso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Salario Anual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Antiguedad";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 264);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(765, 258);
            this.dgvEmpleados.TabIndex = 47;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 540);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtbCargo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbSalario_anual);
            this.Controls.Add(this.txtbFecha_ingreso);
            this.Controls.Add(this.txtbAntiguedad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbCuil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbFecha_nac);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbNro_tel_sec);
            this.Controls.Add(this.txtbNro_tel_princ);
            this.Controls.Add(this.txtbNro_doc);
            this.Controls.Add(this.txtbTipo_doc);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbNro_tel_sec;
        private System.Windows.Forms.TextBox txtbNro_tel_princ;
        private System.Windows.Forms.TextBox txtbNro_doc;
        private System.Windows.Forms.TextBox txtbTipo_doc;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbFecha_nac;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbCuil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbSalario_anual;
        private System.Windows.Forms.TextBox txtbFecha_ingreso;
        private System.Windows.Forms.TextBox txtbAntiguedad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}