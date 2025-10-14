using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Api_Articulo.Models
{
    public class ArticuloDto
    {
        

        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public List<string> Imagenes { get; set; } = new List<string>();

        public int IDCtegoria { get; set; }

        public int IDMarca { get; set; }
        

        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }





    }
}