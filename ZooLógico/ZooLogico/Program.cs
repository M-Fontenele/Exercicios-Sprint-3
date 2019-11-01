using System.IO.Pipes;
using System.Collections.Generic;
using System;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pasto = new string[3];
            string[] gaiola = new string[3];
            string[] casaEmArvore = new string[3];
            string[] cavernaDePedra = new string[3];
            string[] piscinaGelada = new string[3];
            string[] piscina = new string[3];
            string[] aquario = new string[3];
            var animais = new Dictionary<string, string>();
                animais.Add("1","Tubarão Martelo");
                animais.Add("2","Tucano");
                animais.Add("3","Arara");
                animais.Add("4","Leão");
                animais.Add("5","Orangotango");
                animais.Add("6","Chimpanzé");
                animais.Add("7","Pinguim");
                animais.Add("8","Tartagura");
                animais.Add("9","Golfinho");

            Console.Clear();
            System.Console.WriteLine("Escolha o animal para mandar para sua jaula: ");

            for(int i = 1 ; i <= animais.Count ; i ++){
                System.Console.WriteLine((i) + "-" + animais[i.ToString()]);
            }

            System.Console.WriteLine();
            string escolhaAnimal = Console.ReadLine();

            Console.Clear();
            
            var jaulas = new Dictionary<string, string>();
                jaulas.Add("1","Pasto");
                jaulas.Add("2","Gaiola");
                jaulas.Add("3","Casa em árvore ");
                jaulas.Add("4","Caverna de pedra");
                jaulas.Add("5","Piscina Gelada");
                jaulas.Add("6","Piscina");
                jaulas.Add("7","Aquário");

            System.Console.WriteLine("Escolha a jaula que deseja mandar:  ");

            for(int i = 1 ; i <= jaulas.Count ; i ++){
                System.Console.WriteLine((i) + "-" + jaulas[i.ToString()]);
            }

            System.Console.WriteLine();
            string escolhaJaula = Console.ReadLine();

        }
    }
}
