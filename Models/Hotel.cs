using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class Hotel
    {
        public string Nome{get;set;}
        public Morada Morada{get;set;}
        public List<IRececionista> Rececionistas{get; private set;}

        public List<IFuncionaria> Funcionarias{get; private set;}
        public IGerente Gerente {get;private set;}

        #region Construtores
        public Hotel(string nome){
            Nome = nome;
            Rececionistas = new List<IRececionista>();
            Funcionarias = new List<IFuncionaria>();
        }

        public Hotel(string nome, Morada morada){
            Nome = nome;
            Morada = morada;
            Rececionistas = new List<IRececionista>();
            Funcionarias = new List<IFuncionaria>();
        }
        #endregion
    
    
        #region Métodos
        public void ContratarGerente(IGerente gerente){
            Gerente = gerente;
        }

        public void ContratarFuncionaria(IFuncionaria funcionaria){
            Funcionarias.Add(funcionaria);
        }


        public void ContratarRececionista(IRececionista rececionista){
            Rececionistas.Add(rececionista);
        }
        #endregion
    
    }
}