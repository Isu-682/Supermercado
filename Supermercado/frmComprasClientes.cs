using System;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmComprasClientes : Form
    {
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
    }
}
