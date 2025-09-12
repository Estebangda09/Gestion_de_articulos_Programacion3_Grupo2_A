using dominio;
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
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            listar();

        }

        

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listar();

        }

        private void listar()
        {
            frmListarArticulos ListaArticulo = new frmListarArticulos();
            ListaArticulo.MdiParent = this;
            ListaArticulo.Show();
        }

       


     
        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();

            frmArticulo.ShowDialog();
        }


        private void detallesDeLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {  
         
             

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void detallesDeLosArticulosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
              FrmDetalleArticulo articulo = new FrmDetalleArticulo();

            articulo.ShowDialog();

        }
    }
}
