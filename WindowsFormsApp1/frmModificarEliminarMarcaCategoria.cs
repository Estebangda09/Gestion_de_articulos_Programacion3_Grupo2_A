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
        bool isMarca = false;
        public frmAgregarMarcaCategoriaSimple()
        {
            InitializeComponent();
        }

        public frmAgregarMarcaCategoriaSimple(bool isMarca)
        {
            this.isMarca = isMarca;
            InitializeComponent();

            if (isMarca)
            {
                Text = "Agregando Marca...";
                labelTipoPorAgregar.Text = "Ingrese el nombre de la Marca a agregar:";
                CargarFormularioMarca();
            }
            else
            {
                Text = "Agregando Categoria...";
                labelTipoPorAgregar.Text = "Ingrese la Categoria a agregar:";
                CargarFormularioCategoria();
            }
        }

        private void CargarFormularioMarca()
        {
            dgv.DataSource = new MarcaNegocio().ListarMarcas();
            dgv.Columns["ID"].Visible = false;
        }

        private void CargarFormularioCategoria()
        {
            dgv.DataSource = new CategoriaNegocio().ListarCategorias();
            dgv.Columns["ID"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor llene los campos obligatorios antes de aceptar",
                        "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isMarca)
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    Marca marca = new Marca();
                    marca.Descripcion = textBox1.Text.Trim();
                    negocio.AgregarMarca(marca);
                    MessageBox.Show("Marca Agregada", "Agregado",MessageBoxButtons.OK);
                    CargarFormularioMarca();
                }
                else
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    Categoria categoria = new Categoria();
                    categoria.Descripcion = textBox1.Text.Trim();
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Categoria Agregada", "Agregado", MessageBoxButtons.OK);
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
