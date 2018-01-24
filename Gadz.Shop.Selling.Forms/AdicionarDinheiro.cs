using Gadz.Shop.Commom.Utils;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {

    public partial class AdicionarDinheiro : Form {
        FinalizarVenda _form;

        public AdicionarDinheiro(FinalizarVenda form) {

            _form = form;

            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e) {

            string id_forma_pgto = _form.lstFormaPgto.SelectedValue.ToString();
            string forma_pgto = _form.lstFormaPgto.Text;
            string _valor;
            DataGridView _grid;
            bool found = false;

            _grid = _form.dgPagamentos;
            _valor = Funcoes.RemoveMask(this.txtValor.Text);

            foreach (DataGridViewRow r in _form.dgPagamentos.Rows) {

                if (id_forma_pgto.Equals(r.Cells["id_forma_pgto"].Value.ToString())) {

                    r.Cells["Valor"].Value = float.Parse(r.Cells["Valor"].Value.ToString()) + float.Parse(_valor);
                    _form.Recalcular(sender, e);
                    found = true;
                    break;
                }
            }

            if (!found)
                _form.dgPagamentos.Rows.Add(id_forma_pgto, forma_pgto, _valor);

            this.Close();
        }

        private void Funcao(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5 || e.KeyCode == Keys.Enter)
                this.Salvar(null, null);
        }

    }
}