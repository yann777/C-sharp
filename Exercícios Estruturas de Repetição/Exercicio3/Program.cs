using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            while (nome == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor preencha o campo");
                Console.ResetColor();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();
            }

            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nome cadastrado com sucesso");
            Console.ResetColor();
            Console.WriteLine("Aperte a tecla enter para continuar");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            while (idade < 0 || idade > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida");
                Console.ResetColor();
                Console.WriteLine("--------------");
                Console.WriteLine("Digite sua idade:");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Idade cadastrada com sucesso");
            Console.ResetColor();
            Console.WriteLine("Aperte a tecla enter para continuar");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Digite o seu salário:");
            int salario = int.Parse(Console.ReadLine());

            while (salario < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Salário inválido");
                Console.ResetColor();
                Console.WriteLine("----------------");
                Console.WriteLine("Digite seu salário:");
                salario = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Salário cadastrado com sucesso");
            Console.ResetColor();
            Console.WriteLine("Aperte a tecla enter para continuar");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------- Opções ----------------");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" (c) Casado                        ");
            Console.WriteLine(" (s) Solteiro                      ");
            Console.WriteLine(" (d) Divorciado                    ");
            Console.WriteLine(" (v) Viúvo                         ");
            Console.WriteLine("-----------------------------------");
            string estadoCivil = Console.ReadLine();

            do{

                switch (estadoCivil)
                {
                    case "s":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Estado Civil cadastrado como 'Solteiro(a)'");
                        Console.ResetColor();
                        break;

                    case "c":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Estado Civil cadastrado como 'Casado(a)'");
                        Console.ResetColor();
                        break;

                    case "v":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Estado Civil cadastrado como 'Viúvo(a)'");
                        Console.ResetColor();
                        break;

                    case "d":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Estado Civil cadastrado como 'Divorciado(a)'");
                        Console.ResetColor();
                        break;

                    case "":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Estado Civil Inválido");
                        Console.ResetColor();
                        break;

                }
            }while (estadoCivil == "");


        }
    }
}
