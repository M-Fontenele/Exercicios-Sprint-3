using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Orangotango : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name;
        }
    }
}