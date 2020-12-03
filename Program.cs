using System;
using Projeto_01.Entities;
using System.Windows;
using Projeto_01.Repositories;

namespace Projeto_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            try
            {
                var Cliente_Repository = new ClienteRepository();
                Console.WriteLine("\n - PROJETO CONTROLE DE CLIENTES - \n");

                //Console.ReadKey();
                Console.WriteLine("\n - Selecione uma das opções abaixo para continuar - ");
                Console.WriteLine("\n Digite 1 para ler os dados");
                Console.WriteLine("\n Digite 2 para gravar um novo registro");
                Console.WriteLine("\n Digite 3 para sair do programa");
                var opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    var conteudo = Cliente_Repository.LerDados();
                    Console.WriteLine(conteudo);
                    Main(args);
                }
                else if (opcao == "2")
                {
                    Console.Write("Informe o Id do Cliente........: ");
                    cliente.Id = int.Parse(Console.ReadLine());
                    Console.Write("Informe o Nome do Cliente..........: ");
                    cliente.Nome = Console.ReadLine();
                    Console.Write("Informe o email do Cliente.........: ");
                    cliente.Email = Console.ReadLine();
                    Console.Write("Informe o CPF do Cliente...........: ");
                    cliente.Cpf = Console.ReadLine();
                    Cliente_Repository.GravarDados(cliente);
                    Main(args);
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("\n - Fim do programa - \n");
                    Environment.Exit(0);
                }
                                    
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message + "." + "\nDigite uma tecla para retornar");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                
            }
            
           
        }
        
    }
}
