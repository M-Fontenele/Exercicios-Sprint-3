using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper, erro;
            int calculo = 0;

            Console.WriteLine("Digite o 1º número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 º número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

            switch (oper) {
                case "+":
                    calculo = num1 + num2;
                    Console.WriteLine($"O resultado de {num1} + {num2} é igual a " + calculo);
                    break;
                case "-":
                    calculo = num1 - num2;
                    Console.WriteLine($"O resultado de {num1} - {num2} é igual a " + calculo);
                    break;
                case "*":
                    calculo = num1 * num2;
                    Console.WriteLine($"O resultado de {num1} * {num2} é igual a " + calculo);
                    break;
                case "/":
                    calculo = num1 / num2;
                    Console.WriteLine($"O resultado de {num1} / {num2} é igual a " + calculo);
                    break;
                case "%":
                    calculo = num1 % num2;
                    Console.WriteLine($"O resultado de {num1} % {num2} é igual a " + calculo);
                    break;
                default:
                    erro = "Operação inválida";
                    Console.WriteLine(erro);

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