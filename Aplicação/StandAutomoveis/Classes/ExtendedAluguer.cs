using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Aluguer
    {
        public Aluguer(decimal valor, double kms)
        {
            this.Valor = valor;
            this.Kms = kms;
        }

        public override string ToString()
        {
            return this.DataInicio.ToLongDateString() + this.DataFim.ToLongDateString() + Valor + Kms;
        }
    }
}
