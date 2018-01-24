using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Commom.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Access.Infrastructure {
    public class UsuarioRepository : IUsuarioRepository {

        IList<IUsuario> _usuarios = new List<IUsuario> {
            new Usuario{ Login = "admin", Senha = "admin", Nome = "Administrador", Perfil = Perfil.Diretor, Cargo = "ADMINISTRADOR", Email = "adm@adm.com.br" }
        };

        public void Add(IUsuario entity) {
            _usuarios.Add(entity);
        }

        public IEnumerable<IUsuario> GetAll() {
            return _usuarios;
        }

        public IEnumerable<IUsuario> Find(Func<IUsuario, bool> criterio) {
            return _usuarios.Where(criterio);
        }

        public IUsuario Get(Identity id) {
            return _usuarios.First(x => x.Id == id);
        }

        public void Remove(Identity id) {
            _usuarios.Remove(Get(id));
        }

        public void Save(IUsuario entity) {
            var usuario = Get(entity.Id);
            usuario = entity;
        }
    }
}
