using System;
using CriarMobs.Mobs;

namespace CriarMobs.Mobs
{
    public class Goblin : Monstros
    {
        public Goblin()
        {
            Random numAleatorio = new Random();
            this.Vida = numAleatorio.Next(9,12);
            this.Forca = numAleatorio.Next(5,7);
            this.Destreza = numAleatorio.Next(7,9);
            this.Inteligencia = numAleatorio.Next(1,3);
            int arma = numAleatorio.Next(1,10);
            if(arma > 0 && arma <= 7){
                this.EquipamentodeAtaque = "Porrete";
            }else if (arma > 7 && arma <= 10){
                this.EquipamentodeAtaque = "Adaga";
            }
            if(Inteligencia == 3){
                this.EquipamentodeDefesa = "Escudo de madeira";
            }
        }
    }
}