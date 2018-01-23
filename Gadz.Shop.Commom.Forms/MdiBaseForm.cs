using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms {
    public class MdiBaseForm : Form
    {

        public MdiBaseForm() {

        }

        public MdiBaseForm(Form mdi) {
            if (mdi == null)
                return;

            TopMost = true;
            MdiParent = mdi;
            WindowState = FormWindowState.Maximized;
        }
    }
}
