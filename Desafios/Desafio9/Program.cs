using System;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "=================================================";
            int escolha;

                Console.Clear();
                System.Console.WriteLine(menuBar); 
                System.Console.WriteLine("Calculadora de pesos em outros planetas");
                System.Console.WriteLine(menuBar);

                System.Console.Write("Digite o peso que quer transformar(Terra) : ");
                double Pterra = double.Parse(Console.ReadLine());

                do{
                    Console.Clear();

                    System.Console.WriteLine(menuBar); 
                    System.Console.WriteLine("Calculadora de pesos em outros planetas");
                    System.Console.WriteLine(menuBar);

                    System.Console.WriteLine($"Digite o peso que quer transformar(Terra) : {Pterra}");
                    

                    System.Console.WriteLine("Digite qual praneta quer saber o peso: ");
                    System.Console.WriteLine();
                    System.Console.WriteLine("1 - Mercúrio");
                    System.Console.WriteLine("2 - Vênus");
                    System.Console.WriteLine("3 - Marte");
                    System.Console.WriteLine("4 - Júpiter");
                    System.Console.WriteLine("5 - Saturno");
                    System.Console.WriteLine("6 - Urano");

                    escolha = int.Parse(Console.ReadLine());
                } while (!(1 <= escolha && 6 >= escolha ));

            switch (escolha)
            {
                case 1:
                    double Pplaneta = (Pterra / 10 * 378)/100 ;
                    System.Console.WriteLine("Seu peso em Mercúrio é " + Pplaneta);
                    break;
                case 2:
                    double Pplanetav = (Pterra / 10 * 860)/100 ;
                    System.Console.WriteLine("Seu peso em Vênus é " + Pplanetav);
                    break;
                case 3:
                    double Pplanetam = (Pterra / 10 * 372)/100 ;
                    System.Console.WriteLine("Seu peso em Marte é " + Pplanetam);
                    break;
                case 4:
                    double Pplanetaj = (Pterra / 10 * 2480)/100 ;
                    System.Console.WriteLine("Seu peso em Júpiter é " + Pplanetaj);
                    break;
                case 5:
                    double Pplanetas = (Pterra / 10 * 1050)/100 ;
                    System.Console.WriteLine("Seu peso em Saturno é " + Pplanetas);
                    break;
                case 6:
                    double Pplanetau = (Pterra / 10 * 850)/100 ;
                    System.Console.WriteLine("Seu peso em Urano é " + Pplanetau);
                    break;
            }
        }
    }
}
