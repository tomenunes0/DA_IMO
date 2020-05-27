using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class Arrendamento
    {
        public override string ToString()
        {
            return "Data: " +InicioContrado+ " " + DuracaoMeses + " Renovavel: " + Renovavel + " a "+ Arrendatario;
        }
    }
}
