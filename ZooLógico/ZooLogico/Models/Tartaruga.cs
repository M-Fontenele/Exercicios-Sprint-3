using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Tartaruga : Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }
    }
}