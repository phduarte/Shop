using System;
using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms {
    public class MdiBaseForm : Form {

        protected Form MdiCurrent;

        protected MdiBaseForm() {
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.WindowsDefaultLocation;
            Load += Maximizar;
            Shown += Maximizar;
        }

        private void Maximizar(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
        }
    }
}
