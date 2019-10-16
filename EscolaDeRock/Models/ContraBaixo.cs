using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentosMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do contrabaixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Trocando acorde do contrabaixo.");
            return true;
        }
    }
}