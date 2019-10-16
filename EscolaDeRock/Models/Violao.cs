using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentosMusical, IHarmonia, IPercussao, IMelodia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Manter o ritmo do Violão.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Violão.");
            return true;
        }

        public bool ToccarSolo()
        {
            Console.WriteLine("Tocando solo do Violão.");
            return true;
        }
    }
}