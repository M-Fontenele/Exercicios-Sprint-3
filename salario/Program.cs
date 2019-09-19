using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento = 0;

            Console.Write("Digite o valor do seu salário: ");
            salario = double.Parse(Console.ReadLine());

            if(salario < 500){
                aumento = salario + (salario * 30) / 100;
                Console.WriteLine("Você tem direito ao aumento!");
                Console.WriteLine("Após o aumento seu salário será de " + aumento);
            }
            else if(salario >= 500){
                Console.WriteLine("Desculpe");
                Console.WriteLine("Você não tem direito ao aumento");
            }
        }
    }
}
