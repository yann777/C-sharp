using System;

namespace LogicaDeProgamcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm;
            int valorDois;

            //Aqui vai o código
            
            // Console.WriteLine("Digite o seu nome");
            // string nomeCompleto = Console.ReadLine();
            // Console.WriteLine("Bem-Vindo "+nomeCompleto);

            //Entrada de dados
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("-----------------------");
            Console.Write("Digite o primeiro valor: ");
            valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.Write("Digite o segundo valor: ");
            valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("-----------------------");
            Console.WriteLine("A Soma de "+valorUm+" + "+valorDois+" = "+soma);
        }
    }
}
