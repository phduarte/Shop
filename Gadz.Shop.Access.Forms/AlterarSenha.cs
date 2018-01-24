using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Access.Forms {
    public partial class AlterarSenha : MdiBaseForm {

        public AlterarSenha() {
            InitializeComponent();
        }

        private void Alterar(object sender, EventArgs e) {

            //string sql;

            //if (!Valida(this.txtNovaSenha.Text, this.txtNovaSenha.Text)) {

            //    MessageBox.Show(null, "Senhas não conferem ou são invalidas.", Program.Name);

            //    this.txtNovaSenha.Focus();
            //    this.txtNovaSenha.Text = "";
            //    this.txtConfirmar.Text = "";


            //} else {
            //    sql = string.Format("UPDATE tb_funcionarios SET senha = '{0}' where id_funcionario = '{1}';", this.txtNovaSenha.Text, user.ID);

            //    if (conn.ExecuteNonQuery(sql)) {

            //        MessageBox.Show(null, "Senha alterada com sucesso.", Program.Name);

            //        this.Close();

            //    } else {
            //        MessageBox.Show(null, "Erro ao alterar senha.", Program.Name);
            //    }
            //}
        }

        private void Submit(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Alterar(sender, e);
            }
        }
    }
}
