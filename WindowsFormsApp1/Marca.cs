using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Marca
    {
       public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Articulo> Articulos { get; set; }

        public Marca()
        {
            Articulos = new List<Articulo>();
        }

       
    }
}
