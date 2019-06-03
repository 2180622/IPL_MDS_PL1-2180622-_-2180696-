using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class CarroVenda
    {
        public CarroVenda(string nrChassis, string marca, string modelo, string combustivel, string extras)
        {
            this.NumeroChassis = nrChassis;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Extras = extras;
        }

        public CarroVenda()
        {
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " Extras: " + Extras;
        }
    }
}
