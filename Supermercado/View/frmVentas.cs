using Supermercado.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmVentas : Form
    {
        Datos datos = new Datos();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void frmVentas_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData(
                "SELECT id as \"Id\", " +
                "id_empleado as \"Id Empleado\", " +
                "id_factura as \"Id Factura\" " +
                "FROM \"ventas\" order by id");

            if (ds != null)
            {
                dgvVentas.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar la venta seleccionada?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"ventas\" WHERE id = " + r);

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
