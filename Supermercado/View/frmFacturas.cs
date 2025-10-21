using Supermercado.Data;
using System;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmFacturas : Form
    {
        Datos datos = new Datos();
        int id = -1;

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {

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
                string queryUpdate = "INSERT INTO public.\"facturas\" " +
                    "(numero, codigo, fecha, hora, importe_total) VALUES (" +
                    "'" + txtbNumero.Text + "'," +
                    "'" + txtbCodigo.Text + "'," +
                    "'" + txtbFecha.Text + "'," +
                    "'" + txtbHora.Text + "'," +
                    "'" + txtbImporte_total.Text + "')";


                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE public.\"clientes\" SET " +
                    "numero = '" + txtbNumero.Text + "', " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "fecha = '" + txtbFecha.Text + "', " +
                    "hora = '" + txtbHora.Text + "', " +
                    "importe_total = '" + txtbImporte_total.Text + "', " +
                    "WHERE id = " + id;

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

        private void limpiar()
        {
            txtbNumero.Text = "";
            txtbCodigo.Text = "";
            txtbFecha.Text = "";
            txtbHora.Text = "";
            txtbImporte_total.Text = "";
        }
    }
}
