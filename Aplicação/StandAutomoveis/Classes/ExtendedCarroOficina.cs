using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class CarroOficina
    {

        public CarroOficina(string Marca, string Modelo, string Matricula, string NumeroChassis, string Kms, string Combustivel)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Matricula = Matricula;
            this.NumeroChassis = NumeroChassis;
            this.Kms = Kms;
            this.Combustivel = Combustivel;
        }
        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Matricula + " | " + NumeroChassis + " | " + Kms + "Kms " + Combustivel + "L";
        }
    }
}
