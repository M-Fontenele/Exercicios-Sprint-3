using System;
using System.Collections.Generic;

namespace Desafio27
{
    enum MenuEnum {
        Adcionar,
        Remover,
        Mostrar,
        Sair
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Dictionary<string,string> agenda = new Dictionary<string,string>();
            string[] listaMenu = Enum.GetNames(typeof(MenuEnum));

            List<string> opcoesMenu = new List<string>(){
                "    - 0              ",
                "    - 1              ",
                "    - 2              ",
                "    - 3              "
            };

            bool querSair = false;
            int opcaoSelecionada = 0;

            do{
                bool escolhido = false;

                do{
                    Console.Clear();
                    System.Console.WriteLine("Agenda de Aniversarios");
                    System.Console.WriteLine();
                    for(int i = 0; i < opcoesMenu.Count; i++){
                        string titulo = listaMenu[i];
                        if(opcaoSelecionada == i){
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            System.Console.WriteLine(opcoesMenu[opcaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        }
                        else{
                            System.Console.WriteLine(opcoesMenu[i].Replace("-",">").Replace(i.ToString(),titulo));
                        }
                    }

                    var key = Console.ReadKey().Key;

                    switch (key){
                        case ConsoleKey.UpArrow :
                            opcaoSelecionada = opcaoSelecionada == 0 ? opcaoSelecionada : --opcaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow :
                            opcaoSelecionada = opcaoSelecionada == opcoesMenu.Count - 1 ? opcaoSelecionada : ++opcaoSelecionada;
                            break;
                        case ConsoleKey.Enter :
                            escolhido = true;
                            break;
                    }
                    

                } while (!escolhido);

                switch (opcaoSelecionada){
                    case 0 :
                        Console.Clear();
                        System.Console.Write("Person's name: ");
                        string nome = Console.ReadLine();
                        System.Console.Write("Birthday");
                        string day = Console.ReadLine();
                        System.Console.Write("Month of birth: ");
                        string month = Console.ReadLine();
                        System.Console.Write("Year of birth: ");
                        string Year = Console.ReadLine();
                        break;
                }

            } while(!querSair);
        }
    }
}
