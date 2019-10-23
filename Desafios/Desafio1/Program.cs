using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite a base do seu retangulo: ");
            int baseretangulo = int.Parse(Console.ReadLine());
            System.Console.Write("Digite a altura do seu retangulo: ");
            int alturaretangulo = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"O perimetro do retangulo é {baseretangulo * 2 + alturaretangulo * 2}");
            System.Console.WriteLine($"A área do retangulo é {baseretangulo * alturaretangulo}");
            double d = Math.Sqrt(baseretangulo*baseretangulo + alturaretangulo*alturaretangulo);
            System.Console.WriteLine($"A diagonal do retangulo mede {d}");
        }
    }
}
