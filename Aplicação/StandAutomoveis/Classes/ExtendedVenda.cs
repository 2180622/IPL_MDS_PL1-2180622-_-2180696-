using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Venda
    {
        public Venda(decimal valor, string estado, DateTime data)
        {
            this.Valor = valor;
            this.Estado = estado;
            this.Data = data;
        }

        public Venda()
        {
        }

        public override string ToString()
        {
            return Valor + "€  " + Estado + "  Vendido a: " + Data.ToShortDateString();
        }
    }
}
