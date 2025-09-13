namespace WindowsFormsApp1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(381, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al Sistema";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListarToolStripMenuItem,
            this.BuscarToolStripMenuItem,
            this.detallesDeLosArticulosToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.menuToolStripMenuItem.Text = "Articulos";
            // 
            // ListarToolStripMenuItem
            // 
            this.ListarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem";
            this.ListarToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.ListarToolStripMenuItem.Text = "Listado de Articulos";
            this.ListarToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // BuscarToolStripMenuItem
            // 
            this.BuscarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem";
            this.BuscarToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.BuscarToolStripMenuItem.Text = "Buscar Articulos";
            this.BuscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
            // 
            // detallesDeLosArticulosToolStripMenuItem
            // 
            this.detallesDeLosArticulosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.detallesDeLosArticulosToolStripMenuItem.Name = "detallesDeLosArticulosToolStripMenuItem";
            this.detallesDeLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.detallesDeLosArticulosToolStripMenuItem.Text = "Detalles de los Articulos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarArticulo,
            this.categoríaToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(157, 26);
            this.btnAgregarArticulo.Text = "Artículo";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarArticulo});
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // ModificarArticulo
            // 
            this.ModificarArticulo.Name = "ModificarArticulo";
            this.ModificarArticulo.Size = new System.Drawing.Size(224, 26);
            this.ModificarArticulo.Text = "Articulo";
            this.ModificarArticulo.Click += new System.EventHandler(this.ModificarArticulo_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EliminarArticulo});
            this.eliminarToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // EliminarArticulo
            // 
            this.EliminarArticulo.Name = "EliminarArticulo";
            this.EliminarArticulo.Size = new System.Drawing.Size(144, 26);
            this.EliminarArticulo.Text = "Artículo";
            this.EliminarArticulo.Click += new System.EventHandler(this.EliminarArticulo_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem detallesDeLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EliminarArticulo;

    }
}