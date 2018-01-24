using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    public partial class EscolherAcao : Form
    {
        private DataGridViewRow _row; 
        public DataGridViewRow ActiveRow {
            get { return _row; }
            set {
                _row = value;
                try {
                    this.id_venda = int.Parse(_row.Cells["id_venda"].Value.ToString());
                }
                catch {
                }
            }
        }

        public int id_venda { get;set; }
        public float preco_venda { get; set; }
        public float preco_pago { get; set; }

        public EscolherAcao() {
            InitializeComponent();
        }

        public EscolherAcao(DataGridViewRow row) {

            this.ActiveRow = row;
            InitializeComponent();
        }

        private void EmitirBoleto(object sender, EventArgs e) {

            //string _LocalRelatorio = Path.GetDirectoryName(Application.ExecutablePath) + @"\formularios\rptPedidoVenda.rpt";

            //frmReportViewer f = new frmReportViewer();

            //f.Connection = Program.conn;
            //f.FileName = _LocalRelatorio;
            //f.Sql = "select * from vw_vendas where id_venda = '" + this.id_venda.ToString() + "'";
            //f.MdiParent = Program.frmMain;
            //f.Show();

            //this.Close();

        }

        private void ReceberPagamento(object sender, EventArgs e) {

            //if (this.id_venda > 0) {
            //    frmFinalizarVenda f = new frmFinalizarVenda(id_venda);

            //    f.MdiParent = Program.frmMain;
            //    f.TopMost = true;
            //    f.Show();

            //    this.Close();
            //}
        }

        private void ContinuarVenda(object sender, EventArgs e) {

            //if (this.id_venda > 0) {

            //    this.Close();

            //    frmCadastrarVenda f = new frmCadastrarVenda(this.id_venda);

            //    f.MdiParent = Program.frmMain;
            //    f.TopMost = true;
            //    f.Show();

            //}
        }
    }
}