using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    enum TipoIndustria { Empresa, Organizacion, Institucion}
    class Industria : Cliente
    {
        TipoIndustria Tipo;
        bool Autorizacion;

        public Industria(string miNombre, bool miAutorizacion, TipoIndustria miTipo) : base(miNombre)
        {
            Autorizacion = miAutorizacion;
            Tipo = miTipo;
        }
    }
}
