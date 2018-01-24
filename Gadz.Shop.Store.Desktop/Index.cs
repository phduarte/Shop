using System;
using System.Windows.Forms;
using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Access.Services;
using Gadz.Shop.Access.Forms;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.Store {
    public partial class Index : MdiBaseForm {

        private IUsuario _usuario => new AccessServices().CurrentUserLogged();

        public Index() {
            InitializeComponent();
        }

        private void CadastrarProduto(object sender, EventArgs e) {
            new Admin.Forms.Produtos.Cadastro().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void PesquisarProduto(object sender, EventArgs e) {
            new Admin.Forms.Produtos.Pesquisa().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void AdicionarEstoque(object sender, EventArgs e) {
            new Admin.Forms.Estoque.Entrada().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void PesquisarFornecedor(object sender, EventArgs e) {
            new Admin.Forms.Fornecedores.Pesquisa().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void CadastrarFornecedores(object sender, EventArgs e) {
            new Admin.Forms.Fornecedores.Cadastro().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void PesquisarFabricantes(object sender, EventArgs e) {
            new Admin.Forms.Fabricantes.Pesquisa().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void AtualizarPrecos(object sender, EventArgs e) {
            new Admin.Forms.Precos.Cadastro().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void PesquisarPrecos(object sender, EventArgs e) {
            new Admin.Forms.Produtos.Pesquisa().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void CadastrarCliente(object sender, EventArgs e) {
            new Admin.Forms.Clientes.Cadastro().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void ConsultarCredito(object sender, EventArgs e) {

        }

        private void CadastrarFabricante(object sender, LinkLabelLinkClickedEventArgs e) {
            new Admin.Forms.Fabricantes.Cadastro().AbrirSeEstiverLogado(_currentMdiParent);
        }

        private void RelatorioReposicao(object sender, EventArgs e) {
            string _LocalRelatorio = Application.ExecutablePath + @"\relatorios\rptEstoqueReposicao.rpt";

            //frmReportViewer f = new frmReportViewer(_LocalRelatorio);

            //f.MdiParent = this.MdiParent;
            //f.Show();
        }
    }
}
