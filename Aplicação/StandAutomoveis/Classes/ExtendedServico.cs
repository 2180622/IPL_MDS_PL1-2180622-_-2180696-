﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Servico
    {
        public Servico(string tipo, DateTime dataEntrada, DateTime dataSaida)
        {
            this.Parcelas = new HashSet<Parcela>();
            this.Tipo = tipo;
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Entrada:" + DataEntrada.ToShortDateString()  + " | Tipo de serviço: " + Tipo + " | Saída: " + DataSaida.ToShortDateString();
        }
    }
}