﻿using System;

namespace CONDICIONAIS
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui vai o código do programa
            // C# é uma linguagem sensitiva

            // Declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

            // Entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();
            
            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse (Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse (Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse (Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3;


            //Exibir o resultado
            if(media>5){
                //Valor verdadeiro
                Console.WriteLine("O Aluno "+nomeCompleto+" está APROVADO com a média de: "+media+"!");

            }else{
                //Valor falso
                Console.WriteLine("O Aluno "+nomeCompleto+" está REPROVADO com a média de: "+media+"!");
            }




        }
    }
}
