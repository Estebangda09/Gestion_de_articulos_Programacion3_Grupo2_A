using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("select id, descripcion from MARCAS");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)accesoDatos.Lector["id"];
                    aux.Descripcion = (string)accesoDatos.Lector["descripcion"];
                    lista.Add(aux);
                }
                return lista;
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

        public void AgregarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(
                       "INSERT INTO MARCAS (Descripcion)" +
                       "VALUES (@Descripcion); "
                   );
                datos.SetearParametro("Descripcion", marca.Descripcion);
                datos.EjecutarAccion();

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
        public void ModificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datos.SetearParametro("@Descripcion", marca.Descripcion);
                datos.SetearParametro("@Id", marca.Id);
                datos.EjecutarAccion();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EliminarMarca(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM MARCAS WHERE Id = @Id");
                datos.SetearParametro("@Id", id);
                datos.EjecutarAccion();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}

