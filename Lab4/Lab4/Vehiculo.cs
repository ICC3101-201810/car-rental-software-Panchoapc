using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum TipoVehiculo { Auto, Bus ,Camion, Moto ,Acuatico, MaquinariaPesada}
    class Vehiculo
    {
        TipoVehiculo Tipo;
        string Patente;
        int Costo;

        public Vehiculo(TipoVehiculo miTipo, string miPatente, int miCosto)
        {
            Tipo = miTipo;
            Patente = miPatente;
            Costo = miCosto;
        }
        public void DetallesVehiculo()
        {
            Console.WriteLine("Vehiculo tipo {0}\nPatente: {1}\nCosto: {2}", Tipo,Patente,Costo);
        }
        public TipoVehiculo GetTipoVehiculo()
        {
            return Tipo;
        }
    }
}
