using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis
{
    public partial class Cliente
    {

        public Cliente(string nome, string morada, string nif, int contacto)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.NIF = nif;
            this.Contacto = contacto;
        }

        public override string ToString()
        {
            return Nome + "(" + NIF + ")" + " Contacto: " + Contacto;
        }
    }
}
