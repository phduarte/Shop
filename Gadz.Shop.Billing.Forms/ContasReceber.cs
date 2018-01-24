using System;
using System.Windows.Forms;

namespace Gadz.Shop.Billing.Forms {
    public partial class ContasReceber : Form
    {

        //Connection conn = Program.conn;
        //Usuario user = Program.user;

        public ContasReceber() {
            InitializeComponent();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            
            //frmAddCliente f = new frmAddCliente();

            //f.MdiParent = Program.frmMain;
            //f.Show();
        }

        private void Pesquisar(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbCliente;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader("select id_cliente, cliente from tb_clientes where nome like '%" + cmbCliente.Text + "%'");

            //while (rec.Read())
            //    itens.Add(rec["id_cliente"].ToString(), rec["cliente"].ToString());

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();

        }

        private void Limpar(object sender, EventArgs e) {
            cmbCliente.Text = "";
            dtRecebimento.ResetText();
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;

            //sql = "exec sp_contas_receber "
            //    + "@id_cliente = '" + cmbCliente.SelectedValue.ToString() + "',"
            //    + "@id_funcionario = '" + user.ID.ToString() + "',"
            //    + "@dt_recebimento = '" + dtRecebimento.Value.ToShortDateString() + "',"
            //    + "@valor = '" + txtValor.Text + "',"
            //    + "@desc_pagamento = '" + txtDescricao.Text + "'";

            //if (conn.ExecuteNonQuery(sql))
            //    MessageBox.Show(null, "Conta cadastrada com sucesso.", Program.Name);
            //else
            //    MessageBox.Show(null, "Erro ao cadastrar conta.", Program.Name);

        }
    }
}
