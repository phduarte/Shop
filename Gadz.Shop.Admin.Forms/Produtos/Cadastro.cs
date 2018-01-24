using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Produtos {
    public partial class Cadastro : MdiBaseForm {

        private int _id_produto;
        private string _cod;
        private bool _closeAfterSave = false;
        
        public Cadastro() {
            InitializeComponent();
        }

        public Cadastro(string cod_barras) : this() {
            _cod = cod_barras;
        }

        private void Abrir(object sender, EventArgs e) {

            ListarCategoria(sender, e);
            ListarFabricante(sender, e);
            ListarFornecedor(sender, e);
            DefinirPermissoes(sender, e);

            txtCodigo.Text = _cod;

            if (txtCodigo.Text != "") {

                _closeAfterSave = true;

                btnLimpar.Visible = false;
                Preencher(sender, e);
            }
        }

        private void DefinirPermissoes(object sender, EventArgs e) {

            //if (user.Perfil == Usuario.TipoPerfil.Diretor)
            //    linkAddFornecedor.Enabled = true;
            //else {
            //    linkAddFornecedor.Enabled = false;
            //}

            //if (user.Perfil == Usuario.TipoPerfil.Gerente || user.Perfil == Usuario.TipoPerfil.Diretor) {
            //    linkAddCategoria.Enabled = true;
            //    linkAddFabricante.Enabled = true;
            //} else {
            //    linkAddCategoria.Enabled = false;
            //    linkAddFabricante.Enabled = false;
            //}
        }

        private void Preencher(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;

            //sql = "select top 1 * "
            //    + "from vw_produtos "
            //    + "where cod_barras = '" + txtCodigo.Text + "'";

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {

            //    rec.Read();

            //    _id_produto = int.Parse(rec["id_produto"].ToString());

            //    imgProduto.ImageLocation = rec["imagem"].ToString();
            //    cmbCategoria.SelectedValue = rec["id_categoria"].ToString();
            //    cmbFabricante.SelectedValue = rec["id_fabricante"].ToString();
            //    cmbFornecedor.SelectedValue = rec["id_fornecedor"].ToString();

            //    txtNome.Text = rec["nome_produto"].ToString();
            //    txtObs.Text = rec["obs"].ToString();

            //    cmbTipo.Text = rec["tipo_unidade"].ToString();
            //    txtPeso.Text = rec["peso"].ToString();
            //    txtEstoqueMinimo.Text = rec["estoque_minimo"].ToString();

            //    //bloqueia os campos que não podem ser editados
            //    txtCodigo.Enabled = false;
            //    txtQtd.Enabled = false;
            //    dtFabricacao.Enabled = false;
            //    dtCompra.Enabled = false;
            //    dtValidade.Enabled = false;
            //    txtPrecoCompra.Enabled = false;
            //    txtPrecoPrazo.Enabled = false;
            //    txtPrecoVenda.Enabled = false;
            //    cmbSetor.Enabled = false;

            //    txtQtd.Text = "*";
            //    dtFabricacao.ResetText();
            //    dtCompra.ResetText();
            //    dtValidade.ResetText();
            //    txtPrecoCompra.Text = "0";
            //    txtPrecoPrazo.Text = "0";
            //    txtPrecoVenda.Text = "0";

            //    lbStatusProduto.Visible = true;

            //}

            //rec.Close();
        }

        private void Salvar(object sender, EventArgs e) {

            //if (Valida()) {

            //    //salvar a imagem para a pasta do aplicativo.
            //    if (MessageBox.Show(null, "Tem certeza que deseja salvar os dados do produto?", Program.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {

            //        String origem = txtImagem.Text;
            //        String destino;

            //        if (origem != "") {

            //            destino = (Path.GetDirectoryName(Application.ExecutablePath) + "\\imagens\\produtos\\" + cmbCategoria.Text + "_" + txtNome.Text.ToLower() + Path.GetExtension(origem).ToLower().Replace(" ", "-"));

            //            if (!Directory.Exists(Path.GetDirectoryName(destino)))
            //                Directory.CreateDirectory(Path.GetDirectoryName(destino));

            //            try {
            //                File.Copy(origem, destino, true);
            //            } catch {
            //            }

            //        } else {
            //            destino = imgProduto.ImageLocation;
            //        }

            //        //cadastra o produto
            //        if (txtCodigo.Text != "") {

            //            string sql;
            //            string fabricante = "0";
            //            string fornecedor = "0";

            //            if (cmbFabricante.SelectedValue != null)
            //                fabricante = cmbFabricante.SelectedValue.ToString();

            //            if (cmbFornecedor.SelectedValue != null)
            //                fornecedor = cmbFornecedor.SelectedValue.ToString();

            //            string dimensoes = String.Format("{0}x{1}x{2}", txtLargura.Text, txtAltura.Text, txtProfundidade.Text);
            //            string fabricacao = checkBox1.Checked ? dtFabricacao.Value.ToString() : "";
            //            string validade = chkValidade.Checked ? dtValidade.Value.ToString() : "";

            //            sql = "exec sp_produtos "
            //                + "@id_produto = '" + _id_produto.ToString() + "',"
            //                + "@nome_produto = '" + txtNome.Text.Replace("'", "").ToUpper() + "',"
            //                + "@id_categoria = '" + cmbCategoria.SelectedValue + "',"
            //                + "@id_fornecedor = '" + fornecedor + "',"
            //                + "@id_fabricante = '" + fabricante + "',"
            //                + "@peso = '" + txtPeso.Text + "',"
            //                + "@dimensoes = '" + dimensoes + "',"
            //                + "@tipo_unidade = '" + cmbTipo.Text + "',"
            //                + "@estoque_minimo = '" + txtEstoqueMinimo.Text + "',"
            //                + "@imagem = '" + "imagens\\produtos\\" + Path.GetFileName(destino) + "',"
            //                + "@obs = '" + txtObs.Text.Replace("'", "") + "',"
            //                + "@cod_barras = '" + txtCodigo.Text + "',"
            //                + "@data_compra = '" + dtCompra.Value.ToShortDateString() + "',"
            //                + "@data_fabricacao = '" + fabricacao + "',"
            //                + "@data_validade = '" + validade + "',"
            //                + "@estoque_inicial = '" + txtQtd.Text.Replace("*", "0") + "',"
            //                + "@local_estoque = '" + cmbSetor.Text + "',"
            //                + "@desc_preco = 'CADASTRO',"
            //                + "@data_preco = '" + dtCompra.Value.ToString() + "',"
            //                + "@preco_venda = '" + Funcoes.RemoveMask(txtPrecoVenda.Text).Replace(",", ".") + "',"
            //                + "@preco_compra = '" + Funcoes.RemoveMask(txtPrecoCompra.Text).Replace(",", ".") + "',"
            //                + "@preco_prazo = '" + Funcoes.RemoveMask(txtPrecoPrazo.Text).Replace(",", ".") + "',"
            //                + "@situacao_preco = 'Normal'";

            //            if (conn.ExecuteNonQuery(sql)) {

            //                Limpar(sender, e);
            //                MessageBox.Show(null, "Produto cadastrado com sucesso.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //                if (_closeAfterSave)
            //                    Close();

            //            } else {
            //                MessageBox.Show(null, "Falha ao cadastrar produto.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        } else {
            //            txtCodigo.Focus();
            //            MessageBox.Show(null, "Necessário informar o código do produto", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //} else
            //    MessageBox.Show(null, "Todos os campos amarelos são de preenchimento obrigatório.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar(object sender, EventArgs e) {

            lbStatusProduto.Visible = false;

            //desbloqueia campos que podem ser cadastrados
            txtCodigo.Enabled = true;
            txtQtd.Enabled = true;
            dtCompra.Enabled = true;
            dtFabricacao.Enabled = false;
            dtValidade.Enabled = false;
            txtPrecoCompra.Enabled = true;
            txtPrecoPrazo.Enabled = true;
            txtPrecoVenda.Enabled = true;
            cmbSetor.Enabled = true;

            //Dados do produto
            imgProduto.ImageLocation = "";
            txtCodigo.Text = "";
            txtNome.Text = "";
            cmbCategoria.SelectedIndex = -1;
            txtObs.Text = "";

            //Estoque
            cmbTipo.Text = "";
            txtPeso.Text = "0";
            txtLargura.Text = "0";
            txtAltura.Text = "0";
            txtProfundidade.Text = "0";
            txtQtd.Text = "1";
            txtEstoqueMinimo.Text = "1";
            cmbSetor.SelectedIndex = -1;

            dtFabricacao.ResetText();
            dtValidade.ResetText();

            //Origem
            cmbFornecedor.SelectedIndex = -1;
            imgFornecedor.ImageLocation = "";
            cmbFabricante.SelectedIndex = -1;
            imgFabricante.ImageLocation = "";

            //Preço
            txtPrecoCompra.Text = "";
            txtPrecoVenda.Text = "";
            txtPrecoPrazo.Text = "";
            dtCompra.ResetText();

            txtCodigo.Focus();
        }

        private void ListarFornecedor(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbFornecedor;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader("select id_fornecedor, fornecedor from tb_fornecedores where status='A';");

            //itens.Add("", "");

            //while (rec.Read()) {
            //    itens.Add(rec["id_fornecedor"].ToString(), rec["fornecedor"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();
        }

        private void ListarFabricante(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbFabricante;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader("select id_fabricante, fabricante from tb_fabricantes");

            //itens.Add("", "");

            //while (rec.Read()) {
            //    itens.Add(rec["id_fabricante"].ToString(), rec["fabricante"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();
        }

        private void ListarCategoria(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = cmbCategoria;

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader("select id_categoria, grupo + '-' + subgrupo + '-' + categoria as categoria from tb_categorias order by grupo, subgrupo, categoria");

            //itens.Add("", "");

            //while (rec.Read()) {
            //    itens.Add(rec["id_categoria"].ToString(), rec["categoria"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();
        }

        private void CadastrarCategoria(object sender, LinkLabelLinkClickedEventArgs e) {
            new Categorias.Cadastro().ShowInside(_currentMdiParent);
        }

        private void CadastrarFabricante(object sender, LinkLabelLinkClickedEventArgs e) {
            new Fabricantes.Cadastro().ShowInside(_currentMdiParent);
        }

        private void CadastrarFornecedor(object sender, LinkLabelLinkClickedEventArgs e) {
            new Fornecedores.Cadastro().ShowInside(_currentMdiParent);
        }

        private void AlterarImagem(object sender, LinkLabelLinkClickedEventArgs e) {

            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.ShowDialog();

            if (arquivo.FileName != "") {
                txtImagem.Text = arquivo.FileName;
                imgProduto.ImageLocation = arquivo.FileName;
            }
        }

        private void LimparCodigo(object sender, EventArgs e) {
            txtCodigo.Clear();
        }

        private void ImagemFabricante(object sender, EventArgs e) {

            //string _categoria = cmbFabricante.Text;

            //if (_categoria != "") {

            //    string sql = "select top 1 logotipo from tb_fabricantes where fabricante = '" + _categoria + "' and logotipo is not null and logotipo <> '';";

            //    SqlDataReader rec;

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.Read()) {
            //        imgFabricante.ImageLocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + rec["logotipo"].ToString();
            //    }

            //    rec.Dispose();
            //}
        }

        private void txtObs_Leave(object sender, EventArgs e) {
            cmbFornecedor.Focus();
        }

        private void cmbFabricante_Leave(object sender, EventArgs e) {
            cmbTipo.Focus();
        }

        private void dtValidade_Leave(object sender, EventArgs e) {
            txtPrecoCompra.Focus();
        }

        private void cmbFornecedor_Leave(object sender, EventArgs e) {
            cmbFabricante.Focus();
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
            //} catch {
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
            //    } catch {
            //    }
            //}
        }

        private void ValidarPrecoPrazo(object sender, EventArgs e) {

            //float _venda = float.Parse(Funcoes.RemoveMask(txtPrecoVenda.Text));
            //float _prazo = float.Parse(Funcoes.RemoveMask(txtPrecoPrazo.Text));

            //try {
            //    if (_prazo < _venda)
            //        txtPrecoPrazo.Text = txtPrecoVenda.Text;
            //} catch {
            //}
        }

        private void cmbFabricante_Validated(object sender, EventArgs e) {
            ImagemFabricante(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            dtFabricacao.Enabled = checkBox1.Checked;
        }

        private void chkValidade_CheckedChanged(object sender, EventArgs e) {
            dtValidade.Enabled = chkValidade.Checked;
        }

        private bool Valida() {

            bool b = false;

            //b = txtCodigo.Text != "";
            //b = b && txtNome.Text != "";
            //b = b && Funcoes.RemoveMask(txtPrecoCompra.Text) != "";
            //b = b && Funcoes.RemoveMask(txtPrecoVenda.Text) != "";
            //b = b && Funcoes.RemoveMask(txtPrecoPrazo.Text) != "";
            //b = b && cmbCategoria.Text != "";
            //b = b && cmbFabricante.Text != "";
            //b = b && cmbFornecedor.Text != "";
            //b = b && txtQtd.Text != "";
            //b = b && txtEstoqueMinimo.Text != "";
            //b = b && cmbTipo.Text != "";
            //b = b && cmbSetor.Text != "";

            return b;

        }
    }
}