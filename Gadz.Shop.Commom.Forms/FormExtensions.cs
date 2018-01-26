using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms {
    public static class FormExtensions {

        public static void ShowInside(this MdiBaseForm form, Form mdi) {
            if (mdi == null)
                return;

            form.MdiParent = mdi;
            form.Show();
        }

        public static void ShowInside(this Form form, Form mdi) {
            if (mdi == null)
                return;

            form.MdiParent = mdi;
            form.Show();
        }
    }
}
