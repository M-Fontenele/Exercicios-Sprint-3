using System;

namespace vetor_impar_par
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] numeros = new int[6];

            for(int i = 0;i < 6; i++){
                Console.WriteLine($"Digite o valor {i+1}");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for(int n = 0 ; n < 6 ;n++){
                int nump,numimp = 0;
                if(((numeros[n]) % 2) == 0 ){
                    if(n == 6){
                        Console.WriteLine("");
                    }
                }
                else{
                    if(n == 6){
                        Console.WriteLine("");
                    }
                }
            }

        }
    }
}
