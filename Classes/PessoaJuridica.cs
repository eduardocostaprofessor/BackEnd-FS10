using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProj.Interfaces;
using System.Text.RegularExpressions;

namespace BackEndProj.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }

        // Para rendimentos até R$5.000,00- desconto de 6%
        // Para rendimentos entre R$5.001,00 e R$10.000,00 - desconto de 8%
        // Para rendimentos acima de R$10.000,01 - desconto de 10%
        public override float PagarImposto(float parRendimento)
        {
            
            if( parRendimento <= 5000) 
            {
                return parRendimento - (parRendimento / 100) * 6; //desconta 6% do rendimento
            } 
            else if ( parRendimento >= 5001 && parRendimento <= 10000 )
            {
                return parRendimento - (parRendimento / 100) * 8; // desconta 8% do rendimento
            }
            
            return parRendimento - (parRendimento / 100) * 10; // desconta 10% do rendimento
        }

        public bool ValidarCnpj(string parCnpj)
        {
            
            // 55.664.305/0001-90 - 18
            // 55664305000190 - 14


            if(Regex.IsMatch( parCnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$" ))
            {
                //valida se tem o mil contra 0001
                if( parCnpj.Length == 18 )
                {
                    if( parCnpj.Substring(11, 4) == "0001" ){
                        return true;
                    }
                } 
                else if(parCnpj.Length == 14 )
                {
                    if( parCnpj.Substring(8, 4) == "0001" ){
                        return true;
                    }
                } 
                
            }

            return false;
        }
    }
}