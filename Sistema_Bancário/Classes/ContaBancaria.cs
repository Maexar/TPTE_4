using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Bancário.Classes;

namespace Sistema_Bancário.Classes
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public decimal Saldo { get; private set; }
        public Cliente Titular { get; private set; }


        public void CadastrarConta(int numeroDaConta, Cliente titular)
        {

            while (true)
            {
                Console.WriteLine("Digite o NÚMERO da conta: ");

                try
                {
                    NumeroDaConta = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            }
            
            Console.WriteLine("Cadastrando Titular");
            Titular = new Cliente();
            Titular.CadastrarCliente();
        }   
        public void Depositar(decimal valor)
        {
 
            Saldo += valor;
       
        }

        public bool Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(decimal valor, ContaBancaria contaDestino)
        {
            
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
