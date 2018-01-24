using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Clientes {
    public partial class Pesquisa : MdiBaseForm {

        public Pesquisa() {
            InitializeComponent();
        }

        private void Pesquisar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //sql = "select top 50 id_cliente, cliente, cpf, sexo, telefone, cep, lougradouro, numero, bairro, cidade "
            //    + "from vw_clientes "
            //    + "where cliente like '%" + txtNome.Text + "%'";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    dgLista.Rows.Add(rec["id_cliente"].ToString(),
            //                        rec["cliente"].ToString(),
            //                        rec["cpf"].ToString(),
            //                        rec["sexo"].ToString(),
            //                        rec["telefone"].ToString(),
            //                        rec["cep"].ToString(),
            //                        rec["lougradouro"].ToString(),
            //                        rec["numero"].ToString(),
            //                        rec["bairro"].ToString(),
            //                        rec["cidade"].ToString()
            //    );

            //rec.Close();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            new Cadastro().ShowInside(_currentMdiParent);
        }

        private void Editar(object sender, EventArgs e) {

            var grid = (DataGridView)sender;
            string cpf;

            if (grid.SelectedRows.Count > 0) {

                cpf = grid.SelectedRows[0].Cells["cpf"].Value.ToString();

                new Cadastro(cpf).ShowInside(_currentMdiParent);
            }
        }
    }
}