using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Articulo
    {
        public int IdArticulo { get; set;}
        public string Codigo {  get; set; }
        public string Nombre{ get; set; }
        public string Descricpcion {  get; set; }
        //public int IdMarca { get; set; }
       public int IdCategoria { get; set; }
        public decimal Precio { get; set; }

      
       

        public List<Imagen> Imagenes { get; set; }
        public Marca Marca { get; internal set; }
        public Categoria Categoria { get; internal set; }

        public Articulo()
        {
            Imagenes = new List<Imagen>();
        }

    }
}
