using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class CarRental
    {
        List<Sucursal> Sucursales;
        public CarRental()
        {
            Sucursales = new List<Sucursal>();
        }

        public void AgregarSucursal(Sucursal s)
        {
            Sucursales.Add(s);
        }
        public void MostrarSucursales()
        {
            Console.WriteLine("Las sucursales se encuentran en:");
            int i = 1;
            foreach (Sucursal s in Sucursales)
            {
                Console.WriteLine(i+".- "+s.GetRegion());
                i++;
            }
        }
        public List<Sucursal> GetListaSucursales()
        {
            return Sucursales;
        }




    }
}
