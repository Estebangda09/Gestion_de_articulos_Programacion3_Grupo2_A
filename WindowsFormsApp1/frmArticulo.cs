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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void buttonEliminarIMG_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxVistaPrevia_Click(object sender, EventArgs e)
        {

        }
    }
}
