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

        // GET: api/Articulo/5
        public Articulo Get(int id)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            List <Articulo> lista = negocio.Listar();

            return lista.Find(x=> x.Id == id);
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
        public void Delete(int id)
        {
        }
    }
}
