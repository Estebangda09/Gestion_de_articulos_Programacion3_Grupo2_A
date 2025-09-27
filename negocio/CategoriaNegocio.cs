using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {

            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("select id,descripcion from CATEGORIAS");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
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

        public void AgregarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {

                throw new ArgumentException("La descripción no puede estar vacía o contener solo espacios en blanco.");
            }
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(
                       "INSERT INTO CATEGORIAS (Descripcion)" +
                       "VALUES (@Descripcion); "
                   );
                datos.SetearParametros("Descripcion", categoria.Descripcion);
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

        public void ModificarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                datos.SetearParametros("@Descripcion", categoria.Descripcion);
                datos.SetearParametros("@Id", categoria.Id);
                datos.EjecutarAccion();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EliminarCategoria(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE FROM CATEGORIAS  WHERE Id = @Id");
                datos.SetearParametros("@Id", id);
                datos.EjecutarAccion();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
    
    }

