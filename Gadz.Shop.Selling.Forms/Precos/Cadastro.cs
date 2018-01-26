using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms.Precos {
    public partial class Cadastro : Form {

        public Cadastro() {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;
            //string id_produto;
            //string _precoVenda;
            //string _precoCompra;
            //string _precoPrazo;

            //id_produto = cmbProduto.SelectedValue.ToString();
            //_precoVenda = Funcoes.RemoveMask(txtPrecoVenda.Text.Trim()).Replace(",",".");
            //_precoCompra = Funcoes.RemoveMask(txtPrecoCompra.Text.Trim()).Replace(",", ".");
            //_precoPrazo = Funcoes.RemoveMask(txtPrecoPrazo.Text.Trim()).Replace(",", ".");

            //string _data_termino = chkTermina.Checked ? cmbDataFim.Value.ToString() : cmbDataInicio.Value.ToString();

            //sql = "exec sp_precos "
            //    + "@id_produto = '" + id_produto.ToString() + "',"
            //    + "@desc_preco = 'ATUALIZADO',"
            //    + "@data_preco = '" + cmbDataInicio.Value.ToString() + "',"
            //    + "@preco_venda = '" + _precoVenda + "',"
            //    + "@preco_compra = '" + _precoCompra + "',"
            //    + "@preco_prazo = '" + _precoPrazo + "',"
            //    + "@situacao_preco = 'Normal',"
            //    + "@id_funcionario = '" + user.ID.ToString() + "',"
            //    + "@data_termino = '" + _data_termino + "'";

            //if (conn.ExecuteNonQuery(sql))
            //    MessageBox.Show(null, "Preço do produto atualizado com sucesso.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //else
            //    MessageBox.Show(null, "Erro ao atualizar o preço do produto.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar(object sender, EventArgs e) {

            cmbCategoria.SelectedIndex = -1;
            cmbProduto.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

            imgProduto.ImageLocation = "";
            txtPrecoVenda.Text = "";
            txtPrecoCompra.Text = "";
            txtPrecoPrazo.Text = "";
            cmbDataInicio.ResetText();
            cmbDataFim.ResetText();
            cmbDataFim.Enabled = false;
            chkTermina.Checked = false;
        }

        private void ListarCategorias(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbCategoria;
            //string sql;

            //sql = "select a.id_categoria, grupo + '-' + subgrupo + '-' + categoria as categoria "
            //    + "from tb_categorias a inner join tb_produtos b on a.id_categoria = b.id_categoria "
            //    + "group by a.id_categoria, grupo, subgrupo, categoria "
            //    + "order by grupo, subgrupo, categoria;";

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read()) {
            //    itens.Add(rec["id_categoria"].ToString(), rec["categoria"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();

            //cmbProduto.Text = "";
        }

        private void ListarProdutos(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbProduto;
            //string sql;

            //_atual = _combo.Text;

            //sql = "select id_produto, nome_produto "
            //    + "from tb_produtos "
            //    + "where id_categoria = " + cmbCategoria.SelectedValue.ToString() + " "
            //    + "order by nome_produto";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read()) {
            //    itens.Add(rec["id_produto"].ToString(), rec["nome_produto"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();
        }

        private void TestarDataFim(object sender, EventArgs e) {

            cmbDataFim.Enabled = chkTermina.Checked;
        }

        private void BuscarImagem(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;
            //string id_produto;

            //id_produto = cmbProduto.SelectedValue.ToString();

            //if (id_produto != "") {

            //    sql = "select imagem from tb_produtos where id_produto=" + id_produto + ";";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.Read())
            //        imgProduto.ImageLocation = rec["imagem"].ToString();

            //    rec.Close();
            //}
        }

        private void ValidarPrecoVenda(object sender, EventArgs e) {

            //float _venda = float.Parse(Funcoes.RemoveMask(txtPrecoVenda.Text));
            //float _prazo = float.Parse(Funcoes.RemoveMask(txtPrecoPrazo.Text));
            //float _compra = float.Parse(Funcoes.RemoveMask(txtPrecoCompra.Text));

            //try {

            //    if (_venda < _compra) {
            //        txtPrecoVenda.Text = txtPrecoCompra.Text;
            //        MessageBox.Show("Preço da venda não pode ser menor do que o preço de compra.");
            //    }

            //    if (_prazo < _venda)
            //        txtPrecoPrazo.Text = txtPrecoVenda.Text;
            //}
            //catch {
            //}
        }

        private void ValidarPrecoCompra(object sender, EventArgs e) {

            //float _venda = float.Parse(Funcoes.RemoveMask(txtPrecoVenda.Text));
            //float _prazo = float.Parse(Funcoes.RemoveMask(txtPrecoPrazo.Text));
            //float _compra = float.Parse(Funcoes.RemoveMask(txtPrecoCompra.Text));

            //if (_compra > 0) {

            //    txtPrecoVenda.Text = _venda == 0 ? txtPrecoCompra.Text : txtPrecoVenda.Text;
            //    txtPrecoPrazo.Text = _prazo == 0 ? txtPrecoVenda.Text : txtPrecoPrazo.Text;

            //    try {
            //        if (_compra > _venda)
            //            txtPrecoVenda.Text = txtPrecoCompra.Text;

            //        if (_prazo < _venda)
            //            txtPrecoPrazo.Text = txtPrecoVenda.Text;
            //    }
            //    catch {
            //    }
            //}
        }

        private void ValidarPrecoPrazo(object sender, EventArgs e) {

            //float _venda = float.Parse(Funcoes.RemoveMask(txtPrecoVenda.Text));
            //float _prazo = float.Parse(Funcoes.RemoveMask(txtPrecoPrazo.Text));

            //try {
            //    if (_prazo < _venda)
            //        txtPrecoPrazo.Text = txtPrecoVenda.Text;
            //}
            //catch {
            //}
        }
    }
}
