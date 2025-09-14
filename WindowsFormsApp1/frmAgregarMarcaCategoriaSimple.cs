using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class frmAgregarMarcaCategoriaSimple : Form
    {   
        private bool isMarca = false;
        private ModoOperacion modo; 
        private int idSeleccionado =0;
        // Constructor vacio
        public frmAgregarMarcaCategoriaSimple()
        {
            InitializeComponent();
        }
        // Constructor con parametros
        public frmAgregarMarcaCategoriaSimple(bool isMarca, ModoOperacion modo)
        {   
            this.isMarca = isMarca;
            this.modo = modo;

            InitializeComponent();
            ConfigurarFormulario();

        }
        // Configuracion inicial del formulario
        private void ConfigurarFormulario()
        {
            if (isMarca) {
                CargarFormularioMarca();
             }
            else {                 
                CargarFormularioCategoria(); 
            }
            switch (modo)
            {
                case ModoOperacion.Agregar:
                    Text = isMarca ? "Agregar Marca" : "Agregar Categoría";
                    labelTipoPorAgregar.Text = isMarca ? "Ingrese la Marca a agregar:" : "Ingrese la Categoría a agregar:";
                    textBox1.Enabled = true;
                    textBox1.Text = "";
                    break;

                case ModoOperacion.Modificar:
                    Text = isMarca ? "Modificar Marca" : "Modificar Categoría";
                    labelTipoPorAgregar.Text = isMarca ? "Seleccione una Marca y modifique:" : "Seleccione una Categoría y modifique:";
                    textBox1.Enabled = true;
                    break;

                case ModoOperacion.Eliminar:
                    Text = isMarca ? "Eliminar Marca" : "Eliminar Categoría";
                    labelTipoPorAgregar.Text = isMarca ? "Seleccione una Marca para eliminar:" : "Seleccione una Categoría para eliminar:";
                    textBox1.Enabled = false;
                    break;
            }

        }
        // Carga de datos en el DataGridView para Marcas
        private void CargarFormularioMarca()
        {
            dgv.DataSource = new MarcaNegocio().ListarMarcas();
            dgv.Columns["ID"].Visible = false;
        }
        // Carga de datos en el DataGridView para Categorias
        private void CargarFormularioCategoria()
        {
            dgv.DataSource = new CategoriaNegocio().ListarCategorias();
            dgv.Columns["ID"].Visible = false;
        }
        // Manejo de la seleccion en el DataGridView
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (modo == ModoOperacion.Agregar)
                return;
            if (dgv.CurrentRow != null)
            {
                idSeleccionado = (int)dgv.CurrentRow.Cells["ID"].Value;
                textBox1.Text = dgv.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }
        // Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMarca)
                {
                    MarcaNegocio negocio = new MarcaNegocio();

                    switch (modo)
                    {
                        case ModoOperacion.Agregar:
                            negocio.AgregarMarca(new Marca { Descripcion = textBox1.Text.Trim() });
                            MessageBox.Show("Marca agregada correctamente");
                            break;

                        case ModoOperacion.Modificar:
                            if (idSeleccionado <= 0)
                            {
                                MessageBox.Show("Debe seleccionar una marca de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            negocio.ModificarMarca(new Marca { Id = idSeleccionado, Descripcion = textBox1.Text.Trim() });
                            MessageBox.Show("Marca modificada correctamente");
                            break;

                        case ModoOperacion.Eliminar:
                            DialogResult dialog  = MessageBox.Show("Deseas eliminar definitivamente el elemento?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.No) break;
                            negocio.EliminarMarca(idSeleccionado);
                            MessageBox.Show("Marca eliminada correctamente");
                            break;
                    }

                    CargarFormularioMarca();
                }
                else
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();

                    switch (modo)
                    {
                        case ModoOperacion.Agregar:
                            negocio.AgregarCategoria(new Categoria { Descripcion = textBox1.Text.Trim() });
                            MessageBox.Show("Categoría agregada correctamente");
                            break;

                        case ModoOperacion.Modificar:
                            negocio.ModificarCategoria(new Categoria { Id = idSeleccionado, Descripcion = textBox1.Text.Trim() });
                            MessageBox.Show("Categoría modificada correctamente");
                            break;

                        case ModoOperacion.Eliminar:
                            DialogResult dialog = MessageBox.Show("Deseas eliminar definitivamente el elemento?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialog == DialogResult.No) break;
                            negocio.EliminarCategoria(idSeleccionado);
                            MessageBox.Show("Categoría eliminada correctamente");
                            break;
                    }
                    CargarFormularioCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
