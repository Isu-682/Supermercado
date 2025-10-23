using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFacturasDet_Click(object sender, System.EventArgs e)
        {
            frmFacturasDetallesTabla facturasDetalles = new frmFacturasDetallesTabla();
            facturasDetalles.Show();
            this.Hide();
        }

        private void btnVentasPro_Click(object sender, System.EventArgs e)
        {
            frmVentasProductos ventasProductos = new frmVentasProductos();
            ventasProductos.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, System.EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, System.EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, System.EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void btnFacturas_Click(object sender, System.EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, System.EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void btnComprasCli_Click(object sender, System.EventArgs e)
        {
            frmComprasClientes comprasClientes = new frmComprasClientes();
            comprasClientes.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, System.EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Hide();
        }
    }
}
