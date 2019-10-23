using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a altura do triangulo: ");
            int h = int.Parse(Console.ReadLine());
            int v = h;

            for(int i = 0; i < h; i++){
                for(int e = 0; e < v; e++){
                    System.Console.Write("*");
                }
                v--;
                System.Console.WriteLine();
            }
        }
    }
}
