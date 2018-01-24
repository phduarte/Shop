using System;
using System.Windows.Forms;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.Admin.Forms.Clientes {
    public partial class Cadastro : MdiBaseForm {
        private int _id_cliente;
        private string _cpf;

        public Cadastro() {
            InitializeComponent();
        }

        public Cadastro(string cpf) : this() {
            _cpf = cpf;
        }

        private void Abrir(object sender, EventArgs e) {
            //txtCPF.Text = _cpf;

            //if (Funcoes.RemoveMask(txtCPF.Text) != "") {
            //    _closeAfterSave = true;
            //    btnLimpar.Visible = false;
            //    PreencherCliente(sender, e);
            //}
        }

        private void Salvar(object sender, EventArgs e) {

            //if (Valida()) {

            //    if (MessageBox.Show(null, "Tem certeza que deseja salvar os dados do cliente?", Program.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

            //        string sql = "exec sp_clientes "
            //                   + "@id_cliente = '" + _id_cliente.ToString() + "',"
            //                   + "@cliente = '" + cmbNome.Text + "',"
            //                   + "@cpf = '" + Funcoes.RemoveMask(txtCPF.Text) + "',"
            //                   + "@sexo = '" + cmbSexo.Text + "',"
            //                   + "@telefone = '" + Funcoes.RemoveMask(txtTelefone.Text) + "',"
            //                   + "@celular = '" + Funcoes.RemoveMask(txtCelular.Text) + "',"
            //                   + "@comercial = '" + Funcoes.RemoveMask(txtComercial.Text) + "',"
            //                   + "@cep = '" + Funcoes.RemoveMask(txtCEP.Text) + "',"
            //                   + "@lougradouro = '" + txtEndereco.Text + "',"
            //                   + "@bairro = '" + txtBairro.Text + "',"
            //                   + "@cidade = '" + cmbCidade.Text + "',"
            //                   + "@numero = '" + txtNumero.Text + "',"
            //                   + "@complemento = '" + txtComplemento.Text + "',"
            //                   + "@obs = '" + txtObs.Text + "',"
            //                   + "@indicacao = '" + cmbIndicao.Text + "',"
            //                   + "@email = '" + txtEmail.Text + cmbEmailDominio.Text + "',"
            //                   + "@dt_nascimento = '" + txtDataNascimento.Value.ToShortDateString() + "',"
            //                   + "@current_user = '" + user.Login + "'";

            //        if (conn.ExecuteNonQuery(sql)) {

            //            MessageBox.Show(null, "Cadastro atualizado.", Program.Name);
            //            Limpar(sender, e);

            //            if (_closeAfterSave)
            //                Close();

            //        } else {
            //            MessageBox.Show(null, "Erro ao atualizar o cadastro.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //} else
            //    MessageBox.Show(null, "Os campos amarelos são de preenchimento obrigatório.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar(object sender, EventArgs e) {

            lbSituacaoCPF.Visible = false;

            //dados de identificação
            cmbNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.ResetText();
            cmbSexo.SelectedIndex = -1;

            //dados de contato
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtComercial.Text = "";
            txtEmail.Text = "";
            cmbEmailDominio.Text = "";

            //dados de endereço
            cmbEnderecoTipo.SelectedIndex = -1;
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            cmbCidade.SelectedIndex = -1;

            cmbEnderecoTipo.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            cmbCidade.Enabled = true;

            txtObs.Text = "";
            cmbIndicao.Text = "";
            cmbIndicao.SelectedIndex = -1;

            txtCPF.Focus();
        }

        private void PreencherCliente(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;
            //string cpf;
            //int sexo;

            //cpf = Funcoes.RemoveMask(txtCPF.Text);

            //if(cpf == "")
            //    lbSituacaoCPF.Visible = false;
            //else
            //    lbSituacaoCPF.Visible = !Funcoes.ValidaCPF(cpf);

            //sql = "select * "
            //    + "from vw_clientes "
            //    + "where cpf = '" + cpf + "';";

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {

            //    rec.Read();

            //    _id_cliente = int.Parse(rec["id_cliente"].ToString());

            //    String dominio;
            //    String email;

            //    email = rec["email"].ToString();
            //    dominio = Funcoes.Rigth(email, email.Length - email.LastIndexOf("@"));
            //    email = Funcoes.Left(email, email.IndexOf("@"));

            //    sexo = rec["sexo"].ToString() == "M" ? 0 : 1;

            //    //dados de identificação
            //    cmbNome.Text = rec["cliente"].ToString();
            //    txtDataNascimento.Text = rec["dt_nascimento"].ToString();
            //    cmbSexo.SelectedIndex = sexo;

            //    //dados de contato
            //    txtTelefone.Text = rec["telefone"].ToString();
            //    txtCelular.Text = rec["celular"].ToString();
            //    txtComercial.Text = rec["comercial"].ToString();
            //    txtEmail.Text = email;

            //    for (int i = 0; i < cmbEmailDominio.Items.Count; i++)
            //        if (cmbEmailDominio.Items[i].ToString() == dominio) {
            //            cmbEmailDominio.SelectedIndex = i;
            //            break;
            //        }

            //    //dados de endereço
            //    txtCEP.Text = rec["cep"].ToString();

            //    for (int i = 0; i < cmbEnderecoTipo.Items.Count; i++)
            //        if (cmbEnderecoTipo.Items[i].ToString() == rec["tipo"].ToString()) {
            //            cmbEnderecoTipo.SelectedIndex = i;
            //            break;
            //        }

            //    txtNumero.Text = rec["numero"].ToString();
            //    txtBairro.Text = rec["bairro"].ToString();
            //    txtComplemento.Text = rec["complemento"].ToString();
            //    txtObs.Text = rec["obs"].ToString();

            //    for (int i = 0; i < cmbIndicao.Items.Count; i++)
            //        if (cmbIndicao.Items[i].ToString() == rec["indicacao"].ToString()) {
            //            cmbIndicao.SelectedIndex = i;
            //            break;
            //        }

            //    for (int i = 0; i < cmbCidade.Items.Count; i++)
            //        if (cmbCidade.Items[i].ToString() == rec["cidade"].ToString()) {
            //            cmbCidade.SelectedIndex = i;
            //            break;
            //        }
            //}

            //rec.Close();

            //if (txtCEP.Text != "")
            //    PreencherEndereco(null, null);

        }

        private void PreencherEndereco(object sender, EventArgs e) {

            //string sql;
            //string cep;
            //SqlDataReader rec;

            //cep = Funcoes.RemoveMask(txtCEP.Text);
            //sql = "select top 1 * from tb_enderecos where cep = '" + cep + "';";

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {

            //    rec.Read();

            //    cmbEnderecoTipo.Text = rec["tipo"].ToString();
            //    txtEndereco.Text = rec["lougradouro"].ToString();
            //    txtBairro.Text = rec["bairro"].ToString();
            //    cmbCidade.Text = rec["cidade"].ToString();

            //    cmbEnderecoTipo.Enabled = false;
            //    txtEndereco.Enabled = false;
            //    txtBairro.Enabled = false;
            //    cmbCidade.Enabled = false;
            //}

            //rec.Close();
        }

        private void PesquisarEndereco(object sender, LinkLabelLinkClickedEventArgs e) {
            new Enderecos.Pesquisa(txtCEP).ShowInside(_currentMdiParent);
        }

        private void ListarClientes(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual, sql;
            //ComboBox _combo = cmbNome;

            //sql = "select distinct top 30 cpf, cliente "
            //    + "from tb_clientes "
            //    + "where cliente like '%" + cmbNome.Text + "%'";

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    itens.Add(rec["cpf"].ToString(), rec["cliente"].ToString());

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();

        }

        private void MudarCliente(object sender, EventArgs e) {

            if (cmbNome.SelectedIndex > -1) {
                //this.txtCPF.Focus();
                txtCPF.Text = cmbNome.SelectedValue.ToString();
                PreencherCliente(sender, e);
            }
        }

        private bool Valida() {

            bool b = false;

            //b = Funcoes.RemoveMask(txtCPF.Text) != "";
            //b = b && cmbNome.Text != "";
            //b = b && Funcoes.RemoveMask(txtCEP.Text) != "";
            //b = b && cmbEnderecoTipo.Text != "";
            //b = b && txtEndereco.Text != "";
            //b = b && txtNumero.Text != "";
            //b = b && txtBairro.Text != "";
            //b = b && cmbCidade.Text != "";
            //b = b && txtEmail.Text != "";
            //b = b && cmbEmailDominio.Text != "";

            return b;
        }

    }
}