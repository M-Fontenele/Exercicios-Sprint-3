using System;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string menubar = "============================================";

            Console.Clear();
            System.Console.WriteLine(menubar);
            System.Console.WriteLine("Calcularodo de IMC");
            System.Console.WriteLine(menubar);
            System.Console.WriteLine();

            System.Console.Write("Quanto você pesa(KG): ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.Write("Qual a sua altura(Metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            System.Console.WriteLine($"o seu IMC é {imc}");

            if(imc < 20){
                System.Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc <= 25){
                System.Console.WriteLine("Você está com a pesagem normal");
            }
            else if (imc <= 30){
                System.Console.WriteLine("Você está com excesso de peso");
            }
            else if (imc <= 35){
                System.Console.WriteLine("Você está com obesidade");
            }
            else if (imc > 35){
                System.Console.WriteLine("Você está com obesidade mórbida");
            }
        }
    }
}
