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
        public void DisplayVehiculos()
        {
            Console.WriteLine("Los vehiculos de la sucursal en {0} son:", Region);
            int i = 1;
            foreach (Vehiculo v in Vehiculos)
            {
                v.DetallesVehiculo();
                i++;
            }
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

        public void Arrendar(TipoVehiculo tipo)
        {
            List<Vehiculo> filtrado = Vehiculos.Where(veh => veh.GetTipoVehiculo() == tipo).ToList();
            Console.WriteLine("El cliente que desea arrendar el vehiculo es:\n1.-Persona2.-Empresa.\n3.-Organizacion.\n4.-Institucion.");
            string Tcli = Console.ReadLine();
            int Tcliente;
            Int32.TryParse(Tcli, out Tcliente);
            string tipocli = Enum.GetName(typeof(TipoVehiculo), Tcliente - 1);
            Console.WriteLine("RUT de la de la {0}.", tipocli);
            string rutCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la {0}.", tipocli);
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Que tipo de licencia tiene?");
            string licenciaCliente = Console.ReadLine();
            TipoCliente tcEnum;
            Enum.TryParse<TipoCliente>(Tcli, out tcEnum);
            Cliente cliente = new Cliente(tcEnum, nombreCliente, rutCliente, licenciaCliente);
            Console.WriteLine("Desea agregar algun accesorio a su compra?");
            Accesorio accesorio = new Accesorio();
            accesorio.MostrarTiposAccesorios();
            Console.WriteLine("0.- No Gracias");
            string TAcc = Console.ReadLine();
            while (TAcc != "0")
            {
                int Tacc;
                Int32.TryParse(TAcc, out Tacc);
                string tipoacc = Enum.GetName(typeof(Accesorios), Tacc - 1);
                Accesorios tcAcc;
                Enum.TryParse<Accesorios>(TAcc, out tcAcc);
                accesorio.AgregarAccesorio(tcAcc);
                Console.WriteLine("Desea agregar otro accesorio a su compra?");
                accesorio.MostrarTiposAccesorios();
                Console.WriteLine("0.- No Gracias");
                TAcc = Console.ReadLine();
            }
            Arriendo arriendo = new Arriendo(cliente, filtrado[0], accesorio);
            Arriendos.Add(arriendo);
            //var empList = Vehiculos.Where(emp => emp.GetTipoVehiculo() == tipo);
        }
        
    }
}
