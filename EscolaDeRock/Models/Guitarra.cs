using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentosMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acorde da Guitarra.");
            return true;
        }

        public bool ToccarSolo()
        {
            Console.WriteLine("Tocando solo da Guitarra.");
            return true;
        }
    }
}