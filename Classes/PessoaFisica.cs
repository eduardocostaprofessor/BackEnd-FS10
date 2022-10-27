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
            DateTime dataConvertida;

            if (DateTime.TryParse(parDtNasc, out dataConvertida))
            {
                Console.WriteLine($"Data Convertida: {dataConvertida}");
                DateTime dataAtual = DateTime.Today;
                Console.WriteLine($"Data Atual: {dataAtual}");
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                Console.WriteLine($"Anos Convertido: {anos}");

                if (anos >= 18)
                {
                    return true;
                }
            }

            return false;
        }
    }
}