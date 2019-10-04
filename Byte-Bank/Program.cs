using System;
using ByteBank;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastro de Cliente.
            #region Cadatro Conta.
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
            Console.WriteLine();
            #endregion

            Console.WriteLine("ByteBank - Cadastro da Conta");
            Console.Write("Entre com a Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());

            ContaCorrente contaCorrente1 = new ContaCorrente(agencia,conta,cliente1);
            double saldo;
            do{
                Console.Write("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0){
                    contaCorrente1.Saldo = saldo;
                } else {
                    Console.WriteLine("Valor do saldo deve ser positivo.");
                }
            } while(saldo < 0);
            #endregion

            Cliente cliente2 = new Cliente("Cesar","123.123.123.12","1@A.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,312,cliente2);

            #region Depósito.
            Console.Clear();
            Console.WriteLine("ByteBank - Depósito em Conta");
            Cliente usuario = contaCorrente1.Titular;
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            Console.Write("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Saque.
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            Console.Write("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente1.Saque(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Transferência.
            Console.WriteLine("ByteBank - Transferência");
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo Origem: {contaCorrente1.Saldo}");
            Console.WriteLine($"Saldo Destino: {contaCorrente2.Saldo}");
            Console.WriteLine();
            Console.Write("Digite o valor da Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if (contaCorrente1.Transferencia(contaCorrente1,valor)){
                Console.WriteLine("Transferencia Efetuada");
            } else{
                Console.WriteLine("Não foi possível realizar a operação.");
            }
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo Origem: {contaCorrente1.Saldo}");
            Console.WriteLine($"Novo Saldo Destino: {contaCorrente2.Saldo}");
            Console.WriteLine();
            #endregion
        }
    }
}
