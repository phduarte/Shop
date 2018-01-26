using System;
using System.Windows.Forms;

namespace Gadz.Shop.Billing.Forms {
    public partial class ContasPagar : Form {

        readonly BillingServices _services;

        public ContasPagar() {
            _services = BillingServices.Instance;
            InitializeComponent();
        }

        private void Limpar(object sender, EventArgs e) {
            cmbFornecedor.Text = "";
            dtPagamento.ResetText();
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void Salvar(object sender, EventArgs e) {
            var conta = _services.PegarConta(string.Empty);
            _services.SalvarPagamento(conta);
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {

            //frmAddFuncionario f = new frmAddFuncionario();

            //f.MdiParent = Program.frmMain;
            //f.Show();
        }

        private void Pesquisar(object sender, EventArgs e) {

            var itens = _services.ListarFornecedores();

            cmbFornecedor.DataSource = new BindingSource(itens, null);
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.ValueMember = "Id";
            //cmbFornecedor.Text = _atual;
        }

        private void Preencher(object sender, EventArgs e) {

        }
    }
}
