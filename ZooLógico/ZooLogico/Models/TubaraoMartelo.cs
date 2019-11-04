using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class TubaraoMartelo : Animais , IAquario
    {
        public string JaulaAquario()
        {
            return this.GetType().Name;
        }
    }
}