using System;
using System.Collections.Generic;
using System.Text;
using Projeto_01.Entities;
using System.IO;

namespace Projeto_01.Repositories
{
    public class ClienteRepository
    {
        private string path = @"H:\Projetos\Repositorio_local\COTI\Projeto01\Cliente.txt";
        
        public void GravarDados(Cliente cliente)
        {
            using (var Stream_Writer = new StreamWriter(path, true))
            {
                Stream_Writer.WriteLine("Id...........: " + cliente.Id);
                Stream_Writer.WriteLine("Nome.........: " + cliente.Nome);
                Stream_Writer.WriteLine("Email........: " + cliente.Email);
                Stream_Writer.WriteLine("CPF..........: " + cliente.Cpf);
                Stream_Writer.WriteLine("...");


            }
        }

        public string LerDados()
        {
            using (var Stream_Reader = new StreamReader(path))
            {
                return Stream_Reader.ReadToEnd();
            }
        }
    }
}
