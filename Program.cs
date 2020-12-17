using System;
using Projeto_01.Entities;
using System.Windows;
using Projeto_01.Repositories;

namespace Projeto_01
{
    //classe inicial
    public class Program
    {
        //método de execução do projeto
        static void Main(string[] args)
        {
            //criando objeto para a classe Cliente..
            var cliente = new Cliente();
            try
            {
                //Cria objeto para a classe ClienteRepository e menu para usuário
                var Cliente_Repository = new ClienteRepository();
                Console.WriteLine("\n - PROJETO CONTROLE DE CLIENTES - \n");
                Console.WriteLine("\n - Selecione uma das opções abaixo para continuar - ");
                Console.WriteLine("\n Digite 1 para ler os dados");
                Console.WriteLine("\n Digite 2 para gravar um novo registro");
                Console.WriteLine("\n Digite 3 para sair do programa");
                //Cria objeto para receber a opção selecionada pelo usuário
                var opcao = Console.ReadLine();
                //Usa o valor atribuido ao objeto "opcao" e executa a instrução 
                if (opcao == "1")
                {
                    //Cria objeto "conteudo" que recebe da classe "Cliente_Repository"
                    //os dados lidos pelo método "LerDados", no arquivo físico
                    //e os exibe na tela recarregando o método principal

                    var conteudo = Cliente_Repository.LerDados();
                    Console.WriteLine(conteudo);
                    Main(args);
                }
                else if (opcao == "2")
                {
                    //Recebe os dados digitados
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
                //exibe a msg de erro, pausa o processo até alguma tecla ser pressionada.
                //Após pressionar tecla, limpa a tela e retorna ao método principal.
                Console.WriteLine("\nOcorreu um erro: " + e.Message + "." + "\nDigite uma tecla para retornar");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                
            }
            
           
        }
        
    }
}
