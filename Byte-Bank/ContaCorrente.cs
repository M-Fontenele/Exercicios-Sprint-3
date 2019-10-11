using System;

namespace ByteBank
{
    public class ContaCorrente
    { 
        public Cliente Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        private double _Saldo {get;set;}
        public double Saldo
        {
            get { return _Saldo; }
        }
        public ContaCorrente (int Agencia, int Numero, Cliente Titular){
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Titular = Titular;
        this._Saldo = 0.0;
        }

        public bool Deposito(double valor){
            if (valor >= 0){
                this._Saldo += valor;
                return true;
            } else {
                return false;
            }
        }

        // public double Deposito(double valor){
        //     if (valor >= 0){
        //         return this._Saldo += valor;
        //     } else {
        //         return this.Saldo;
        //     }
        // }

        
        public bool Saque(double valor){
            if (valor <= 0 ){
                return false;
            }
            if (this.Saldo >= valor){
                this._Saldo -= valor;
                return true;
            }else{
                return false;
            }
            
        }
        public bool Transferencia(ContaCorrente contaDestino, double valor){
            if(this.Saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            } else{
                return false;
            }
        }
    }
}