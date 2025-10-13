using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dominio;
using negocio;

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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Articulo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Articulo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articulo/5
        public void Delete(int id)
        {
        }
    }
}
