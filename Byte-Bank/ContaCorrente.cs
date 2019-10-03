using System;

namespace ByteBank
{
    public class ContaCorrente
    { 
        public string Titular{get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo = 0;

        public ContaCorrente (int Agencia, int Numero, string Titular){
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Titular = Titular;
        }

        public int SaldoDaConta(int saldo){
            
        }
    }
}