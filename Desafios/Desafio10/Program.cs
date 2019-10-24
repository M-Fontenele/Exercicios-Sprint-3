using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 3 == 0){
                System.Console.WriteLine("Esse número é divisivel por três");
            }
            else
            {
                System.Console.WriteLine("Esse número não é divisivel por três");
            }
        }
    }
}
