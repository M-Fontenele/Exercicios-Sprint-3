using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Leao : Animais, IPasto
    {
        public string JaulaPasto()
        {
            return this.GetType().Name;
        }
    }
}