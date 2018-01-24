using Gadz.Shop.Access.Services;
using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Access.Forms {
    public partial class Login : MdiBaseForm {

        AccessServices _services = new AccessServices();

        public Login() {
            InitializeComponent();
        }

        private void Entrar(object sender, EventArgs e) {

            //string sql;
            //SqlDataReader rec;

            //sql = "select a.id_funcionario, a.usuario, a.nome, a.cargo, a.perfil "
            //    + "from tb_funcionarios a "
            //    + "where a.usuario = '" + txtUsuario.Text + "' and a.senha='" + txtSenha.Text + "' and status='A';";

            //rec = conn.ExecuteReader(sql);

            //if (rec.Read()) {

            //    user.IsLogged = true;
            //    user.Login = txtUsuario.Text;
            //    user.Nome = rec["nome"].ToString();
            //    user.Cargo = rec["cargo"].ToString();
            //    user.ID = Convert.ToInt32(rec["id_funcionario"].ToString());

            //    switch (rec["perfil"].ToString()) {
            //        case "0":
            //            user.Perfil = Usuario.TipoPerfil.Diretor;
            //            break;
            //        case "1":
            //            user.Perfil = Usuario.TipoPerfil.Gerente;
            //            break;
            //        case "2":
            //            user.Perfil = Usuario.TipoPerfil.Estoquista;
            //            break;
            //        case "3":
            //            user.Perfil = Usuario.TipoPerfil.Vendedor;
            //            break;
            //        case "4":
            //            user.Perfil = Usuario.TipoPerfil.Caixa;
            //            break;
            //    }

            //    frmMain.DefinirPermissoes();
            //    frmMain.stUsuario.Text = user.Nome;
            //    frmMain.stCargo.Text = user.Cargo;
            //    frmMain.stDesde.Text = DateTime.Now.ToString();
            //    frmMain.stPerfil.Text = user.IsLogged ? "Logado" : "Deslogado";
            //    frmMain.stLicenca.Text = "";

            //    //
            //    frmMain.mnLogin.Enabled = false;
            //    frmMain.mnLogout.Enabled = true;
            //    frmMain.mnAlterarSenha.Enabled = true;
            //    frmMain.mnTrocarUsuario.Enabled = true;
            //    frmMain.mnTelaInicial.Enabled = true;

            //    if(user.Perfil == Usuario.TipoPerfil.Diretor)
            //        frmMain.TelaInicial(sender, e);

            //    Close();

            //} else {

            //    MessageBox.Show(null, "Usuários ou Senha não são validos.", Program.Name);

            //    txtSenha.Text = "";
            //}

            //rec.Dispose();

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
            new RecuperacaoSenha().ShowInside(_currentMdiParent);
        }

        private void Fechar(object sender, FormClosedEventArgs e) {

            //if (!user.IsLogged && user.Visita == 1) {
            //    Application.Exit();
            //}
        }
    }
}