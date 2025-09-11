using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class FrmDetalleArticulo : Form
    {
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            /// buscararticulo(CodigoArttextBox.Text);
            Articulo articulo = new Articulo();

            if (CodigoArttextBox.Text == "" ) 
            {
                MessageBox.Show("pongo un coidgo valido");
            }

            try
            {
               articulo= buscararticulo(CodigoArttextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                
               
                return;
            }

            if (articulo != null) 
            {
                MessageBox.Show("no se encontro");
            }



           
        }


        public Articulo buscararticulo (string articulo)
        {

           AccesoDatos accesoDatos = new AccesoDatos();






                try
                {

                    accesoDatos.SetearConsulta("select Codigo, Nombre, Descripcion, Precio,IdMarca,IdCategoria from ARTICULOS where Codigo = @Codigo");
                    accesoDatos.SetearParametros("@codigo",articulo);
                    accesoDatos.EjecutarLectura();

                if (accesoDatos.Lector.Read())
                {


                    Articulo aux = new Articulo();

                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descricpcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    /*
                    aux.ImagenUrl = new Imagen();
                    aux.ImagenUrl.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];*/
                    aux.tipo = new Categoria();
                    aux.marca = new Marca();



                    aux.tipo.Id = (int)accesoDatos.Lector["IdCategoria"];


                    aux.marca.Id = (int)accesoDatos.Lector["IdMarca"];




                    return aux;
                }



                    return null;




                }
                catch (Exception ex)
                {

                    throw ex;
                }

                finally
                {
                    accesoDatos.CerrarConexion();

                }
            
            





            
        }

        private void dataGridViewdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


      
        }
    }
}
    
    







