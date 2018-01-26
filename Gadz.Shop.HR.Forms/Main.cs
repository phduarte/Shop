using Gadz.Shop.Access.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.HR.Forms {
    public partial class Main : Form {

        readonly TaskScheduler _threadUI;

        public Main() {

            _threadUI = TaskScheduler.FromCurrentSynchronizationContext();

            InitializeComponent();
            DefinirPermissoes();
            Program.Sessao.AoLogar += DefinirPermissoes;
        }

        void DefinirPermissoes() {

            Task.Factory.StartNew(()=> {
                bool visivel = Program.Sessao.Logada;

                //
                menuAcessoLogin.Enabled = !visivel;
                menuAcessoLogout.Enabled = visivel;
                menuAcessoTrocarSenha.Enabled = visivel;
                menuAcessoTrocarUsuario.Enabled = visivel;

                //


                menuRh.Visible = visivel;
            }, CancellationToken.None, TaskCreationOptions.None, _threadUI);
        }

        private void loginToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Login().ShowInside(this);
        }

        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e) {
            if(MessageBox.Show("Tem certeza que deseja deslogar?","",MessageBoxButtons.OKCancel) == DialogResult.OK) {
                Program.Sessao.Deslogar();
                DefinirPermissoes();
            }
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new AlterarSenha().ShowInside(this);
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, System.EventArgs e) {
            if (MessageBox.Show("Tem certeza que deseja deslogar?", "", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                Program.Sessao.Deslogar();
                loginToolStripMenuItem_Click(sender, e);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e) {
            if (MessageBox.Show("Tem certeza que deseja sair?", "", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                Close();
            }
        }

        private void menuCadastroFuncionariosCadastro_Click(object sender, System.EventArgs e) {
            new Funcionarios.Cadastro().ShowInside(this);
        }

        private void menuCadastroFuncionariosPesquisa_Click(object sender, System.EventArgs e) {
            new Funcionarios.Pesquisa().ShowInside(this);
        }

        private void menuCadastroEnderecosCadastro_Click(object sender, System.EventArgs e) {
            new Enderecos.Cadastro().ShowInside(this);
        }

        private void menuCadastroEnderecosPesquisa_Click(object sender, System.EventArgs e) {
            new Enderecos.Pesquisa().ShowInside(this);
        }

        private void menuCadastroSalariosPesquisa_Click(object sender, System.EventArgs e) {
            new Salarios.Pesquisa().ShowInside(this);
        }

        private void menuCadastroSalariosPromocoes_Click(object sender, System.EventArgs e) {
            new Salarios.Cadastro().ShowInside(this);
        }

        private void sobreToolStripMenuItem_Click(object sender, System.EventArgs e) {
            MessageBox.Show("Recursos Humanos para SISTEMA DE LOJA");
        }
    }
}
