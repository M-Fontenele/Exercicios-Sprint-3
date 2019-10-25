using System;

namespace Desafio21
{
    class Program
    {
        static void Main(string[] args)
        {
            string menubar = "===================================";

            Console.Clear();
            System.Console.WriteLine(menubar);
            System.Console.WriteLine("         Caixa eletronico          ");
            System.Console.WriteLine(menubar);

            System.Console.WriteLine();
            System.Console.WriteLine("Quanto você deseja sacar");
            int valor = int.Parse(Console.ReadLine());

            int notas100 = valor / 100;
            valor -= notas100 * 100;

            int notas50 = valor / 50;
            valor -= notas50 * 50;

            int notas20 = valor / 20;
            valor -= notas20 * 20;

            int notas10 = valor / 10;
            valor -= notas10 * 10;

            int notas5 = valor / 5;
            valor -= notas5 * 5;

            int notas2 = valor / 2;
            valor -= notas2 * 2;

            int notas1 = valor;

            System.Console.WriteLine("você recebeu: ");
            System.Console.WriteLine();
            System.Console.WriteLine($"{notas100} notas de 100 Reais");
            System.Console.WriteLine($"{notas50} notas de 50 Reais");
            System.Console.WriteLine($"{notas20} notas de 20 Reais");
            System.Console.WriteLine($"{notas10} notas de 10 Reais");
            System.Console.WriteLine($"{notas5} notas de 5 Reais");
            System.Console.WriteLine($"{notas2} notas de 2 Reais");
            System.Console.WriteLine($"{notas1} notas de 1 Reais");



        }
    }
}
