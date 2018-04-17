using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum Accesorios { RadioBTh, GPS, RuedaRepuesto, CortinaVentana, Sillita}
    class Accesorio
    {
        List<Accesorios> accesorios;

        public Accesorio()
        {
            accesorios = new List<Accesorios>();
        }
        public void MostrarTiposAccesorios()
        {
            int i = 1;
            foreach (string acc in Enum.GetNames(typeof(Accesorios)))
            Console.WriteLine(i+".-"+acc);
            i++;
        }
        public void AgregarAccesorio(Accesorios a)
        {
            accesorios.Add(a);
        }
        

    }
}
