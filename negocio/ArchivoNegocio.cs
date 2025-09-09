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
              ///  comando.CommandText = "select Codigo, Nombre, Descripcion, Precio, ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE A.Id = I.IdArticulo";
                /// ////matias
                 comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
    "       ISNULL(I1.ImagenUrl, '') AS ImagenUrl, " +
    "       ISNULL(C.Id, 0) AS IdCategoria, ISNULL(C.Descripcion, '') AS Categoria, " +
    "       ISNULL(M.Id, 0) AS IdMarca,    ISNULL(M.Descripcion, '') AS Marca " +
    "FROM Articulos A " +
    "OUTER APPLY ( " +
    "    SELECT TOP 1 ImagenUrl " +
    "    FROM Imagenes I " +
    "    WHERE I.IdArticulo = A.Id " +
    "    ORDER BY I.Id " +
    ") I1 " +
    "LEFT JOIN Categorias C ON A.IdCategoria = C.Id " +
    "LEFT JOIN Marcas     M ON A.IdMarca     = M.Id";


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
                  "INSERT INTO Articulos (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) " +
                  "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdCategoria, @IdMarca)"
              );

                
                datos.SetearParametros("@Codigo", articulo.Codigo);                 
                datos.SetearParametros("@Nombre", articulo.Nombre);                 
                datos.SetearParametros("@Descripcion", articulo.Descricpcion);       
                datos.SetearParametros("@Precio", articulo.Precio);                 
                datos.SetearParametros("@IdCategoria", articulo.tipo.Id);           
                datos.SetearParametros("@IdMarca", articulo.marca.Id);

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
