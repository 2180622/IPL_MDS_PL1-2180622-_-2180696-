using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Cliente
    {
        BDStandContainer BDStand;

        public Cliente(string nome, string morada, string nif, int contacto)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.NIF = nif;
            this.Contacto = contacto;
        }

       /* public float Total
        {
            get
            {
                //instacia o internoTotal como 0 para inicar a variavel
                float internoTotal = 0;

                foreach (Carro item in BDStand.Carros)
                {

                    internoTotal += item.Valor;

                }

                return internoTotal;

            }

        }*/
        public override string ToString()
        {
            return Nome + "(" + NIF + ")" + " Contacto: " + Contacto;
        }
    }
}
