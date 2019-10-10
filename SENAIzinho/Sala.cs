using System.Xml.Linq;
using System;
using SENAIzinho;
namespace SENAIzinho
{
    public class Sala
    {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos;

        public Sala(int numerodaSala, int capacidadeTotalSala)
        {
            this.numeroSala = numerodaSala;
            this.capacidadeTotal = capacidadeTotalSala;
        }

        public string AlocarAluno(string nomeAluno)
        {
            for(int i = 0; i >= 10; i++){
                if(Alunos[i].Length == 0){
                    Alunos[i] = nomeAluno;
                    return "O Aluno foi cadatrado com sucesso!";
                }else if(i == 9){
                    return "Não foi possível registrar o aluno! /n A sala está cheia!";
                }
            }return "ERRO";
        }

        public string RemoverAluno(string nomeAluno)
        {
            for(int i = 0; i >= 10; i++){
                if(Alunos[i] == nomeAluno){
                    
                    return "O aluno foi removido com sucesso da sala!";
                }else if(i == 9){
                    return "O aluno não faz parte dessa sala!";
                }
            }return "ERRO.";
        }

        public void MostrarAluno()
        {   
            string todosOsAlunos;
            string alunoad;

            foreach(string item in Alunos){
                System.Console.WriteLine();
            }
        }
    }
}