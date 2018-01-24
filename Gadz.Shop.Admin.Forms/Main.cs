using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Categorias.Cadastrar().ShowInside(this);
        }

        private void clientesToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Clientes.Pesquisa().ShowInside(this);
        }

        private void enderecosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Enderecos.Pesquisa().ShowInside(this);
        }

        private void estoqueToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Estoque.Excluir().Show();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Fabricantes.Pesquisa().ShowInside(this);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Fornecedores.Pesquisa().ShowInside(this);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Funcionarios.Pesquisa().ShowInside(this);
        }

        private void produtosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Produtos.Pesquisa().ShowInside(this);
        }

        private void salariosToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Salarios.Alteracao().ShowInside(this);
        }

        private void loginToolStripMenuItem_Click(object sender, System.EventArgs e) {
            new Access.Forms.Login().ShowInside(this);
        }
    }
}
