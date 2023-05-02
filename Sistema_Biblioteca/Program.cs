using System;

namespace Sistema_Biblioteca
{
    internal class Program : Emprestimo
    {
        public static void Main()
        {
            var biblioteca = new Biblioteca();
            var usuarios = new Usuario[10];
            var livros = new Livro[10];
            var funcionarios = new Funcionario[10];
            while (true)
            {
                Console.Title = "Biblioteca";
                
                Console.WriteLine("1 - Para registrar usuário.");
                Console.WriteLine("2 - Para registar livro.");
                Console.WriteLine("3 - Para regitrar funcionario");
                Console.WriteLine("4 - Para procurar usuario");
                Console.WriteLine("5 - Para verificar livros disponiveis / realizar emprestimo de livros.");
                Console.Write("Digite sua escolha: ");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.Write("Digite seu nome: ");
                    var nome = Console.ReadLine();
                    Console.Write("Digite sua cidade: ");
                    var cidade = Console.ReadLine();
                    Console.Write("Digite seu CPF: ");
                    var cpf = int.Parse(Console.ReadLine());
                    Console.Write("Digite sua idade: ");
                    var idade = int.Parse(Console.ReadLine());
                    biblioteca.RegistrarUsuario(usuarios, nome, cidade, cpf, idade);
                }

                if (opc == 2)
                {
                    bool disponivel = true;
                    Console.Write("Digite o nome do Livro:");
                    string nomeLivro = Console.ReadLine();
                    Console.Write("Digite o nome do autor do Livro:");
                    string autor = Console.ReadLine();
                    Console.Write("Digite o genero do livro opçoes validas romance, misterio, ficção, supense e fantasia:");
                    string genero = Console.ReadLine().ToLower(); ;

                    if (genero != "romance" && genero != "misterio" && genero != "ficção" && genero != "suspense" && genero != "fantasia")
                    {
                        Console.WriteLine("Genero nao reconhecdo digite exatamente como esta nas opcoes validas!");
                        Console.ReadKey();
                        Console.Clear();
                        Main();
                    }

                    Console.Write("Digite o  ISBN (International Standard Book Number) do livro:");
                    int numeroLivro = int.Parse(Console.ReadLine());
                    biblioteca.registarLivro(livros, nomeLivro, autor, genero, numeroLivro,disponivel);
                }

                if (opc == 3)
                {
                    Console.WriteLine("Digite o nome do funcionario");
                    string nomefunci = Console.ReadLine();
                    Console.WriteLine("Digite o cargo do funcionario");
                    string cargo  = Console.ReadLine();
                    Console.WriteLine("Digite o salario do funcionario");
                    string salario = Console.ReadLine();
                    Console.WriteLine("Digite o Cpf do funcionario");
                    int cpffunci = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digitea senha do funcionario");
                    int senha = int.Parse(Console.ReadLine());
                    Funcionario funci = new Funcionario();
                    funci.RegistrarFuncionario(funcionarios,nomefunci,cargo,salario,cpffunci,senha);
                }

                if (opc == 4)
                {
                    
                     Console.Write("Digite o Cpf do usuario:");
                     int cpf = int.Parse(Console.ReadLine());
                     Usuario.ProcurarUsuario(usuarios, cpf);
                    
                 }

                    if (opc == 5)
                  {

                    Usuario[] usuarioscopiados = new Usuario[usuarios.Length];
                    Array.Copy(usuarios, usuarioscopiados, usuarios.Length);

                    Livro[] livroscopiados = new Livro[livros.Length];
                    Array.Copy(livros, livroscopiados, livros.Length);


                    EmprestimoLivro(livroscopiados, usuarioscopiados);
                  }
            }
        }
    }
}
