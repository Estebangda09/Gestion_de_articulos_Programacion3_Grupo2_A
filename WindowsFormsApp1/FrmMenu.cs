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

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            
            form1.ShowDialog(); 
        }

        private void AgregararticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            
            frmArticulo.ShowDialog();
        }
    }
}
