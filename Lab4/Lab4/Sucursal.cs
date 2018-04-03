using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Sucursal
    {
        string Region;
        List<Vehiculo> Vehiculos;

        public Sucursal(string miRegion)
        {
            Region = miRegion;
            Vehiculos = new List<Vehiculo>();
        }
    }
}
