using System;

namespace Exercicio_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Tabuada você gostaria de saber?");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;
            Console.WriteLine("-------------------------------------");

            while(contador <= 10){
                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
            }
        }
    }
}
