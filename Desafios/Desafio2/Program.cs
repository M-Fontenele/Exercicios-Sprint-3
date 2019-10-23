using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite a temperatura em centigrados: ");
            double tempC = double.Parse(Console.ReadLine());

            double tempF = ((tempC * 9) + 160)/5;

            System.Console.WriteLine(tempF);
        }
    }
}
