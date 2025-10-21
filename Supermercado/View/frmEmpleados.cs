using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmEmpleados : Form
    {
        Datos datos = new Datos();
        int id = -1;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos datos = new Datos();

            // Validaciones
            if (!int.TryParse(txtbEdad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtbSalario_anual.Text, out decimal salario))
            {
                MessageBox.Show("Salario inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txtbFecha_nac.Text, out DateTime fechaNac))
            {
                MessageBox.Show("Fecha de nacimiento inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txtbFecha_ingreso.Text, out DateTime fechaIngreso))
            {
                MessageBox.Show("Fecha de ingreso inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id == -1)
            {
                string queryInsert = "INSERT INTO public.\"empleados\" " +
                    "(nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, " +
                    "cuil, direccion, nro_tel_princ, nro_tel_sec, email, cargo," +
                    "antiguedad, fecha_ingreso, salario_anual) VALUES (" +
                    "'" + txtbNombre.Text + "', " +
                    "'" + txtbApellido.Text + "', " +
                    edad + ", " +
                    "'" + fechaNac.ToString("yyyy-MM-dd") + "', " +
                    "'" + txtbTipo_doc.Text + "', " +
                    "'" + txtbNro_doc.Text + "', " +
                    "'" + txtbCuil.Text + "', " +
                    "'" + txtbDireccion.Text + "', " +
                    "'" + mtxtbNro_tel_princ.Text + "', " +
                    "'" + mtxtbNro_tel_sec.Text + "', " +
                    "'" + txtbEmail.Text + "', " +
                    "'" + txtbCargo.Text + "', " +
                    "'" + txtbAntiguedad.Text + "', " +
                    "'" + fechaIngreso.ToString("yyyy-MM-dd") + "', " +
                    salario.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")";

                resultado = datos.ExecuteQuery(queryInsert);

                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito", "Siste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();

                }
                else
                {
                    MessageBox.Show("Error al agregar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryUpdate = "UPDATE public.\"empleados\" SET " +
                    "nombre = '" + txtbNombre.Text + "', " +
                    "apellido = '" + txtbApellido.Text + "', " +
                    "edad = " + edad + ", " +
                    "fecha_nac = '" + fechaNac.ToString("yyyy-MM-dd") + "', " +
                    "tipo_doc = '" + txtbTipo_doc.Text + "', " +
                    "nro_doc = '" + txtbNro_doc.Text + "', " +
                    "cuil = '" + txtbCuil.Text + "', " +
                    "direccion = '" + txtbDireccion.Text + "', " +
                    "nro_tel_princ = '" + mtxtbNro_tel_princ.Text + "', " +
                    "nro_tel_sec = '" + mtxtbNro_tel_sec.Text + "', " +
                    "email = '" + txtbEmail.Text + "', " +
                    "cargo = '" + txtbCargo.Text + "', " +
                    "antiguedad = '" + txtbAntiguedad.Text + "', " +
                    "fecha_ingreso = '" + fechaIngreso.ToString("yyyy-MM-dd") + "', " +
                    "salario_anual = " + salario.ToString(System.Globalization.CultureInfo.InvariantCulture) + " " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryUpdate);

                if (resultado)
                {
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiar()
        {
            txtbNombre.Text = "";
            txtbApellido.Text = "";
            txtbEdad.Text = "";
            txtbFecha_nac.Text = "";
            txtbTipo_doc.Text = "";
            txtbNro_doc.Text = "";
            txtbCuil.Text = "";
            txtbDireccion.Text = "";
            mtxtbNro_tel_princ.Text = "";
            mtxtbNro_tel_sec.Text = "";
            txtbEmail.Text = "";
            txtbCargo.Text = "";
            txtbAntiguedad.Text = "";
            txtbFecha_ingreso.Text = "";
            txtbSalario_anual.Text = "";
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "nombre as \"Nombre\", " +
                "apellido as \"Apellido\"," +
                "edad as \"Edad\"," +
                "fecha_nac as \"Fecha de Nacimiento\"," +
                "tipo_doc as \"Tipo de Documento\", " +
                "nro_doc as \"Numero de Documento\", " +
                "cuil as \"Cuil\"," +
                "direccion as \"Direccion\"," +
                "nro_tel_princ as \"Numero Telefonico Principal\", " +
                "nro_tel_sec as \"Numero Telefonico Secundario\", " +
                "email as \"Email\", " +
                "cargo as \"Cargo\"," +
                "antiguedad as \"Antiguedad\"," +
                "fecha_ingreso as \"Fecha de Ingreso\"," +
                "salario_anual \"Salario Anual\" FROM \"empleados\" order by id");
            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void editarToolStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void eliminaToolStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvEmpleados[0, dgvEmpleados.CurrentCell.RowIndex].Value);
            bool resultado;
            Datos datos = new Datos();
            string queryDelete = "DELETE FROM public.\"empleados\" WHERE id = " + Id;
            resultado = datos.ExecuteQuery(queryDelete);
            if (resultado)
            {
                MessageBox.Show("Registro eliminado con éxito", "Siste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int Id)
        {
            DataSet ds = datos.getAllData("SELECT * FROM public.\"empleados\" WHERE id = " + Id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                id = Convert.ToInt32(row["id"]);
                txtbNombre.Text = row["nombre"].ToString();
                txtbApellido.Text = row["apellido"].ToString();
                txtbEdad.Text = row["edad"].ToString();
                txtbFecha_nac.Text = row["fecha_nac"].ToString();
                txtbTipo_doc.Text = row["tipo_doc"].ToString();
                txtbNro_doc.Text = row["nro_doc"].ToString();
                txtbCuil.Text = row["cuil"].ToString();
                txtbDireccion.Text = row["direccion"].ToString();
                mtxtbNro_tel_princ.Text = row["nro_tel_princ"].ToString();
                mtxtbNro_tel_sec.Text = row["nro_tel_sec"].ToString();
                txtbEmail.Text = row["email"].ToString();
                txtbCargo.Text = row["cargo"].ToString();
                txtbAntiguedad.Text = row["antiguedad"].ToString();
                txtbFecha_ingreso.Text = row["fecha_ingreso"].ToString();
                txtbSalario_anual.Text = row["salario_anual"].ToString();
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos del empleado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
