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
        
        


        public List<Articulo>buscararticulos (string articulo)
        {

           AccesoDatos accesoDatos = new AccesoDatos();

            
            List<Articulo> lista = new List<Articulo>();



                try
                {

                accesoDatos.SetearConsulta("SELECT  a.Codigo, a.Nombre, a.Descripcion, a.Precio,      m.Descripcion AS Marca,   c.Descripcion AS Categoria    FROM Articulos a LEFT JOIN Marcas m     ON m.Id = a.IdMarca  LEFT JOIN Categorias c ON c.Id = a.IdCategoria WHERE Codigo = @Codigo;");


                    accesoDatos.SetearParametros("@Codigo",articulo.Trim());
                    accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
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



                   // aux.tipo.Id = (int)accesoDatos.Lector["IdCategoria"];
                    aux.tipo.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    aux.marca.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                   // aux.marca.Id = (int)accesoDatos.Lector["IdMarca"];

                   lista.Add(aux);


                    
                   
                }
                return lista;



                




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
            List<Articulo>lista = new List<Articulo>();


            if (CodigoArttextBox.Text == "")
            {
                MessageBox.Show("pongo un codigo valido");
                return;
            }

            try
            {
                lista = buscararticulos(CodigoArttextBox.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (lista == null || lista.Count ==0)
            {
                MessageBox.Show("no se encontro");
                return;
            }

            dataGridViewdetalle.DataSource = null;
            dataGridViewdetalle.DataSource = lista;

        }

        private void Atrasbutton_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            frmMenu.ShowDialog();
        }
    }
}
    
    







