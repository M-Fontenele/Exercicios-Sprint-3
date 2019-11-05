using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Tucano : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name;
        }
    }
}