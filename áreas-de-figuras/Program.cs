using System;

namespace áreas_de_figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            string figura;

            Console.WriteLine("Escolha a figura que quer calcular a área: \n1 para Quadrado \n2 para Triângulo \n3 para Círculo \n4 para Trapézio \n5 para Retâgulo \n6 para Losango");
            figura = Console.ReadLine();

            switch(figura){
                case "1":
                    Console.WriteLine("Qual o lado do Quadrado: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Quadrado é :" + (l * l));
                    break;
                case "2":
                    Console.WriteLine("Qual a altura do Triangulo ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a base do Triangulo ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Triângulo é :" + ((h * b) / 2) );
                    break;
                case "3":
                    Console.WriteLine("Qual o raio do Circulo ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Circulo é :" + ((r * r) * 3,14 ) );
                    break;
                case "4":
                    Console.WriteLine("Qual a base maior do Trapézio ");
                    double bma = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a base menor do Trapézio ");
                    double bme = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a altura do Trapézio ");
                    double htra = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Circulo é :" + (((bma + bme) * htra ) / 2 ) );
                    break;
                case "5":
                    Console.WriteLine("Qual a altura do Retângulo ");
                    double hre = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a base do Retângulo ");
                    double bre = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do Retângulo é :" + (hre * bre));
                    break;
                case "6":
                    Console.WriteLine("Qual a Diagonal maior do Losango ");
                    double hlo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a Diagonal menor do Losango ");
                    double blo = double.Parse(Console.ReadLine());
                    Console.WriteLine("A área do losango é :" + ((hlo * blo) / 2) );
                    break;
            }

            Console.WriteLine("Escolha a figura que quer calcular a área: \n1 para Quadrado \n2 para Triângulo \n3 para Círculo \n4 para Trapézio \n5 para Retâgulo \n6 para Losango");
            figura = Console.ReadLine();

            while(figura != "0"){
                Console.WriteLine("Escolha a figura que quer calcular a área: \n1 para Quadrado \n2 para Triângulo \n3 para Círculo \n4 para Trapézio \n5 para Retâgulo \n6 para Losango");
                figura = Console.ReadLine();
            }



            // if(figura == "1"){
            //     Console.WriteLine("Qual o lado do Quadrado: ");
            //     l = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do Quadrado é :" + (l * l));
            // }
            // else if(figura == "2"){
            //     Console.WriteLine("Qual a altura do Triangulo ");
            //     h = double.Parse(Console.ReadLine());
            //     Console.WriteLine("Qual a base do Triangulo ");
            //     b = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do Triângulo é :" + ((h * b) / 2) );  
            // }
            // else if(figura == "3"){
            //     Console.WriteLine("Qual o raio do Circulo ");
            //     r = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do Circulo é :" + ((r * r) * 3,14 ) );    
            // }
            // else if(figura == "4"){
            //     Console.WriteLine("Qual a base maior do Trapézio ");
            //     bma = double.Parse(Console.ReadLine());
            //     Console.WriteLine("Qual a base menor do Trapézio ");
            //     bme = double.Parse(Console.ReadLine());
            //     Console.WriteLine("Qual a altura do Trapézio ");
            //     h = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do Circulo é :" + (((bma + bme) * h ) / 2 ) );    
            // }
            // else if(figura == "5"){
            //     Console.WriteLine("Qual a altura do Retângulo ");
            //     h = double.Parse(Console.ReadLine());
            //     Console.WriteLine("Qual a base do Retângulo ");
            //     b = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do Retângulo é :" + ((h * b)) );  
            // }
            // else if(figura == "6"){
            //     Console.WriteLine("Qual a Diagonal maior do Losango ");
            //     h = double.Parse(Console.ReadLine());
            //     Console.WriteLine("Qual a Diagonal menor do Losango ");
            //     b = double.Parse(Console.ReadLine());
            //     Console.WriteLine("A área do losango é :" + ((h * b) / 2) );  
            // }



        }
    }
}
