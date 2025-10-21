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

        public frmClientes(int id)
        {
            InitializeComponent();

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"clientes\" WHERE id = " + id);
            txtbNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtbApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
            txtbTipo_doc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
            txtbNro_doc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
            mtxtbNro_tel_princ.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
            mtxtbNro_tel_sec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
            txtbEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
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
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
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

        private void limpiar()
        {
            txtbNombre.Text = "";
            txtbApellido.Text = "";
            txtbTipo_doc.Text = "";
            txtbNro_doc.Text = "";
            mtxtbNro_tel_princ.Text = "";
            mtxtbNro_tel_sec.Text = "";
            txtbEmail.Text = "";
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvClientes[0, dgvClientes.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"clientes\" WHERE id = " + r);
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
        }

        private void cargarDatos(int clienteId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"clientes\" WHERE id = " + clienteId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtbApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtbTipo_doc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
                txtbNro_doc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
                mtxtbNro_tel_princ.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtxtbNro_tel_sec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtbEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                id = clienteId;
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
