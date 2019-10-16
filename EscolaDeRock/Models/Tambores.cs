using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentosMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Manter o ritmo do Tambores.");
            return true;
        }
    }
}