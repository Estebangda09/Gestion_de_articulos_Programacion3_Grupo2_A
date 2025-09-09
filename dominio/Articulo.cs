using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
       // public int IdArticulo { get; set;}
        public string Codigo {  get; set; }
        public string Nombre{ get; set; }
        public string Descricpcion {  get; set; }
      /// <summary>
      ///  public int IdMarca { get; set; }
      /// </summary>
      ////  public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        /// <summary>
        /// public Imagen ImagenUrl { get; set; }
        /// </summary>
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();
        public Categoria    tipo { get; set; }
        public Marca marca { get; set; }






    }
}
