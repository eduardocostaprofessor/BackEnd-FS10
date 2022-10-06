using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BackEndProj.Interfaces;


namespace BackEndProj.Classes
{
    public class Pessoa : IPessoa
    {
        // atributos
        public string nome { get; set; }
        public string endereco { get; set; }
        public float rendimento { get; set; }

        public float PagarImposto(float parRendimento)
        {
            throw new NotImplementedException();
        }

        // métodos


    }
}