using System;

namespace Sistema_Biblioteca
{
    internal class Livro : Funcionario
    {
        public string NomeLivro;
        public string Autor;
        public string Genero;
        public string Editora;
        public string Descricao;
        public int NumeroDoLivro;
        public bool Disponivel = true;

        public static int ProcurarLivro(Livro[] livroscopiados, Emprestimo[] empretimos)
        {
            Console.Write("Digite o ISBN (International Standard Book Number) do livro: ");
            int isbn = int.Parse(Console.ReadLine());
            foreach (var procurar in empretimos)
            {
                if (procurar != null && procurar.NumeroDoLivro == isbn)
                {
                    Console.WriteLine("Livro encontrado!");
                    Console.WriteLine("Nome do livro:" + procurar.NomeLivro);
                    Console.WriteLine("Nome do autor do livro:" + procurar.Autor);
                    Console.WriteLine("Preço do livro:" + procurar.Genero);
                    Console.WriteLine("ISBN do livro:" + procurar.NumeroDoLivro);
                    if (procurar.Disponivel == true)
                    {
                        Console.WriteLine("Livro disponivel para emprestimo");
                    }
                    else
                    {
                        Console.WriteLine("Livro nao disponivel para emprestimo!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    return 1;
                }
                else
                {
                    Console.WriteLine("Livro não registrado!");
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
                }
            }
                    return 0;
        }
    }
}
