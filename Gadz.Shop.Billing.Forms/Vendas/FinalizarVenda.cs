using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    public partial class FinalizarVenda : Form
    {

        public int id_venda { get; set; }

        /// <summary>
        /// Inicia formulário de pagamento da venda (normalmente usado pelos caixas).
        /// </summary>
        /// <param name="id_venda">indica o código da venda a ser paga.</param>
        /// <param name="valor">indica o valor do preço da venda.</param>
        public FinalizarVenda() {
            InitializeComponent();
        }
        
        public FinalizarVenda(int id_venda) {
            InitializeComponent();
            this.id_venda = id_venda;
        }

        private void Abrir(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //sql = "select * "
            //    + "from tb_vendas "
            //    + "where id_venda = '" + id_venda.ToString() + "' and status_venda = 'EM NEGOCIACAO'";

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {

            //    rec.Read();

            //    float _valor;

            //    _valor = float.Parse(rec["prego_venda"].ToString()) - float.Parse(rec["prego_pago"].ToString());

            //    this.txtValorCompra.Text = String.Format("{0:C}", _valor);

            //} else {
            //    MessageBox.Show("Esta venda não está mais em status de negociação.\n\nPode já ter sido faturada ou ter sido cancelada.",Program.Name);
            //    this.Close();
            //}

            //rec.Close();
        }

        private void Finalizar(object sender, EventArgs e) {

            //string id_venda = this.id_venda.ToString();
            //string sql;
            //bool ok = false;

            //if (this.ValidaFormulario()) {

            //    if (MessageBox.Show(null, "Essa ação não poderá ser desfeita.\n\nVocê tem certeza sobre as opções de pagamento cadastradas?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {

            //        foreach (DataGridViewRow r in this.dgPagamentos.Rows) {

            //            sql = "exec sp_vendas_pagamentos "
            //                + "@id_venda = '" + id_venda + "',"
            //                + "@id_forma_pgto = '" + r.Cells["id_forma_pgto"].Value.ToString() + "',"
            //                + "@valor = '" + r.Cells["valor"].Value.ToString().Replace(",", ".") + "',"
            //                + "@obs = ''";

            //            if (conn.ExecuteNonQuery(sql)) {
            //                ok = true;
            //            } else {
            //                ok = false;
            //                break;
            //            }
            //        }

            //        if (ok) {
            //            MessageBox.Show(null, "Pagamento registrado com sucesso.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            this.Close();
            //        } else {
            //            MessageBox.Show(null, "Erro ao registrar pagamento. Contate o administrador.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //} else {
            //    MessageBox.Show(null, "Valor que está tentando pagar e maior do que o preço real da venda.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Cancelar(object sender, EventArgs e) {
            this.Close();
        }

        private void Adicionar(object sender, EventArgs e) {

            //if (this.lstFormaPgto.SelectedItems.Count > 0) {

            //    frmAdicionarDinheiro f = new frmAdicionarDinheiro(this);

            //    f.MdiParent = Program.frmMain;
            //    f.TopMost = true;
            //    f.Show();
            //}
        }

        private void Remover(object sender, EventArgs e) {
        
            foreach(DataGridViewRow r in this.dgPagamentos.SelectedRows)
                this.dgPagamentos.Rows.Remove(r);
        }

        internal void Recalcular(object sender, EventArgs e) {

            //Single i = 0, _valor = 0;

            //foreach(DataGridViewRow r in this.dgPagamentos.Rows)
            //    i += Convert.ToSingle(r.Cells["valor"].Value.ToString());

            //if (i > 0) {
            //    _valor = Single.Parse(Funcoes.RemoveMask(this.txtValorCompra.Text));
            //    _valor -= i;
            //}

            //this.txtPago.Text = String.Format("{0:C}", i);
            //this.txtRestante.Text = String.Format("{0:C}", _valor);
        }

        private void ListarFormaPgto(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //ListBox _combo = this.lstFormaPgto;
            //string sql;

            //sql = "select id_forma_pgto, forma_pgto "
            //    + "from tb_forma_pgto "
            //    + "where forma_pgto <> 'NAO INFORMADO' "
            //    + "order by id_forma_pgto";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    itens.Add(rec["id_forma_pgto"].ToString(), rec["forma_pgto"].ToString());

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";

            //rec.Close();

        }

        //<summary>
        //Garante que não será incluído valores acima do valor da venda.
        //</summary>
        private bool ValidaFormulario() {

            //float _restante;
            //string _valor;

            //_valor = Funcoes.RemoveMask(txtRestante.Text);

            //if (txtRestante.Text.StartsWith("-")) {
            //    _valor = "-" + _valor;
            //}

            //_restante = float.Parse(_valor);

            //return _restante >= 0 ? true : false;
            return false;
        }
    }
}