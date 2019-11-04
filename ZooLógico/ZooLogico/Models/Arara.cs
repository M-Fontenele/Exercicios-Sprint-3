using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Arara : Animais, IGaiola
    {
        public string JaulaGaiola()
        {
            return this.GetType().Name;
        }
    }
}