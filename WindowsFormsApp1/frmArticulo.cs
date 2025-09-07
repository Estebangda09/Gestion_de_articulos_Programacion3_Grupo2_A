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


namespace WindowsFormsApp1
{
    public partial class frmArticulo : Form
    {
        public frmArticulo()
        {
            InitializeComponent();
        }



        private void listImagenArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listImagenArticulo.SelectedItem != null)
            {
                string selectedImagePath = listImagenArticulo.SelectedItem.ToString();
                pictureBoxVistaPrevia.Image = Image.FromFile(selectedImagePath);
                pictureBoxVistaPrevia.SizeMode = PictureBoxSizeMode.Zoom;
            }

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
            listImagenArticulo.Items.Clear();

            // Limpiar vista previa
            pictureBoxVistaPrevia.Image = null;

        }

        private void buttonCancelarArticulo_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        

        private void buttonAgregarIMG_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    listImagenArticulo.Items.Add(file);
                }
            }

        }

      

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArchivoNegocio archivoNegocio = new ArchivoNegocio();
            


            try
            {

               articulo.Codigo= textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descricpcion = textDescripcion.Text;

                decimal precio;
                if (decimal.TryParse(textPrecio.Text, out precio))
                {
                    articulo.Precio = precio;  
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                }


                archivoNegocio.Agregar(articulo);

                MessageBox.Show("agregado");
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            
              CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                comboCategoria.DataSource = negocio.Categorias();
                comboCategoria.DisplayMember = "Descripcion"; 
                comboCategoria.ValueMember = "Id";          


            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }
    }
}
