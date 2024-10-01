using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Bancário.Classes;

namespace Sistema_Bancário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Bem vindo ao Banco Prosperidade!");
                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Exibir Dados do Cliente");
                Console.WriteLine("3 - Atualizar Dados do Cliente");
                Console.WriteLine("4 - Depositar");
                Console.WriteLine("5 - Sacar");
                Console.WriteLine("6 - Transferir");
                Console.WriteLine("0 - Sair");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\n Opção inválida. Tente Novamente \n");
                    opcao = -1;
                }

                switch (opcao)
                {
                    case 1:

                        Cliente cliente = new Cliente();
                        cliente.CadastrarCliente("nome", "cpf", "rua", "bairro", "cidade", "estado", "cep", "email", "telefone");

                        Console.WriteLine("Cliente Cadastrado com sucesso");
                        Console.WriteLine("Nome: " + cliente.Nome);
                        Console.WriteLine("CPF: " + cliente.Cpf);
                        Console.WriteLine("Rua: " + cliente.Endereco.Rua);
                        Console.WriteLine("Bairro: " + cliente.Endereco.Bairro);
                        Console.WriteLine("Cidade: " + cliente.Endereco.Cidade);
                        Console.WriteLine("Estado: " + cliente.Endereco.Estado);
                        Console.WriteLine("CEP: " + cliente.Endereco.Cep);
                        Console.WriteLine("Email: " + cliente.Email);
                        Console.WriteLine("Telefone: " + cliente.Telefone);



                        break;


                    case 2: 
                        
                        Cliente cli_Exibir = new Cliente();
                        cli_Exibir.ExibirDados();
                        break;
    
                    case 3:
                        int op; 
                        do
                        {
                            Console.WriteLine("Digite uma opção:");
                            Console.WriteLine("1 - Atualizar Endereço");
                            Console.WriteLine("2 - Atualizar Email");
                            Console.WriteLine("3 - Atualizar Telefone");

                            try
                            {
                                op = int.Parse(Console.ReadLine());
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("\n Opção inválida. Tente Novamente \n");
                                op = -1;
                            }

                            switch(op)
                            {
                                case 1:
                                    Cliente cli_End = new Cliente();
                                    cli_End.AtualizarEndereco("rua", "bairro", "cidade", "estado", "cep");
                                    Console.WriteLine("Endereço Atualizado com sucesso");
                                    Console.WriteLine("Rua: " + cli_End.Endereco.Rua);
                                    Console.WriteLine("Bairro: " + cli_End.Endereco.Bairro);
                                    Console.WriteLine("Cidade: " + cli_End.Endereco.Cidade);
                                    Console.WriteLine("Estado: " + cli_End.Endereco.Estado);
                                    Console.WriteLine("CEP: " + cli_End.Endereco.Cep);
                                    break;

                                case 2:
                                    Cliente Email_Att = new Cliente();
                                    Console.WriteLine("Digite o novo Email: ");
                                    Email_Att.AtualizarEmail(Console.ReadLine());
                                    Console.WriteLine("Email Atualizado com sucesso");
                                    Console.WriteLine("Email: " + Email_Att.Email);
                                    break;

                                case 3:
                                    Cliente Fone_Att = new Cliente();
                                    Console.WriteLine("Digite o novo Telefone: ");
                                    Fone_Att.AtualizarTelefone(Console.ReadLine());
                                    Console.WriteLine("Telefone Atualizado com sucesso");
                                    Console.WriteLine("Telefone: " + Fone_Att.Telefone);
                                    break;

                            }

                        }while(op != 0);

                        break;
                       
                }// switch



            }while(opcao != 0);

        }// main
    }// class Program
}// namespace
