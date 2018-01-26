using System;
using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms.Controls
{
    public partial class Loading : Form {

        public Loading() {
            InitializeComponent();
        }

        private void Abrir(object sender, EventArgs e) {

            while (true)
                for (int i = this.progressBar1.Minimum; i < this.progressBar1.Maximum; i++)
                    this.progressBar1.Value = i;
        
        }
    }
}
