using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Stock.Forms.Fornecedores {
    public partial class Pesquisa : MdiBaseForm {

        public Pesquisa() {
            InitializeComponent();
        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //sql = "select top 50 id_fornecedor, fornecedor, desde "
            //    + "from tb_fornecedores "
            //    + "where fornecedor like '%" + txtNome.Text + "%' "
            //    + "order by fornecedor asc;";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    dgLista.Rows.Add(rec["id_fornecedor"].ToString(), rec["fornecedor"].ToString(), rec["desde"].ToString());

            //rec.Close();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            new Cadastro().ShowInside(_currentMdiParent);
        }
    }
}