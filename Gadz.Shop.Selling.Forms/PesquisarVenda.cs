using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    public partial class PesquisarVenda : Form
    {

        public PesquisarVenda() {
            InitializeComponent();
        }

        private void Procurar(object sender, EventArgs e) {

            //SqlDataReader rec;
            //string sql = "";

            //dgLista.Rows.Clear();

            //if (chkProtocolo.Checked) {

            //    sql = "select top 50 id_venda, cliente, status_venda, data_venda, preco_venda, preco_pago "
            //        + "from vw_vendas_resumo "
            //        + "where protocolo='" + this.txtProtocolo.Text + "'";

            //}else if(chkCliente.Checked){

            //    sql = "select id_venda, cliente, status_venda, data_venda, preco_venda, preco_pago "
            //        + "from vw_vendas_resumo "
            //        + "where cliente like '" + this.txtCliente.Text + "%'";

            //}else if(chkDataCompra.Checked){

            //    sql = "select id_venda, cliente, status_venda, data_venda, preco_venda, preco_pago "
            //        + "from vw_vendas_resumo "
            //        + "where convert(date,data_venda) = '" + this.txtDataCompra.Value.ToShortDateString() + "'";
            //}

            //if (sql != "") {
            //    rec = conn.ExecuteReader(sql);

            //    while (rec.Read())
            //        dgLista.Rows.Add(rec["id_venda"].ToString(), rec["data_venda"].ToString(), rec["cliente"].ToString(), rec["status_venda"].ToString(), String.Format("{0:C}", Single.Parse(rec["preco_venda"].ToString())), String.Format("{0:C}", Single.Parse(rec["preco_pago"].ToString())));

            //    rec.Close();
            //}
        }

        private void EmitirPedido(object sender, EventArgs e) {

            //if (dgLista.SelectedCells.Count > 0) {

            //    DataGridViewRow r;

            //    r = dgLista.SelectedCells[0].OwningRow;

            //    string _LocalRelatorio = Path.GetDirectoryName(Application.ExecutablePath) + @"\formularios\rptPedidoVenda.rpt";

            //    frmReportViewer f = new frmReportViewer();

            //    f.Connection = Program.conn;
            //    f.FileName = _LocalRelatorio;
            //    f.Sql = "select * from vw_vendas where id_venda = '" + r.Cells["id_venda"].Value.ToString() + "'";
            //    f.MdiParent = Program.frmMain;
            //    f.Show();

            //    this.Close();
            //}
        }

        private void EscolherAcao(object sender, EventArgs e) {

            if (this.dgLista.SelectedCells.Count > 0) {

                DataGridViewRow r = this.dgLista.SelectedCells[0].OwningRow;
                new EscolherAcao(r).ShowDialog();
            }
        }
    }
}