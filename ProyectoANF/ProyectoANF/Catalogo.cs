using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoANF
{
    public class Catalogo
    {
        public int id { get; set; }
        public Empresa empresa { get; set; }
        public float cuenta { get; set; }
        public string nombre { get; set; }
        

    }
}
