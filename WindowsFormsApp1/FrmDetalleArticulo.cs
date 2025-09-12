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
        
    


        public Articulo buscararticulo (string articulo)
        {

           AccesoDatos accesoDatos = new AccesoDatos();






                try
                {

                accesoDatos.SetearConsulta("SELECT Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria " +
    "FROM Articulos " +
    "WHERE Codigo = @Codigo;");


                    accesoDatos.SetearParametros("@Codigo",articulo.Trim());
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
                MessageBox.Show("ANDA MAL0");
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

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();


            if (CodigoArttextBox.Text == "")
            {
                MessageBox.Show("pongo un codigo valido");
            }

            try
            {
                articulo = buscararticulo(CodigoArttextBox.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (articulo == null)
            {
                MessageBox.Show("no se encontro");
            }

            MessageBox.Show(articulo.Nombre.ToString());

        }
    }
}
    
    







