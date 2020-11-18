using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //Pedir a operação
            //Pedir o 1º número
            //Pedir o 2º número


            Console.WriteLine("Digite a operação que deseja fazer \nSoma, Subtração, Multiplicação, Divisão.");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;


            // if(operacao == "Soma"){
            //     resultado = num1 + num2;
            // }
            // else if(operacao == "Subtração"){
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicação"){
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisão"){
            //     resultado = num1 / num2;
            // }
            // else{
            //     Console.WriteLine("Operação inválida");
            // }


            switch (operacao)
            {
                case "Soma":
                resultado = num1 + num2;
                break;
                
                case "Subtração":
                resultado = num1 - num2;
                break;
                
                case "Multiplicação":
                resultado = num1 + num2;
                break;

                case "Divisão":
                resultado = num1 / num2;
                break;
                
                default:
                Console.WriteLine("Operação inválida");
                break;

                
            }
            Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");

            
        }
    }
}
