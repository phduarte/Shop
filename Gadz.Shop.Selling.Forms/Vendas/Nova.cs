using Gadz.Shop.Access.Forms;
using Gadz.Shop.Commom.Forms;
using Gadz.Shop.Commom.Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms.Vendas {
    public partial class Nova : MdiBaseForm {

        SellingServices _services = SellingServices.Instance;
        TaskScheduler _threadUI;

        public Nova() {
            _threadUI = TaskScheduler.FromCurrentSynchronizationContext();
            InitializeComponent();
            Load += Logar;
        }

        private void MostarTela() {
            Task.Factory.StartNew(()=> {
                if (Program.Sessao.Logada) {
                    Show();
                } else {
                    Close();
                }
            }, CancellationToken.None, TaskCreationOptions.None, _threadUI);
        }

        private void Logar(object sender, EventArgs e) {

            if (!Program.Sessao.Logada) {
                Hide();
                new Login().ShowDialog();

                Show();
            }
        }



        private void btnIniciar_Click(object sender, EventArgs e) {
            
            if(string.IsNullOrWhiteSpace(txtNome.Text) && string.IsNullOrWhiteSpace(txtCPF.Text)) {
                lbErro.Visible = true;
                lbErro.Text = "Informe um nome ou CPF";
                return;
            }

            var cliente = _services.PegarCliente(By.Cpf(txtCPF.Text));
            var venda = _services.CriarNovaVenda(cliente);
            Limpar();

            Hide();

            new Carrinho(venda.Id).ShowDialog();

            Show();
        }

        private void lnkLocalizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            _services.ProcurarClientes(By.Nome(txtNome.Text));
        }

        void Limpar() {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            lbErro.Visible = false;
            lbErro.Text = "";
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                PesquisarNome();
            }
        }

        private bool PesquisarNome() {

            var cliente = _services.PegarCliente(By.Cpf(txtCPF.Text));

            if(cliente != null) {
                txtNome.Text = cliente.Nome;
                txtNome.ReadOnly = true;
                return true;
            }

            return false;
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnIniciar_Click(sender, e);
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e) {

            txtNome.Text = string.Empty;

            if (txtCPF.TextLength == 11) {
                if (PesquisarNome()) {
                    btnIniciar.Focus();
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e) {
            PesquisarNome();
        }
    }
}
