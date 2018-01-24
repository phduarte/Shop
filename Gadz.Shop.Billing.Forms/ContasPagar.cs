using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Billing.Data;
using Gadz.Shop.Billing.Model.Faturas;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Billing.Forms {
    public partial class ContasPagar : Form {

        //Connection conn = Program.conn;
        readonly IFaturaRepository _repository;
        readonly IUsuario user;

        public ContasPagar() {
            //user = Program.user;
            _repository = new FaturaRepository();
            InitializeComponent();
        }

        private void Limpar(object sender, EventArgs e) {
            cmbFornecedor.Text = "";
            dtPagamento.ResetText();
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void Salvar(object sender, EventArgs e) {

            var conta = new Fatura {
                FornecedorId = 0,
                FuncionarioId = 0,
                DataPagamento = DateTime.Today,
                Valor = 100D,
                Descricao = txtDescricao.Text,
            };

            if (conta.Exists) {
                _repository.Save(conta);
            } else {
                _repository.Add(conta);
            }
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {

            //frmAddFuncionario f = new frmAddFuncionario();

            //f.MdiParent = Program.frmMain;
            //f.Show();
        }

        private void Pesquisar(object sender, EventArgs e) {

            //var itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbFornecedor;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader("select id_fornecedor, fornecedor from tb_fornecedores where nome like '%" + cmbFornecedor.Text + "%'");

            //while (rec.Read())
            //    itens.Add(rec["id_fornecedor"].ToString(), rec["fornecedor"].ToString());

            var itens = _repository.Find(x=>x.FornecedorId == 0);

            cmbFornecedor.DataSource = new BindingSource(itens, null);
            cmbFornecedor.DisplayMember = "Value";
            cmbFornecedor.ValueMember = "Key";
            //cmbFornecedor.Text = _atual;

            //rec.Close();
        }

        private void Preencher(object sender, EventArgs e) {

        }

    }
}
