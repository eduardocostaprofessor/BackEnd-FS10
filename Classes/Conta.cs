using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProj.Classes
{
    public abstract class Conta
    {
        public string agencia {get; private set; }
        public string conta { get; set; }
        private double saldo;

        //construtor padrão
        // public Conta()
        // {

        // }
        // //construtor sobrecarga 1
        // public Conta(string parAgencia, string parConta)
        // {
        //     this.agencia = parAgencia;
        //     this.conta = parConta;
        // }

        //construtor sobrecarga 2
        public Conta(string parAgencia, string parConta, double parSaldo)
        {
            this.agencia = parAgencia;
            this.conta = parConta;
            this.saldo = parSaldo;
        }


        // gets and sets - encapsulamento

        public void preencherAgencia(string ag){
            if( ag.Length >= 3 ){
                this.agencia = ag;
            }
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double s)
        {
            if (s > 0)
            {
                this.saldo = s;
            }
        }








    }
}