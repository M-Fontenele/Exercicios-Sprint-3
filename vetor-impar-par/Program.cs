using System;

namespace vetor_impar_par
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] vetor = new int[6];
            int par = 0;
            int impar = 0;

            for(int cont = 0; cont < 6; cont++){
                Console.Write($"Digite o {cont+1}º número: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }
            foreach(int num in vetor){
                if(num % 2 == 0){
                    par++;
                }else{
                    impar++;
                }
            }
            Console.WriteLine($"Você tem {par} números pares e {impar} números impares");
            // int[] numeros = new int[6];

            // for(int i = 0;i < 6; i++){
            //     Console.WriteLine($"Digite o valor {i+1}");
            //     numeros[i] = int.Parse(Console.ReadLine());
            // }
            // for(int i = 0 ; i < 6 ;i++){
            //     int nump,numimp = 0;
            //     if(((numeros[i]) % 2) == 0 ){
            //         nump=+ 1;
            //         if(i == 6){
            //             Console.WriteLine($"{nump}");
            //         }
            //     }
            //     else{
            //         numimp=+1;
            //         if(i == 6){
            //             Console.WriteLine($"{numimp}");
            //         }
            //     }
            // }
        }
    }
}
