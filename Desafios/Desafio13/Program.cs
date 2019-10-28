using System.Collections.Generic;
using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite três valores para ver se forma um triangulo: ");
            System.Console.Write("Valor 1 : ");
            int valor1 = int.Parse(Console.ReadLine());
            System.Console.Write("Valor 2 : ");
            int valor2 = int.Parse(Console.ReadLine());
            System.Console.Write("Valor 3 : ");
            int valor3 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add(valor1);
            lista.Add(valor2);
            lista.Add(valor3);

            lista.Sort();

            int verificacaomaior = valor2 + valor3;
            int verificacaomenor = Math.Abs(valor2 - valor3);
            int[] vetor = new int[3];

            if(verificacaomenor < valor1 && valor1 < verificacaomaior){
                System.Console.Write($"os valores formam um triângulo ");
                if(valor1 == valor2 && valor1 == valor3){
                    System.Console.WriteLine("equilátero");
                } else if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3){
                    System.Console.WriteLine("isósceles");
                } else {
                    System.Console.WriteLine("escaleno");
                }
            }
            else
            {
                System.Console.WriteLine("esses valores não formam um triângulo.");
            }
        }
    }
}
