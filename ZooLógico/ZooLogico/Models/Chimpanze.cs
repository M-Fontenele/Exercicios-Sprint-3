using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Chimpanze : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name;
        }
    }
}