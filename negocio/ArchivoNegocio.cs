using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio

{
    public class ArchivoNegocio
    {
        public List<Articulo> Listar()
        {

            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                ///conexion.ConnectionString = "Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=Esteban94*;";
                // matias
                conexion.ConnectionString = "server = .\\SQLEXPRESS02; database = CATALOGO_P3_DB; integrated security =true ;";

                
                comando.CommandType = System.Data.CommandType.Text;
                ////esteban
                /// comando.CommandText = "select Codigo, Nombre, Descripcion, Precio, ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE A.Id = I.IdArticulo";
                /// ////matias
                comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                      "I.ImagenUrl, " +
                      "C.Id AS IdCategoria, C.Descripcion AS Categoria, " +
                      "M.Id AS IdMarca, M.Descripcion AS Marca " +
                      "FROM Articulos A " +
                      "INNER JOIN Imagenes I ON A.Id = I.IdArticulo " +
                      "INNER JOIN Categorias C ON A.IdCategoria = C.Id " +
                      "INNER JOIN Marcas M ON A.IdMarca = M.Id";

                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                      
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descricpcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl = new Imagen();
                    aux.ImagenUrl.ImagenUrl = (string)lector["ImagenUrl"];
                   aux.tipo = new Categoria();
                    aux.marca = new Marca();



                   aux.tipo.Id = (int)lector["IdCategoria"];               
                    aux.tipo.Descripcion = (string)lector["Categoria"];
                    
                    aux.marca.Id = (int)lector["IdMarca"];
                    aux.marca.Descripcion = (string)lector["Marca"];



                    lista.Add(aux);

                }
                conexion.Close();

                return lista;


            }
            catch (Exception ex)
            {
                throw ex;
            }


           

        }
        public void Agregar (Articulo articulo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.SetearConsulta(
       "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio) " +
       "VALUES (" + articulo.Codigo + ", '" + articulo.Nombre + "', '" + articulo.Descricpcion + "', " + articulo.Precio + ")"
                   );

                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                datos.CerrarConexion();

            }
        }
     }   
    
}
