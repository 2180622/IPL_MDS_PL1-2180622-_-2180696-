using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Servico
    {
        public Servico(string tipo)
        {
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return "Data de entrada:" + DataEntrada.ToShortDateString()  + " | Tipo de serviço: " + Tipo + " | Data de saída: " + DataSaida.ToShortDateString();
        }
    }
}