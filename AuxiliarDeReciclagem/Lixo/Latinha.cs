using System;
using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Lixo
{
    public class Latinha : IMetal
    {
        public int Amarelo()
        {
            return 3;
        }
    }
}