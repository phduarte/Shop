using Gadz.Shop.Access.DomainModel.Usuarios;
using Gadz.Shop.Access.Infrastructure;
using Gadz.Shop.Commom.Forms;
using System;

namespace Gadz.Shop.Access.Forms {
    public partial class RecuperacaoSenha : MdiBaseForm {
        
        readonly IUsuarioRepository _repository;

        public RecuperacaoSenha() {
            _repository = new UsuarioRepository();
            InitializeComponent();
        }

        private void RecuperarSenha(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;
            //string email = "";

            //sql = "select email "
            //    + "from tb_funcionarios "
            //    + "where usuario = '" + txtUsuario.Text +"';";

            //rec = conn.ExecuteReader(sql);

            //if (rec.Read())
            //    email = rec[0].ToString();

            //if (email != "") {

            //    Email mail = new Email();

            //    mail.De = "paul_ikis@hotmail.com";
            //    mail.Para = email;
            //    mail.Assunto = "Recuperação de Senha";
            //    mail.Servidor = "arezzo@almavivadobrasil.com.br";
            //    mail.Enviar();

            //    MessageBox.Show(null,"Sua senha foi enviada com sucesso para o seu email.",Program.Name);

            //    mail = null;

            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();

            //} else {
            //    MessageBox.Show(null, "Falha ao recuperar sua senha. \n\nContate o administrador.", Program.Name);
            //}
        }
    }
}