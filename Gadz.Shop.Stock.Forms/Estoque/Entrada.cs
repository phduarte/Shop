using Gadz.Shop.Commom.Forms;
using System.Windows.Forms;

namespace Gadz.Shop.Stock.Forms.Estoque {
    public partial class Entrada : MdiBaseForm {

        public int id_produto { get; set; }

        public Entrada() {
            InitializeComponent();
        }

        public Entrada(int id_produto) {
            this.id_produto = id_produto;
            InitializeComponent();
        }

        private void Salvar(object sender, System.EventArgs e) {

            //string sql;
            //string dt_fabricacao;
            //string dt_validade;

            //dt_fabricacao = chkFabricacao.Checked ? txtDataFabricacao.Value.ToString() : "";
            //dt_validade = chkValidade.Checked ? txtDataValidade.Value.ToString() : "";

            //sql = "set dateformat dmy "
            //    + "insert tb_estoque(id_produto,data_inicial,data_compra,data_fabricacao,data_validade,estoque_inicial,local_estoque) "
            //    + "values(" + cmbProduto.SelectedValue.ToString() + ",GETDATE(),'" + dtCompra.Value.ToString() + "','" + dt_fabricacao + "','" + dt_validade + "','" + txtQtd.Text + "','" + cmbLocal.Text + "');";

            //if (conn.ExecuteNonQuery(sql))
            //    MessageBox.Show(null,"Estoque atualizado com sucesso.",Program.Name);
            //else
            //    MessageBox.Show(null,"Erro ao atualizar estoque",Program.Name);
        }

        private void Limpar(object sender, System.EventArgs e) {

            cmbCategoria.SelectedIndex = -1;
            cmbProduto.SelectedIndex = -1;

            dtCompra.ResetText();
            txtQtd.Text = "";

            cmbLocal.SelectedIndex = -1;

            chkFabricacao.Checked = false;
            chkValidade.Checked = false;

            cmbCategoria.Focus();
        }

        private void ListarCategorias(object sender, System.EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual, sql;

            //sql = "select a.id_categoria, a.grupo + '-' + a.subgrupo + '-' + a.categoria as categoria "
            //    + "from tb_categorias a inner join tb_produtos b on a.id_categoria = b.id_categoria "
            //    + "group by a.id_categoria, a.grupo, a.subgrupo, a.categoria "
            //    + "order by a.grupo, a.subgrupo, a.categoria";

            //ComboBox _combo = (ComboBox)sender;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    itens.Add(rec["id_categoria"].ToString(), rec["categoria"].ToString());

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();

            //cmbProduto.SelectedIndex = -1;
        }

        private void ListarProdutos(object sender, System.EventArgs e) {

            //if (cmbCategoria.SelectedIndex > -1) {

            //    Dictionary<string, string> itens = new Dictionary<string, string>();
            //    SqlDataReader rec;
            //    string _atual, sql;
            //    ComboBox _combo = (ComboBox)sender;

            //    _atual = _combo.Text;

            //    sql = "select id_produto, nome_produto "
            //        + "from tb_produtos "
            //        + "where id_categoria = '" + cmbCategoria.SelectedValue.ToString() + "' "
            //        + "order by nome_produto";

            //    rec = conn.ExecuteReader(sql);

            //    while (rec.Read())
            //        itens.Add(rec["id_produto"].ToString(), rec["nome_produto"].ToString());

            //    _combo.DataSource = new BindingSource(itens, null);
            //    _combo.DisplayMember = "Value";
            //    _combo.ValueMember = "Key";
            //    _combo.Text = _atual;

            //    rec.Close();
            //}
        }

        private void DataFabricacao(object sender, System.EventArgs e) {
            txtDataFabricacao.Enabled = chkFabricacao.Checked;
        }

        private void DataValidade(object sender, System.EventArgs e) {
            txtDataValidade.Enabled = chkValidade.Checked;
        }

        private void CadastrarProduto(object sender, LinkLabelLinkClickedEventArgs e) {
            new Produtos.Cadastro().ShowInside(_currentMdiParent);
        }

        private void CadastrarCategoria(object sender, LinkLabelLinkClickedEventArgs e) {
            new Categorias.Cadastro().ShowInside(_currentMdiParent);
        }
    }
}