using Gadz.Shop.Commom.Forms;
using System;

namespace Gadz.Shop.Admin.Forms.Fornecedores {
    public partial class Cadastro : MdiBaseForm {

        public Cadastro() {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;
            //SqlDataReader rec;
            //if (txtFornecedor.Text == "") {
            //    MessageBox.Show(null, "É necessário informar o nome da categoria.", Program.Name);
            //} else {
            //    //verifica se já existe fornecedor com esse nome
            //    sql = String.Format("select * from tb_fornecedores where nome = '{0}'", txtFornecedor.Text);

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.HasRows) {
            //        MessageBox.Show("Já existe um fornecedor com esse nome use as opções de Pesquisa para consultar", Program.Name);
            //    } else {

            //        rec.Close();

            //        sql = string.Format("INSERT tb_fornecedores(fornecedor) VALUES('{0}');", txtFornecedor.Text);

            //        if (conn.ExecuteNonQuery(sql)) {

            //            MessageBox.Show(null, "Cadastro realizado com sucesso.", Program.Name);

            //            txtFornecedor.Text = "";

            //        } else {
            //            MessageBox.Show(null, "Erro ao realizar cadastro.", Program.Name);
            //        }
            //    }

            //    rec.Dispose();
            //}
        }

        //private void txtFornecedor_KeyUp(object sender, KeyEventArgs e)
        //{
        //    SqlDataReader rec;
        //    string sql;

        //    sql = string.Format("select fornecedor from tb_fornecedores where fornecedor like '%{0}%';", this.txtFornecedor.Text);

        //    rec = conn.ExecuteReader(sql);

        //    while (rec.Read())
        //    {
        //        this.listFornecedores.Items.Add(rec["fornecedor"].ToString());
        //    }

        //    rec.Dispose();
        //}
    }
}