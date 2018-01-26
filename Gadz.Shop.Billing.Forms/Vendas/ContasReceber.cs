using Gadz.Shop.Commom.Model;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Billing.Forms {
    public partial class ContasReceber : Form {

        BillingServices _services = BillingServices.Instance;

        public ContasReceber() {
            InitializeComponent();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            
            //frmAddCliente f = new frmAddCliente();

            //f.MdiParent = Program.frmMain;
            //f.Show();
        }

        private void Pesquisar(object sender, EventArgs e) {

            var itens = _services.ListarClientes();

            cmbCliente.DataSource = new BindingSource(itens, null);
            cmbCliente.DisplayMember = "Value";
            cmbCliente.ValueMember = "Key";
            //cmbCliente.Text = _atual;

        }

        private void Limpar(object sender, EventArgs e) {
            cmbCliente.Text = "";
            dtRecebimento.ResetText();
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void Salvar(object sender, EventArgs e) {

            var fatura = _services.PegarFatura(Identity.New());

            fatura.Cliente = _services.PegarCliente(cmbCliente.SelectedValue.ToString());
            fatura.DataRecebimento = dtRecebimento.Value.ToShortDateString();
            fatura.Valor = decimal.Parse(txtValor.Text);
            fatura.Descricao = txtDescricao.Text;
            _services.SalvarFatura(fatura);

        }
    }
}
