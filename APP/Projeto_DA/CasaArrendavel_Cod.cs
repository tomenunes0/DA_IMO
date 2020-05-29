using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class CasaArrendavel
    {
        public override string ToString()
        {
            return "Arrendavel" + ": " + IdCasa + " " + Rua + " " + Localidade;
        }
    }
}
