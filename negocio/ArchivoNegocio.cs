using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                conexion.ConnectionString = "Server=localhost,1433; Database=CATALOGO_P3_DB; Integrated Security=False; User ID=sa; Password=Esteban94*;";
                //
                //
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, Descripcion, Precio, ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE A.Id = I.IdArticulo";
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
     }   
    
}
