using System;
using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Lixo
{
    public class Garrafa : IVidro
    {
        public bool Verde()
        {
            return true;
        }
    }
}