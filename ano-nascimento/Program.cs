using System;

namespace ano_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {   
            int idade, ano = 0;
            Console.WriteLine("Digite seu ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            while(ano > 2019){
                Console.WriteLine("Por favor digite uma ano igual ou menor que 2019 n tem como vc ter nascido do futuro : ");
                ano = int.Parse(Console.ReadLine());
            }

            idade = 2019 - ano;

            if(idade >= 0 && idade <=2 ){
                Console.WriteLine("Você é um Recém-Nascido");
                Console.WriteLine("Sua idade é " + idade);
            }
            else if(idade >=3 && idade <= 11){
                Console.WriteLine("Você é uma Criança");
                Console.WriteLine("Sua idade é " + idade);
            }
            else if(idade >=12 && idade <=19){
                Console.WriteLine("Você é um Adolecente");
                Console.WriteLine("Sua idade é " + idade);
            }
            else if(idade >=20 && idade <=65){
                Console.WriteLine("Você é um Adulto");
                Console.WriteLine("Sua idade é " + idade);
            }
            else if(idade >65){
                Console.WriteLine("Você é um idoso");
                Console.WriteLine("Sua idade é " + idade);
            }
        }
    }
}
