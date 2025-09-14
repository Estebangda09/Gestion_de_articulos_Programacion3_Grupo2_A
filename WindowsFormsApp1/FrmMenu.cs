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
    public partial class FrmMenu : Form
    {
        private frmListarArticulos _listado;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            listar();

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listar();

        }
        private void listar()
        {
            if (_listado == null)
            {
                _listado = new frmListarArticulos();
                _listado.MdiParent = this;
                _listado.Show();
            }
            else
            {
                _listado.Activate();
            }
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.ShowDialog();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = _listado.GetSeleccionado();
            frmArticulo frmArticulo = new frmArticulo(seleccionado);
            frmArticulo.ShowDialog();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            Articulo seleccionado = new Articulo();
            try
            {
                if (_listado == null)
                {
                    MessageBox.Show("Abrí primero el listado de artículos.");
                    return;
                }
                DialogResult = MessageBox.Show("Deseas eliminar definitivamente el elemento?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.No) return;
                seleccionado = (Articulo)_listado.GetSeleccionado();
                negocio.Eliminar(seleccionado.Codigo);
                _listado.cargar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frmAgregarMarcaCategoriaSimple = new frmAgregarMarcaCategoriaSimple(true);
            frmAgregarMarcaCategoriaSimple.ShowDialog();
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frmAgregarMarcaCategoriaSimple = new frmAgregarMarcaCategoriaSimple(false);
            frmAgregarMarcaCategoriaSimple.ShowDialog();
        }
    }
}
