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
        private Articulo articulo = null;
        public frmArticulo()
        {
            InitializeComponent();
        }
        
        

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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
                comboCategoria.DataSource = negocio.Categorias();
                comboMarca.DataSource =  marcaNegocio.listamarca();
               

                comboCategoria.DisplayMember = "Descripcion"; 
                comboCategoria.ValueMember = "Id";


                comboMarca.DisplayMember = "Descripcion";
                comboMarca.ValueMember = "Id";


                if(articulo != null)
                {
                    textCodigo.Text = articulo.Codigo;
                    textNombre.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descricpcion;
                    textPrecio.Text = articulo.Precio.ToString();
                    comboCategoria.SelectedValue = articulo.tipo.Id;
                    comboMarca.SelectedValue = articulo.marca.Id;
                    txtImagenUrl.Text = articulo.ImagenUrl.ImagenUrl;
                    pictureBoxVistaPrevia.Load(articulo.ImagenUrl.ImagenUrl);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            Articulo articulo = new Articulo();
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

                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descricpcion = textDescripcion.Text;


                // Cargar imagen desde el TextBox
                articulo.ImagenUrl = new Imagen();
                articulo.ImagenUrl.ImagenUrl = txtImagenUrl.Text;

                decimal precio;
                if (decimal.TryParse(textPrecio.Text, out precio))
                {
                    articulo.Precio = precio;
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                    return;
                }
                articulo.tipo = (Categoria)comboCategoria.SelectedItem;
                articulo.marca = (Marca)comboMarca.SelectedItem;


                archivoNegocio.Agregar(articulo);
                MessageBox.Show("agregado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBoxVistaPrevia_Click(object sender, EventArgs e)
        {

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
