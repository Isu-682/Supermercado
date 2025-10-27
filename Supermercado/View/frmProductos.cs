using Supermercado.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class frmProductos : Form
    {
        Datos datos = new Datos();
        int id = -1;
        int idProveedor;

        public frmProductos()
        {
            InitializeComponent();
        }

        public frmProductos(int idProveedor)
        {
            InitializeComponent();
            this.idProveedor = idProveedor;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void frmProductos_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
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
                string queryUpdate = "INSERT INTO public.\"productos\" " +
                    "(id_proveedor, codigo, imagen, nombre, marca, tipo, grupo, peso, precio_unidad, stock) VALUES (" +
                    "'" + idProveedor + "'," +
                    "'" + txtbCodigo.Text + "'," +
                    "'" + txtbImagen.Text + "'," +
                    "'" + txtbNombre.Text + "'," +
                    "'" + txtbMarca.Text + "'," +
                    "'" + txtbTipo.Text + "'," +
                    "'" + txtbGrupo.Text + "'," +
                    "" + txtbPeso.Text + "," +
                    "" + txtbPrecio_unidad.Text + "," +
                    "" + txtbStock.Text + ")";

                resultado = datos.ExecuteQuery(queryUpdate);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al agregar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                string queryup = "UPDATE productos SET " +
                    "codigo = '" + txtbCodigo.Text + "', " +
                    "imagen = '" + txtbImagen.Text + "', " +
                    "nombre = '" + txtbNombre.Text + "', " +
                    "marca = '" + txtbMarca.Text + "', " +
                    "tipo = '" + txtbTipo.Text + "', " +
                    "grupo = '" + txtbGrupo.Text + "', " +
                    "peso = " + txtbPeso.Text + ", " +
                    "precio_unidad = " + txtbPrecio_unidad.Text + ", " +
                    "stock = " + txtbStock.Text + " " +
                    "WHERE id = " + id;

                resultado = datos.ExecuteQuery(queryup);

                if (resultado)
                {
                    MessageBox.Show("Actualizado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarDatos()
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos order by id");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos de la base de datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatos(int cId)
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos WHERE id = " + cId);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtbNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtbCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtbImagen.Text = ds.Tables[0].Rows[0]["imagen"].ToString();
                txtbMarca.Text = ds.Tables[0].Rows[0]["marca"].ToString();
                txtbGrupo.Text = ds.Tables[0].Rows[0]["grupo"].ToString();
                txtbPeso.Text = ds.Tables[0].Rows[0]["peso"].ToString();
                txtbPrecio_unidad.Text = ds.Tables[0].Rows[0]["precio_unidad"].ToString();
                txtbStock.Text = ds.Tables[0].Rows[0]["stock"].ToString();
                txtbTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                id = cId;
                btnAgregar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("No se pudo cargar el cliente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtbCodigo.Text = "";
            txtbImagen.Text = "";
            txtbNombre.Text = "";
            txtbMarca.Text = "";
            txtbTipo.Text = "";
            txtbGrupo.Text = "";
            txtbPeso.Text = "";
            txtbPrecio_unidad.Text = "";
            txtbStock.Text = "";
            picbImagen.Image = null;
            id = -1;
            btnAgregar.Text = "Agregar";
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value);
            cargarDatos(Id);

            Datos datos = new Datos();
            string img = datos.GetValue("SELECT imagen FROM productos WHERE id =" + Id);

            if (!string.IsNullOrEmpty(img))
            {
                try
                {
                    if (img.StartsWith("http://") || img.StartsWith("https://"))
                    {
                        using (System.Net.WebClient wc = new System.Net.WebClient())
                        {
                            byte[] bytes = wc.DownloadData(img);

                            using (var ms = new System.IO.MemoryStream(bytes))
                            {
                                using (var image = new ImageMagick.MagickImage(ms))
                                {
                                    using (var bmpStream = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                                    {
                                        picbImagen.Image = new Bitmap(bmpStream);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        using (var image = new ImageMagick.MagickImage(img))
                        {
                            using (var ms = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                            {
                                picbImagen.Image = new Bitmap(ms);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picbImagen.Image = null;
            }
        }
        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                bool resultado = datos.ExecuteQuery("DELETE FROM public.\"productos\" WHERE id = " + r);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT * FROM productos Where " +
            "codigo ilike '" + txtbBuscar.Text + "%' OR " +
            "imagen ilike '" + txtbBuscar.Text + "%' OR " +
            "nombre ilike '" + txtbBuscar.Text + "%' OR " +
            "marca ilike '" + txtbBuscar.Text + "%' OR " +
            "tipo ilike '" + txtbBuscar.Text + "%' OR " +
            "grupo ilike '" + txtbBuscar.Text + "%';");
            if (ds != null)
            {
                dgvProductos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }

        private void txtbImagen_TextChanged(object sender, EventArgs e)
        {
            string img = txtbImagen.Text;

            if (!string.IsNullOrEmpty(img))
            {
                try
                {
                    if (img.StartsWith("http://") || img.StartsWith("https://"))
                    {
                        using (System.Net.WebClient wc = new System.Net.WebClient())
                        {
                            byte[] bytes = wc.DownloadData(img);

                            using (var ms = new System.IO.MemoryStream(bytes))
                            {
                                using (var image = new ImageMagick.MagickImage(ms))
                                {
                                    using (var bmpStream = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                                    {
                                        picbImagen.Image = new Bitmap(bmpStream);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        using (var image = new ImageMagick.MagickImage(img))
                        {
                            using (var ms = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                            {
                                picbImagen.Image = new Bitmap(ms);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picbImagen.Image = null;
            }

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewColumn col = dgvProductos.Columns[e.ColumnIndex];
            if (col != null && col.Name.Equals("Imagen", StringComparison.OrdinalIgnoreCase))
            {
                object value = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value != null && !string.IsNullOrEmpty(value.ToString()))
                {
                    string img = value.ToString();
                    try
                    {
                        if (img.StartsWith("http://") || img.StartsWith("https://"))
                        {
                            using (System.Net.WebClient wc = new System.Net.WebClient())
                            {
                                byte[] bytes = wc.DownloadData(img);
                                using (var ms = new System.IO.MemoryStream(bytes))
                                {
                                    using (var image = new ImageMagick.MagickImage(ms))
                                    {
                                        using (var bmpStream = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                                        {
                                            picbImagen.Image = new Bitmap(bmpStream);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            using (var image = new ImageMagick.MagickImage(img))
                            {
                                using (var ms = new System.IO.MemoryStream(image.ToByteArray(ImageMagick.MagickFormat.Bmp)))
                                {
                                    picbImagen.Image = new Bitmap(ms);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    picbImagen.Image = null;
                }
            }
        }
    }
}
