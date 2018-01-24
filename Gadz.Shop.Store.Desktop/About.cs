using Gadz.Shop.Commom.Forms;
using System.Windows.Forms;

namespace Gadz.Shop.Store {
    public partial class About : MdiBaseForm {
        public About() {
            InitializeComponent();
            lbNomePrograma.Text = Program.Name;
        }
    }
}
