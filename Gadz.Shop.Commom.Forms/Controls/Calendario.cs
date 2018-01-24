using System;
using System.Windows.Forms;

namespace Gadz.Shop.Commom.Forms.Controls {

    public partial class Calendario : Form
    {
        //Connection conn = Program.conn;

        public Calendario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            //string sql;

            //sql = string.Format("set dateformat dmy update tb_calendario set feriado='{0}',escala='{1}' where convert(varchar,data,103)='{2:dd/MM/yyyy}';",this.chkFeriado.Checked,this.txtEscala.Text, this.calendario.SelectionRange.Start);

            //if (conn.ExecuteNonQuery(sql))
            //    MessageBox.Show("Calendário atualizado com sucesso.");
            //else
            //    MessageBox.Show("Erro ao atualizar calendário.");
        }
    }
}