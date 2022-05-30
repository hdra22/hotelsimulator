using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, int nif, string telemovel) : base(nome, nif, telemovel)
        {
        }

       public override void ApresentarSe()
       {
           System.Console.WriteLine("Prazer, sou o gerente " + Nome);;
           System.Console.WriteLine();
       }
       public void AtenderOTelefone()
       {
           System.Console.WriteLine("Sou gerente e sei atender o telefone.");;
           System.Console.WriteLine();
       }

       public void ConhecerMuitoBemOHotel()
       {
           System.Console.WriteLine("Sou gerente e conheço tudo no Hotel.");
           System.Console.WriteLine();
       }

       public void FalarOBasicoDeIngles()
       {
           System.Console.WriteLine("Sou gerente e sei falar o básico de Inglês.");
           System.Console.WriteLine();
       }

       public void FazerACama()
       {
           System.Console.WriteLine("Sou gerente e sei fazer a cama.");
           System.Console.WriteLine();
       }

       public void LimparOQuarto()
       {
           System.Console.WriteLine("Sou gerente e sei limpar o quarto");
           System.Console.WriteLine();
       }
    }
}