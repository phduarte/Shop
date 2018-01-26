using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.HR.Forms.Salarios {
    public partial class Cadastro : MdiBaseForm {

        private int _id_funcionario;
        private string _cpf = "";

        public Cadastro() {
            InitializeComponent();
        }

        public Cadastro(Form mdi, string cpf) : this() {
            _cpf = cpf;
        }

        private void Abrir(object sender, EventArgs e) {

            txtCPF.Text = _cpf;

            if (!string.IsNullOrEmpty(_cpf)) {
                btnLimpar.Visible = false;
                PreencherFuncionario(sender, e);
            }
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;

            //if (Valida()) {

            //    if (MessageBox.Show(null, "Tem certeza que deseja salvar os dados do salário do funcionário?", Program.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

            //        sql = "exec sp_funcionarios_salarios "
            //            + "@id_funcionario = '" + _id_funcionario.ToString() + "',"
            //            + "@usuario = '" + user.ID + "',"
            //            + "@dt_inicio = '" + dtInicio.Value.ToShortDateString() + "',"
            //            + "@valor = '" + Funcoes.RemoveMask(txtValor.Text).Replace(",", ".") + "'";

            //        if (conn.ExecuteNonQuery(sql)) {
            //            Limpar(sender, e);
            //            MessageBox.Show(null, "Programação cadastrada com sucesso.", Program.Name);

            //            if (_closeAfterSave)
            //                Close();
            //        } else
            //            MessageBox.Show(null, "Erro ao alterar o salário.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //} else
            //    MessageBox.Show(null, "Campos amarelo são obrigatórios.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar(object sender, EventArgs e) {

            cmbNome.DataSource = null;
            cmbNome.Items.Clear();
            cmbNome.Text = "";
            txtCPF.Text = "";
            txtCargo.Text = "";

            dtInicio.ResetText();
            txtValor.Text = "";
            cmbNome.Focus();

            cmbNome.Enabled = true;
            txtCargo.Enabled = true;
        }

        private void PreencherFuncionario(object sender, EventArgs e) {

            //string sql;
            //SqlDataReader rec;

            //sql = "select top 1 id_funcionario, nome, cargo from tb_funcionarios where cpf='" + Funcoes.RemoveMask(txtCPF.Text) + "'";

            //rec = conn.ExecuteReader(sql);

            //if (rec.Read()) {

            //    cmbNome.Text = rec["nome"].ToString();
            //    txtCargo.Text = rec["cargo"].ToString();

            //    cmbNome.Enabled = false;
            //    txtCargo.Enabled = false;

            //    _id_funcionario = int.Parse(rec["id_funcionario"].ToString());
            //}

            //rec.Close();
        }

        private void ListarFuncionarios(object sender, LinkLabelLinkClickedEventArgs e) {

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

        private void MudarFuncionario(object sender, EventArgs e) {
            if (cmbNome.SelectedIndex > -1) {
                txtCPF.Focus();
                txtCPF.Text = cmbNome.SelectedValue.ToString();
                txtValor.Focus();
            }
        }

        private void PesquisarFuncionarios(object sender, LinkLabelLinkClickedEventArgs e) {
            new Funcionarios.Pesquisa().ShowInside(_currentMdiParent);
        }

        private bool Valida() {

            bool b = false;

            //b = Funcoes.RemoveMask(txtCPF.Text) != "";
            //b = b && Funcoes.RemoveMask(txtValor.Text) != "";

            return b;
        }
    }
}
