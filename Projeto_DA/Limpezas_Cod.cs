using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    partial class Limpeza
    {

        public decimal total
        {
            get
            {
                Decimal temp = 0;
                foreach (Servico item in Servicos)
                {
                    temp += item.total;
                }
                return temp;
            }
        }

        public override string ToString()
        {
            return total + "€ a (" + Data + ")";
        }
    }
}
