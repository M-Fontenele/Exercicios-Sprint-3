using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Pinguim : Animais, IPiscinaGelada
    {
        public string JaulaPiscinaGelada()
        {
            return this.GetType().Name;
        }
    }
}