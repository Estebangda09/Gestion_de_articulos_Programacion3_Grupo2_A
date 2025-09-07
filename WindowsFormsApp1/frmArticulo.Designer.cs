namespace WindowsFormsApp1
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.listImagenArticulo = new System.Windows.Forms.ListBox();
            this.buttonAgregarIMG = new System.Windows.Forms.Button();
            this.buttonEliminarIMG = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxVistaPrevia = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(47, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(47, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio: ";
            // 
            // textCodigo
            // 
            this.textCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCodigo.Location = new System.Drawing.Point(162, 87);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(324, 20);
            this.textCodigo.TabIndex = 1;
         
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Location = new System.Drawing.Point(162, 139);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(324, 20);
            this.textNombre.TabIndex = 2;
           
            // 
            // textDescripcion
            // 
            this.textDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescripcion.Location = new System.Drawing.Point(162, 191);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(324, 20);
            this.textDescripcion.TabIndex = 3;
      
            // 
            // textPrecio
            // 
            this.textPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrecio.Location = new System.Drawing.Point(162, 344);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(326, 20);
            this.textPrecio.TabIndex = 6;
         

            // 
            // comboMarca
            // 
            this.comboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(162, 242);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(324, 21);
            this.comboMarca.TabIndex = 4;
         
            // 
            // comboCategoria
            // 
            this.comboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(162, 291);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(324, 21);
            this.comboCategoria.TabIndex = 5;
         
            // 
            // listImagenArticulo
            // 
            this.listImagenArticulo.AccessibleDescription = "  ";
            this.listImagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listImagenArticulo.FormattingEnabled = true;
            this.listImagenArticulo.Location = new System.Drawing.Point(162, 385);
            this.listImagenArticulo.Name = "listImagenArticulo";
            this.listImagenArticulo.Size = new System.Drawing.Size(326, 95);
            this.listImagenArticulo.TabIndex = 7;
            this.listImagenArticulo.SelectedIndexChanged += new System.EventHandler(this.listImagenArticulo_SelectedIndexChanged);
            // 
            // buttonAgregarIMG
            // 
            this.buttonAgregarIMG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAgregarIMG.Location = new System.Drawing.Point(162, 486);
            this.buttonAgregarIMG.Name = "buttonAgregarIMG";
            this.buttonAgregarIMG.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarIMG.TabIndex = 8;
            this.buttonAgregarIMG.Text = "Agregar";
            this.buttonAgregarIMG.UseVisualStyleBackColor = true;
            this.buttonAgregarIMG.Click += new System.EventHandler(this.buttonAgregarIMG_Click);
            // 
            // buttonEliminarIMG
            // 
            this.buttonEliminarIMG.Location = new System.Drawing.Point(243, 486);
            this.buttonEliminarIMG.Name = "buttonEliminarIMG";
            this.buttonEliminarIMG.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarIMG.TabIndex = 9;
            this.buttonEliminarIMG.Text = "Eliminar";
            this.buttonEliminarIMG.UseVisualStyleBackColor = true;
       
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(52, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Imagen";
            
            // 
            // pictureBoxVistaPrevia
            // 
            this.pictureBoxVistaPrevia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxVistaPrevia.Location = new System.Drawing.Point(520, 111);
            this.pictureBoxVistaPrevia.Name = "pictureBoxVistaPrevia";
            this.pictureBoxVistaPrevia.Size = new System.Drawing.Size(276, 206);
            this.pictureBoxVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVistaPrevia.TabIndex = 16;
            this.pictureBoxVistaPrevia.TabStop = false;
           
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(563, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vista Previa Producto";
            
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGuardar.Location = new System.Drawing.Point(544, 456);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(110, 53);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiar.Location = new System.Drawing.Point(667, 456);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(109, 53);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCancelarArticulo
            // 
            this.buttonCancelarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarArticulo.Location = new System.Drawing.Point(792, 456);
            this.buttonCancelarArticulo.Name = "buttonCancelarArticulo";
            this.buttonCancelarArticulo.Size = new System.Drawing.Size(109, 53);
            this.buttonCancelarArticulo.TabIndex = 12;
            this.buttonCancelarArticulo.Text = "Cancelar";
            this.buttonCancelarArticulo.UseVisualStyleBackColor = false;
            this.buttonCancelarArticulo.Click += new System.EventHandler(this.buttonCancelarArticulo_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.buttonCancelarArticulo);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxVistaPrevia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEliminarIMG);
            this.Controls.Add(this.buttonAgregarIMG);
            this.Controls.Add(this.listImagenArticulo);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(961, 623);
            this.MinimumSize = new System.Drawing.Size(807, 585);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.ListBox listImagenArticulo;
        private System.Windows.Forms.Button buttonAgregarIMG;
        private System.Windows.Forms.Button buttonEliminarIMG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxVistaPrevia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelarArticulo;
    }
}