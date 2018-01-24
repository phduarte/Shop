using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Produtos {
    public partial class Pesquisa : MdiBaseForm {

        public Pesquisa() {
            InitializeComponent();
        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //if (chkCodigo.Checked) {

            //    sql = "select top 50 id_produto, cod_barras, nome_produto, categoria, grupo, subgrupo, estoque_atual, preco_venda "
            //        + "from vw_produtos  "
            //        + "where cod_barras = '" + this.txtCodigo.Text + "' and ordem_estoque = 1 "
            //        + "order by nome_produto asc;";

            //} else if(chkNome.Checked){

            //    sql = "select id_produto, cod_barras, nome_produto, categoria, grupo, subgrupo, estoque_atual, preco_venda "
            //        + "from vw_produtos "
            //        + "where nome_produto like '%" + this.txtNome.Text + "%' and ordem_estoque = 1 "
            //        + "order by nome_produto asc;";
            //}

            //if (sql != "") {
            //    rec = conn.ExecuteReader(sql);

            //    while (rec.Read())
            //        dgLista.Rows.Add(rec["id_produto"].ToString(), rec["cod_barras"].ToString(), rec["nome_produto"].ToString(), rec["categoria"].ToString(), rec["grupo"].ToString(), rec["subgrupo"].ToString(), rec["estoque_atual"].ToString(), String.Format("{0:C}", Single.Parse(rec["preco_venda"].ToString())));

            //    rec.Close();
            //}
        }

        private void Cadastrar(object sender, EventArgs e) {
            new Cadastro().ShowInside(_currentMdiParent);
        }

        private void Editar(object sender, EventArgs e) {

            DataGridView grid = (DataGridView)sender;
            DataGridViewRow r;
            string cod_barras;

            r = grid.SelectedCells[0].OwningRow;

            cod_barras = r.Cells["cod_barras"].Value.ToString();

            new Cadastro(cod_barras).ShowInside(_currentMdiParent);
        }
    }
}