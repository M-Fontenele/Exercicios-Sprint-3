using System;

namespace Vetor_Nposições
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantos posições você quer em seu vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for(int i = 0; i < n; i++){
                System.Console.WriteLine($"Qual número você quer colocar na {i + 1}");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            for(int i = 0; i < n; i++){
                System.Console.WriteLine(vetor[i]);
            }
        }
    }
}
