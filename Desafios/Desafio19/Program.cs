using System;

namespace Desafio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string menubar = "=========================================";

            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(menubar);
            System.Console.WriteLine("            Criando um vetor             ");
            System.Console.WriteLine(menubar);
            Console.ResetColor();

            System.Console.Write("Digites quantos valores você quer que seu vetor tenha: ");
            int vetorEspaco = int.Parse(Console.ReadLine());

            int[] vetor = new int[vetorEspaco];

            for(int i = 0; i < vetorEspaco; i++){
                    Console.Clear();
                    System.Console.WriteLine($"Digite o valor que deseja colocar no espaço {i + 1} do seu vetor: ");
                    vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            System.Console.WriteLine("Seu vetor é :");
            System.Console.WriteLine();

            System.Console.Write("[");

            for(int i = 0; i < vetorEspaco; i++){
                System.Console.Write("    ");
                System.Console.Write(vetor[i]);
            }
            System.Console.Write("    ");
            System.Console.WriteLine("]");

        }
    }
}
