using System.Collections.Generic;
using System.Linq;
using System;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Escreva uma palavra : ");
            string nomea = Console.ReadLine();
            System.Console.Write("Escreva uma palavra : ");
            string nomeb = Console.ReadLine();

            int resultado = String.Compare(nomea.ToLower(),nomeb.ToLower());

            if(resultado < 0 ){
                System.Console.WriteLine(nomea);
                System.Console.WriteLine(nomeb);
            }
            else if(resultado > 0){
                System.Console.WriteLine(nomeb);
                System.Console.WriteLine(nomea);
            }
            else if(resultado == 0){
                System.Console.WriteLine(nomea);
                System.Console.WriteLine(nomeb);
            }          
        }
    }
}
