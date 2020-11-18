using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------");

            if(idade <= 4){
                Console.WriteLine("Você não pode participar da competição");
            }

            if(idade >= 5 && idade <= 7 ){
                Console.WriteLine("Você está na categoria Infantil A");
            }
            if(idade >= 8 && idade <= 10){
                Console.WriteLine("Você está na categoria Infantil B");
            }
            if(idade >= 11 && idade <= 13){
                Console.WriteLine("Você está na categoria Juvenil A");
            }
            if(idade >= 14 && idade <= 17){
                Console.WriteLine("Você está na categoria Juvenil B");
            }
            if(idade >= 18){
                Console.WriteLine("Você está na categoria Sênior");
            }
           
        }
    }
}
