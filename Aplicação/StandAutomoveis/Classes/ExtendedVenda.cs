using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Venda
    {
        public Venda(decimal valor, string estado)
        {
            this.Valor = valor;
            this.Estado = estado;
        }

        public override string ToString()
        {
            return Valor + "€ " + Estado;
        }
    }
}
