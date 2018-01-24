using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Access.DomainModel.Usuarios {
    public interface IUsuario : IEntity {
        string Login { get; }
        string Senha { get; }
        string Nome { get; }
        bool ValidarSenha(string senha);
        bool Logado { get; }
        Perfil Perfil { get; }
        string Email { get; }
        Status Status { get; }
        void Logar();
        void Deslogar();
        void TrocarSenha(string senha);
    }
}
