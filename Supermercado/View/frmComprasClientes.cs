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
                "SELECT cc.id AS \"Id\", " +
                "cc.id_venta AS \"Id Venta\", " +
                "cc.id_cliente AS \"Id Cliente\" " +
                "FROM public.\"compras_clientes\" cc " +
                "ORDER BY cc.id");

            if (ds != null)
            {
                dgvCompras_Clientes.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.",
                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCompras_Clientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvCompras_Clientes[0, dgvCompras_Clientes.CurrentCell.RowIndex].Value.ToString();

            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?",
                                              "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"compras_clientes\" WHERE id = " + id);

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
