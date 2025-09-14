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
        public frmListarArticulos(bool mostrarComoVentana = false)
        {
            InitializeComponent();
            this.mostrarComoVentana = mostrarComoVentana;

            ConfigurarEstilo();
        }

        private bool mostrarComoVentana;
        //carga inicial
        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        // seleccion de datos
        private void dgvArchivos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArchivos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArchivos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl.ImagenUrl);
            }

        }
        //ejecucion de cargar/actualizar datos
        public void Cargar()
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArchivos.DataSource = listaArticulos;
                AjustarTabla();

                cargarImagen(listaArticulos[0].ImagenUrl.ImagenUrl);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //ajuste de tabla
        private void AjustarTabla()
        {
            dgvArchivos.Columns["Precio"].DefaultCellStyle.Format = "$ 0.00";
            dgvArchivos.Columns["ImagenUrl"].Visible = false;
            dgvArchivos.Columns["ID"].Visible = false;
        }
        //carga de imagen
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
        //boton volver
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }
        //filtro de busqueda
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            dgvArchivos.DataSource = null;
            dgvArchivos.DataSource = listaFiltrada;
            AjustarTabla();
        }
        //boton recargar
        private void btnReload_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        //configuracion de estilo segun modo
        private void ConfigurarEstilo()
        {
            if (mostrarComoVentana)
            {
                this.TopLevel = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;

                txtFiltro.Visible = false;
                lbeFiltro.Visible = false;

            }
            else
            {
                this.TopLevel = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Dock = DockStyle.None;

                
                txtFiltro.Visible = true;
                lbeFiltro.Visible = true;  
            }
        }

    }
}