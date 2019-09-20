using System;

namespace tabuada_do_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A tabuada do 5 é : ");

            for(int i = 0; i < 100; i++){
                Console.WriteLine($"5 * {i} = " + (5 * i));
            }
        }
    }
}
