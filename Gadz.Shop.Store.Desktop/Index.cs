using System;
using System.Windows.Forms;
using Gadz.Shop.Access;
using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Access.Forms;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.Store {
    public partial class Index : MdiBaseForm {

        private IUsuario _usuario => AccessServices.Instance.CurrentUserLogged();

        public Index() {
            InitializeComponent();
        }

        private void CadastrarProduto(object sender, EventArgs e) {
            new Stock.Forms.Produtos.Cadastro().AbrirSeEstiverLogado(MdiParent);
        }

        private void PesquisarProduto(object sender, EventArgs e) {
            new Stock.Forms.Produtos.Pesquisa().AbrirSeEstiverLogado(MdiParent);
        }

        private void AdicionarEstoque(object sender, EventArgs e) {
            new Stock.Forms.Estoque.Entrada().AbrirSeEstiverLogado(MdiParent);
        }

        private void PesquisarFornecedor(object sender, EventArgs e) {
            new Stock.Forms.Fornecedores.Pesquisa().AbrirSeEstiverLogado(MdiParent);
        }

        private void CadastrarFornecedores(object sender, EventArgs e) {
            new Stock.Forms.Fornecedores.Cadastro().AbrirSeEstiverLogado(MdiParent);
        }

        private void PesquisarFabricantes(object sender, EventArgs e) {
            new Stock.Forms.Fabricantes.Pesquisa().AbrirSeEstiverLogado(MdiParent);
        }

        private void AtualizarPrecos(object sender, EventArgs e) {
            new Selling.Forms.Precos.Cadastro().AbrirSeEstiverLogado(MdiParent);
        }

        private void PesquisarPrecos(object sender, EventArgs e) {
            new Stock.Forms.Produtos.Pesquisa().AbrirSeEstiverLogado(MdiParent);
        }

        private void CadastrarCliente(object sender, EventArgs e) {
            new Selling.Forms.Clientes.Cadastro().AbrirSeEstiverLogado(MdiParent);
        }

        private void ConsultarCredito(object sender, EventArgs e) {

        }

        private void CadastrarFabricante(object sender, LinkLabelLinkClickedEventArgs e) {
            new Stock.Forms.Fabricantes.Cadastro().AbrirSeEstiverLogado(MdiParent);
        }

        private void RelatorioReposicao(object sender, EventArgs e) {
            string _LocalRelatorio = Application.ExecutablePath + @"\relatorios\rptEstoqueReposicao.rpt";

            //frmReportViewer f = new frmReportViewer(_LocalRelatorio);

            //f.MdiParent = this.MdiParent;
            //f.Show();
        }
    }
}
