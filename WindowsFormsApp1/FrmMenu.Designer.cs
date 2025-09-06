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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregararticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificartoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(338, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al Sistema";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListarToolStripMenuItem,
            this.BuscarToolStripMenuItem,
            this.AgregararticuloToolStripMenuItem,
            this.ModificartoolStripMenuItem1,
            this.EliminarToolStripMenuItem,
            this.detallesDeLosArticulosToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Articulos";
            // 
            // ListarToolStripMenuItem
            // 
            this.ListarToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem";
            this.ListarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ListarToolStripMenuItem.Text = "Listado de Articulos";
            this.ListarToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // BuscarToolStripMenuItem
            // 
            this.BuscarToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem";
            this.BuscarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.BuscarToolStripMenuItem.Text = "Buscar Articulos";
            // 
            // AgregararticuloToolStripMenuItem
            // 
            this.AgregararticuloToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.AgregararticuloToolStripMenuItem.Name = "AgregararticuloToolStripMenuItem";
            this.AgregararticuloToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.AgregararticuloToolStripMenuItem.Text = "Agregar Aarticulos";
            this.AgregararticuloToolStripMenuItem.Click += new System.EventHandler(this.AgregararticuloToolStripMenuItem_Click);
            // 
            // ModificartoolStripMenuItem1
            // 
            this.ModificartoolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.ModificartoolStripMenuItem1.Name = "ModificartoolStripMenuItem1";
            this.ModificartoolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.ModificartoolStripMenuItem1.Text = "Modificar Articulos";
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.EliminarToolStripMenuItem.Text = "Eliminar Articulos";
            // 
            // detallesDeLosArticulosToolStripMenuItem
            // 
            this.detallesDeLosArticulosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.detallesDeLosArticulosToolStripMenuItem.Name = "detallesDeLosArticulosToolStripMenuItem";
            this.detallesDeLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.detallesDeLosArticulosToolStripMenuItem.Text = "Detalles de los Articulos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(841, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "    En lso iconos de articulos (arriba a la derecha)tiene las opciones,\r\n     par" +
    "a poder usar el el sistema correctamente";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregararticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificartoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeLosArticulosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}