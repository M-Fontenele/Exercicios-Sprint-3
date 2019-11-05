using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Golfinho : Animal , IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }
    }
}