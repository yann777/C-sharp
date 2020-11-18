using System;

namespace Exercicio_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int anoNascimento, anoAtual, idade, semanas;

            //Entrada de dados
            Console.WriteLine("Qual seu ano de nascimento?");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine("Qual seu ano de atual?");
            anoAtual = int.Parse(Console.ReadLine());

            //Processamento
            idade = (anoAtual-anoNascimento);
            semanas = (idade*52);


            //Exibir resultado
            Console.WriteLine("-------------------------");
            Console.WriteLine("Você tem "+idade+" anos, e em semanas tem "+semanas);
        }
    }
}
