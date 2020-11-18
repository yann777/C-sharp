using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o usuário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();

            while(nome == senha){
            Console.WriteLine("A senha não pode ser a mesma que o nome de usuário, por favor digite novamente!");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();
            }
            Console.WriteLine("Cadastrado efetuado com sucesso");
        }
    }
}
