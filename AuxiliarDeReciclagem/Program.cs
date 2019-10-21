using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.Serialization.Json;
using System.Linq;
using System;
using System.Collections.Generic;
using AuxiliarDeReciclagem.Lixo;

namespace AuxiliarDeReciclagem
{
    enum LixosEnum : int
        {
            Jornal,
            Garrafa865PET,
            Guarda866Chuva,
            Latinha,
            Garrafa,
            Papel,
            Resto865de865Comida

        }
    class Program
    {
        static void Main(string[] args)
        {

            string[] ItensLixo = Enum.GetNames(typeof(LixosEnum));

            var ListaDeItens = new List<string>()
            {
                "   - 0              ",
                "   - 1              ",
                "   - 2              ",
                "   - 3              ",
                "   - 4              ",
                "   - 5              ",
                "   - 6              ",
            };

            int Escolha; 

            do{

                Console.Clear();

                System.Console.WriteLine("Escolha qual o item que quer analisar ( Para sair digite 0)");

                for (int i = 0; i < ListaDeItens.Count; i++)
                {
                    string titulo = ItensLixo[i];

                    System.Console.WriteLine(ListaDeItens[i].Replace(i.ToString(), titulo).Replace("865", " ").Replace("-", $"{i + 1}").Replace("866", "-"));
                }

                Escolha = int.Parse(Console.ReadLine());

                switch (Escolha){
                    
                    case 1 :
                        
                        break;
                    case 2 :
                        
                        break;
                    case 3 :
                        
                        break;
                    case 4 :
                        
                        break;
                    case 5 :
                        
                        break;
                    case 6 :
                        
                        break;

                }

            } while (Escolha != 0);
        }
    }
}
