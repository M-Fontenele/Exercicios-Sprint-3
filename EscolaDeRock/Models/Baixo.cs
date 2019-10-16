using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentosMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }
    }
}