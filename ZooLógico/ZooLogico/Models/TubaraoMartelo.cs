using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class TubaraoMartelo : Animal , IAquatico , IBranquiado
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }

        public string RespirarDeBaixoDAgua()
        {
            return this.GetType().Name;
        }
    }
}