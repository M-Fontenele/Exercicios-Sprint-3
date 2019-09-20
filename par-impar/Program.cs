using System;

namespace par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            

            // while (!(num1 == 0)){
                
            //     Console.WriteLine("Digite um número igual a zero: ");
            //     num1 = int.Parse(Console.ReadLine());
            // }

            do{
                Console.WriteLine("Digite um número ou zero para parar: ");
                num1 = int.Parse(Console.ReadLine());

                if(num1 % 2 == 0){
                Console.WriteLine($"O número {num1} é um número par!");
                }
                else {
                    Console.WriteLine($"O número {num1} é um número impar!");
                }
            }while(num1 !=0);
            
            

        }
    }
}
