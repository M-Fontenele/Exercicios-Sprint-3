using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Golfinho : Animais, IAquario
    {
        public string JaulaAquario()
        {
            return this.GetType().Name;
        }
    }
}