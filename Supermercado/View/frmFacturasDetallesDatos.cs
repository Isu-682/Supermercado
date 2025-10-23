using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado.View
{
    public partial class frmFacturasDetallesDatos : Form
    {
        int id = -1;

        public frmFacturasDetallesDatos()
        {
            InitializeComponent();
        }

        public frmFacturasDetallesDatos(int id)
        {
            InitializeComponent();

            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"facturas_detalles\" WHERE id = " + id);
            txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtbDescr_factura.Text = ds.Tables[0].Rows[0]["descr_factura"].ToString();
            txtbCosto_asoc.Text = ds.Tables[0].Rows[0]["costo_asoc"].ToString();
            txtbIva.Text = ds.Tables[0].Rows[0]["iva"].ToString();
            txtbMedio_de_pago.Text = ds.Tables[0].Rows[0]["medio_de_pago"].ToString();
            txtbDescr_pago.Text = ds.Tables[0].Rows[0]["descr_pago"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos datos = new Datos();

            if (id == -1)
            {
                string queryUpdate = "INSERT INTO public.\"facturas_detalles\" (tipo, descr_factura, " +
                    "costo_asoc, iva, medio_de_pago, descr_pago) Values " +
                    "('" + txtbTipo.Text + "','" + txtbDescr_factura.Text + "','" + txtbCosto_asoc.Text + "','" + txtbIva.Text +
                    "','" + txtbIva.Text + "','" + txtbMedio_de_pago.Text + "','" + txtbDescr_pago.Text + ",)";
                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro insertado con éxito", "Siste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar al registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE \"facturas_detalles\" SET tipo = '" + txtbTipo.Text + "', descr_factura = '" + txtbDescr_factura.Text + "', " +
                    "costo_asoc = '" + txtbCosto_asoc.Text + "', iva = '" + txtbIva.Text + "', medio_de_pago = '" + txtbMedio_de_pago.Text
                    + "', descr_pago = '" + txtbDescr_pago.Text + "' WHERE id = " + id;
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
    }
}
