using System;
using System.Collections.Generic;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            do{
                List<Aluno> alunos = new List<Aluno>();
                List<Sala> salas = new List<Sala>();
                int alunosCadastrados = 0;
                int salasCadastradas = 0;

                System.Console.WriteLine("Bem Vindo!");
                System.Console.WriteLine("O que você deseja fazer:");
                System.Console.WriteLine("1 - Cadastrar Aluno");
                System.Console.WriteLine("2 - Cadastrar Sala");
                System.Console.WriteLine("3 - Alocar Aluno");
                System.Console.WriteLine("4 - Remover Aluno");
                System.Console.WriteLine("5 - Verificar Salas");
                System.Console.WriteLine("6 - Verificar Alunos");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine();
                escolha = Console.ReadLine();
                Console.Clear();

                switch(escolha){
                    case "1":
                        if(alunosCadastrados < 100){
                            System.Console.Write("Digite seu nome: ");
                            string nome = Console.ReadLine();
                            System.Console.Write("Digite sua idade: ");
                            string idade = Console.ReadLine();
                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();
                        }else{
                            System.Console.WriteLine();
                            System.Console.WriteLine("Desculpe a escola está com o número maximo de alunos.");
                            System.Console.WriteLine();
                        }
                    break;
                    case "2":
                        if(salasCadastradas > 10){
                                System.Console.Write("Digite o número da sala que quer entrar: ");
                                Console.ReadLine();
                        }
                    break;
                    case "3":

                    break;
                }
            }while(escolha != "0");
        }

        Void
    }
}
