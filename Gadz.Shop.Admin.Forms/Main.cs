using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gadz.Shop.Access.Forms;

namespace Gadz.Shop.Admin.Forms {
    public partial class Main : Form {

        TaskScheduler _threadUI;

        public Main() {
            _threadUI = TaskScheduler.FromCurrentSynchronizationContext();
            InitializeComponent();
            DefinirPermissoes();
            Program.Sessao.AoMudar += DefinirPermissoes;
        }

        private void DefinirPermissoes() {

            Task.Factory.StartNew(()=> {

                bool visivel = Program.Sessao.Logada;

                //login
                menuClientes.Visible = visivel;
                menuLogin.Enabled = !visivel;
                menuLogout.Enabled = visivel;
                menuTrocarSenha.Enabled = visivel;

                //cadastro
                menuCadastro.Visible = visivel;
                menuFabricantes.Visible = visivel;
                menuEnderecos.Visible = visivel;
                menuEstoque.Visible = visivel;
                menuFornecedores.Visible = visivel;
                menuFuncionarios.Visible = visivel;
                menuProdutos.Visible = visivel;

                //relatórios
                menuRelatorios.Visible = visivel;

            }, CancellationToken.None, TaskCreationOptions.None, _threadUI);
        }

        private void clientesToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Clientes.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void enderecosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Enderecos.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void fabricantesToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Fabricantes.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Fornecedores.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Funcionarios.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void produtosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Produtos.Pesquisa().AbrirSeEstiverLogado(this);
        }

        private void salariosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Salarios.Cadastro().AbrirSeEstiverLogado(this);
        }

        private void menuLogin_Click(object sender, EventArgs e) {
            new Login().ShowInside(this);
        }

        private void menuLogout_Click(object sender, EventArgs e) {
            Program.Sessao.Deslogar();
        }

        private void menuTrocarSenha_Click(object sender, EventArgs e) {
            new AlterarSenha().AbrirSeEstiverLogado(this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e) {
            new Estoque.Entrada().AbrirSeEstiverLogado(this);
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e) {
            new Estoque.Saida().AbrirSeEstiverLogado(this);
        }
    }
}
