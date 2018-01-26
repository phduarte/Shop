using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gadz.Shop.Commom.Forms;

namespace Gadz.Shop.HR.Forms.Funcionarios {
    public partial class Cadastro : MdiBaseForm {

        private int _id_funcionario;
        private string _cpf;
        private bool _closeAfterSave = false;
        
        public Cadastro() {
            InitializeComponent();
        }

        public Cadastro(int id_funcionario) : this() {
            _id_funcionario = id_funcionario;
        }

        public Cadastro(string cpf) {
            _cpf = cpf;
            InitializeComponent();
        }

        private void Abrir(object sender, EventArgs e) {

            ListarPerfil(sender, e);
            txtCPF.Text = _cpf;

            if (!String.IsNullOrEmpty(_cpf)) {
                _closeAfterSave = true;
                btnLimpar.Visible = false;
                PreencherFuncionario(_cpf);
            } else if (_id_funcionario != 0) {
                _closeAfterSave = true;
                btnLimpar.Visible = false;
                PreencherFuncionario(_id_funcionario);
            }
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;
            //string perfil;

            //if (Valida()) {

            //    if (MessageBox.Show(null, "Tem certeza que deseja salvar os dados do funcionário?", Program.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

            //        perfil = cmbPerfil.SelectedValue == null ? "0" : cmbPerfil.SelectedValue.ToString();

            //        sql = "exec sp_funcionarios "
            //            + "@id_funcionario = '" + _id_funcionario.ToString() + "',"
            //            + "@nome = '" + cmbNome.Text.ToUpper() + "',"
            //            + "@cargo = '" + cmbCargo.Text.ToUpper() + "',"
            //            + "@email = '" + txtEmail.Text + cmbEmailDominio.Text + "',"
            //            + "@usuario = '" + txtUsuario.Text + "',"
            //            + "@senha = '" + txtSenha.Text + "',"
            //            + "@perfil = '" + perfil + "',"
            //            + "@dt_nascimento = '" + dtNascimento.Value.ToShortDateString() + "',"
            //            + "@cpf = '" + Funcoes.RemoveMask(txtCPF.Text) + "',"
            //            + "@telefone = '" + Funcoes.RemoveMask(txtTelefone.Text) + "',"
            //            + "@celular = '" + Funcoes.RemoveMask(txtCelular.Text) + "',"
            //            + "@lougradouro = '" + txtEndereco.Text.ToLower() + "',"
            //            + "@bairro = '" + txtBairro.Text + "',"
            //            + "@cidade = '" + cmbCidade.Text + "',"
            //            + "@cep = '" + Funcoes.RemoveMask(txtCEP.Text) + "',"
            //            + "@numero = '" + txtNumero.Text + "',"
            //            + "@status = 'A',"
            //            + "@situacao = '" + cmbSituacao.Text + "',"
            //            + "@complemento = '" + txtComplemento.Text + "',"
            //            + "@escolaridade = '" + cmbEscolaridade.Text + "',"
            //            + "@escolaridade_status = '" + cmbEscolaridadeComp.Text + "',"
            //            + "@estado_civil = '" + cmbEstadoCivil.Text + "',"
            //            + "@sexo = '" + cmbSexo.Text + "',"
            //            + "@filhos = '" + cmbFilhos.Text + "',"
            //            + "@current_user = '" + user.Login + "'";

            //        if (conn.ExecuteNonQuery(sql)) {
            //            MessageBox.Show(null, "Cadastro realizado com sucesso.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            Limpar(sender, e);

            //            if (_closeAfterSave)
            //                Close();
            //        } else
            //            MessageBox.Show(null, "Erro ao realizar cadastro.\nConsulte o administrador.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //} else
            //    MessageBox.Show(null, "Todos os campos são de preenchimento obrigatório.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar(object sender, EventArgs e) {

            _id_funcionario = 0;

            lbSituacaoCPF.Visible = false;

            //desbloquea os campos não editáveis
            txtCPF.Enabled = true;
            txtUsuario.Enabled = true;

            //
            cmbNome.DataSource = null;
            cmbNome.Items.Clear();
            cmbNome.Text = "";
            cmbSexo.SelectedIndex = -1;
            txtCPF.Text = "";
            dtNascimento.ResetText();
            cmbCargo.Text = "";
            cmbSituacao.SelectedIndex = -1;
            cmbEscolaridade.SelectedIndex = -1;
            cmbEscolaridadeComp.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbFilhos.SelectedIndex = -1;

            //
            txtTelefone.Text = "31";
            txtCelular.Text = "31";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            cmbCidade.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCEP.Text = "";
            txtEmail.Text = "";
            cmbEmailDominio.Text = "";

            dgHistoricoSalarial.Rows.Clear();

            cmbEnderecoTipo.SelectedIndex = -1;
            cmbEmailDominio.SelectedIndex = -1;
            radAtivo.Checked = true;
            radInativo.Checked = false;
            cmbEnderecoTipo.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            cmbCidade.Enabled = true;
            //
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirma.Text = "";
            cmbPerfil.SelectedIndex = -1;

            //
            dgHistoricoSalarial.Rows.Clear();

            //
            txtCPF.Focus();
        }

        private void ListarFuncionarios(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual, sql;
            //ComboBox _combo = cmbNome;

            //_atual = _combo.Text.Replace("(Coleção)", "");
            //_combo.DataSource = null;
            //_combo.Items.Clear();

            //sql = "select top 20 id_funcionario, nome "
            //    + "from tb_funcionarios "
            //    + "where nome like '%" + _atual.Replace(" ", "%") + "%'";

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {
            //    while (rec.Read())
            //        itens.Add(rec["id_funcionario"].ToString(), rec["nome"].ToString());

            //    _combo.DataSource = new BindingSource(itens, null);
            //    _combo.DisplayMember = "Value";
            //    _combo.ValueMember = "Key";
            //}

            //_combo.Text = _atual;

            //rec.Close();

        }

        private void PreencherFuncionario(int id_funcionario) {

            //if (id_funcionario != 0) {

            //    string sql;
            //    SqlDataReader rec;

            //    sql = "select top 1 * "
            //        + "from vw_funcionarios "
            //        + "where id_funcionario = '" + id_funcionario + "'";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.HasRows) {

            //        rec.Read();

            //        _cpf = rec["CPF"].ToString();

            //        txtCPF.Text = rec["CPF"].ToString();
            //        cmbNome.Text = rec["nome"].ToString();
            //        cmbSexo.Text = rec["sexo"].ToString();
            //        dtNascimento.Value = DateTime.Parse(rec["dt_nascimento"].ToString());
            //        cmbCargo.Text = rec["cargo"].ToString();
            //        cmbSituacao.Text = rec["situacao"].ToString();
            //        cmbEscolaridade.Text = rec["escolaridade"].ToString();
            //        cmbEscolaridadeComp.Text = rec["escolaridade_status"].ToString();

            //        cmbEstadoCivil.Text = rec["estado_civil"].ToString();
            //        cmbFilhos.Text = rec["filhos"].ToString();
            //        txtTelefone.Text = rec["telefone"].ToString();
            //        txtCelular.Text = rec["celular"].ToString();

            //        txtCEP.Text = rec["cep"].ToString();
            //        txtNumero.Text = rec["numero"].ToString();
            //        txtComplemento.Text = rec["complemento"].ToString();

            //        txtEmail.Text = Funcoes.Left(rec["email"].ToString(), rec["email"].ToString().IndexOf("@"));
            //        cmbEmailDominio.Text = rec["email"].ToString().Replace(txtEmail.Text, "");

            //        txtUsuario.Text = rec["usuario"].ToString();
            //        txtSenha.Text = "*********";
            //        txtConfirma.Text = "*********";
            //        cmbPerfil.Text = rec["perfil"].ToString();

            //        //bloquea os campos que não podem ser editados
            //        txtCPF.Enabled = false;
            //        txtUsuario.Enabled = false;

            //    } else {

            //        Limpar(null, null);

            //    }

            //    rec.Close();

            //    string cep = Funcoes.RemoveMask(txtCEP.Text);

            //    if (cep != "")
            //        PreencherCEP(null, null);

            //    this.PreencherSalarios(Funcoes.RemoveMask(txtCPF.Text));
            //}
        }

        private void PreencherFuncionario(string cpf) {

            //if (cpf != "") {

            //    string sql;
            //    SqlDataReader rec;

            //    lbSituacaoCPF.Visible = !Funcoes.ValidaCPF(cpf);

            //    sql = "select top 1 * "
            //        + "from vw_funcionarios "
            //        + "where cpf = '" + cpf + "'";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.HasRows) {

            //        rec.Read();

            //        _id_funcionario = int.Parse(rec["id_funcionario"].ToString());

            //        cmbNome.Text = rec["nome"].ToString();
            //        cmbSexo.Text = rec["sexo"].ToString();
            //        dtNascimento.Value = DateTime.Parse(rec["dt_nascimento"].ToString());
            //        cmbCargo.Text = rec["cargo"].ToString();
            //        cmbSituacao.Text = rec["situacao"].ToString();
            //        cmbEscolaridade.Text = rec["escolaridade"].ToString();
            //        cmbEscolaridadeComp.Text = rec["escolaridade_status"].ToString();

            //        cmbEstadoCivil.Text = rec["estado_civil"].ToString();
            //        cmbFilhos.Text = rec["filhos"].ToString();
            //        txtTelefone.Text = rec["telefone"].ToString();
            //        txtCelular.Text = rec["celular"].ToString();

            //        txtCEP.Text = rec["cep"].ToString();
            //        txtNumero.Text = rec["numero"].ToString();
            //        txtComplemento.Text = rec["complemento"].ToString();

            //        txtEmail.Text = Funcoes.Left(rec["email"].ToString(), rec["email"].ToString().IndexOf("@"));
            //        cmbEmailDominio.Text = rec["email"].ToString().Replace(txtEmail.Text, "");

            //        txtUsuario.Text = rec["usuario"].ToString();
            //        txtSenha.Text = "*********";
            //        txtConfirma.Text = "*********";

            //        switch (rec["perfil"].ToString()) {
            //            case "1":
            //                cmbPerfil.Text = "Gerente";
            //                break;
            //            case "2":
            //                cmbPerfil.Text = "Estoquista";
            //                break;
            //            case "3":
            //                cmbPerfil.Text = "Vendedor";
            //                break;
            //            case "4":
            //                cmbPerfil.Text = "Caixa";
            //                break;
            //        }

            //        //bloquea os campos que não podem ser editados
            //        txtCPF.Enabled = false;
            //        txtUsuario.Enabled = false;

            //    }

            //    rec.Close();

            //    string cep = Funcoes.RemoveMask(txtCEP.Text);

            //    if (cep != "")
            //        PreencherCEP(null, null);

            //    PreencherSalarios(cpf);
            //} else
            //    lbSituacaoCPF.Visible = false;
        }

        private void MudarFuncionario(object sender, EventArgs e) {

            //switch (sender.GetType().Name) {
            //    case "MaskedTextBox":

            //        _cpf = Funcoes.RemoveMask(((MaskedTextBox)sender).Text);
            //        PreencherFuncionario(_cpf);

            //        break;

            //    case "ComboBox":

            //        if (((ComboBox)sender).SelectedValue != null) {
            //            _id_funcionario = int.Parse(((ComboBox)sender).SelectedValue.ToString());

            //            PreencherFuncionario(_id_funcionario);
            //        }

            //        break;

            //    default:
            //        break;
            //}
        }

        private void PreencherSalarios(string cpf) {

            //if (cpf != "") {

            //    string sql;
            //    SqlDataReader rec;

            //    sql = "select top 10 * "
            //        + "from vw_funcionario_salarios "
            //        + "where cpf = '" + cpf + "' "
            //        + "order by dt_inicio desc";

            //    rec = conn.ExecuteReader(sql);

            //    dgHistoricoSalarial.Rows.Clear();

            //    if (rec.HasRows) {

            //        string _dt_cadastro;
            //        string _dt_inicio;
            //        string _valor;

            //        while (rec.Read()) {

            //            _dt_cadastro = string.Format("{0:dd/MM/yyyy}", DateTime.Parse(rec["dt_cadastro"].ToString()));
            //            _dt_inicio = string.Format("{0:dd/MM/yyyy}", DateTime.Parse(rec["dt_inicio"].ToString()));
            //            _valor = string.Format("{0:C}", float.Parse(rec["valor"].ToString()));

            //            dgHistoricoSalarial.Rows.Add(_dt_cadastro, _dt_inicio, _valor);
            //        }
            //    }

            //    rec.Close();
            //}
        }

        private void ProgramarSalario(object sender, LinkLabelLinkClickedEventArgs e) {

            //var f = new frmAlteracaoSalarial(Funcoes.RemoveMask(txtCPF.Text));

            //f.MdiParent = Program.frmMain;
            //f.TopMost = true;
            //f.Show();
        }

        private void ListarPerfil(object sender, EventArgs e) {

            Dictionary<string, string> itens = new Dictionary<string, string>();
            string _atual;
            ComboBox _combo = cmbPerfil;

            _atual = _combo.Text;

            _combo.Items.Clear();

            itens.Add("1", "Gerente");
            itens.Add("2", "Estoquista");
            itens.Add("3", "Vendedor");
            itens.Add("4", "Caixa");

            _combo.DataSource = new BindingSource(itens, null);
            _combo.DisplayMember = "Value";
            _combo.ValueMember = "Key";
            _combo.Text = _atual;

        }

        private void PreencherCEP(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;
            //string cep;

            //cep = Funcoes.RemoveMask(txtCEP.Text);
            //sql = "select top 1 * "
            //    + "from tb_enderecos "
            //    + "where cep = '" + cep + "';";

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

            //} else {
            //    cmbEnderecoTipo.Enabled = true;
            //    txtEndereco.Enabled = true;
            //    txtBairro.Enabled = true;
            //    cmbCidade.Enabled = true;
            //}

            //rec.Close();

        }

        private void PesquisarEndereco(object sender, LinkLabelLinkClickedEventArgs e) {
            new Enderecos.Pesquisa(txtCEP).ShowInside(_currentMdiParent);
        }

        private void SenhaPadrao(object sender, KeyEventArgs e) {
            txtSenha.Text = txtUsuario.Text;
            txtConfirma.Text = txtSenha.Text;
        }

        private bool Valida() {

            bool b = false;

            //b = !String.IsNullOrEmpty(cmbNome.Text);
            //b = b && !String.IsNullOrEmpty(Funcoes.RemoveMask(txtCPF.Text));
            //b = b && !String.IsNullOrEmpty(Funcoes.RemoveMask(txtCEP.Text));
            //b = b && !String.IsNullOrEmpty(cmbCargo.Text);
            //b = b && !String.IsNullOrEmpty(cmbSituacao.Text);
            //b = b && !String.IsNullOrEmpty(cmbSexo.Text);
            //b = b && !String.IsNullOrEmpty(cmbEscolaridade.Text);
            //b = b && !String.IsNullOrEmpty(cmbEstadoCivil.Text);
            //b = b && !String.IsNullOrEmpty(cmbFilhos.Text);
            //b = b && !String.IsNullOrEmpty(txtNumero.Text);
            //b = b && !String.IsNullOrEmpty(txtBairro.Text);
            //b = b && !String.IsNullOrEmpty(txtEmail.Text);
            //b = b && !String.IsNullOrEmpty(txtUsuario.Text);
            //b = b && !String.IsNullOrEmpty(cmbPerfil.Text);
            //b = b && !String.IsNullOrEmpty(cmbEnderecoTipo.Text);
            //b = b && !String.IsNullOrEmpty(cmbCidade.Text);

            return b;
        }
    }
}
