using System;

namespace testeX
{
    class Program
    {
        static void Main(string[] args)
        {
            int ntri,nh,n = 0 ;

            string asterisco;

            asterisco = "*";

            Console.WriteLine("Qual a altura do triângulo: ");
            nh = int.Parse(Console.ReadLine());

            while(nh <= 0){
                Console.WriteLine("Digite um valor positivo: ");
                nh = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quantos triângulo você quer emprimir: ");
            ntri = int.Parse(Console.ReadLine());


            while(ntri != 0){

                for(n = nh; n != 0; n--){
                    Console.WriteLine(asterisco);
                    asterisco = (asterisco + "*");
                }
                ntri--;
                asterisco = ("*");
                Console.WriteLine("");
            }
        }
    }
}
