using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRental carRental = new CarRental();
            Console.WriteLine("Bienvenido a CarRental.\nPara comenzar, cuantas sucursales tendra su CarRental?");
            string NSuc = Console.ReadLine();
            int Nsuc;
            Int32.TryParse(NSuc, out Nsuc);
            for (int i = 1; i <= Nsuc; i++)
            {
                Console.WriteLine("En que region estara la sucursal numero {0}?",i);
                string region = Console.ReadLine();
                Sucursal sucursal = new Sucursal(region);
                carRental.AgregarSucursal(sucursal);
                Console.WriteLine("Cuantos vehiculos tendra esta sucursal a su disposicion?");
                string NVeh = Console.ReadLine();
                int Nvehiculos;
                Int32.TryParse(NVeh, out Nvehiculos);
                for (int j = 0; j < Nvehiculos; j++)
                {
                    Console.WriteLine("Vehiculo n°{0}:\nQue tipo de vehiculo es:\n1.-Auto\n2.-Bus\n" +
                        "3.-Camion\n4.-Moto\n5.-Acuatico\n6.-MaquinariaPesada",j+1);
                    string TVeh = Console.ReadLine();
                    int Tvehiculos;
                    Int32.TryParse(TVeh, out Tvehiculos);
                    string tipoveh = Enum.GetName(typeof(TipoVehiculo), Tvehiculos - 1);
                    Console.WriteLine("Ingrese la patente del vehiculo tipo {0}.", tipoveh);
                    string Patente = Console.ReadLine();
                    Console.WriteLine("Ingrese el costo de arriendo del {0}.", tipoveh);
                    string Costo = Console.ReadLine();
                    int costo;
                    Int32.TryParse(Costo, out costo);
                    TipoVehiculo tvEnum;
                    Enum.TryParse<TipoVehiculo>(TVeh, out tvEnum);
                    Vehiculo newVehiculo = new Vehiculo(tvEnum, Patente, costo);
                    sucursal.AgregarVehiculo(newVehiculo);
                }
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("En que sucursal desea arrendar su vehiculo?");
            carRental.MostrarSucursales();

            foreach (Sucursal s in carRental.GetListaSucursales())
            {
                s.DisplayVehiculos();
                
            }
            Console.ReadKey();
        }
    }
}
