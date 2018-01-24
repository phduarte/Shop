using Gadz.Shop.Access.DomainModel.Usuarios;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Gadz.Shop.Access {

    public class Session {

        #region fields

        readonly Services.AccessServices _service;
        private static bool logged;
        private static bool alive;

        #endregion

        #region events

        public event Action AoMudar;
        public event Action AoLogar;

        #endregion

        #region properties

        public IUsuario Usuario { get; private set; }
        public string Login => Usuario.Login;
        public string Senha => Usuario.Senha;
        public bool Logada => Usuario.Status == Status.Logado;
        public DateTime StartTime { get; private set; }
        public DateTime SignTime { get; private set; }

        #endregion

        #region constructors

        public Session() {
            _service = new Services.AccessServices();
            Usuario = new UsuarioDeslogado();
            alive = true;
            Listen();
            StartTime = DateTime.Now;
            SignTime = DateTime.MinValue;
        }

        #endregion

        public void Logar(IUsuario usuario) {
            logged = true;
            Usuario = usuario;
            SignTime = DateTime.Now;
            AoLogar?.Invoke();
        }

        public void Deslogar() {
            logged = false;
            _service.Deslogar(Usuario.Login);
            Usuario = new UsuarioDeslogado();
            AoMudar?.Invoke();
        }

        void Analisar(IUsuario usuario) {

            if (usuario == null)
                return;

            if (!Usuario.Equals(usuario)) {
                Logar(usuario);
                AoMudar?.Invoke();
            }
        }

        void Listen() {

            Task.Factory.StartNew(() => {
                while (alive) {
                    try {

                        var usuario = _service.Primeiro();

                        if (usuario != null) {
                            Analisar(usuario);
                        } else {
                            if (logged) {
                                Deslogar();
                            }
                        }
                    } catch (Exception ex) {
                        Debug.WriteLine(ex.Message);
                    }

                    Thread.Sleep(250);
                }
            });
        }
    }
}
