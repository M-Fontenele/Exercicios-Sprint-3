using System;

namespace Desafio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.Write("Qual o tamanho do vetor que vc quer: ");
            int tamanhoVetor = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanhoVetor];
            int[] vetor2 = new int[tamanhoVetor];
            int tamanhoVetor3 = tamanhoVetor * 2;
            int[] vetor3 = new int[tamanhoVetor3];

            for(int i = 0; i < tamanhoVetor; i++){
                Random numAleatorio = new Random();
                vetor1[i] = numAleatorio.Next(100);
            }
            for(int i = 0; i < tamanhoVetor; i++){
                Random numAleatorio = new Random();
                vetor2[i] = numAleatorio.Next(100);
            }

            int v = 0;
            for(int i = 0; i < tamanhoVetor3; i++){
                if(i < tamanhoVetor){
                    vetor3[i] = vetor1[i];
                }
                else{
                    vetor3[i] = vetor2[v];
                    v+= 1;
                }
            }

            System.Console.WriteLine("O vetor 1 é : ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < tamanhoVetor; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor1[i],3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");

            System.Console.WriteLine("O vetor 2 é : ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < tamanhoVetor; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor2[i],3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");

            System.Console.WriteLine("O vetor 3 é : ");
            System.Console.WriteLine();
            System.Console.Write("[");
            for(int i = 0; i < tamanhoVetor3; i++){
                System.Console.Write("   ");
                System.Console.Write($"{vetor3[i],3}");
            }
            System.Console.Write("   ");
            System.Console.WriteLine("]");
        }
    }
}
