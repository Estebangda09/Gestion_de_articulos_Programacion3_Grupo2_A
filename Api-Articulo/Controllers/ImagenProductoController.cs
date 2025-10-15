using System;
using System.Collections.Generic;
using System.Web.Http;
using negocio;
using dominio; 

public class ImagenProductoController : ApiController
{
    [HttpPost]
    [Route("api/productos/{id}/imagenes")]
    public IHttpActionResult AgregarImagenesUrl(int id, [FromBody] List<string> urls)
    {
       
        ArchivoNegocio archivoNegocio = new ArchivoNegocio();
        if (!archivoNegocio.existe(id))
        {
            return NotFound(); 
        }

       
        if (urls == null || urls.Count == 0)
        {
            return BadRequest("No se proporcionaron URLs de imágenes.");
        }

        try
        {
            
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            foreach (string url in urls)
            {
                
                if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    
                    Imagen nuevaImagen = new Imagen();
                    nuevaImagen.IdArticulo = id;
                    nuevaImagen.ImagenUrl = url;

                    
                    imagenNegocio.AgregarImagen(nuevaImagen);
                }
            }

            return Ok("URLs agregadas correctamente.");
        }
        catch (Exception ex)
        {
           
            return InternalServerError(ex);
        }
    }
}