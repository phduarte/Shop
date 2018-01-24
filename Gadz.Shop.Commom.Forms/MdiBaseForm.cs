using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms {
    public class MdiBaseForm : Form {

        protected Form _currentMdiParent;

        [DefaultValue(false)]
        new public bool ShowIcon { get; set; }
        [DefaultValue(false)]
        new public bool ShowInTaskbar { get; set; }

        protected MdiBaseForm() {
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.WindowsDefaultLocation;
            Load += Maximizar;
            Shown += Maximizar;
            //FormClosing += Esconder;
        }

        private void Esconder(object sender, FormClosingEventArgs e) {
            //Hide();
            //e.Cancel = true;
        }

        private void Maximizar(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
        }

        public void ShowInside(Form mdi) {
            if (mdi == null)
                return;

            _currentMdiParent = mdi;
            //TopMost = true;
            MdiParent = mdi;
            Show();
        }

        public void ShowInside() {

            if (_currentMdiParent == null) {
                throw new Exception("MDI não foi definido.");
            }

            Show();
        }
    }
}
