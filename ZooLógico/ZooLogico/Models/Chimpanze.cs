using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Chimpanze : Animais, ICasaEmArvore
    {
        public string JaulaCasaEmArvore()
        {
            return this.GetType().Name;
        }
    }
}