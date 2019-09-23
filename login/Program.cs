using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {   
            string login, senha;

            Console.WriteLine("Digite seu login");
            login = Console.ReadLine();
            Console.WriteLine("Digite sua Senha");
            senha = Console.ReadLine();

            if((login == "admin") && (senha == "admin")){
                Console.WriteLine("Bem vindo Admin. ");
            }
            else{
                Console.WriteLine("Olá Usuário. ");
            }
            
        }
    }
}
