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
        public HttpResponseMessage Post([FromBody] ArticuloDto articulodto)
        {
            ArchivoNegocio archivoNegocio = new ArchivoNegocio();

            try
            {

                if (articulodto == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Faltan datos del artículo.");

                if (string.IsNullOrWhiteSpace(articulodto.Codigo) || string.IsNullOrWhiteSpace(articulodto.Nombre))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Código y Nombre son obligatorios.");

                if (articulodto.Precio < 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser negativo.");


                if (articulodto.IDMarca <= 0 || articulodto.IDCtegoria <= 0)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Marca y Categoría deben ser válidas.");


                var articulo = new Articulo
                {
                    Codigo = articulodto.Codigo.Trim(),
                    Nombre = articulodto.Nombre.Trim(),
                    Descripcion = string.IsNullOrWhiteSpace(articulodto.Descripcion) ? null : articulodto.Descripcion.Trim(),
                    Precio = articulodto.Precio,
                    Marca = new Marca { Id = articulodto.IDMarca },
                    Categoria = new Categoria { Id = articulodto.IDCtegoria }
                };


                if (articulodto.Imagenes != null && articulodto.Imagenes.Count > 0)
                {
                    articulo.Imagenes = articulodto.Imagenes
                        .Where(u => string.IsNullOrWhiteSpace(u) == false)
                        .Distinct()
                        .Select(u => new Imagen { ImagenUrl = u })
                        .ToList();
                }

                if (string.IsNullOrWhiteSpace(articulodto.ImagenUrl) == false)
                {
                    articulo.ImagenUrl = new Imagen { ImagenUrl = articulodto.ImagenUrl };
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

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Articulo/5
        public HttpResponseMessage Delete(int id)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            List<Articulo> lista = new List<Articulo>();
            lista = negocio.Listar();

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

            string nombre = articulo.Nombre;
            negocio.Eliminar(id);

            return Request.CreateResponse(HttpStatusCode.OK, $"Articulo {id} - '{nombre}' ha sido eliminado con exito de la base de datos.");
        }

        //Modificar api/Articulo/{id}
        
        public IHttpActionResult ModificarProducto(int id, [FromBody] Articulo articulo)
        {
            if (id != articulo.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del producto enviado.");
            }

            try
            {
                ArchivoNegocio archivoNegocio = new ArchivoNegocio();
                if (!archivoNegocio.existe(id))
                {
                    return NotFound(); 
                }

                archivoNegocio.Modificar(articulo);

                return Ok("Producto modificado correctamente.");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
