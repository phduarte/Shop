using System;
using System.Windows.Forms;
using Gadz.Shop.Commom.Utils;

namespace Gadz.Shop.Selling.Forms {
    public partial class CadastrarVenda : Form {
        //Usuario user = Program.user;
        //frmMain frmMain = Program.frmMain;

        public int _id_venda { set; get; }
        public int id_estoque { set; get; }
        public int id_produto { set; get; }
        public int id_preco { set; get; }

        public CadastrarVenda(int id_venda = 0) {

            //Program.frmAddVenda = this;

            this._id_venda = id_venda;

            InitializeComponent();
        }

        private void Abrir(object sender, EventArgs e) {

            //this.usuario = user;
            //this.lbPerfil.Text = user.Nome;

            if (_id_venda != 0) {
                this.Preencher(_id_venda);
            } else
                this.NovaVenda(sender, e);
        }

        private void Fechar(object sender, FormClosingEventArgs e) {
            //if (MessageBox.Show(null, "Você tem certeza que deseja fechar esta tela?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            //    e.Cancel = true;
            //else {

            //    string sql;

            //    sql = "delete tb_vendas "
            //        + "from tb_vendas a left join tb_vendas_itens b "
            //        + "on a.id_venda = b.id_venda "
            //        + "where a.id_venda = '" + _id_venda.ToString() + "' and b.id_venda is null";

            //    conn.ExecuteNonQuery(sql);
            //}
        }

        private void NovaVenda(object sender, EventArgs e) {

            //bool _b = false;

            //if (_id_venda != 0) {

            //    _b = MessageBox.Show(null, "Já existe uma venda em andamento. Deseja cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes;

            //    if (_b) {
            //        string sql;

            //        sql = "UPDATE tb_vendas SET status_venda = 'CANCELADA' where id_venda = '" + this._id_venda.ToString() + "'";

            //        conn.ExecuteNonQuery(sql);
            //    }
            //} else {

            //    _b = true;

            //    this._id_venda = 0;
            //    this.Limpar(null, null);
            //    this.dgLista.Rows.Clear();
            //    this.txtTotal.Text = "R$ 0,00";
            //}

            //if (_b) {

            //    frmIniciarVenda f = new frmIniciarVenda(this);
            //    f.ShowDialog();
            //}
        }

        private void Limpar(object sender, EventArgs e) {

            this.id_preco = -1;
            this.id_estoque = -1;
            this.id_produto = 0;

            this.imgProduto.ImageLocation = "";

            this.txtCodigo.Text = "";
            this.txtDescricao.Text = "";
            this.txtValorUnitario.Text = "R$ 0,00";
            this.txtQuantidade.Text = "0";
            this.txtQtdDisponivel.Text = "0";
            this.txtSubTotal.Text = "R$ 0,00";

            this.lbObsTitulo.Text = "";
            this.lbObsDetalhes.Text = "";

            this.Recalcular(sender, e);
        }

        private void Preencher(int id_venda) {

            //string sql;
            //SqlDataReader rec;

            //sql = "select protocolo, cod_barras, nome_produto, preco_venda, qtd, subtotal, id_venda_itens "
            //    + "from vw_vendas "
            //    + "where id_venda = " + id_venda.ToString();

            //rec = conn.ExecuteReader(sql);

            //if (rec.HasRows) {

            //    while (rec.Read()) {
            //        this.lbProtocolo.Text = rec["protocolo"].ToString();
            //        this.dgLista.Rows.Add(rec["cod_barras"].ToString(), rec["nome_produto"].ToString(), rec["preco_venda"].ToString(), rec["qtd"].ToString(), rec["subtotal"].ToString(), rec["id_venda_itens"].ToString());
            //    }
            //}

            //rec.Close();

        }

        private void Pesquisa(object sender, EventArgs e) {

            //string _cod_barras = this.txtCodigo.Text;
            //SqlDataReader rec;

            //this.Limpar(sender, e);
            //this.txtCodigo.Text = _cod_barras;

            //if (_cod_barras != "") {

            //    string sql = "select top 1 id_preco,id_produto, id_estoque, nome_produto, preco_venda," +
            //                 "obs,grupo, subgrupo,categoria, fabricante,fornecedor, imagem, estoque_atual " +
            //                 "from vw_produtos " +
            //                 "where cod_barras = '" + _cod_barras + "';";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.HasRows) {

            //        rec.Read();

            //        this.id_preco = Convert.ToInt32(rec["id_preco"].ToString());
            //        this.id_produto = Convert.ToInt32(rec["id_produto"].ToString());
            //        this.txtDescricao.Text = rec["nome_produto"].ToString();
            //        this.lbObsTitulo.Text = rec["fabricante"].ToString() + "/" + rec["grupo"].ToString() + "/" + rec["subgrupo"].ToString();
            //        this.lbObsDetalhes.Text = rec["obs"].ToString();
            //        this.imgProduto.ImageLocation = rec["imagem"].ToString();

            //        rec.Close();

            //        //consultar estoque
            //        this.AtualizarPreco(null, null);
            //        this.AtualizarEstoque(null, null);
            //        this.txtQuantidade.Text = "0";

            //        if (int.Parse(this.txtQtdDisponivel.Text) > 0)
            //            this.txtQuantidade.Text = (float.Parse(this.txtQuantidade.Text) + 1).ToString();

            //        this.Recalcular(sender, e);
            //        this.txtQuantidade.Focus();

            //    } else {

            //        rec.Close();

            //        bool _x;

            //        //_x = user.Perfil == Usuario.TipoPerfil.Diretor;
            //        //_x = _x || user.Perfil == Usuario.TipoPerfil.Estoquista;
            //        //_x = _x || user.Perfil == Usuario.TipoPerfil.Gerente;

            //        _x = user.Perfil != Usuario.TipoPerfil.Vendedor;

            //        if (_x) {
            //            _x = MessageBox.Show(null, "O produto que você procura não foi encontrado.\n\nDeseja cadastrá-lo?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;

            //            if (_x) {

            //                frmCadastrarProduto f = new frmCadastrarProduto();

            //                f.MdiParent = Program.frmMain;
            //                f.TopMost = true;
            //                f.Show();
            //            } else {
            //                this.Limpar(sender, e);
            //            }
            //        } else {

            //            MessageBox.Show(null, "O produto que você procura não foi encontrado.\n\nSe o código estiver correto, solicite ao estoquista ou seu gerente que realize o cadastra do produto.", Program.Name);

            //        }
            //    }

            //    rec.Dispose();
            //}
        }

        private void AtualizarEstoque(object sender, EventArgs e) {

            //string _cod = this.id_produto.ToString();

            //if (_cod != "") {

            //    string sql;
            //    SqlDataReader rec;

            //    sql = "select top 1 id_estoque,SUM(case when vendidos >= estoque_inicial then 0 else estoque_inicial - vendidos end) as estoque_atual "
            //        + "from dbo.vw_estoque_status "
            //        + "where id_produto = " + _cod + " "
            //        + "group by id_estoque "
            //        + "order by estoque_atual desc;";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.Read()) {
            //        this.txtQtdDisponivel.Text = rec["estoque_atual"].ToString();
            //        this.id_estoque = int.Parse(rec["id_estoque"].ToString());
            //    } else {
            //        this.txtQtdDisponivel.Text = "0";
            //        this.id_estoque = 0;
            //    }

            //    rec.Close();
            //}
        }

        private void AtualizarPreco(object sender, EventArgs e) {

            //string _cod = this.id_produto.ToString();

            //if (_cod != "") {

            //    string sql;
            //    SqlDataReader rec;

            //    sql = "select top 1 id_preco, preco_venda,DATEDIFF(second,data_preco,getdate()) as tempo "
            //        + "from tb_precos "
            //        + "where id_produto = " + _cod + " "
            //        + "order by tempo asc;";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.Read()) {
            //        this.txtValorUnitario.Text = String.Format("{0:C}", Convert.ToSingle(rec["preco_venda"].ToString()));
            //        this.id_preco = Convert.ToInt32(rec["id_preco"].ToString());
            //    } else {
            //        this.txtValorUnitario.Text = String.Format("{0:C}", 0);
            //        this.id_preco = -1;
            //    }

            //    rec.Close();
            //}
        }

        private void Recalcular(object sender, EventArgs e) {

            string _qtd = this.txtQuantidade.Text;
            string _vlr = this.txtValorUnitario.Text;

            Single qtd = 0.0F;
            Single vlr = 0.0F;
            Single i = 0.0F;

            if (_qtd != "" && _vlr != "") {

                qtd = Convert.ToSingle(this.txtQuantidade.Text);
                vlr = Convert.ToSingle(Funcoes.RemoveMask(this.txtValorUnitario.Text));

                this.txtSubTotal.Text = String.Format("{0:C}", ValorTotal(qtd, vlr));

                foreach (DataGridViewRow r in dgLista.Rows)
                    i += Convert.ToSingle(Funcoes.RemoveMask(r.Cells[4].Value.ToString()));

                this.txtTotal.Text = String.Format("{0:C}", i);

            } else {

                this.txtSubTotal.Text = String.Format("{0:C}", 0);

            }
        }

        private void Adicionar(object sender, EventArgs e) {

            //if (this.txtCodigo.Text == "") {

            //    this.txtCodigo.Focus();

            //    MessageBox.Show(null, "Informe o código do produto...", Program.Name);

            //} else if (this.txtQuantidade.Text == "0") {

            //    this.txtQuantidade.Focus();

            //    MessageBox.Show(null, "Selecione a quantidade que deseja adicionar na lista.", Program.Name);

            //} else {

            //    int i = 0;
            //    string sql;

            //    sql = "insert tb_vendas_itens(id_venda,id_produto,id_estoque,id_preco,qtd) "
            //        + "values(" + _id_venda.ToString() + "," + id_produto.ToString() + "," + id_estoque.ToString() + "," + id_preco.ToString() + "," + this.txtQuantidade.Text.Replace(",", ".") + ");";

            //    if (conn.ExecuteNonQuery(sql)) {

            //        string id_venda_itens;
            //        SqlDataReader rec;

            //        sql = "select max(id_venda_itens) as id_venda_itens "
            //            + "from tb_vendas_itens "
            //            + "where id_venda = '" + _id_venda.ToString() + "' and id_produto = '" + id_produto.ToString() + "'";

            //        rec = conn.ExecuteReader(sql);

            //        rec.Read();
            //        id_venda_itens = rec["id_venda_itens"].ToString();
            //        rec.Close();

            //        this.dgLista.Rows.Add(this.txtCodigo.Text, this.txtDescricao.Text, this.txtValorUnitario.Text, this.txtQuantidade.Text, this.txtSubTotal.Text, id_venda_itens);

            //        foreach (DataGridViewRow r in dgLista.Rows)
            //            i += Convert.ToInt32(r.Cells[3].Value.ToString());

            //        this.lbProdutosLista.Text = string.Format("{0} Produto(s) em sua lista", i);

            //        //this.txtQuantidade.Text = (int.Parse(this.txtQuantidade.Text) - 1).ToString();
            //        this.Recalcular(sender, e);
            //        this.AtualizarEstoque(sender, e);
            //        this.Limpar(sender, e);
            //    }
            //}
        }

        private void Excluir(object sender, EventArgs e) {

            //bool b = false;

            //if (this.dgLista.SelectedCells.Count > 0) {

            //    b = MessageBox.Show(null, "Tem certeza que deseja excluir o item selecionado?", Program.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes;

            //    if (b) {

            //        DataGridViewRow r;
            //        string id;

            //        r = this.dgLista.SelectedCells[0].OwningRow;

            //        id = r.Cells["id_venda_itens"].Value.ToString();

            //        string sql;

            //        sql = "delete tb_vendas_itens where id_venda_itens = " + id + ";";

            //        if (conn.ExecuteNonQuery(sql)) {
            //            MessageBox.Show(null, "Item excluído com sucesso.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            dgLista.Rows.Remove(r);
            //            this.Recalcular(null, null);
            //        } else
            //            MessageBox.Show(null, "Erro ao excluir item.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void FinalizarVenda(object sender, EventArgs e) {

            float total = float.Parse(Funcoes.RemoveMask(this.txtTotal.Text));
            FinalizarVenda f = new FinalizarVenda(this._id_venda);

            f.TopMost = true;
            f.ShowDialog();
        }

        private void GoToCodigo(object sender, EventArgs e) {
            this.txtCodigo.Focus();
        }

        private void ValidaCodigo(object sender, EventArgs e) {

            if (this.txtCodigo.Text != "") {
                this.Pesquisa(sender, e);
            } else {
                this.txtCodigo.Focus();
            }
        }

        private void Submit(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ValidaCodigo(sender, null);
            }
        }

        private void Funcao(object sender, KeyEventArgs e) {

            //MessageBox.Show(e.KeyCode.ToString());

            if (e.KeyCode == Keys.Space) {
                this.Limpar(null, null);
                this.txtCodigo.Focus();
                e.Handled = false;
            } else if (e.KeyCode == Keys.F1) {
                this.ProcurarProduto(sender, e);
            } else if (e.KeyCode == Keys.F2) {
                this.NovaVenda(sender, e);
            } else if (e.KeyCode == Keys.F3) {
                this.Adicionar(null, null);
                this.txtCodigo.Focus();
            } else if (e.KeyCode == Keys.F4) {
                this.Excluir(null, null);
            } else if (e.KeyCode == Keys.F5) {
                this.FinalizarVenda(sender, e);
            } else if (e.KeyCode == Keys.F7) {
                this.Sair(null, null);
            }
        }

        private void DefineQuantidade(object sender, KeyEventArgs e) {

            bool found = false; //valida se o valor é alterado

            this.AtualizarEstoque(null, null);

            if (e.KeyCode == Keys.Add) {
                this.txtQuantidade.Text = (Convert.ToSingle(this.txtQuantidade.Text) + 1.0).ToString();
                found = true;
            } else if (e.KeyCode == Keys.Subtract) {
                this.txtQuantidade.Text = (Convert.ToSingle(this.txtQuantidade.Text) - 1.0).ToString();
                found = true;
            } else if (e.KeyCode == Keys.Enter) {
                found = true;
            }

            if (found)
                this.Recalcular(sender, e);
        }

        private Single ValorTotal(Single qtd, Single valor) {

            Single _total = 0;

            _total = qtd * valor;

            return _total;
        }

        private void ValidaQuantidade(object sender, KeyPressEventArgs e) {

            bool _teste = true;

            //MessageBox.Show(e.KeyChar.ToString());

            if (Char.IsDigit(e.KeyChar)) {
                _teste = false;
            } else {

                switch (e.KeyChar.ToString()) {
                    case ",":
                        _teste = false;
                        break;
                }
            }

            e.Handled = _teste;
        }

        private void ValidaEstoque(object sender, EventArgs e) {

            string _qtd = this.txtQuantidade.Text;

            if (_qtd != "") {

                Single x = Convert.ToSingle(this.txtQuantidade.Text);
                Single y = Convert.ToSingle(this.txtQtdDisponivel.Text);

                if (x > y) {
                    this.txtQuantidade.Text = this.txtQtdDisponivel.Text;
                    MessageBox.Show("Não há estoque disponível para a quantidade desejada!\n\nO número em azul mostra o limite disponível para este produto.");
                } else if (x < 0) {
                    this.txtQuantidade.Text = "0";
                }

            } else {
                this.txtQuantidade.Text = "0";
            }
        }

        private void Sair(object sender, EventArgs e) {
            this.Close();
        }

        private void FuncaoExcluir(object sender, EventArgs e) {

            bool b;

            b = this.dgLista.SelectedRows.Count > 0;
            this.btnExcluir.Visible = b;
        }

        private void ProcurarProduto(object sender, EventArgs e) {
            //new frmPesquisarProduto().ShowDialog();
        }
    }
}