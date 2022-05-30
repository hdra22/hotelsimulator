using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Models
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
        }

        public Cliente(string nome, int nif, string telemovel) : base(nome, nif, telemovel)
        {
        }

        public override void ApresentarSe()
        {
            throw new NotImplementedException();
        }
    }
}