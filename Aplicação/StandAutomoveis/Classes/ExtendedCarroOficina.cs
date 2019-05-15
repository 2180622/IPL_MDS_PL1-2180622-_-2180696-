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
            return this.NumeroChassis + "Marca: " + this.Marca + " -" + this.Modelo + "  " + this.Matricula + " " + this.Kms + " Kms" + this.Combustivel + "L";
        }
    }
}
