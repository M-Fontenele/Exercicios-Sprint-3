using System;

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Digite um número de 1 a 12: ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes){
                case 1 :
                    System.Console.WriteLine($"O mês {mes} é Janeiro.");
                    break;
                case 2 :
                    System.Console.WriteLine($"O mês {mes} é Fevereiro.");
                    break;
                case 3 :
                    System.Console.WriteLine($"O mês {mes} é Março.");
                    break;
                case 4 :
                    System.Console.WriteLine($"O mês {mes} é Abril.");
                    break;
                case 5 :
                    System.Console.WriteLine($"O mês {mes} é Maio.");
                    break;
                case 6 :
                    System.Console.WriteLine($"O mês {mes} é Junho.");
                    break;
                case 7 :
                    System.Console.WriteLine($"O mês {mes} é Julho.");
                    break;
                case 8 :
                    System.Console.WriteLine($"O mês {mes} é Agosto.");
                    break;
                case 9 :
                    System.Console.WriteLine($"O mês {mes} é Setembro.");
                    break;
                case 10 :
                    System.Console.WriteLine($"O mês {mes} é Outubro.");
                    break;
                case 11 :
                    System.Console.WriteLine($"O mês {mes} é Novembro.");
                    break;
                case 12 :
                    System.Console.WriteLine($"O mês {mes} é Dezembro.");
                    break;
                default:
                    System.Console.WriteLine($"{mes} não representa um mês.");
                    break;
            }
        }
    }
}
