using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio; 
using negocio;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArchivoNegocio dato = new ArchivoNegocio();
            listaArticulos = dato.Listar();
            dgvArchivos.DataSource = listaArticulos;
            dgvArchivos.Columns["ImagenUrl"].Visible = false;

            if (listaArticulos.Count > 0)
                cargarImagen(listaArticulos[0].ImagenUrl.ImagenUrl);
        }

        private void dgvArchivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArchivos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArchivos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch
            {
                pbxArticulo.Load("https://w7.pngwing.com/pngs/285/84/png-transparent-computer-icons-error-super-8-film-angle-triangle-computer-icons-thumbnail.png");
            }
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {
        }
    }
}