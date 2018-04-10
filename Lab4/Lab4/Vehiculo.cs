using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Vehiculo
    {
        string Patente;
        int Costo;

        public Vehiculo(string miPatente, int miCosto)
        {
            Patente = miPatente;
            Costo = miCosto;
        }
    }
}
