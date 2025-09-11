using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        [DisplayName("Código")]

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descricpcion { get; set; }
        
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();
        public Categoria    tipo { get; set; }
        public Marca marca { get; set; }

        public decimal Precio { get; set; }
        public Imagen ImagenUrl { get; set; }
    }
}
