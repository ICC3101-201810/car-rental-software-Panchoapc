using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum TipoVehiculo {Auto, Acuatico, Moto, Camion, Bus, MaquinariaPesada }
    class Vehiculo
    {
        TipoVehiculo Tipo;

        public Vehiculo(TipoVehiculo miTipo)
        {
            Tipo = miTipo;
        }
    }
}
