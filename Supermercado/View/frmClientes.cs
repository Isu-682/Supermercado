using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmClientes : Form
    {
        Datos datos = new Datos();
        int id = -1;

        public frmClientes()
        {
            InitializeComponent();
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

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO public.\"clientes\" " +
                    "(nombre, apellido, tipo_doc, nro_doc, nro_tel_princ, nro_tel_sec, email) VALUES (" +
                    "'" + txtbNombre.Text + "'," +
                    "'" + txtbApellido.Text + "'," +
                    "'" + txtbTipo_doc.Text + "'," +
                    "'" + txtbNro_doc.Text + "'," +
                    "'" + mtxtbNro_tel_princ.Text + "'," +
                    "'" + mtxtbNro_tel_sec.Text + "'," +
                    "'" + txtbEmail.Text + "')";


                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Siste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE public.\"clientes\" SET " +
                    "nombre = '" + txtbNombre.Text + "', " +
                    "apellido = '" + txtbApellido.Text + "', " +
                    "tipo_doc = '" + txtbTipo_doc.Text + "', " +
                    "nro_doc = '" + txtbNro_doc.Text + "', " +
                    "nro_tel_princ = '" + mtxtbNro_tel_princ.Text + "', " +
                    "nro_tel_sec = '" + mtxtbNro_tel_sec.Text + "', " +
                    "email = '" + txtbEmail.Text + "' " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Siste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "nombre as \"Nombre\", " +
                "apellido as \"Apellido\"," +
                "tipo_doc as \"Tipo de Documento\", " +
                "nro_doc as \"Numero de Documento\", " +
                "nro_tel_princ as \"Numero Telefonico Principal\", " +
                "nro_tel_sec as \"Numero Telefonico Secundario\", " +
                "email \"Email\" FROM \"clientes\" order by id");
            if (ds != null)
            {
                dgvClientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
