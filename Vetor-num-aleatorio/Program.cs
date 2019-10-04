using System;

namespace Vetor_num_aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for(int i = 0; i < 10; i++){
                Random GeradorAleatorio = new Random();
                vetor[i] = GeradorAleatorio.Next();
            }
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine(vetor[i]);
            }
        }
    }
}
