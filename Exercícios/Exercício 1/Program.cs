using System;

namespace Exercicio_Cindicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis

            float meses, dias, horas, minutos;

            //Entrada de dados
            
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------");

            //Processamento

            meses = (idade*12);
            dias = (idade*365);
            horas = (idade*8760);
            minutos = (idade*525600);


            //Exibir resultado
            
            Console.WriteLine("Você viveu "+meses+" Meses, "+dias+" dias, "+horas+" horas, "+minutos+" e minutos.");
           
        }
    }
}
