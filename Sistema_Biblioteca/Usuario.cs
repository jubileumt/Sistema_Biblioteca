﻿using System;

namespace Sistema_Biblioteca
{
   internal class Usuario : Livro
    {
        public string Nome;
        public string Cidade;
        public int Cpf;
        public int Idade;

             public static int ProcurarUsuario(Usuario[] usuarios, int cpf)
        {
            foreach (var procurar in usuarios)
            {
                if (procurar != null & procurar.Cpf == cpf)
                {
                    Console.WriteLine("Usuario encontrado!");
                    Console.WriteLine(procurar.Nome);
                    Console.WriteLine(procurar.Cidade);
                    Console.WriteLine(procurar.Cidade);
                    Console.WriteLine(procurar.Cpf);
                    Console.ReadKey();
                    Console.Clear();
                    return 1;
                }
                else
                {
                    Console.WriteLine("Usuario não encontrado!");
                    return 0;
                }
            } 
            return 0;
        }
    }
}
