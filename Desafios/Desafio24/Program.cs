using System;

namespace Desafio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            Console.Clear();
            for(int i = 0; i < 10; i++){
                Random numAleatorio = new Random();
                vetor1[i] = numAleatorio.Next(100); 
            }
            for(int i = 0; i < 10; i++){
                Random numAleatorio = new Random();
                vetor2[i] = numAleatorio.Next(100); 
            }

            System.Console.WriteLine("O vetor 1 é: ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < 10; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor1[i], 3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");
            System.Console.WriteLine();

            System.Console.WriteLine("O vetor 2 é: ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < 10; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor2[i], 3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");
            System.Console.WriteLine();

            for(int i = 0; i < 10; i++){
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            System.Console.WriteLine("O vetor 3 é: ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < 10; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor3[i], 3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");
            System.Console.WriteLine();
        }
    }
}
