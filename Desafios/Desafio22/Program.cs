using System;

namespace Desafio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = new int[3,3];
            int somatotal = 0;

            Console.Clear();
            for(int i = 0; i < 3; i++){
                for(int i2 = 0; i2 < 3; i2++){
                    Random numAleatorio = new Random();
                    matriz[i,i2] = numAleatorio.Next(1000);
                }
            }
            System.Console.WriteLine("Matriz 3X3");
            for(int i = 0; i < 3; i++){
                System.Console.Write("|");
                for(int i2 = 0; i2 < 3; i2++){
                    System.Console.Write("   ");
                    System.Console.Write($"{matriz[i,i2], 3}");
                }
                System.Console.Write("   ");
                System.Console.Write("|");
                System.Console.WriteLine();
            }
            foreach(int item in matriz){
                somatotal += item;
            }
            System.Console.WriteLine($"A soma de todos os elementos da Matriz acima é {somatotal}");
        }
    }
}
