using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoANF
{
    class Analisis
    {

        public Analisis(String cuenta, int anioAnterior, int anioSiguiente, float saldoAnterior, float saldoSiguiente)
        {
            this.cuenta = cuenta;
            this.anioAnterior = anioAnterior;
            this.anioSiguiente = anioSiguiente;
            this.saldoAnterior = saldoAnterior;
            this.saldoSiguiente = saldoSiguiente;
        }

        public string cuenta { get; set; }
        public int anioAnterior { get; set; }
        public int anioSiguiente { get; set; }
        public float saldoAnterior { get; set; }
        public float saldoSiguiente { get; set; }
    }
}
