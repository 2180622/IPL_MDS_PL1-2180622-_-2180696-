using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Parcela
    {
        public Parcela(decimal valor, string descricao)
        {
            this.Valor = valor;
            this.Descricao = descricao;
        }

        public Parcela()
        {

        }

        public override string ToString()
        {
            return Descricao + "  " + " | " + Valor + "€";
        }
    }
}
