using System;

namespace ByteBank
{
    public class Cliente
    {
        public string Cpf {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        private string _Senha {get;set;}

        public string Senha
        {
            get { return _Senha; }
        }

        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocaSenha(string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return true;
            }else{
                return false;
            }
        }
    }
}