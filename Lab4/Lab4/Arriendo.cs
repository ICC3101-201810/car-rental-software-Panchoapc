using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Arriendo
    {
        Cliente arrendatario;
        Vehiculo VehiculoArrendado;
        Accesorio Accesorio;

        public Arriendo( Cliente miArrendatario, Vehiculo miVehiculoArr, Accesorio MisAccesorios)
        {
            arrendatario = miArrendatario;
            VehiculoArrendado = miVehiculoArr;
            Accesorio = MisAccesorios;
        }
    }
}
