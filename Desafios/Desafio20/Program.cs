using System.Linq;
using System;
using System.Collections.Generic;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Console.Clear();
            for(int i = 0; i < 10; i ++){
                Random numAleatorio = new Random();
                vetor[i] = numAleatorio.Next();
            }
            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            foreach(int item in vetor){
                if (item % 2 == 0){
                    par.Add(item);
                }
                else{
                    impar.Add(item);
                }
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Lista de números par");
            Console.ResetColor();
            foreach(int item in par){
                System.Console.WriteLine(item);
            }
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Lista de números impar");
            Console.ResetColor();
            foreach(int item in impar){
                System.Console.WriteLine(item);
            }
        }
    }
}
