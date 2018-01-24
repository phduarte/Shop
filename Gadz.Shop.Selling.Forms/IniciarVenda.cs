using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    public partial class IniciarVenda : MdiBaseForm {

        public int id_cliente { get; set; }

        public IniciarVenda() {
            InitializeComponent();
        }

        private void Iniciar(object sender, EventArgs e) {

            //if (id_cliente == 0) {
            //    MessageBox.Show(null, "Necessário informar o nome do cliente.\n\nVocê pode pesquisar pelos clientes cadastrados ou cadastrar um novo cliente caso não localize o cliente desejado.", Program.Name);
            //} else {

            //    SqlDataReader rec;
            //    int i = 0;
            //    string sql;

            //    sql = "select count(*) + 1 as registros from tb_vendas where convert(date,data_venda) = convert(date,getdate());";

            //    rec = conn.ExecuteReader(sql);

            //    if (rec.Read())
            //        i = Convert.ToInt32(rec[0].ToString());

            //    rec.Close();

            //    //código de barra in-store
            //    string _protocolo;

            //    _protocolo = "2001";
            //    _protocolo = _protocolo + Funcoes.Rigth(DateTime.Today.DayOfYear.ToString().PadLeft(4, '0').ToString(), 4);
            //    _protocolo = _protocolo + Funcoes.Rigth(i.ToString().PadLeft(5, '0'), 5);

            //    sql = "insert tb_vendas(id_cliente,id_funcionario,data_venda,status_venda,protocolo) "
            //        + "values(" + this.id_cliente + "," + this.usuario.ID + ",GETDATE(),'EM NEGOCIACAO','" + _protocolo + "')";

            //    if (conn.ExecuteNonQuery(sql)) {

            //        _form.lbProtocolo.Text = _protocolo;

            //        //pega o id da venda que está sendo realizada
            //        sql = "select MAX(id_venda) as id_venda "
            //            + "from tb_vendas "
            //            + "where id_funcionario = " + this.usuario.ID + ";";

            //        rec = conn.ExecuteReader(sql);

            //        if (rec.Read())
            //            _form._id_venda = Convert.ToInt32(rec["id_venda"].ToString());

            //        rec.Close();

            //        this.Dispose();

            //    } else {
            //        MessageBox.Show(null, "Erro ao iniciar a venda.", Program.Name);
            //    }
            //}
        }

        private void Preencher(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql;
            //string cpf;

            //cpf = Funcoes.RemoveMask(this.txtCPF.Text);
            //sql = "select top 1 * "
            //    + "from vw_clientes where cpf = '" + cpf + "';";

            //rec = conn.ExecuteReader(sql);

            //if (rec.Read()) {
            //    this.id_cliente = int.Parse(rec["id_cliente"].ToString());
            //    this.cmbCliente.Text = rec["cliente"].ToString();
            //    this.txtObs.Text = rec["obs"].ToString();
            //}

            //rec.Close();

        }

        private void AlterarCPF(object sender, EventArgs e) {
            if(this.cmbCliente.SelectedIndex > -1) {
                this.txtCPF.Text = this.cmbCliente.SelectedValue.ToString();
                //this.cmbCliente.Focus();
            }
        }

        private void Pesquisar(object sender, EventArgs e) {

            //Dictionary<string, string> itens = new Dictionary<string, string>();
            //SqlDataReader rec;
            //string _atual;
            //ComboBox _combo = this.cmbCliente;

            //_atual = _combo.Text;

            //_combo.DataSource = null;
            //_combo.Items.Clear();

            //rec = conn.ExecuteReader("select top 30 cpf, cliente from tb_clientes where cliente like '%" + _atual + "%';");

            //while (rec.Read()) {
            //    itens.Add(rec["cpf"].ToString(), rec["cliente"].ToString());
            //}

            //_combo.DataSource = new BindingSource(itens, null);
            //_combo.DisplayMember = "Value";
            //_combo.ValueMember = "Key";
            //_combo.Text = _atual;

            //rec.Close();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e) {
            //new frmAddCliente().Show();
        }
    }
}
