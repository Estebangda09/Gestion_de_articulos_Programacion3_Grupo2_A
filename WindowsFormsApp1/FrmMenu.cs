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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

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

        private void AgregararticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();

            frmArticulo.ShowDialog();
        }


        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();

            frmArticulo.ShowDialog();
        }

        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
