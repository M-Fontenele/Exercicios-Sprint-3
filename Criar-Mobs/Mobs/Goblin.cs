using System;

namespace CriarMobs.Mobs
{
    public class Goblin
    {
        public int Vida {get;set;}
        public int Forca {get;set;}
        public int Destreza {get;set;}
        public int Inteligencia {get;set;}
        public string EquipamentodeAtaque {get;set;}
        public string EquipamentodeDefesa {get;set;}
        

        public Goblin()
        {
            Random numAleatorio = new Random();
            this.Vida = numAleatorio.Next(9,12);
            this.Forca = numAleatorio.Next(5,7);
            this.Destreza = numAleatorio.Next(7,9);
            this.Inteligencia = numAleatorio.Next(1,3);
            int arma = numAleatorio.Next(1,10);
            if(arma > 0 && arma <= 8){
                this.EquipamentodeAtaque = "Porrete";
            }else if (arma > 0 && arma <= 10){
                this.EquipamentodeAtaque = "Adaga";
            }
            if(Inteligencia == 3){
                this.EquipamentodeDefesa = "Escudo de madeira";
            }

        }
    }
}