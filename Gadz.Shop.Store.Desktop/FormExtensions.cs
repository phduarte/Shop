using Gadz.Shop.Access.Forms;
using Gadz.Shop.Access.Services;
using Gadz.Shop.Commom.Forms;
using System.Windows.Forms;

namespace Gadz.Shop.Store {
    public static class FormExtensions {

        public static void AbrirSeEstiverLogado(this MdiBaseForm form, Form mdi) {
            if (new AccessServices().CurrentUserLogged().Logado) {
                form.ShowInside(mdi);
            } else {
                var login = new Login();
                login.FormClosed += (sender, e)=>{
                    form.ShowInside(mdi);
                };
                login.ShowInside(mdi);
            }
        }

        public static void AbrirSeEstiverLogado(this Form form, Form mdi) {
            if (new AccessServices().CurrentUserLogged().Logado) {
                form.Show();
            } else {
                var login = new Login();
                login.FormClosed += (sender, e) => { form.Show(); };
                login.ShowInside(mdi);
            }
        }
    }
}
