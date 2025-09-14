using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WindowsFormsApp1
{
    public partial class frmArticulo : Form
    {
        private Articulo _articulo = null;
        public frmArticulo()
        {
            InitializeComponent();
        }

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this._articulo = articulo;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            // Limpiar campos de texto
            textCodigo.Text = "";
            textNombre.Text = "";
            textDescripcion.Text = "";
            textPrecio.Text = "0";

            // Restablecer ComboBoxes
            comboMarca.SelectedIndex = -1;
            comboCategoria.SelectedIndex = -1;

            // Limpiar lista de imágenes
            txtImagenUrl.Text = "";

            // Limpiar vista previa
            pictureBoxVistaPrevia.Image = null;

        }

        private void buttonCancelarArticulo_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {


            CategoriaNegocio negocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                comboCategoria.DataSource = negocio.ListarCategorias();
                comboMarca.DataSource = marcaNegocio.ListarMarcas();


                comboCategoria.DisplayMember = "Descripcion";
                comboCategoria.ValueMember = "Id";


                comboMarca.DisplayMember = "Descripcion";
                comboMarca.ValueMember = "Id";


                if (_articulo != null)
                {
                    textCodigo.Text = _articulo.Codigo;
                    textNombre.Text = _articulo.Nombre;
                    textDescripcion.Text = _articulo.Descripcion;
                    textPrecio.Text = _articulo.Precio.ToString();
                    comboCategoria.SelectedValue = _articulo.Categoria.Id;
                    comboMarca.SelectedValue = _articulo.Marca.Id;
                    txtImagenUrl.Text = _articulo.ImagenUrl.ImagenUrl;
                    cargarImagen(_articulo.ImagenUrl.ImagenUrl);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxVistaPrevia.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxVistaPrevia.Load("https://w7.pngwing.com/pngs/285/84/png-transparent-computer-icons-error-super-8-film-angle-triangle-computer-icons-thumbnail.png");
            }
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ArchivoNegocio archivoNegocio = new ArchivoNegocio();

            try
            {

                if (string.IsNullOrWhiteSpace(textCodigo.Text) ||
                    string.IsNullOrWhiteSpace(textNombre.Text) ||
                    string.IsNullOrWhiteSpace(textDescripcion.Text) ||
                    comboCategoria.SelectedIndex == -1 ||
                    comboMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                if (_articulo == null)
                    _articulo = new Articulo();

                _articulo.Codigo = textCodigo.Text;
                _articulo.Nombre = textNombre.Text;
                _articulo.Descripcion = textDescripcion.Text;


                // Cargar imagen desde el TextBox
                _articulo.ImagenUrl = new Imagen();
                _articulo.ImagenUrl.ImagenUrl = txtImagenUrl.Text;

                decimal precio;
                if (decimal.TryParse(textPrecio.Text, out precio))
                {
                    _articulo.Precio = precio;
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                    return;
                }
                _articulo.Categoria = (Categoria)comboCategoria.SelectedItem;
                _articulo.Marca = (Marca)comboMarca.SelectedItem;

                if (_articulo.Id != 0)
                {
                    archivoNegocio.Modificar(_articulo);
                    MessageBox.Show("Modificado satisfactoriamente");
                    this.Close();
                }
                else
                {
                    archivoNegocio.Agregar(_articulo);
                    MessageBox.Show("Agregado satisfactoriamente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {


        }

        private void txtImagenUrl_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                pictureBoxVistaPrevia.Load(txtImagenUrl.Text);
            }
            catch
            {
                pictureBoxVistaPrevia.Load("https://w7.pngwing.com/pngs/285/84/png-transparent-computer-icons-error-super-8-film-angle-triangle-computer-icons-thumbnail.png");
            }
        }
    }
}
