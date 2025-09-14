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
        //metodo para listar articulos
        public List<Articulo> Listar()
        {
            
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {   //Comentar la que no usen 
                ///Esteban conexion a base 
                  conexion.ConnectionString = "Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=Esteban94*;";
                //Adrian
                //conexion = new SqlConnection("Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=BaseDeDatos#2;";
                // matias
                //conexion.ConnectionString = "server = .\\SQLEXPRESS02; database = CATALOGO_P3_DB; integrated security =true ;";

                comando.CommandType = System.Data.CommandType.Text;
                
                comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.Id, " +
                   "       ISNULL(I1.ImagenUrl, '') AS ImagenUrl, " +
                   "       ISNULL(C.Id, 0) AS IdCategoria, ISNULL(C.Descripcion, '') AS Categoria, " +
                   "       ISNULL(M.Id, 0) AS IdMarca,    ISNULL(M.Descripcion, '') AS Marca " +
                   "       FROM Articulos A " +
                   "       OUTER APPLY ( " +
                   "        SELECT TOP 1 ImagenUrl " +
                   "        FROM Imagenes I " +
                   "       WHERE I.IdArticulo = A.Id " +
                   "       ORDER BY I.Id " +
                   ") I1 " +
                   "LEFT JOIN Categorias C ON A.IdCategoria = C.Id " +
                   "LEFT JOIN Marcas     M ON A.IdMarca     = M.Id";



                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["ID"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl = new Imagen();
                    aux.ImagenUrl.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Marca = new Marca();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];

                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];

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
        //metodo para agregar articulos
        public int Agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Inserto el artículo
                    datos.SetearConsulta(
                        "INSERT INTO Articulos (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) " +
                        "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdCategoria, @IdMarca); " +
                        "SELECT SCOPE_IDENTITY();"
                    );

                    datos.SetearParametros("@Codigo", articulo.Codigo);
                    datos.SetearParametros("@Nombre", articulo.Nombre);
                    datos.SetearParametros("@Descripcion", articulo.Descripcion);
                    datos.SetearParametros("@Precio", articulo.Precio);
                    datos.SetearParametros("@IdCategoria", articulo.Categoria.Id);
                    datos.SetearParametros("@IdMarca", articulo.Marca.Id);


                    int idArticulo = Convert.ToInt32(datos.EjecutarEscalar());


                    if (!string.IsNullOrEmpty(articulo.ImagenUrl.ImagenUrl))
                    {
                        AccesoDatos datosImg = new AccesoDatos();
                        datosImg.SetearConsulta(
                            "INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)"
                        );
                        datosImg.SetearParametros("@IdArticulo", idArticulo);
                        datosImg.SetearParametros("@ImagenUrl", articulo.ImagenUrl.ImagenUrl);
                        datosImg.EjecutarAccion();
                        datosImg.CerrarConexion();
                    }

                    return idArticulo;
                }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        //metodo para modificar articulos
        public int Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datosImg = null;

            try
            {
                // Actualizo los campos principales del artículo
                datos.SetearConsulta(
                    "UPDATE Articulos " +
                    "SET Codigo = @Codigo, " +
                    "    Nombre = @Nombre, " +
                    "    Descripcion = @Descripcion, " +
                    "    Precio = @Precio, " +
                    "    IdCategoria = @IdCategoria, " +
                    "    IdMarca = @IdMarca " +
                    "WHERE Id = @Id;"
                );

                datos.SetearParametros("@Id", articulo.Id);
                datos.SetearParametros("@Codigo", articulo.Codigo);
                datos.SetearParametros("@Nombre", articulo.Nombre);
                datos.SetearParametros("@Descripcion", articulo.Descripcion);
                datos.SetearParametros("@Precio", articulo.Precio);
                datos.SetearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.SetearParametros("@IdMarca", articulo.Marca.Id);

                datos.EjecutarAccion();

                
                if (!string.IsNullOrEmpty(articulo.ImagenUrl?.ImagenUrl))
                {
                    datosImg = new AccesoDatos();
                    datosImg.SetearConsulta(
                        "IF EXISTS (SELECT 1 FROM Imagenes WHERE IdArticulo = @IdArticulo) " +
                        "   UPDATE Imagenes SET ImagenUrl = @ImagenUrl WHERE IdArticulo = @IdArticulo; " +
                        "ELSE " +
                        "   INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl);"
                    );
                    datosImg.SetearParametros("@IdArticulo", articulo.Id);
                    datosImg.SetearParametros("@ImagenUrl", articulo.ImagenUrl.ImagenUrl);
                    datosImg.EjecutarAccion();
                    datosImg.CerrarConexion();
                }

                return articulo.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();                    
            }
        }
        //metodo para eliminar articulos
        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("DELETE FROM CATALOGO_P3_DB.dbo.ARTICULOS WHERE Id = @Id");
                accesoDatos.SetearParametro("@Id", id);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }

}
