using System;


namespace Sistema_Biblioteca
{
    internal class Emprestimo : Biblioteca
    {
        protected Livro  livroemprestado;
        protected Usuario usuarioemprestado;
        protected int datainicial;
        protected int datafinal;


        /* public override int Copiar(Livro[] livros)
         {
             Livro[] livroscopiados = new Livro[livros.Length];
             Array.Copy(livros, livroscopiados, livros.Length);
             return 0;
          }
         public override int Copiar(Usuario[] usuarios)
         {
             Usuario[] usuarioscopiados = new Usuario[usuarios.Length];
             Array.Copy(usuarios, usuarioscopiados, usuarios.Length);
             return 0;
         }
        */
         protected static int LivrosDisponiveis(Livro[] livroscopiados)
        {
            //Livro[] livroscopiados = new Livro[livros.Length];
            //Array.Copy(livros, livroscopiados, livros.Length);
            int contadorLivrosDisponiveis = 0;
            int i;
            foreach (var livroslivres in livroscopiados)
            {
                if (livroslivres != null && livroslivres.Disponivel == true)
                {
                   
                    contadorLivrosDisponiveis++;
                    if (contadorLivrosDisponiveis ==  1 )
                    {
                        Console.WriteLine("-----------Livros disponiveis-----------");
                    }
                    Console.WriteLine("Nome do livro: " + livroslivres.NomeLivro);
                    Console.WriteLine();
                }
            }

            if (contadorLivrosDisponiveis > 0)
            {
                Console.ReadKey();
                Console.Clear();
                return 1;
            }

            else
            {
                Console.WriteLine("Ainda tem livro disponivel!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
        }

        public static void EmprestimoLivro(Livro[] livroscopiados, Usuario[] usuarioscopiados)
        {
            Emprestimo[] emprestimo = new Emprestimo[10];

           
            Console.Write("Digite o cpf do usuario que deseja realizar emprestimo:");
            int cpf = int.Parse(Console.ReadLine());

            foreach (var usuariocopiado in usuarioscopiados)
            {
                if (usuariocopiado != null && usuariocopiado.Cpf==cpf)
                {
                    Console.WriteLine("Usuario conectado!");
                    Console.WriteLine("1 - Para verificar os livros disponiveis.");
                    Console.WriteLine("2 - Deseja verificar as informcoes de um livro.");
                    Console.WriteLine("3 - Para realizar emprestimos.");
                    Console.Write("Escolha:");
                    int opc = int.Parse(Console.ReadLine());

                    if (opc == 1 )
                    {
                        LivrosDisponiveis(livroscopiados);
                    }

                    if (opc == 2)
                    {
                        ProcurarLivro(livroscopiados,emprestimo);
                    }

                    if (opc == 3)
                    {
                        Console.Write("Digite o nome do livro que deseja pegar emprestado:");
                        string nomelivro = Console.ReadLine();
                        foreach (var livroemprestado in livroscopiados)
                        {
                            if (livroemprestado != null && livroemprestado.NomeLivro == nomelivro && livroemprestado.Disponivel == true)
                            {
                               
                                Console.WriteLine("Livro disponivel para emprestimo!");
                                string nome = usuariocopiado.Nome;
                                string cidade = usuariocopiado.Cidade;
                                int idade = usuariocopiado.Idade;
                                int cpF = usuariocopiado.Cpf;

                                string nomeLivro = livroemprestado.NomeLivro;
                                string auto = livroemprestado.Autor;
                                string genero = livroemprestado.Genero;
                                int numlivro = livroemprestado.NumeroDoLivro;

                                var novo_emprestimo = new Emprestimo { Nome = nome,  Cidade = cidade,Idade=idade, Cpf = cpF, NomeLivro = nomeLivro, Autor = auto, Genero = genero, NumeroDoLivro = numlivro,Disponivel = false };
                                emprestimo[Array.IndexOf(emprestimo, null)] = novo_emprestimo;
                                Console.WriteLine("Emprestimo realizado com sucesso!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
            }
        }
        
    }
}
