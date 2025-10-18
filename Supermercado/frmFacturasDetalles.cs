using System;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmFacturasDetalles : Form
    {
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
    }
}
