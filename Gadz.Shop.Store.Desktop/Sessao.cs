using Gadz.Shop.Access.DomainModel.Usuarios;
using System;

namespace Gadz.Shop.Store {
    internal class Sessao {

        public IUsuario Usuario { get; private set; }
        public event Action AoMudar;
        public string Login => Usuario.Login;
        public string Senha => Usuario.Senha;
        public bool Logada => Usuario.Status == Status.Logado;

        public Sessao() {
            Usuario = new Usuario();
        }

        public void Redefinir(IUsuario usuario) {
            if (usuario == null)
                return;

            if (!Usuario.Equals(usuario)) {
                Usuario = usuario;
                AoMudar?.Invoke();
            }
        }

        public void Deslogar() {
            Usuario = new Usuario();
            AoMudar?.Invoke();
        }
    }
}
