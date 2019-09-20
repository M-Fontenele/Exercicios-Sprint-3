using System;

namespace impar_0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Os números impares entre 0 e 100 são: ");

            for(int i = 0; i < 100; i++){
    
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
