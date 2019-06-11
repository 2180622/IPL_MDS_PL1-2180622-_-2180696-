using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Carro
    {
        BDStandContainer BDStand;
        public float Valor;

        /*public float Total
        {
            get
            {
                //instacia o internoTotal como 0 para inicar a variavel
                float internoTotal = 0;

                foreach (Servico item in BDStand.Servicos)
                {

                    internoTotal += item.Valor;

                }

                return internoTotal;

            }

        }*/
    }
}
