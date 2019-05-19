using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class CarroOficina
    {
        public override string ToString()
        {
            return this.Marca + " " + this.Modelo + " " + this.Matricula + " | " + this.NumeroChassis + " | " + this.Kms + "Kms " + this.Combustivel + "L";
        }
    }
}
