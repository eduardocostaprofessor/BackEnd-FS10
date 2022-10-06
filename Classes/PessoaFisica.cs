using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProj.Interfaces;

namespace BackEndProj.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string cpf { get; set; }
        public DateTime dataNacimento { get; set; }

        public bool ValidarDataNascimento(string parDtNasc)
        {
            throw new NotImplementedException();
        }
    }
}