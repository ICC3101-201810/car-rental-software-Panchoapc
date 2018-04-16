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
        List<Arriendo> Arriendos;

        public Sucursal(string miRegion)
        {
            Region = miRegion;
            Vehiculos = new List<Vehiculo>();
            Arriendos = new List<Arriendo>();
        }
        public string GetRegion()
        {
            return Region;
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }
        public void Arrendar(Vehiculo vehiculo)
        {
            // Vehiculos.Find(Predicate<Vehiculos> vehiculo);
        }
        
    }
}
