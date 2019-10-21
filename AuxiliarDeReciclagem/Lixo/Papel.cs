using System;
using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Lixo
{
    public class Papel : IPapel
    {
        public bool Azul()
        {
            return true ;
        }
    }
}