using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Access.Infrastructure;
using Gadz.Shop.Commom.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Access {

    public class AccessServices : Singleton<AccessServices> {

        static IDictionary<string, IUsuario> _usuariosLogados = new Dictionary<string, IUsuario>();
        readonly IUsuarioRepository _repository;

        public AccessServices() {
            _repository = new UsuarioRepository();
        }

        public void AlterarSenha(string usuario, string senha, string novaSenha) {

        }

        public void LembrarSenhaDoUsuario(string usuario) {

        }

        public void LembrarSenhaDoEmail() {
        }

        public void InativarUsuario(string id) {

        }

        public void Logar(string usuario, string senha) {
            var usuarioBanco = Pegar(usuario, senha);
            if (usuarioBanco != null) {
                usuarioBanco.Logar();
                _usuariosLogados.Add(usuario, usuarioBanco);
            } else {
                throw new Exception("Usuário ou senha inválidos.");
            }
        }

        public void Deslogar(string usuario) {
            _usuariosLogados.Remove(usuario);
        }

        public bool Logado(string usuario) {
            return _usuariosLogados[usuario] != null;
        }

        public bool Existe(string usuario) {
            return _usuariosLogados.ContainsKey(usuario);
        }

        public IUsuario Pegar(string usuario, string senha) {
            return _repository.Find(x => x.Login.Equals(usuario) && x.Senha.Equals(senha)).FirstOrDefault();
        }

        public IUsuario Primeiro() {
            return _usuariosLogados.FirstOrDefault().Value;
        }


        public IUsuario CurrentUserLogged() {

            var usuario = Primeiro();

            if (usuario == null)
                return new UsuarioDeslogado();

            return usuario;
        }
    }
}
