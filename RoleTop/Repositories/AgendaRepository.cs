using System.Collections.Generic;
using System.IO;
using RoleTop.Models;

namespace RoleTop.Repositories
{
    public class AgendaRepository : RepositoryBase
    {
        private const string PATH = "Database/Agendar.csv";

        public AgendaRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Agendar agendar)
        {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            agendar.Id = (ulong)++quantidadePedidos;
            var linha = new string[] {PrepararAgendaCSV(agendar)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Agendar> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Agendar> agendar = new List<Agendar>();
            foreach (var linha in linhas)
            {
                Agendar agenda = new Agendar();

                agenda.Id = ulong.Parse(ExtrairValorDoCampo("id",linha));
                agenda.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                agenda.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                agenda.Cliente.Email = ExtrairValorDoCampo("cliente_email",linha);
                agenda.Cliente.CPF = ExtrairValorDoCampo("cliente_cpf",linha);

                agendar.Add(agenda);
            }
            return agendar;
        }

        private string PrepararAgendaCSV(Agendar agendar)
        {
            Cliente c = agendar.Cliente;
            PlanoEvento pe = agendar.PlanoEvento;

            return $"id={agendar.Id};status_pedido={agendar.Status};cliente_nome={c.Nome};cliente_email={c.Email};cliente_cpf={c.CPF}"; 
        }
    }
}