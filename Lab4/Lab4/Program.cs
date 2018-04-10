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
            Console.WriteLine("Bienvenido a CarRental.\nPara comenzar, cuatas sucursales tendra su CarRental?");
            string NSuc = Console.ReadLine();
            int Nsuc;
            Int32.TryParse(NSuc, out Nsuc);
            for (int i = 1; i <= Nsuc; i++)
            {
                Console.WriteLine("En que region estara la sucursal numero {0}?",i);
                string region = Console.ReadLine();
                Sucursal sucursal = new Sucursal(region);
                carRental.AgregarSucursal(sucursal);
            }
            carRental.MostrarSucursales();
            Console.ReadKey();
        }
    }
}
