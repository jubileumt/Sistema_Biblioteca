using System;
//using System.Collections.Generic;

namespace Sistema_Biblioteca
{
    internal class Biblioteca : Usuario
    {

        public virtual int Copiar(Livro[] livros) { return 0; }
        public virtual int Copiar(Usuario[] usuarios) { return 0; }
        public int RegistrarUsuario(Usuario[] usuarios, string nome, string cidade, int cpf, int idade)
        {
            Usuario biblioteca = new Usuario();
            {
                Nome = nome;
                Cidade = cidade;
                Cpf = cpf;
                Idade = idade;
            };
            if (idade < 14)
            {
                Console.WriteLine("Idade nao suficiente para registar!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            foreach (var verificar in usuarios)
            {
                if (verificar != null && verificar.Cpf == cpf)
                {
                    Console.WriteLine("CPF já registrado!!");
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
                }
            }
            var novo_usuario = new Usuario { Nome = nome, Cidade = cidade, Cpf = cpf, Idade = idade };
            usuarios[Array.IndexOf(usuarios, null)] = novo_usuario;
            Emprestimo emprestimo1 = new Emprestimo();
            emprestimo1.Copiar(usuarios);
            Console.WriteLine("Usuario registrado com sucesso!");
            Console.ReadKey();
            Console.Clear();
            return 1;
        }
        public int registarLivro(Livro[] livros, string nomeLivro, string autor, string genero, int numeroLivro, bool disponivel)
        {
            Livro livro = new Livro();
            {
                NomeLivro = nomeLivro;
                Autor = autor;
                Genero = genero;
                NumeroDoLivro = numeroLivro;
                Disponivel = disponivel;
            }
            foreach (var verificar in livros)
            {
                if (verificar != null && verificar.NumeroDoLivro == numeroLivro)
                {
                    Console.WriteLine("Livros nao podem ter o mesmo  ISBN (International Standard Book Number)!");
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
                }
            }

            var novo_livro = new Livro { NomeLivro = nomeLivro, Autor = autor, Genero = Genero, NumeroDoLivro = numeroLivro, Disponivel = disponivel };
            livros[Array.IndexOf(livros, null)] = novo_livro;

            //Emprestimo emprestimo = new Emprestimo();
            // emprestimo.Copiar(livros);
            Console.WriteLine("Livro registrado com sucesso!");
            Console.ReadKey();
            Console.Clear();
            return 1;
        }
    }
}
