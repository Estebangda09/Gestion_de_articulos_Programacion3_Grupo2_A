using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {


      public  List<Imagen> imagenes()
        {
            List<Imagen> imagenes = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("select id,Id,ImagenUrl from IMAGENES");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)accesoDatos.Lector["id"];
                    aux.IdArticulo = (int)accesoDatos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];


                    imagenes.Add(aux);


                }


            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                accesoDatos.CerrarConexion();
            }



            return imagenes;

        }


    }
}
