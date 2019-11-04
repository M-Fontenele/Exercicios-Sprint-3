using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Tartaruga : Animais, IPiscina
    {
        public string JaulaPiscina()
        {
            return this.GetType().Name;
        }
    }
}