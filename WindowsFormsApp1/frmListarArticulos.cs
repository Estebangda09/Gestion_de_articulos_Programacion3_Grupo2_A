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

        public frmListarArticulos()
        {
            InitializeComponent();
            Text = "Listado de Artículos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
        }

        private void dgvArchivos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArchivos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArchivos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
            }

        }

        private void cargar()
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArchivos.DataSource = listaArticulos;
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

            listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descricpcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper())  );
            dgvArchivos.DataSource = null;
            dgvArchivos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}