using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Servico
    {
        BDStandContainer BDStand;
        public float Valor;

        public Servico(string tipo, DateTime dataEntrada, DateTime dataSaida)
        {
            this.Parcelas = new HashSet<Parcela>();
            this.Tipo = tipo;
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;
        }

        /*public decimal Total
        {
            get
            {
                //instacia o internoTotal como 0 para inicar a variavel
                decimal internoTotal = 0;

                foreach (Parcela item in BDStand.Parcelas.ToList())
                {

                    internoTotal += item.Valor;

                }

                return internoTotal;

            }
            
        }*/

        public override string ToString()
        {
            return "Entrada:" + DataEntrada.ToShortDateString()  + " | Tipo de serviço: " + Tipo + " | Saída: " + DataSaida.ToShortDateString();
        }
    }
}