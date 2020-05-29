 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class Servico
    {
        public decimal total;

        public override string ToString()
        {
            total = Valor * Unidades;
            return total + "€ "+ Unidades+"x [" + Unidades +" " + Descricao + "] ";
        }
    }
}
