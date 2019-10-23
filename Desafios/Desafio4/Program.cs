using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0){
                System.Console.WriteLine($"O número {num} é par");
            } else {
                System.Console.WriteLine($"O número {num} é impar");
            }
        }
    }
}
