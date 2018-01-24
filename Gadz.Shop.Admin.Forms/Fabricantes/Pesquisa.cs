using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Fabricantes {
    public partial class Pesquisa : MdiBaseForm
    {
        public Pesquisa() {
            InitializeComponent();
        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //sql = "select top 50 id_fabricante, fabricante "
            //    + "from tb_fabricantes "
            //    + "where fabricante like '%" + txtNome.Text + "%' "
            //    + "order by fabricante asc;";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    dgLista.Rows.Add(rec["id_fabricante"].ToString(), rec["fabricante"].ToString());

            //rec.Close();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            new Cadastro().ShowInside(_currentMdiParent);
        }
    }
}