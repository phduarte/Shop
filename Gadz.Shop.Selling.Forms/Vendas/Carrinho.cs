using System;
using System.Diagnostics;
using System.Windows.Forms;
using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Vendas;

namespace Gadz.Shop.Selling.Forms.Vendas {
    public partial class Carrinho : Form {

        private Identity _id;
        readonly SellingServices _services;
        readonly IVenda _venda;

        public Carrinho(Identity id) {
            _services = SellingServices.Instance;
            _venda = _services.BuscarVenda(id);
            _id = id;
            InitializeComponent();
        }

        private void Abrir(object sender, EventArgs e) {
            if (!_id.Empty) {
                Preencher(_id);
            } else
                NovaVenda(sender, e);
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

            imgProduto.ImageLocation = "";

            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtValorUnitario.Text = "R$ 0,00";
            txtQuantidade.Text = "0";
            txtQtdDisponivel.Text = "0";
            txtSubTotal.Text = "R$ 0,00";

            lbObsTitulo.Text = "";
            lbObsDetalhes.Text = "";

            Recalcular(sender, e);
        }

        private void Preencher(string id_venda) {

            lbProtocolo.Text = _venda.Id;

            AtualizarLista();
        }

        private void Pesquisa(object sender, EventArgs e) {


            var produto = _services.PegarProdutoPorSku(txtCodigo.Text);

            if (produto == null) {

                if (PodeCadastrarProduto()) {

                    if(MessageBox.Show("O produto que você procura não foi encontrado.\n\nDeseja cadastrá-lo?", string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes){

                        //                frmCadastrarProduto f = new frmCadastrarProduto();

                        //                f.MdiParent = Program.frmMain;
                        //                f.TopMost = true;
                        //                f.Show();
                    }

                } else {
                    MessageBox.Show("O produto que você procura não foi encontrado.\n\nSe o código estiver correto, solicite ao estoquista ou seu gerente que realize o cadastra do produto.");
                }

                return;
            }


            //produto.Adicionar();

            Limpar(sender, e);
            txtCodigo.Text = produto.Sku;

            txtDescricao.Text = produto.Nome.ToUpper();
            //lbObsTitulo.Text = produto.Fabricante + "/" + produto.Grupo + "/" + produto.SubGrupo;
            lbObsDetalhes.Text = produto.Descricao.ToUpper();
            imgProduto.ImageLocation = produto.Imagem;
            txtValorUnitario.Text = string.Format("{0:C}", produto.Preco);
            txtQtdDisponivel.Text = produto.Estoque.ToString();
            txtQuantidade.Text = produto.Quantidade.ToString();

            Recalcular(sender, e);
            txtQuantidade.Focus();
        }

        private static bool PodeCadastrarProduto() {

            bool _x;
            var perfil = Program.Sessao.Usuario.Perfil;

            _x = perfil == Perfil.Diretor;
            _x = _x || perfil == Perfil.Estoquista;
            _x = _x || perfil == Perfil.Gerente;

            return _x;
        }

        private void Recalcular(object sender, EventArgs e) {
            txtTotal.Text = string.Format("{0:C}", _venda.ValorTotal);
        }

        private void Adicionar(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) {
                txtCodigo.Focus();
                MessageBox.Show("Informe o código do produto...");
                return;
            }

            if (txtQuantidade.Text == "0") {
                txtQuantidade.Focus();
                MessageBox.Show("Selecione a quantidade que deseja adicionar na lista.");
                return;
            }

            var produto = _services.PegarProdutoPorSku(txtCodigo.Text);

            _venda.Add(produto);

            AtualizarLista();
            Recalcular(sender, e);
            Limpar(sender, e);
        }

        private void AtualizarLista() {

            dgLista.DataSource = null;
            dgLista.Refresh();

            foreach (var i in _venda.Produtos) {
                dgLista.Rows.Add(i.Sku, i.Nome, i.Preco.ToString(), i.Quantidade.ToString(), i.SubTotal.ToString(), i.Id.ToString());
            }

            lbProdutosLista.Text = string.Format("{0} Produto(s) em sua lista", _venda.Produtos.Count);
        }

        private void Excluir(object sender, EventArgs e) {

            var perfil = Program.Sessao.Usuario.Perfil;

            if (!(perfil == Perfil.Gerente || perfil == Perfil.Diretor)) {
                return;
            }


            if (dgLista.SelectedCells.Count == 0) {
                return;
            }

            var r = dgLista.SelectedCells[0].OwningRow;
            var id = r.Cells["id_venda_itens"].Value.ToString();

            _venda.Remove(id);
            _services.SalvarVenda(_venda);

            AtualizarLista();
        }

        private void FinalizarVenda(object sender, EventArgs e) {
            _services.FinalizarVenda(_venda);
            Close();
        }

        private void GoToCodigo(object sender, EventArgs e) {
            txtCodigo.Focus();
        }

        private void ValidaCodigo(object sender, EventArgs e) {

            if (!string.IsNullOrWhiteSpace(txtCodigo.Text.Replace(" ",""))) {
                Pesquisa(sender, e);
            } else {
                GoToCodigo(sender, e);
            }
        }

        private void Submit(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ValidaCodigo(sender, null);
            }
        }

        private void Funcao(object sender, KeyEventArgs e) {
            
            if(txtCodigo.TextLength == 13) {
                Pesquisa(sender, e);
            }

            switch (e.KeyCode) {
                case Keys.Space:
                    Limpar(null, null);
                    txtCodigo.Focus();
                    e.Handled = false;
                    break;

                case Keys.Enter:
                Pesquisa(sender, e);
                    break;

                case Keys.F1:
                ProcurarProduto(sender, e);
                    break;

                case Keys.F2:
                    NovaVenda(sender, e);
                    break;

                case Keys.F3:
                    Adicionar(null, null);
                    txtCodigo.Focus();
                    break;

                case Keys.F4:
                    Excluir(null, null);
                    break;

                case Keys.F5:
                    FinalizarVenda(sender, e);
                    break;

                case Keys.F7:
                case Keys.Escape:
                    Sair(null, null);
                    break;

                case Keys.F11:
                    TopMost = !TopMost;
                    FormBorderStyle = FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.Sizable : FormBorderStyle.None ;
                    WindowState = FormWindowState.Maximized;
                    break;

                default:
                    Debug.WriteLine(e.KeyCode.ToString());
                    break;
            }
        }

        private void DefineQuantidade(object sender, KeyEventArgs e) {

            bool found = false; //valida se o valor é alterado
            var produto = _services.PegarProdutoPorSku(txtCodigo.Text);

            if (e.KeyCode == Keys.Add) {
                produto.Adicionar();
                found = true;
            } else if (e.KeyCode == Keys.Subtract) {
                produto.Remover();
                found = true;
            } else if ((int)e.KeyCode >= 96 && (int)e.KeyCode <= 105) {

                found = true;
            }

            txtQuantidade.Text = produto.Quantidade.ToString("N1");

            if (found) {
                _venda.Add(produto);
                Recalcular(sender, e);
            }
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

            string _qtd = txtQuantidade.Text;

            if (_qtd != "") {

                Single x = Convert.ToSingle(txtQuantidade.Text);
                Single y = Convert.ToSingle(txtQtdDisponivel.Text);

                if (x > y) {
                    txtQuantidade.Text = txtQtdDisponivel.Text;
                    MessageBox.Show("Não há estoque disponível para a quantidade desejada!\n\nO número em azul mostra o limite disponível para este produto.");
                } else if (x < 0) {
                    txtQuantidade.Text = "0";
                }

            } else {
                txtQuantidade.Text = "0";
            }
        }

        private void Sair(object sender, EventArgs e) {
            Close();
        }

        private void FuncaoExcluir(object sender, EventArgs e) {
            btnExcluir.Visible = dgLista.SelectedRows.Count > 0;
        }

        private void ProcurarProduto(object sender, EventArgs e) {
            //new frmPesquisarProduto().ShowDialog();
        }
    }
}