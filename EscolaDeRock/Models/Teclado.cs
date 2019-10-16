using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Teclado : InstrumentosMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acorde da Teclado.");
            return true;
        }

        public bool ToccarSolo()
        {
            Console.WriteLine("Tocando solo da Teclado.");
            return true;
        }
    }
}