using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmFacturasDetalles : Form
    {
        Datos datos = new Datos();
        int id = -1;

        public frmFacturasDetalles()
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
                string queryUpdate = "INSERT INTO public.\"facturas_detalles\" " +
                    "(nombre, apellido, tipo_doc, nro_doc, nro_tel_princ, nro_tel_sec, email) VALUES (" +
                    "'" + txtbTipo.Text + "'," +
                    "'" + txtbCodigo.Text + "'," +
                    "'" + txtbDescr_factura.Text + "'," +
                    "'" + txtbCosto_asoc.Text + "'," +
                    "'" + txtbIva.Text + "'," +
                    "'" + txtbMedio_de_pago.Text + "'," +
                    "'" + txtbDescr_pago.Text + "')";


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
                string queryup = "UPDATE public.\"facturas_detalles\" SET " +
                    "tipo = '" + txtbTipo.Text + "', " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "descr_factura = '" + txtbDescr_factura.Text + "', " +
                    "costo_asoc = '" + txtbCosto_asoc.Text + "', " +
                    "iva = '" + txtbIva.Text + "', " +
                    "medio_de_pago = '" + txtbMedio_de_pago.Text + "', " +
                    "descr_pago = '" + txtbDescr_pago.Text + "' " +
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

        public frmFacturasDetalles(int id)
        {
            InitializeComponent();

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas_detalles\" WHERE id = " + id);
            txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
            txtbDescr_factura.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
            txtbCosto_asoc.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
            txtbIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
            txtbMedio_de_pago.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
            txtbDescr_pago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", " +
                "tipo as \"Tipo\", " +
                "codigo as \"Codigo\"," +
                "descr_factura as \"Descripcion de la Factura\", " +
                "costo_asoc as \"Costo Asociado\", " +
                "iva as \"IVA\", " +
                "medio_de_pago as \"Medio de Pago\", " +
                "descr_pago \"Descripcion de Pago\" FROM \"facturas_detalles\" order by id");
            if (ds != null)
            {
                dgvFacturas_detalles.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturasDetalles_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void frmFacturasDetalles_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void limpiar()
        {
            txtbTipo.Text = "";
            txtbCodigo.Text = "";
            txtbDescr_factura.Text = "";
            txtbCosto_asoc.Text = "";
            txtbIva.Text = "";
            txtbMedio_de_pago.Text = "";
            txtbDescr_pago.Text = "";
        }

        private void cargarDatos(int clienteId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM \"facturas_detalles\" WHERE id = " + clienteId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtbDescr_factura.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
                txtbCosto_asoc.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
                txtbIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
                txtbMedio_de_pago.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
                txtbDescr_pago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();

                id = clienteId;
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvFacturas_detalles[0, dgvFacturas_detalles.CurrentCell.RowIndex].Value);
            cargarDatos(Id);
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvFacturas_detalles[0, dgvFacturas_detalles.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"facturas_detalles\" WHERE id = " + r);
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
    }
}
