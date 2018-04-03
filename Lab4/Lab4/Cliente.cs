using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Cliente
    {
        string Nombre;

        public Cliente(string miNombre)
        {
            Nombre = miNombre;
        }
    }
}
