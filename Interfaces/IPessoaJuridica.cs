using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProj.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string parCnpj);
    }
}