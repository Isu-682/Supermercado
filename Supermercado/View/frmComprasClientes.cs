using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmComprasClientes : Form
    {

        Datos datos = new Datos();

        public frmComprasClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void frmComprasClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData(
                "SELECT id as \"Id\", " +
                "id_venta as \"Id Venta\", " +
                "id_producto as \"Id Producto\" " +
                "FROM \"compras_clientes\" order by id");

            if (ds != null)
            {
                dgvCompras_Clientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r = dgvCompras_Clientes[0, dgvCompras_Clientes.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar la venta seleccionada?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"compras_clientes\" WHERE id = " + r);

                if (resultado)
                {
                    MessageBox.Show("Venta eliminada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la venta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
