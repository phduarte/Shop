using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Access.DomainModel.Usuarios {

    public class Usuario : Entity, IUsuario {

        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public Perfil Perfil { get; set; }
        public bool Logado { get { return Status == Status.Logado; } }
        //public int Visita { get; set; }
        public Status Status { get; private set; }

        public bool ValidarSenha(string senha) {

            string[] caract = { "*", "#", "?", "!", "@", "$", "%", "¨", "&" }; //literias
            string[] nums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //numerais
            bool x = false;
            bool f = false;

            //valida regras de novas senhas
            x = senha != Login;                   //não pode ser igual ao nome de usuario
            x = x && senha != "";                      //não pode ser vazio
            //x = x && senha == nova;                    //não pode ser diferente da nova senha

            foreach (string c in caract)
                if (senha.IndexOf(c) > 0) {
                    f = true;
                    break;
                }

            x = x && f;                                 //tem que ter pelo menos 1 caract especial

            foreach (string c in nums)
                if (senha.IndexOf(c) > 0) {
                    f = true;
                    break;
                }

            x = x && f;                                 //tem que ter pelo menos um número

            return x;
        }

        public override string ToString() {
            return Nome;
        }

        public void Logar() {
            Status = Status.Logado;
        }

        public void Deslogar() {
            Status = Status.Deslogado;
        }

        public void TrocarSenha(string senha) {
            Status = Status.Logado;
        }
    }
}
