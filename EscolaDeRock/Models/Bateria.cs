using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentosMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo da Bateria.");
            return true;
        }
    }
}