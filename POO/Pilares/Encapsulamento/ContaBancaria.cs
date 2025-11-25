using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            
        }

        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial > 0)
            {
            Saldo = saldoInicial;
            return;
                
            }
        }

    public void Depositar (float valor)
        {
         if(valor >=0)
            {
                Saldo = valor ;
                return;
            }  

            System.Console.WriteLine($"Deposito invalido");
                
        }

    public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if(valor <= 0 && Saldo <= valor)
            {
                System.Console.WriteLine($"Saque inválido");
            }

            else
            {
                Saldo -= valor;
                System.Console.WriteLine($"Saque efetuado com sucesso");
                return;
            }

        }

    }
}