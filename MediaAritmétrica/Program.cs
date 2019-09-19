using System;

namespace MediaAritmétrica
{
    class Program
    {
        static void Main(string[] args)
        {
            float v1, v2, v3, v4, media;
            
            
            Console.Write("Digite a nota 1: ");
            v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            v2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 3: ");
            v3 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 4: ");
            v4 = float.Parse(Console.ReadLine());

            // Atualização 1

            // Console.WriteLine($"({v1} + {v2} + {v3} + {v4} ) / 4 = {(v1 + v2 + v3 + v4) / 4 }");
            // Console.WriteLine("A sua média é " + media);

            // Atualização 1

            media = (v1 + v2 + v3 + v4) / 4;

            if(media >= 7 && media <= 10){
               Console.WriteLine("A sua média é " + media); 
               Console.WriteLine("Você foi Aprovado"); 
            }
            else if (media < 7 && media >= 0){
                Console.WriteLine("A sua média é " + media); 
                Console.WriteLine("Você foi Reprovado"); 
            }
            else if (media < 0){
                Console.WriteLine("A sua média é " + media); 
                Console.WriteLine("Você é um animal, realmente!!!!"); 
            }
            else if (media > 10){
                Console.WriteLine("A sua média é " + media); 
                Console.WriteLine("Você é o Genio dos Genios!!!!!!!"); 
            }



        }
    }
}
