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

        // Lista Articulos
        private void listar()
        {
            if (_listado == null)
            {
                _listado = new frmListarArticulos(true);
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
        //Agregar Marca
        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Agregar);
            frm.ShowDialog();
            _listado.Cargar();
        }
        //Agregar Categoria
        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Agregar);
            frm.ShowDialog();
            _listado.Cargar();
        }
        // Buscar Articulo
        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos(false);
            ventana.Show();

        }

     

        //Modificar Marca
        private void modificarMarcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Modificar);
            frm.ShowDialog();
            _listado.Cargar();
        }
        //Modificar Categoria
        private void modificarCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Modificar);
            frm.ShowDialog();
            _listado.Cargar();
        }



        //Eliminar Marca
        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(true, ModoOperacion.Eliminar);
            frm.ShowDialog();
            _listado.Cargar();

        }
        //Eliminar Categoria
        private void eliminarCategoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarMarcaCategoriaSimple frm = new frmAgregarMarcaCategoriaSimple(false, ModoOperacion.Eliminar);
            frm.ShowDialog();
            _listado.Cargar();

        }
        // Detalles e Integrantes
        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string msg =
            "Instrucciones de uso:" + Environment.NewLine + Environment.NewLine +
            "• Paso 1: Haz click en el Modulo que quieres utilizar." + Environment.NewLine +
            "• Paso 2: Haz clic en la accion que quieres realizar" + Environment.NewLine +
            "• Paso 3: Sigue las instrucciones del formulario mostrado" + Environment.NewLine +
            "• Consejo: Usa el buscador para filtrar resultados." + Environment.NewLine + Environment.NewLine +
            "• Eliminar Articulo:" + Environment.NewLine +
            " Seleccione el articulo que desea eliminar y presione Ctrl+F2 ";

        MessageBox.Show(this,msg, "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
        // Integrantes
        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg =
                "Integrantes del Grupo 2 A:" + Environment.NewLine + Environment.NewLine +
                "Gomez, Matias          Legajo: 27933" + Environment.NewLine +
                "Gonzalez, Esteban    Legajo: 30378" + Environment.NewLine +
                "Rojas, Adrian            Legajo: 31912";

            MessageBox.Show(this, msg, "Integrantes", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
        // Detalles de los Articulos
        private void detallesDeLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo frmDetalleArticulo = new FrmDetalleArticulo();

            frmDetalleArticulo.ShowDialog();
        }
        // About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}
