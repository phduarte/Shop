using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Admin.Forms.Categorias {

    public partial class Cadastrar : MdiBaseForm {

        public int id_categoria = 0;

        public Cadastrar() {
            InitializeComponent();
        }

        private void ListarGrupos(object sender, EventArgs e) {

            //SqlDataReader rec;

            //string sql = "select distinct grupo "
            //           + "from tb_categorias "
            //           + "order by grupo;";

            //cmbGrupo.Items.Clear();
            //cmbSubGrupo.Items.Clear();
            //cmbCategoria.Items.Clear();
            //cmbSubGrupo.Text = "";
            //cmbCategoria.Text = "";

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read()){

            //    cmbGrupo.Items.Add(rec["grupo"].ToString()) ;
            //}

            //rec.Close();
        }

        private void ListarSubGrupos(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "select distinct subgrupo "
            //           + "from tb_categorias "
            //           + "where grupo = '" + cmbGrupo.Text  + "' order by subgrupo;";

            //cmbSubGrupo.Items.Clear();
            //cmbCategoria.Items.Clear();
            //cmbSubGrupo.Text = "";
            //cmbCategoria.Text = "";

            //if (cmbGrupo.Text != "") {

            //    rec = conn.ExecuteReader(sql);

            //    while (rec.Read()) {
            //        cmbSubGrupo.Items.Add(rec["subgrupo"].ToString());
            //    }

            //    rec.Close();
            //}
        }

        private void ListarCategorias(object sender, EventArgs e) {

            //SqlDataReader rec;

            //string sql = string.Format("select distinct categoria from tb_categorias where grupo='{0}' and subgrupo='{1}' order by categoria;", cmbGrupo.Text, cmbSubGrupo.Text);

            //cmbCategoria.Text ="";
            //cmbCategoria.Items.Clear();

            //if (cmbSubGrupo.Text != "") {

            //    rec = conn.ExecuteReader(sql);

            //    while (rec.Read()) {

            //        cmbCategoria.Items.Add(rec["categoria"].ToString());
            //    }

            //    rec.Close();
            //}
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;
            //SqlDataReader rec;

            //if (cmbCategoria.Text == "") {
            //    MessageBox.Show(null, "É necessário informar o nome da categoria.", Program.Name);
            //} else {
            //    //verifica se já existe categoria com essa tabulação
            //    sql = String.Format("select * from tb_categorias where grupo = '{0}' and subgrupo='{1}' and categoria='{2}';", cmbGrupo.Text, cmbSubGrupo.Text, cmbCategoria.Text);

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.HasRows) {
            //        MessageBox.Show("Já existe uma categoria com esse nome.", Program.Name);
            //    } else {

            //        rec.Close();

            //        sql = string.Format("INSERT tb_categorias(grupo,subgrupo,categoria) VALUES('{0}','{1}','{2}')", cmbGrupo.Text, cmbSubGrupo.Text, cmbCategoria.Text);

            //        if (conn.ExecuteNonQuery(sql))
            //            MessageBox.Show(null,"Cadastro realizado com sucesso.", Program.Name);
            //        else
            //            MessageBox.Show(null,"Erro ao realizar cadastro.",Program.Name);
            //    }

            //    rec.Dispose();
            //}
        }
    }
}