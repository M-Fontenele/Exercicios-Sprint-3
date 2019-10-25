using System;
using System.Collections.Generic;

namespace Desafio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            List<int> lista = new List<int>();

            Console.Clear();
            for(int i = 0; i < 10; i++){
                Random numAleatorio = new Random();
                vetor[i] = numAleatorio.Next(100);
            }

            System.Console.WriteLine("O vetor é");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < 10; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor[i], 3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");
            System.Console.WriteLine();

            for(int i = 0; i < 10; i++){
                lista.Add(vetor[i]);
            }

            lista.Sort();

            System.Console.WriteLine($"O maior valor desse vetor é {lista[9]}");
            System.Console.WriteLine($"O menor valor desse vetor é {lista[0]}");
        }
    }
}
