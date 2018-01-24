using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Funcionarios {
    public partial class Pesquisa : MdiBaseForm {

        public Pesquisa() {

            InitializeComponent();
        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //sql = "select top 50 id_funcionario, nome, cargo, usuario "
            //    + "from tb_funcionarios " 
            //    + "where nome like '%" + txtNome.Text + "%' "
            //    + "order by nome asc;";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    dgLista.Rows.Add(rec["id_funcionario"].ToString(), rec["nome"].ToString(), rec["cargo"].ToString(), rec["usuario"].ToString());

            //rec.Close();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            //var f = new frmAddFuncionario();

            //f.MdiParent = Program.frmMain;
            //f.TopMost = true;
            //f.Show();
        }

        private void Editar(object sender, EventArgs e) {

            //DataGridView grid = (DataGridView)sender;
            //int id_funcionario;

            //if (grid.SelectedRows.Count > 0) {

            //    id_funcionario = int.Parse(grid.SelectedRows[0].Cells["id_funcionario"].Value.ToString());

            //    frmAddFuncionario f = new frmAddFuncionario(id_funcionario);

            //    f.MdiParent = Program.frmMain;
            //    f.TopMost = true;
            //    f.Show();
            //}
        }
    }
}