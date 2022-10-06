using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProj.Interfaces;

namespace BackEndProj.Classes
{
    public class PessoaJuridica : IPessoaJuridica
    {
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }

        public bool ValidarCnpj(string parCnpj)
        {
            throw new NotImplementedException();
        }
    }
}