using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProj.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(string parDtNasc);
    }
}