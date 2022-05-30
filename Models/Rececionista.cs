using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Rececionista : Pessoa, IRececionista
    {
        public Rececionista()
        {
        }

        public Rececionista(string nome, int nif, string telemovel) : base(nome, nif, telemovel)
        {
        }

        public override void ApresentarSe()
        {
            System.Console.WriteLine("Prazer, sou a rececionista " + Nome);
            System.Console.WriteLine();
        }

        public void AtenderOTelefone()
        {
            System.Console.WriteLine("Sei atender o telefone.");;
            System.Console.WriteLine();
        }

        public void FalarOBasicoDeIngles()
        {
            System.Console.WriteLine("Sei falar o básico de Inglês.");
            System.Console.WriteLine();
        }
    }
}