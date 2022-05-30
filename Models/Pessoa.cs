using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{   
    #region Atributos
    public abstract class Pessoa : IPessoa
    {
        public string Nome{get;set;}
        public int NIF{get;set;}
        public string Telemovel{get;set;}
    #endregion


    #region Construtores
    public Pessoa(){
    }

    public Pessoa(string nome, int nif, string telemovel){
        Nome = nome;
        NIF = nif;
        Telemovel = telemovel;
    }
    #endregion


    #region Métodos

    public virtual void ApresentarSe()
    {  
        System.Console.WriteLine("Sou o(a)" + Nome);
        System.Console.WriteLine();
    }

        #endregion

    }
}