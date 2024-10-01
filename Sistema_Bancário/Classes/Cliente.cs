using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Bancário.Classes;

namespace Sistema_Bancário.Classes
{
    internal class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Cli_Endereco Endereco { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }






        public void  CadastrarCliente(string nome, string cpf, string rua, string bairro, string cidade, string estado, string cep, string email, string telefone)
        {
            Console.WriteLine("Digite seu Nome: ");
            Nome = Console.ReadLine();
           
            Console.WriteLine("Digite o seu CPF: ");
            Cpf = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua Rua: ");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu Bairro: ");
            bairro = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua Cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu Estado: ");
            estado = Console.ReadLine();

            Console.WriteLine("Digite o seu CEP: ");
            cep = Console.ReadLine();
         
            Endereco = new Cli_Endereco(rua, bairro, cidade, estado, cep);
           
            Console.WriteLine("Digite o seu Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("Digite o seu Telefone: ");
            Telefone = Console.ReadLine();

        
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Rua: " + Endereco.Rua);
            Console.WriteLine("Bairro: " + Endereco.Bairro);
            Console.WriteLine("Cidade: " + Endereco.Cidade);
            Console.WriteLine("Estado: " + Endereco.Estado);
            Console.WriteLine("CEP: " + Endereco.Cep);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefone: " + Telefone);
        }


        public void AtualizarEndereco(string rua, string bairro, string cidade, string estado, string cep)
        {
           

            Console.WriteLine("Digite o nome da sua Rua: ");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu Bairro: ");
            bairro = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua Cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu Estado: ");
            estado = Console.ReadLine();

            Endereco = new Cli_Endereco(rua, bairro, cidade, estado, cep);

        }

        public void AtualizarEmail(string email)
        {
            Email = email;
        }

        public void AtualizarTelefone(string telefone)
        {
            Telefone = telefone;
        }


       
    }
}
