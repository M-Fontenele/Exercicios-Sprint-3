using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite um valor para A : ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Digite um valor para B : ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            int d = b;
            b = c;
            a = d;

            System.Console.WriteLine("se Trocarmos o valor das variaveis temos");
            System.Console.WriteLine($"A valendo {a}");
            System.Console.WriteLine($"B valendo {b}");



        }
    }
}
