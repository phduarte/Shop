using System;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Access.DomainModel.Usuarios {

    internal class UsuarioDeslogado : Entity, IUsuario {

        public string Login => "undefined";

        public string Senha => "undefined";

        public string Nome => "Deslogado";

        public bool Logado => false;

        public Perfil Perfil => Perfil.Indefinido;

        public string Email => "email@empresa.com.br";

        public Status Status => Status.Deslogado;

        public UsuarioDeslogado() {
        }

        public void Deslogar() {
            throw new NotImplementedException();
        }

        public void Logar() {
            throw new NotImplementedException();
        }

        public void TrocarSenha(string senha) {
            throw new NotImplementedException();
        }

        public bool ValidarSenha(string senha) {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return Nome;
        }
    }
}
