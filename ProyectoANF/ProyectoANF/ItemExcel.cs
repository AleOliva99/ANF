using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoANF
{

    [System.Serializable]
    public class ItemExcel
    {
        public string empresa { get; set; }
        public string cuenta { get; set; }
        public string nombre { get; set; }
        public int year { get; set; }
        public float saldo { get; set; }

        public ItemExcel() { }

        public ItemExcel(Catalogo catalogo)
        {
            this.empresa = catalogo.empresa.nombre;
            this.cuenta = catalogo.cuenta.ToString();
            this.nombre = catalogo.nombre;
            this.year = catalogo.year;
            this.saldo = catalogo.saldo;
        }
    }
}
