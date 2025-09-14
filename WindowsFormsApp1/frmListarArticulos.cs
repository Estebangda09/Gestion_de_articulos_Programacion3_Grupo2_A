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
    public partial class frmListarArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public Articulo GetSeleccionado()
        {
            if (dgvArchivos == null || dgvArchivos.CurrentRow == null)
                return null;

            return dgvArchivos.CurrentRow.DataBoundItem as Articulo;
        }
        public frmListarArticulos()
        {
            InitializeComponent();
            Text = "Listado de Artículos";
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }


        private void dgvArchivos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArchivos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArchivos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
            }

        }

        public void Cargar()
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArchivos.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].ImagenUrl.ImagenUrl);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArchivos.Columns["ImagenUrl"].Visible = false;
            dgvArchivos.Columns["ID"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://w7.pngwing.com/pngs/285/84/png-transparent-computer-icons-error-super-8-film-angle-triangle-computer-icons-thumbnail.png");
            }
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }


        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            dgvArchivos.DataSource = null;
            dgvArchivos.DataSource = listaFiltrada;
            ocultarColumnas();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvArchivos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArchivos.CurrentRow.DataBoundItem;
                frmArticulo formularioEdicion = new frmArticulo(seleccionado);
                formularioEdicion.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccioná un artículo para modificar.");
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}