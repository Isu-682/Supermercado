using Supermercado.Data;
using Supermercado.View;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmFacturas : Form
    {
        Datos datos = new Datos();
        int id = -1;

        public frmFacturas()
        {
            InitializeComponent();
        }

        public frmFacturas(int id)
        {
            InitializeComponent();

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas\" WHERE id = " + id);
            txtbNumero.Text = ds.Tables[0].Rows[0]["numero"].ToString();
            txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
            dtpFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            dtpHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
            txtbImporte_total.Text = ds.Tables[0].Rows[0]["importe_total"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void frmFacturas_Load(object sender, EventArgs e)
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

            if (id == -1)
            {
                string queryInsert = "INSERT INTO public.\"facturas\" (numero, codigo, fecha, hora, importe_total) " +
                                     "VALUES ('" + txtbNumero.Text + "', '" + txtbCodigo.Text + "', '" +
                                     dtpFecha.Value.ToString("yyyy-MM-dd") + "', '" + dtpHora.Value.ToString("HH:mm:ss") + "', '" +
                                     txtbImporte_total.Text + "') RETURNING id;";

                int nuevoIdFactura = datos.ExecuteInsertAndReturnId(queryInsert);

                if (nuevoIdFactura > 0)
                {
                    MessageBox.Show("Factura insertada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSet dsEmpleados = datos.getAllData("SELECT MAX(id) as id FROM public.\"empleados\"");
                    int idEmpleadoActual = Convert.ToInt32(dsEmpleados.Tables[0].Rows[0]["id"]);

                    string queryVenta = "INSERT INTO public.\"ventas\" (id_empleado, id_factura) " +
                                        "VALUES (" + idEmpleadoActual + ", " + nuevoIdFactura + ")";
                    datos.ExecuteQuery(queryVenta);

                    DialogResult respuesta = MessageBox.Show("¿Desea agregar más detalles a la factura?", "Agregar detalles", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        frmFacturasDetallesDatos detallesForm = new frmFacturasDetallesDatos(nuevoIdFactura);
                        detallesForm.ShowDialog();
                    }
                    else
                    {
                        limpiar();
                    }

                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al insertar la factura", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryUpdate = "UPDATE public.\"facturas\" SET " +
                    "numero = '" + txtbNumero.Text + "', " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "fecha = '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "', " +
                    "hora = '" + dtpHora.Value.ToString("HH:mm:ss") + "', " +
                    "importe_total = '" + txtbImporte_total.Text + "' " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryUpdate);

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtbNumero.Text = "";
            txtbCodigo.Text = "";
            dtpFecha.Text = "";
            dtpHora.Text = "";
            txtbImporte_total.Text = "";
            id = -1;
            btnAgregar.Text = "Agregar";
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "numero as \"Numero\", " +
                "codigo as \"Codigo\"," +
                "fecha as \"Fecha\", " +
                "hora as \"Hora\", " +
                "importe_total \"Importe Total\" FROM \"facturas\" order by id");
            if (ds != null)
            {
                dgvFacturas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturas_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void cargarDatos(int clienteId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"facturas\" WHERE id = " + clienteId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNumero.Text = ds.Tables[0].Rows[0]["numero"].ToString();
                txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                dtpFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                dtpHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                txtbImporte_total.Text = ds.Tables[0].Rows[0]["importe_total"].ToString();

                id = clienteId;
            }
            else
            {
                MessageBox.Show("No se pudo cargar la factura", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"facturas\" WHERE id = " + r);
                if (resultado)
                {
                    MessageBox.Show("Registro eliminado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
