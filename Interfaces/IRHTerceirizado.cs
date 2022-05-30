using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Models;

namespace HotelCSharp.Interfaces
{
    public interface IRHTerceirizado
    {
        void ContratarFuncionaria(IFuncionaria funcionaria);

        void ContratarRececionista(IRececionista rececionista);

        void PromoverParaGerente(Funcionaria funcionaria);

        void PromoverParaGerente(Rececionista rececionista);
    }
}