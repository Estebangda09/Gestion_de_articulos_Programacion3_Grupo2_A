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
            this.artículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artículoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(286, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al Sistema";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Articulos";
            // 
            // ListarToolStripMenuItem
            // 
            this.ListarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem";
            this.ListarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ListarToolStripMenuItem.Text = "Listado de Articulos";
            this.ListarToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // BuscarToolStripMenuItem
            // 
            this.BuscarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem";
            this.BuscarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.BuscarToolStripMenuItem.Text = "Buscar Articulos";
            this.BuscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
            // 
            // detallesDeLosArticulosToolStripMenuItem
            // 
            this.detallesDeLosArticulosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.detallesDeLosArticulosToolStripMenuItem.Name = "detallesDeLosArticulosToolStripMenuItem";
            this.detallesDeLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.detallesDeLosArticulosToolStripMenuItem.Text = "Detalles de los Articulos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem,
            this.categoríaToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artículoToolStripMenuItem.Text = "Artículo";
            this.artículoToolStripMenuItem.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.categoríaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem1,
            this.categoríaToolStripMenuItem1,
            this.marcaToolStripMenuItem1});
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // artículoToolStripMenuItem1
            // 
            this.artículoToolStripMenuItem1.Name = "artículoToolStripMenuItem1";
            this.artículoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.artículoToolStripMenuItem1.Text = "Artículo";
            this.artículoToolStripMenuItem1.Click += new System.EventHandler(this.artículoToolStripMenuItem1_Click);
            // 
            // categoríaToolStripMenuItem1
            // 
            this.categoríaToolStripMenuItem1.Name = "categoríaToolStripMenuItem1";
            this.categoríaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.categoríaToolStripMenuItem1.Text = "Categoría";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem2,
            this.categoríaToolStripMenuItem2,
            this.marcaToolStripMenuItem2});
            this.eliminarToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // artículoToolStripMenuItem2
            // 
            this.artículoToolStripMenuItem2.Name = "artículoToolStripMenuItem2";
            this.artículoToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.artículoToolStripMenuItem2.Text = "Artículo";
            // 
            // categoríaToolStripMenuItem2
            // 
            this.categoríaToolStripMenuItem2.Name = "categoríaToolStripMenuItem2";
            this.categoríaToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.categoríaToolStripMenuItem2.Text = "Categoría";
            // 
            // marcaToolStripMenuItem2
            // 
            this.marcaToolStripMenuItem2.Name = "marcaToolStripMenuItem2";
            this.marcaToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem2.Text = "Marca";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem2;

    }
}