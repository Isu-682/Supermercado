using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado.View
{
    public partial class frmFacturasDetallesDatos : Form
    {
        int id = -1;
        int idFactura;

        public frmFacturasDetallesDatos()
        {
            InitializeComponent();
        }

        public frmFacturasDetallesDatos(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
        }

        public frmFacturasDetallesDatos(int id, int idFactura)
        {
            InitializeComponent();

            this.id = id;
            this.idFactura = idFactura;

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas_detalles\" WHERE id = " + id);
            txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtbDescr_factura.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
            txtbCosto_asoc.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
            txtbIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
            txtbMedio_de_pago.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
            txtbDescr_pago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();
            btnAgregar.Text = "Actualizar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos datos = new Datos();

            if (id == -1)
            {
                // 🔹 Insert con id_factura incluido
                string queryInsert = "INSERT INTO public.\"facturas_detalles\" (id_factura, tipo, " +
                    "descr_factura, costo_asoc, iva, medio_de_pago, descr_pago) VALUES (" +
                    "'" + idFactura + "'," +
                    "'" + txtbTipo.Text + "'," +
                    "'" + txtbDescr_factura.Text + "'," +
                    "'" + txtbCosto_asoc.Text + "'," +
                    "'" + txtbIva.Text + "'," +
                    "'" + txtbMedio_de_pago.Text + "'," +
                    "'" + txtbDescr_pago.Text + "')";

                resultado = datos.ExecuteQuery(queryInsert);
                if (resultado)
                {
                    MessageBox.Show("Detalle insertado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar el detalle", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryUpdate = "UPDATE public.\"facturas_detalles\" SET " +
                    "tipo = '" + txtbTipo.Text + "', " +
                    "descr_factura = '" + txtbDescr_factura.Text + "', " +
                    "costo_asoc = '" + txtbCosto_asoc.Text + "', " +
                    "iva = '" + txtbIva.Text + "', " +
                    "medio_de_pago = '" + txtbMedio_de_pago.Text + "', " +
                    "descr_pago = '" + txtbDescr_pago.Text + "' " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryUpdate);

                if (resultado)
                {
                    MessageBox.Show("Detalle actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el detalle", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
