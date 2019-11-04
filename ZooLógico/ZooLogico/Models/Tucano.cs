using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Tucano : Animais, IGaiola
    {
        public string JaulaGaiola()
        {
            return this.GetType().Name;
        }
    }
}