using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.HR.Forms.Enderecos {
    public partial class Pesquisa : MdiBaseForm {

        MaskedTextBox _returnCep;

        public Pesquisa() {
            InitializeComponent();
        }

        public Pesquisa(MaskedTextBox txtCEP) : this() {
            _returnCep = txtCEP;
        }

        private void Abrir(object sender, EventArgs e) {

            ListarCidades(sender, e);

        }

        private void ListarCidades(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual, sql;
            //ComboBox _combo = cmbCidade;

            //sql = "select distinct cidade "
            //    + "from tb_enderecos "
            //    + "order by cidade asc";

            //_atual = _combo.Text;

            //rec = conn.ExecuteReader(sql);

            //while (rec.Read())
            //    itens.Add(rec["cidade"].ToString(), rec["cidade"].ToString());

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();

        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";
            //string criterio;
            //string cidade;

            //cidade = cmbCidade.Text;
            //criterio = txtEndereco.Text;
            //criterio = criterio.Replace(" ", "%");

            //dgLista.Rows.Clear();

            //sql = "select top 50 * "
            //    + "from tb_enderecos "
            //    + "where (cep + ' ' + tipo + ' ' + lougradouro + ' ' + bairro) like '%" + criterio + "%' and cidade like '" + cidade + "%'";

            //rec = conn.ExecuteReader(sql);

            //if (rec != null) {
            //    while (rec.Read())
            //        dgLista.Rows.Add(rec["cep"].ToString(),
            //                            rec["tipo"].ToString(),
            //                            rec["lougradouro"].ToString(),
            //                            rec["bairro"].ToString(),
            //                            rec["cidade"].ToString(),
            //                            rec["frete_1"].ToString(),
            //                            rec["frete_2"].ToString(),
            //                            rec["frete_3"].ToString(),
            //                            rec["frete_4"].ToString(),
            //                            rec["frete_5"].ToString(),
            //                            rec["frete_6"].ToString(),
            //                            rec["frete_7"].ToString(),
            //                            rec["frete_8"].ToString(),
            //                            rec["frete_9"].ToString()
            //                            );

            //    rec.Close();
            //}
        }

        private void EnviarCEP(object sender, EventArgs e) {

            if (_returnCep != null) {
                if (dgLista.SelectedCells.Count > 0) {

                    DataGridViewRow r;

                    r = dgLista.SelectedCells[0].OwningRow;

                    _returnCep.Text = r.Cells["cep"].Value.ToString();
                    _returnCep.SelectionStart = 1;
                    _returnCep.SelectionLength = 9;
                    _returnCep.Focus();

                    Close();

                }
            }
        }
    }
}