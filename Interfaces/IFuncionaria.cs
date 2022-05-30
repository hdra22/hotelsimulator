using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Interfaces
{
    public interface IFuncionaria : IPessoa
    {
        void FazerACama();
        void LimparOQuarto();
    }
}