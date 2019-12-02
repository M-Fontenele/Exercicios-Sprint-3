using System;
using RoleTop.Enums;

namespace RoleTop.Models
{
    public class Agendar
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public PlanoEvento PlanoEvento {get;set;}
        public DateTime DataDoPedido {get;set;}
        public double PrecoTotal {get;set;}
        public uint Status {get;set;}

        public Agendar()
        {
            this.Cliente = new Cliente();
            this.PlanoEvento = new PlanoEvento();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }

    }
}