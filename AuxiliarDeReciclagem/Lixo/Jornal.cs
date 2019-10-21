using System;
using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Lixo
{
    public class Jornal : IPapel
    {
        public bool Azul()
        {
            System.Console.WriteLine("Esse lixo vai para a Lixeira de Papel de cor Azul");
            return true;
        }
    }
}