using System;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {
            string menubar = "======================================";

            Console.Clear();
            System.Console.WriteLine(menubar);
            System.Console.WriteLine("números ímpares");
            System.Console.WriteLine(menubar);
            System.Console.WriteLine();

            System.Console.Write("Digite um valor Limite: ");
            int limite = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limite; i+= 2){
                System.Console.WriteLine(i);
            }
        }
    }
}
