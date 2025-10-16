using Api_Articulo.Models;
using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace Api_Articulo.Controllers
{
    public class ArticuloController : ApiController
    {
        // GET: api/Articulo
        public IEnumerable<Articulo> Get()
        {
            ArchivoNegocio negocio = new ArchivoNegocio();

            return negocio.Listar();

        }

        // GET: api/Articulo/N
        public HttpResponseMessage Get(int id)
        {
            List<Articulo> lista = new ArchivoNegocio().Listar();

            if (id <= 0)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "El id debe ser mayor a 0.");

            Articulo articulo = null;
            foreach (var x in lista)
            {
                if (x.Id == id)
                {
                    articulo = x;
                    break;
                }
            }

            if (articulo == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"No existe el artículo con id {id}.");

            return Request.CreateResponse(HttpStatusCode.OK, articulo);
        }

        // POST: api/Articulo
        public HttpResponseMessage Post([FromBody] ArticuloDto articuloDto)
        {
            ArchivoNegocio archivoNegocio = new ArchivoNegocio();

            try
            {

                if (articuloDto == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Faltan datos del artículo.");

                if (string.IsNullOrWhiteSpace(articuloDto.Codigo) || string.IsNullOrWhiteSpace(articuloDto.Nombre))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Código y Nombre son obligatorios.");

                if (articuloDto.Precio < 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser negativo.");


                if (articuloDto.IDMarca <= 0 || articuloDto.IDCtegoria <= 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Marca y Categoría deben ser válidas.");


                var articulo = new Articulo
                {
                    Codigo = articuloDto.Codigo.Trim(),
                    Nombre = articuloDto.Nombre.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(articuloDto.Descripcion) ? null : articuloDto.Descripcion.Trim(),
                    Precio = articuloDto.Precio,
                    Marca = new Marca { Id = articuloDto.IDMarca },
                    Categoria = new Categoria { Id = articuloDto.IDCtegoria }
                };


                if (articuloDto.Imagenes != null && articuloDto.Imagenes.Count > 0)
                {
                    articulo.Imagenes = articuloDto.Imagenes
                        .Where(u => string.IsNullOrWhiteSpace(u) == false)
                        .Distinct()
                        .Select(u => new Imagen { ImagenUrl = u })
                        .ToList();
                }

                if (string.IsNullOrWhiteSpace(articuloDto.ImagenUrl) == false)
                {
                    articulo.ImagenUrl = new Imagen { ImagenUrl = articuloDto.ImagenUrl };
                }
                else
                {
                    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                        articulo.ImagenUrl = articulo.Imagenes[0];
                }

                archivoNegocio.Agregar(articulo);

                return Request.CreateResponse(HttpStatusCode.Created, "Artículo agregado correctamente.");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado.");
            }
        }

        public HttpResponseMessage Post(int id, [FromBody] ImagenesDto imagenesDto)
        {
            try
            {
                if (id <= 0)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "El id debe ser mayor a 0.");

                if (imagenesDto == null || imagenesDto.Imagenes == null || imagenesDto.Imagenes.Count == 0)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Debes enviar al menos una URL de imagen.");

                // (Opcional) verificar que el artículo exista
                var artNegocio = new ArchivoNegocio();
                if (!artNegocio.existe(id))
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"No existe el artículo con id {id}.");

                var imgNegocio = new ImagenNegocio();

                int agregadas = 0;
                foreach (var url in imagenesDto.Imagenes)
                {
                    if (string.IsNullOrWhiteSpace(url)) continue;

                    imgNegocio.AgregarImagen(new Imagen
                    {
                        IdArticulo = id,
                        ImagenUrl = url.Trim()
                    });
                    agregadas++;
                }

                return Request.CreateResponse(HttpStatusCode.Created, new
                {
                    Mensaje = "Imágenes agregadas.",
                    Agregadas = agregadas
                });
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado.");
            }
        }

        // PUT: api/Articulo/5
        public HttpResponseMessage Put(int id, [FromBody] ArticuloDto articuloDto)
        {
            try
            {
                if (articuloDto == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Faltan datos del artículo.");

                if (string.IsNullOrWhiteSpace(articuloDto.Codigo) || string.IsNullOrWhiteSpace(articuloDto.Nombre))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Código y Nombre son obligatorios.");

                if (articuloDto.Precio < 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser negativo.");


                if (articuloDto.IDMarca <= 0 || articuloDto.IDCtegoria <= 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Marca y Categoría deben ser válidas.");

                ArchivoNegocio archivoNegocio = new ArchivoNegocio();
                var articulo = new Articulo
                {
                    Id = id,
                    Codigo = articuloDto.Codigo.Trim(),
                    Nombre = articuloDto.Nombre.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(articuloDto.Descripcion) ? null : articuloDto.Descripcion.Trim(),
                    Precio = articuloDto.Precio,
                    Marca = new Marca { Id = articuloDto.IDMarca },
                    Categoria = new Categoria { Id = articuloDto.IDCtegoria }
                };


                if (articuloDto.Imagenes != null && articuloDto.Imagenes.Count > 0)
                {
                    articulo.Imagenes = articuloDto.Imagenes
                        .Where(u => string.IsNullOrWhiteSpace(u) == false)
                        .Distinct()
                        .Select(u => new Imagen { ImagenUrl = u })
                        .ToList();
                }

                if (string.IsNullOrWhiteSpace(articuloDto.ImagenUrl) == false)
                {
                    articulo.ImagenUrl = new Imagen { ImagenUrl = articuloDto.ImagenUrl };
                }
                else
                {
                    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                        articulo.ImagenUrl = articulo.Imagenes[0];
                }

                archivoNegocio.Modificar(articulo);

                return Request.CreateResponse(HttpStatusCode.OK, "Artículo agregado correctamente.");
            }
            catch (Exception)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado.");
            }
        }

  

        // DELETE: api/Articulo/N
        public HttpResponseMessage Delete(int id)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            List<Articulo> lista = new List<Articulo>();
            lista = negocio.Listar();

            if (id <= 0)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "El id debe ser mayor a 0.");

            if (!negocio.existe(id))
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"No existe el artículo con id {id}.");


            Articulo articulo = null;
            foreach (var x in lista)
            {
                if (x.Id == id)
                {
                    articulo = x;
                    break;
                }
            }          

            string nombre = articulo.Nombre;
            negocio.Eliminar(id);

            return Request.CreateResponse(HttpStatusCode.OK, $"Articulo {id} - '{nombre}' ha sido eliminado con exito de la base de datos.");
        }

        
    }
}
