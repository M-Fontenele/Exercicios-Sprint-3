using System;

namespace tabuadas1_ao_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadas 1 ao 10: ");

            // for(int i=0; i<11; i++){
            //     Console.WriteLine();
            //     Console.WriteLine($"1 * {i} = " + (i * 1));
            //     Console.WriteLine($"2 * {i} = " + (i * 2));
            //     Console.WriteLine($"3 * {i} = " + (i * 3));
            //     Console.WriteLine($"4 * {i} = " + (i * 4));
            //     Console.WriteLine($"5 * {i} = " + (i * 5));
            //     Console.WriteLine($"6 * {i} = " + (i * 6));
            //     Console.WriteLine($"7 * {i} = " + (i * 7));
            //     Console.WriteLine($"8 * {i} = " + (i * 8));
            //     Console.WriteLine($"9 * {i} = " + (i * 9));
            //     Console.WriteLine($"10 * {i} = " + (i * 10));

            // }

            for(int i = 1; i <= 10; i++){
                for(int n = 1; n <= 10; n++){
                    Console.Write($"{n,-2} x {i,-2} = {i * n,-3}        ");
                }
                Console.WriteLine();
            }
        }
    }
}
