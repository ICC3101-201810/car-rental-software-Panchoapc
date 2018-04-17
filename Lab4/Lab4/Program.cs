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
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("____________________________CAR RENTAL SOFTWARE _____________________________________");
            Console.WriteLine("_____________________________________________________________________________________\n\n");
            CarRental carRental = new CarRental();
            Console.WriteLine("Para comenzar, debe crear su empreza de Car Rental.\nLo primero sera la creacion de sus " +
                "sucrusales y en que lugar estaran localizadas. ");
            Console.WriteLine("Cuantas sucursales tendra su CarRental?");
            string NSuc = Console.ReadLine();
            int Nsuc;
            Int32.TryParse(NSuc, out Nsuc);
            Console.WriteLine("Creando sus {0} sucursales............",NSuc);
            Console.WriteLine("Perfecto, ahora debe designar sus sucursales " +
                "a alguna region e inscribir los autos que tenga cada una de estas.\n");
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
            //LAB del 17/08
            Console.WriteLine("Excelente! Ahora estamos listos para empezar a operar." +
                " Este programa se enviara a todas las sucursales para que pedan operar dia a dia.\n\n\n");
            Console.WriteLine("\t\t\t¡¡¡¡¡¡¡¡¡¡¡¡Bienvenido a Car Rental!!!!!!!!!!!!!!\nPara comenzar, seleccione la sucursal en " +
                "la que se encuentra.");
            carRental.MostrarSucursales();
            string succ = Console.ReadLine();
            int nsuc;
            Int32.TryParse(succ, out nsuc);
            Sucursal estaSuc = carRental.GetListaSucursales().ToList()[nsuc - 1];
            string userInput = "1";
            while (userInput != "0")
            {
                Console.WriteLine("____________________CAR RENTAL {0}!___________________", estaSuc.GetRegion().ToUpper());
                Console.WriteLine("Este es su Menu de inicio, aca debe seleccionar el numero " +
                    "de la opcion que desea que el programa ejecute:\n1.-Arrendar un vehiculo.\n2.-Recibir un vehiculo.\n0.-Salir del programa");
                userInput = Console.ReadLine();
                int intUserInput;
                Int32.TryParse(userInput, out intUserInput);
                if (userInput == "1")
                {
                    Console.WriteLine("Los vehiculos que tenemos para arrendar son:");
                    estaSuc.DisplayTipoVehiculos();
                    Console.WriteLine("Cual de estos vehiculos desea el cliente?\n1.-Auto\n2.-Bus.\n3.-Camion" +
                        "\n4.-Moto\n5.-Acuatico\n6.-MaquinariaPesada");
                    string TVeh = Console.ReadLine();
                    int Tvehiculos;
                    Int32.TryParse(TVeh, out Tvehiculos);
                    Tvehiculos = Tvehiculos - 1;
                    string tipoveh = Enum.GetName(typeof(TipoVehiculo), Tvehiculos);
                    TipoVehiculo tvEnum;
                    Enum.TryParse<TipoVehiculo>(TVeh, out tvEnum);
                    estaSuc.Arrendar(tvEnum);
                }
                
                
                
            }
            Console.WriteLine("Buenas noches!");
            Console.WriteLine("Apagando programa CAR RENTAL");
            Console.ReadKey();
        }
    }
}
