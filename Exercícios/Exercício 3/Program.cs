using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento;

            Console.WriteLine("Qual seu salário?");
            float salario = int.Parse(Console.ReadLine());

            aumento = (salario*1.30);

            if(salario <= 500){
            Console.WriteLine("Parabéns você recebeu um aumento de 30% e ficou "+aumento);
            }
            else{
            Console.WriteLine("Você não está dentro dos requisitos que a empresa pede.");
            }
        }
    }
}
