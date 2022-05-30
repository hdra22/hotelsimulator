using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Funcionaria : Pessoa, IFuncionaria
    {
        public Funcionaria()
        {
        }

        public Funcionaria(string nome, int nif, string telemovel) : base(nome, nif, telemovel)
        {
        }

        public override void ApresentarSe()
        {
            System.Console.WriteLine("Prazer sou a funcionaria " + Nome);
            System.Console.WriteLine();
        }

        public void FazerACama()
        {
            System.Console.WriteLine("Sei fazer a cama.");
            System.Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            System.Console.WriteLine("Sei limpar o quarto");
            System.Console.WriteLine();
        }
    }
}