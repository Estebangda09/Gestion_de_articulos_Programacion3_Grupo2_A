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
            Text = "Gestion De articulos";
        }
        // Configuracion inicial del formulario
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            listar();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listar();

        }
        // Lista Articulos
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
        // Agrega Articulo
        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.ShowDialog();
            _listado.Cargar();
        }

        // Modifica Articulo
        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = _listado.GetSeleccionado();
            frmArticulo frmArticulo = new frmArticulo(seleccionado);
            frmArticulo.ShowDialog();
            _listado.Cargar();
        }

        // Elimina Articulo
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
                negocio.Eliminar(seleccionado.Id);
                _listado.Cargar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        //Agregar Marca y Categoria
        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Agregar);
            frm.ShowDialog();
            _listado.Cargar();
        }
        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Agregar);
            frm.ShowDialog();
            _listado.Cargar();
        }


        //Modificar Marca y Categoria
        private void modificarMarcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Modificar);
            frm.ShowDialog();
            _listado.Cargar();
        }
        private void modificarCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Modificar);
            frm.ShowDialog();
            _listado.Cargar();
        }


        //Eliminar Marca y Categoria
        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Eliminar);
            frm.ShowDialog();
            _listado.Cargar();

        }

        private void eliminarCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Eliminar);
            frm.ShowDialog();
            _listado.Cargar();

        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg =
                "Instrucciones de uso:" + Environment.NewLine + Environment.NewLine +
                "• Paso 1: Haz click en el Modulo que quieres utilizar." + Environment.NewLine +
                "• Paso 2: Haz clic en la accion que quieres realizar" + Environment.NewLine +
                "• Paso 3: Sigue las instrucciones del formulario mostrado" + Environment.NewLine +
                "• Consejo: Usa el buscador para filtrar resultados.";

            MessageBox.Show(this,msg, "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg =
                "Integrantes del Grupo 2 A:" + Environment.NewLine + Environment.NewLine +
                "Gomez, Matias       Legajo: 27933" + Environment.NewLine +
                "Gonzales, Esteban   Legajo: 11111" + Environment.NewLine +
                "Rojas, Adrian       Legajo: 31912";

            MessageBox.Show(this, msg, "Integrantes", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void detallesDeLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();

            frmDetalleArticulo.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
