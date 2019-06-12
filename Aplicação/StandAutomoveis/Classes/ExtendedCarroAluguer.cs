using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class CarroAluguer
    {
        public CarroAluguer(string combustivel, string estado, string marca, string matricula, string modelo, string nrChassis)
        {
            this.Combustivel = combustivel;
            this.Estado = estado;
            this.Marca = marca;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.NumeroChassis = nrChassis;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo +  " | " + Estado + " | " + Combustivel;
        }
    }
}
