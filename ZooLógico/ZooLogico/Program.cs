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
            string[] pasto = new string[3];
            string[] gaiola = new string[3];
            string[] casaEmArvore = new string[3];
            string[] cavernaDePedra = new string[3];
            string[] piscinaGelada = new string[3];
            string[] piscina = new string[3];
            string[] aquario = new string[3];

            var animais = new Dictionary<string, Animais>();
                animais.Add("1",new TubaraoMartelo());
                animais.Add("2",new Tucano());
                animais.Add("3",new Arara());
                animais.Add("4",new Leao());
                animais.Add("5",new Orangotango());
                animais.Add("6",new Chimpanze());
                animais.Add("7",new Pinguim());
                animais.Add("8",new Tartaruga());
                animais.Add("9",new Golfinho());

            var todosAnimais = new List<string>(){
                "Tubarao Martelo",
                "Tucano",
                "Arara",
                "Leão",
                "Orangotango",
                "Chimpanzé",
                "Pinguim",
                "Tartaruga",
                "Golfinho"
            };

            Console.Clear();
            System.Console.WriteLine("Escolha o animal para mandar para sua jaula: ");

            for(int i = 0 ; i < todosAnimais.Count ; i ++){
                System.Console.WriteLine((i + 1) + "-" + todosAnimais[i]);
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

            switch (escolhaJaula){
                case "1":
                    break;
            }

        }

        public static void Alocar (Animais animal){
            Type habitat = animal.GetType().GetInterfaces().FirstOrDefault();
            if(habitat.Equals(typeof(IAquario))){
                IAquario habitatAnimal = (IAquario)animal;
            }
            else if(habitat.Equals(typeof(ICasaEmArvore))){
                ICasaEmArvore habitatAnimal = (ICasaEmArvore)animal;
            }
            else if(habitat.Equals(typeof(ICavernaDePedra))){
                ICavernaDePedra habitatAnimal = (ICavernaDePedra)animal;
            }
            else if(habitat.Equals(typeof(IGaiola))){
                IGaiola habitatAnimal = (IGaiola)animal;
            }
            else if(habitat.Equals(typeof(IPasto))){
                IPasto habitatAnimal = (IPasto)animal;
            }
            else if(habitat.Equals(typeof(IPiscina))){
                IPiscina habitatAnimal = (IPiscina)animal;
            }
            else if(habitat.Equals(typeof(IPiscinaGelada))){
                IPiscinaGelada habitatAnimal = (IPiscinaGelada)animal;
            }
        }
    }
}
