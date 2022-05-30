using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

namespace HotelCSharp.Models
{
    public class RH : IRHTerceirizado
    {

        #region Atributos
        public string Nome{get;set;}
        public Hotel Hotel{get;set;}
        #endregion

        #region Construtores
        public RH(string nome, Hotel hotel){
            Nome = nome;
            Hotel = hotel;
        }
        #endregion


        public void ContratarFuncionaria(IFuncionaria funcionaria)
        {
            Hotel.Funcionarias.Add(funcionaria);
        }

        public void ContratarRececionista(IRececionista rececionista)
        {
            Hotel.Rececionistas.Add(rececionista);
        }

        public void PromoverParaGerente(Funcionaria funcionaria)
        {
            //Logica para entrevista
            if (funcionaria.NIF == 0)
            {
                throw new DocumentosInvalidosException("Regularize o seu NIF para que possa ser promovida");
            } else{
            Hotel.ContratarGerente(new Gerente(){
                Nome = funcionaria.Nome,
                NIF = funcionaria.NIF,
                Telemovel = funcionaria.Telemovel
            });
            }
        }

        public void PromoverParaGerente(Rececionista rececionista)
        {
            //Logica para entrevista
            if (rececionista.NIF == 0)
            {
                throw new DocumentosInvalidosException("Regularize o seu NIF para que possa ser promovida");
            } else {
            Hotel.ContratarGerente(new Gerente(){
                Nome = rececionista.Nome,
                NIF = rececionista.NIF,
                Telemovel = rececionista.Telemovel
            });
            }
        }
    }
}