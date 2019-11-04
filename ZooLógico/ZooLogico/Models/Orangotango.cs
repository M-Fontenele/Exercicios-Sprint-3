using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Orangotango : Animais, ICasaEmArvore
    {
        public string JaulaCasaEmArvore()
        {
            return this.GetType().Name;
        }
    }
}