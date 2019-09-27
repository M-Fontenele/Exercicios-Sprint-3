using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Alexandre","123.456.789-00");
            Aluno aluno2 = new Aluno("Cesar","987.654.321-99","Prog1");

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Curso: " + aluno1.Curso);
            Console.WriteLine("Cpf: " + aluno1.Cpf);

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Curso: " + aluno1.Curso);
            Console.WriteLine("Cpf: " + aluno1.Cpf);

            Console.Write("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre com a Nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("CPF: " + aluno3.Cpf);
            Console.WriteLine("Curso: " + aluno3.Curso);
            Console.WriteLine("Nota: " + aluno3.Notas);
            
        }
    }
}
