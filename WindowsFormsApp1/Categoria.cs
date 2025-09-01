using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Articulo> Articulos { get; set; }

        public Categoria()
        {
            Articulos = new List<Articulo>();
        }

    }
}
