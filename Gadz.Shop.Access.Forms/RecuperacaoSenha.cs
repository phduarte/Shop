using Gadz.Shop.Commom.Forms;
using System;

namespace Gadz.Shop.Access.Forms {
    public partial class RecuperacaoSenha : MdiBaseForm {
        
        readonly AccessServices _services = AccessServices.Instance;

        public RecuperacaoSenha() {
            InitializeComponent();
        }

        private void RecuperarSenha(object sender, EventArgs e) {

        }
    }
}