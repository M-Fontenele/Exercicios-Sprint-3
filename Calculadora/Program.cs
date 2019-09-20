using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1º número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 º número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

            while(!(oper == "+" || oper == "-" || oper == "*" || oper == "/" || oper == "%")){
                Console.WriteLine("ERRO!");
                Console.WriteLine("operador invalido digite novamente: ");
                oper = Console.ReadLine();
            }

            switch (oper) {
                case "+":
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual a " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"O resultado de {num1} - {num2} é igual a " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"O resultado de {num1} * {num2} é igual a " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"O resultado de {num1} / {num2} é igual a " + (num1 / num2));
                    break;
                case "%":
                    Console.WriteLine($"O resultado de {num1} % {num2} é igual a " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Operação inválida");

                    break;
            }


            // Atualização 1
            // Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            // Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            // Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            // Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            // Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            // Atualização 1
        }
    }
}