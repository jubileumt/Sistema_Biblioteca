using System;

//using System.Collections.Generic;

namespace Sistema_Biblioteca
{
    internal class Funcionario
    {
        protected string Nomefunci;
        protected string Cargo;
        protected string Salario;
        protected int Cpffunci;
        protected int Senha;

        public int RegistrarFuncionario(Funcionario[] funcionarios, string nomefunci, string cargo, string salario, int cpffunci, int senha)
        {
            Funcionario funcionario = new Funcionario();
            {
                Nomefunci = nomefunci;
                Cargo = cargo;
                Salario = salario;
                Cpffunci = cpffunci;
                Senha = senha;

                foreach (var verificar in funcionarios)
                {
                    if (verificar != null && verificar.Cpffunci == cpffunci)
                    {
                        Console.WriteLine("Não pode existir 2 funcionarios com a mesma senha!");
                        Console.ReadKey();
                        Console.Clear();
                        return 0;
                    }
                }

                var novo_funcionario = new Funcionario { Nomefunci = nomefunci, Cargo = cargo, Salario = salario, Cpffunci = cpffunci, Senha = senha };
                funcionarios[Array.IndexOf(funcionarios, null)] = novo_funcionario;
                Console.WriteLine("Funcionarios cadastrado com sucesso!");
                Console.ReadKey();
                Console.Clear();
                return 1;

            }

        }

    }
}
