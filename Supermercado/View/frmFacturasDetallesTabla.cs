using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmFacturasDetallesTabla : Form
    {
        Datos datos = new Datos();

        public frmFacturasDetallesTabla()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {

        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\", id_factura as \"ID Factura\", tipo as \"Tipo\", descr_factura as \"Descripcion de Factura\"," +
                "costo_asoc as \"Costo Asociado\", iva as \"IVA\", medio_de_pago as \"Medio de Pago\", descr_pago as \"Descripcion de Pago\" FROM \"facturas_detalles\" Order by id");
            if (ds != null)
            {
                dgvFacturas_detalles.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFacturasDetallesTabla_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void frmFacturasDetallesTabla_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
