using System.IO.Pipes;
using System.Collections.Generic;
using System;
using ZooLogico.Models;
using System.Linq;
using ZooLogico.Interface;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escerrouPrograma = false;

            do{
                int codigo = 0;
                Console.Clear();
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine("*       Bem Vindo ao Zoológico!      *");
                System.Console.WriteLine("**************************************");
                System.Console.WriteLine();

                foreach(var item in ListaDeAnimais.Animais.Values){
                    System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
                }

                System.Console.WriteLine();

                System.Console.Write("Escolha um animal da lista:");
                int escolha = int.Parse(Console.ReadLine());
                
            } while(!escerrouPrograma);
        }
    }
}
