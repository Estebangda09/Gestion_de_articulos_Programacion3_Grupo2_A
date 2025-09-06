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
           
           /// dgvArchivos.Columns["ImagenUrl"].Visible = false;
            //cargarImagen(dgvArchivos.CurrentRow.Cells["ImagenUrl"].Value.ToString());
            //pbxArticulo.Load(listaArticulos[0].ImagenUrl);


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
    }
}
