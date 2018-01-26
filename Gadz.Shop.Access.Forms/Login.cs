using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Access.Forms {
    public partial class Login : MdiBaseForm {

        AccessServices _services = AccessServices.Instance;

        public Login() {
            InitializeComponent();
        }

        private void Entrar(object sender, EventArgs e) {
            try {
                _services.Logar(txtUsuario.Text, txtSenha.Text);
                // TODO Definir permissões
                Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void Submit(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Entrar(sender, e);
            }
        }

        private void EsqueciSenha(object sender, LinkLabelLinkClickedEventArgs e) {
            new RecuperacaoSenha().ShowInside(MdiCurrent);
        }

        private void Fechar(object sender, FormClosedEventArgs e) {

            //if (!user.IsLogged && user.Visita == 1) {
            //    Application.Exit();
            //}
        }
    }
}