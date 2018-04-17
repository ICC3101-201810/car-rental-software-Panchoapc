using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum TipoCliente { Persona, Empresa, Organizacion, Institucion }
    class Cliente
    {
        TipoCliente Tipo;
        string Nombre;
        string RUT;
        string TipoLicencia;

        public Cliente(TipoCliente miTipo, string miNombre, string miRUT, string miTipoLicencia)
        {
            Tipo = miTipo;
            Nombre = miNombre;
            RUT = miRUT;
            TipoLicencia = miTipoLicencia;
        }
    }
}
