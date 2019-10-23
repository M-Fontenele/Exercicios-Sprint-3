using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "==================================================================";

            Console.Clear();
            
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("Bem vindo!");
            System.Console.WriteLine("Saiba Quantos litros você gastou na sua viagem");
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine();

            System.Console.Write("Quanto tempo foi gasto no percurso de carro (Em Horas): ");
            double tempo = double.Parse(Console.ReadLine());
            System.Console.Write("Qual a velocidade media do carro (em KM/H): ");
            double velocidadeMedia = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidadeMedia;
            
            System.Console.WriteLine($"Será gasto {Math.Round(distancia / 12 , 2)} litros");


        }
    }
}
