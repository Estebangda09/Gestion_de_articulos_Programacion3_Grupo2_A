namespace WindowsFormsApp1
{
    partial class FrmDetalleArticulo
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
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoArttextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewdetalle = new System.Windows.Forms.DataGridView();
            this.imagenpictureBox = new System.Windows.Forms.PictureBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Atrasbutton = new System.Windows.Forms.Button();
            this.Vercodigosbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VercodigoslistBox = new System.Windows.Forms.ListBox();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de los articulos (busque alguno en particular)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ponga el Codigo del Articulo";
            // 
            // CodigoArttextBox
            // 
            this.CodigoArttextBox.Location = new System.Drawing.Point(218, 114);
            this.CodigoArttextBox.Name = "CodigoArttextBox";
            this.CodigoArttextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoArttextBox.TabIndex = 2;
            // 
            // dataGridViewdetalle
            // 
            this.dataGridViewdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdetalle.Location = new System.Drawing.Point(32, 140);
            this.dataGridViewdetalle.Name = "dataGridViewdetalle";
            this.dataGridViewdetalle.Size = new System.Drawing.Size(616, 274);
            this.dataGridViewdetalle.TabIndex = 3;
            // 
            // imagenpictureBox
            // 
            this.imagenpictureBox.Location = new System.Drawing.Point(687, 140);
            this.imagenpictureBox.Name = "imagenpictureBox";
            this.imagenpictureBox.Size = new System.Drawing.Size(269, 181);
            this.imagenpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenpictureBox.TabIndex = 4;
            this.imagenpictureBox.TabStop = false;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(386, 114);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // Atrasbutton
            // 
            this.Atrasbutton.Location = new System.Drawing.Point(761, 358);
            this.Atrasbutton.Name = "Atrasbutton";
            this.Atrasbutton.Size = new System.Drawing.Size(75, 23);
            this.Atrasbutton.TabIndex = 6;
            this.Atrasbutton.Text = "atras";
            this.Atrasbutton.UseVisualStyleBackColor = true;
            this.Atrasbutton.Click += new System.EventHandler(this.Atrasbutton_Click);
            // 
            // Vercodigosbutton
            // 
            this.Vercodigosbutton.Location = new System.Drawing.Point(1055, 69);
            this.Vercodigosbutton.Name = "Vercodigosbutton";
            this.Vercodigosbutton.Size = new System.Drawing.Size(241, 23);
            this.Vercodigosbutton.TabIndex = 7;
            this.Vercodigosbutton.Text = "Haga click,para que le muestre los codigos";
            this.Vercodigosbutton.UseVisualStyleBackColor = true;
            this.Vercodigosbutton.Click += new System.EventHandler(this.Vercodigosbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(951, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VercodigoslistBox
            // 
            this.VercodigoslistBox.FormattingEnabled = true;
            this.VercodigoslistBox.Location = new System.Drawing.Point(1104, 140);
            this.VercodigoslistBox.Name = "VercodigoslistBox";
            this.VercodigoslistBox.Size = new System.Drawing.Size(120, 212);
            this.VercodigoslistBox.TabIndex = 9;
            this.VercodigoslistBox.SelectedIndexChanged += new System.EventHandler(this.VercodigoslistBox_SelectedIndexChanged);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(525, 114);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton.TabIndex = 10;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // FrmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 450);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.VercodigoslistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vercodigosbutton);
            this.Controls.Add(this.Atrasbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.imagenpictureBox);
            this.Controls.Add(this.dataGridViewdetalle);
            this.Controls.Add(this.CodigoArttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleArticulo";
            this.Text = "FrmDetalleArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoArttextBox;
        private System.Windows.Forms.DataGridView dataGridViewdetalle;
        private System.Windows.Forms.PictureBox imagenpictureBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Atrasbutton;
        private System.Windows.Forms.Button Vercodigosbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox VercodigoslistBox;
        private System.Windows.Forms.Button Limpiarbutton;
    }
}