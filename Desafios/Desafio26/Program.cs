using System;
using System.Collections.Generic;

namespace Desafio26
{
    enum MenuEnum
    {
        Adicionar12novo12nome,
        Sair
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] itensMenu = Enum.GetNames(typeof(MenuEnum));
            List<string> nomes = new List<string>(); 

            var opcaoformacao = new List<string>(){
                "    - 0       ",
                "    - 1       "
            };
            bool querSair = false;
            int opcaoSelecionada = 0;
            do{
                bool formacaoEscolhida = false;

                do{
                    Console.Clear();
                    for(int i = 0; i < opcaoformacao.Count; i++){
                        string titulo = itensMenu[i];
                        if(opcaoSelecionada == i){
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            System.Console.WriteLine(opcaoformacao[opcaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo).Replace("12"," "));
                            Console.ResetColor();
                        }
                        else{
                            System.Console.WriteLine(opcaoformacao[i].Replace(i.ToString(),titulo).Replace("12"," "));
                        }
                    }
                    var key = Console.ReadKey(true).Key;

                    switch (key){
                        case ConsoleKey.UpArrow:
                            opcaoSelecionada = opcaoSelecionada == 0 ? opcaoSelecionada : --opcaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoSelecionada = opcaoSelecionada == opcaoformacao.Count ? opcaoSelecionada : ++opcaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                } while (!formacaoEscolhida);

                switch (opcaoSelecionada){
                    case 0:
                        System.Console.WriteLine("Escreva um nome:");
                        string nome = Console.ReadLine(); 
                        nomes.Add(nome);
                        break;
                    case 1:
                        querSair = true;
                        break;
                }


            } while(!querSair);

            System.Console.WriteLine();
            System.Console.Write("Quantidade de nomes: ");
            System.Console.WriteLine(nomes.Count);
            System.Console.WriteLine();
            System.Console.WriteLine("Os nomes são: ");
            System.Console.WriteLine();
            foreach(string item in nomes){
                System.Console.WriteLine(item);
            }
        }
    }
}
