using Gadz.Shop.Access.DomainModel.Usuarios;

namespace Gadz.Shop.Access {
    public static class Current {

        static IUsuario _usuario = new Usuario();

        public static IUsuario Usuario { get { return _usuario; } }

        public static void Add(IUsuario usuario) {
            _usuario = usuario;
        }

        public static void Clear() {
            _usuario = new Usuario();
        }
    }
}
