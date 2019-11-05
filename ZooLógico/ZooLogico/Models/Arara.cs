using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Arara : Animal , IVoador
    {
        public string Voar()
        {
            return this.GetType().Name;
        }
    }
}