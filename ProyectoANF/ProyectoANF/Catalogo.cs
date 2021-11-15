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
        public int cuenta { get; set; }
        public int cuentaEspecifica { get; set; }
        public string nombre { get; set; }
        public int year { get; set; }
        public float saldo { get; set; }

        public float GetCode()
        {
            return (cuenta + (0.1f * cuentaEspecifica));
        }
    }
}
