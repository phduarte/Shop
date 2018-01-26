using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Access.Forms {
    public partial class AlterarSenha : MdiBaseForm {

        public AlterarSenha() {
            InitializeComponent();
        }

        private void Alterar(object sender, EventArgs e) {
            //if (!Valida(this.txtNovaSenha.Text, this.txtNovaSenha.Text)) {

            //    this.txtNovaSenha.Focus();
            //    this.txtNovaSenha.Text = "";
            //    this.txtConfirmar.Text = "";
        }

        private void Submit(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Alterar(sender, e);
            }
        }
    }
}
