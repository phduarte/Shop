using Gadz.Shop.Access;
using Gadz.Shop.Access.DomainModel.Usuarios;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabricantes = Gadz.Shop.Stock.Forms.Fabricantes;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.Store {
    public partial class Main : Form {

        readonly AccessServices _services;
        readonly TaskScheduler _threadUI;

        public Main() {
            _services = new AccessServices();
            _threadUI = TaskScheduler.FromCurrentSynchronizationContext();

            Text = Program.Name;
            InitializeComponent();
            DefinirPermissoes();
            WindowState = FormWindowState.Maximized;
            Program.Sessao.AoMudar += DefinirPermissoes;
            Load += ExibirTelaInicial;
        }

        void DefinirPermissoes() {

            Task.Factory.StartNew(() => {

                var visivel = Program.Sessao.Logada;
                var usuario = Program.Sessao.Usuario;

                AtualizarStatus(visivel, usuario);
                AlternarModuloAcesso(visivel);
                AlternarModuloCadastro(visivel);
                AlternarModuloRelatorios(visivel);
                AlternarOutrosModulos(visivel);
                DefinirLayout(usuario.Perfil);

            }, CancellationToken.None, TaskCreationOptions.None, _threadUI);
        }

        void DefinirLayout(Perfil perfil) {
            switch (perfil) {
                case Perfil.Estoquista:
                    DefinirLayoutEstoquista();
                    break;
                case Perfil.Vendedor:
                    DefinirLayoutVendedor();
                    break;
                case Perfil.Caixa:
                    DefinirLayoutCaixa();
                    break;
            }
        }

        void AlternarModuloRelatorios(bool visivel) {
            mnRelEstoque.Visible = visivel;
            mnRelVendas.Visible = visivel;
        }

        void AlternarOutrosModulos(bool visivel) {
            mnEstoquista.Visible = visivel;
            mnCaixa.Visible = visivel;
            mnRelatorios.Visible = visivel;
            mnJanelas.Visible = visivel;
            mnPesquisa.Visible = visivel;
            mnFerramentas.Visible = visivel;
            mnVendedor.Visible = visivel;
        }

        void AlternarModuloAcesso(bool logado) {
            mnLogin.Enabled = !logado;
            mnLogout.Enabled = logado;
            mnAlterarSenha.Enabled = logado;
            mnTrocarUsuario.Enabled = logado;
        }

        void AlternarModuloCadastro(bool logado) {
            menuRh.Visible = logado;
            mnCadastroProdutos.Visible = logado;
            mnCadastroContas.Visible = logado;
            mnCadastroFuncionarios.Visible = logado;
        }

        void AtualizarStatus(bool visivel, IUsuario usuario) {
            if (visivel) {
                statusBar.Text = $"{DateTime.Now.ToString()} | {usuario.Login.ToUpper()} | {usuario.Perfil.ToString().ToUpper()}";
            } else {
                statusBar.Text = "Aguardando login";
            }
        }

        void DefinirLayoutCaixa() {
            mnCadastroProdutos.Visible = false;
            mnCadastroContas.Visible = false;
            mnCadastroFuncionarios.Visible = false;

            mnVendedor.Visible = false;
            mnEstoquista.Visible = false;
            mnRelatorios.Visible = false;
        }

        void DefinirLayoutVendedor() {
            mnCadastroContas.Visible = false;
            mnCadastroFuncionarios.Visible = false;
            mnCadastroProdutos.Visible = false;
            mnCaixa.Visible = false;
            mnEstoquista.Visible = false;
            mnRelatorios.Visible = false;
        }

        void DefinirLayoutEstoquista() {
            mnCadastroContas.Visible = false;
            mnCadastroFuncionarios.Visible = false;
            mnVendedor.Visible = false;
            mnCaixa.Visible = false;
            mnEstoquista.Visible = true;
            mnRelVendas.Visible = false;
        }
        
        //acesso
        public void Login(object sender, EventArgs e) {
            new Access.Forms.Login().ShowInside(this);
        }

        public void Logout(object sender, EventArgs e) {

            if (MessageBox.Show(null, "Tem certeza que deseja deslogar?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                Deslogar(sender, e);
            }
        }

        private void Deslogar(object sender, EventArgs e) {

            _services.Deslogar(Program.Sessao.Login);

            FecharTudo(sender, e);

            AtualizarStatus(false, null);

            mnLogin.Enabled = true;
            mnLogout.Enabled = false;

            //
            menuRh.Visible = false;
            mnEstoquista.Visible = false;
            mnVendedor.Visible = false;
            mnCaixa.Visible = false;
            mnRelatorios.Visible = false;
            mnJanelas.Visible = false;
            mnPesquisa.Visible = false;
            mnFerramentas.Visible = false;

            //
            mnAlterarSenha.Enabled = false;
            mnTrocarUsuario.Enabled = false;
            mnLogout.Enabled = false;
            mnLogin.Enabled = true;
        }

        private void AlterarSenha(object sender, EventArgs e) {
            new Access.Forms.AlterarSenha().ShowInside(this);
        }

        private void TrocarUsuario(object sender, EventArgs e) {
            if (MessageBox.Show(null, "Esta ação irá deslogar o usuário atual.\n\nTem certeza que deseja continuar?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {

                Deslogar(sender, e);
                Login(sender, e);
            }
        }

        private void Sair(object sender, EventArgs e) {

            if (MessageBox.Show(null, "Deseja realmente sair do sistema?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        //Diretor
        private void AddContasPagar(object sender, EventArgs e) {
            new Billing.Forms.ContasPagar().Show();
        }

        private void AddContasReceber(object sender, EventArgs e) {
            new Billing.Forms.ContasReceber().Show();
        }

        //Gerente
        private void AddFornecedor(object sender, EventArgs e) {
            new Stock.Forms.Fornecedores.Cadastro().ShowInside(this);
        }

        //Estoquista
        private void AddEstoque(object sender, EventArgs e) {
            new Stock.Forms.Estoque.Entrada().ShowInside(this);
        }

        //
        private void AddCategoria(object sender, EventArgs e) {
            new Stock.Forms.Categorias.Cadastro().ShowInside(this);
        }

        private void AddGrupo(object sender, EventArgs e) {
            new Stock.Forms.Kits.Cadastro().Show();
        }

        private void AddCliente(object sender, EventArgs e) {
            new Selling.Forms.Clientes.Cadastro().ShowInside(this);
        }

        private void AddFabricante(object sender, EventArgs e) {
            new Stock.Forms.Fabricantes.Cadastro().ShowInside(this);
        }

        private void AddFuncionario(object sender, EventArgs e) {
            new HR.Forms.Funcionarios.Cadastro().ShowInside(this);
        }

        private void AddCalendario(object sender, EventArgs e) {
            //Form f = new frmAddCalendario();

            //f.MdiParent = this;
            //f.Show();
        }

        private void AddVenda(object sender, EventArgs e) {
            //new Billing .frmCadastrarVenda().ShowDialog();
            new Selling.Forms.Vendas.Nova().ShowInside(this);
        }

        private void AddProduto(object sender, EventArgs e) {
            new Stock.Forms.Produtos.Cadastro().ShowInside(this);
        }

        private void AddPreco(object sender, EventArgs e) {
            new Selling.Forms.Precos.Cadastro().Show();
        }

        //Caixa
        //ferramentas
        private void Opcoes(object sender, EventArgs e) {

            //Ferramentas.frmOptions f = new Ferramentas.frmOptions();

            //f.MdiParent = this;
            //f.Show();
        }

        private void Calculadora(object sender, EventArgs e) {

        }

        //Pesquisa
        private void PesquisarVendas(object sender, EventArgs e) {

            //new Vendas.frmPesquisarVenda().Show();
        }

        //Janelas
        private void FecharTudo(object sender, EventArgs e) {

            //Application.OpenForms

            foreach (Form childForm in MdiChildren) {

                if(childForm.GetType() != typeof(Index)) {
                    childForm.Close();
                }
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        //Ajuda
        private void AboutMe(object sender, EventArgs e) {
            new About().ShowInside(this);
        }

        private void cicloDePDCAEMelhoriaContínuaToolStripMenuItem_Click(object sender, EventArgs e) {

            //string _url = @"file:///" + Path.GetDirectoryName(Application.ExecutablePath).Replace("\\", "/") + "/dicas/CicloPDCA.html";

            //new Ferramentas.frmWebViewer(_url);

            //f.MdiParent = this;
            //f.Show();
        }

        public void TelaInicial(object sender, EventArgs e) {
            new Index().ShowInside(this);
        }

        private void PesquisaEndereco(object sender, EventArgs e) {
            new Admin.Forms.Enderecos.Pesquisa().ShowInside(this);
        }

        private void PesquisaProdutos(object sender, EventArgs e) {
            new Stock.Forms.Produtos.Pesquisa().ShowInside(this);
        }

        private void PesquisaClientes(object sender, EventArgs e) {
            new Selling.Forms.Clientes.Pesquisa().ShowInside(this);
        }

        private void PesquisaFuncionarios(object sender, EventArgs e) {
            new HR.Forms.Funcionarios.Pesquisa().ShowInside(this);
        }

        private void PesquisaFornecedores(object sender, EventArgs e) {
            new Stock.Forms.Fornecedores.Pesquisa().ShowInside(this);
        }

        private void PesquisaFabricante(object sender, EventArgs e) {
            new Fabricantes.Pesquisa().ShowInside(this);
        }

        private void reposiçãoToolStripMenuItem2_Click(object sender, EventArgs e) {

            string _LocalRelatorio;

            _LocalRelatorio = Path.GetDirectoryName(Application.ExecutablePath) + "\\relatorios\\rptEstoqueReposicao.rpt";

            //Ferramentas.frmReportViewer f = new Ferramentas.frmReportViewer(_LocalRelatorio);

            //f.Connection = Program.conn;
            //f.FileName = _LocalRelatorio;
            //f.Sql = "select * from vw_estoque_reposicao";
            //f.MdiParent = this;
            //f.Show();
        }

        private void RelEstoqueAtual(object sender, EventArgs e) {

            string _LocalRelatorio;

            _LocalRelatorio = Path.GetDirectoryName(Application.ExecutablePath) + "\\relatorios\\rptEstoqueProdutos.rpt";

            //Ferramentas.frmReportViewer f = new Ferramentas.frmReportViewer(_LocalRelatorio);

            //f.Connection = Program.conn;
            //f.FileName = _LocalRelatorio;
            //f.Sql = "select * from vw_estoque_x_produto order by nome_produto";
            //f.MdiParent = this;
            //f.Show();
        }

        private void ExibirTelaInicial(object sender, EventArgs e) {
            new Index().ShowInside(this);
        }
    }
}