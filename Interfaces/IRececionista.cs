using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Interfaces
{
    public interface IRececionista : IPessoa
    {
        void AtenderOTelefone();

        void FalarOBasicoDeIngles();
    }
}