using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Persona : Cliente
    {
        bool Licencia;

        public Persona(string miNombre, bool miLicencia) : base(miNombre)
        {
            Licencia = miLicencia;
        }
    }
}
