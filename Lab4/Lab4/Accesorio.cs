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
        Accesorios Accesorios;

        public Accesorio(Accesorios misAccesorios)
        {
            Accesorios = misAccesorios;
        }
    }
}
