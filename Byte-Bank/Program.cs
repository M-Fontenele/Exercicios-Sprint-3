using System;
using ByteBank;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha){
                    Console.WriteLine("Senha alterada com sucesso!");
                }else{
                    Console.WriteLine("Senha Invalida");
                }
            }while(!trocouSenha);

            Console.Write("Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            ContaCorrente conta1 = new ContaCorrente(agencia,numero,titular);
        }
    }
}
