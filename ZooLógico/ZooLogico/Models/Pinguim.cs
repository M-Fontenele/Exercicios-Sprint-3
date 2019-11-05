using ZooLogico.Interface;

namespace ZooLogico.Models
{
    public class Pinguim : Animal, IQuionofilo
    {
        public string ResistirAoFrio()
        {
            return this.GetType().Name;
        }
    }
}