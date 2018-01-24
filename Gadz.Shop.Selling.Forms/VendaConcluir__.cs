using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    public partial class VendaConcluir__ : Form{

        public VendaConcluir__(){
            InitializeComponent();
        }

        //
        private void Abrir(object sender, EventArgs e){

            //this.lbProtocolo.Text = f.lbProtocolo.Text;
            //this.lbOperador.Text = Program.user.Nome;
            //this.lbUsuario.Text = Program.user.Login;
            //this.lbData.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
            //this.lbHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now);
            //this.lbTotal.Text = Funcoes.Valor(f.txtTotal.Text);
            //this.txtDinheiro.Text = this.lbTotal.Text;
        }

        //recalcula os valores do formulário
        private void ReCalcular(object sender, EventArgs e){

            // ((TextBox)sender).Text = Valor(((TextBox)sender).Text);
        }

        private void AdicionarDinheiro(object sender, EventArgs e) {
        }

        private void Finalizar() {

            //if (f._id_venda.ToString() != "") {

            //    string sql;
            //    string dinheiro = Funcoes.RemoveMask(this.txtDinheiro.Text);
            //    string cartao = Funcoes.RemoveMask(this.txtCredito.Text);
            //    string debito = Funcoes.RemoveMask(this.txtDebito.Text);

            //    sql = "update tb_vendas "
            //        + "set status_venda = 'FINALIZADA', "
            //        + "pago_dinheiro='" + dinheiro + "',"
            //        + "pago_ccredito='" + cartao + "',"
            //        + "pago_cdebito='" + debito + "' "
            //        + "where id_venda = " + f._id_venda.ToString() + ";";

            //    if (conn.ExecuteNonQuery(sql))
            //        MessageBox.Show(null, "Venda concluída com sucesso!\n\nProtocolo " + this.lbProtocolo.Text + ".", Program.Name);
            //    else
            //        MessageBox.Show(null, "Venda de protocolo " + this.lbProtocolo.Text + " cancelada com sucesso.", Program.Name);
            //}

            //this.Close();
        }

        private void Cancelar() {

            //if (f._id_venda.ToString() != "") {
            //    string sql;

            //    sql = "update tb_vendas "
            //        + "set status_venda = 'CANCELADA' "
            //        + "where id_venda = " + f._id_venda.ToString() + ";";

            //    if (conn.ExecuteNonQuery(sql))
            //        MessageBox.Show(null,"Venda cancelada com sucesso!\n\nProtocolo " + this.lbProtocolo.Text + ".",Program.Name);
            //    else
            //        MessageBox.Show(null, "Erro ao finalizar a venda de protocolo " + this.lbProtocolo.Text + "\n\nVenda não foi concretizada.", Program.Name);
            //}

            //this.Close();
        }

        private void Funcao(object sender, KeyEventArgs e) {
            //MessageBox.Show(e.KeyCode.ToString());

            if (e.KeyCode == Keys.F2) {
                this.AdicionarDinheiro(sender, e) ;
            } else if (e.KeyCode == Keys.F7) {
                this.Cancelar();
            } else if (e.KeyCode == Keys.F10) {
                this.Finalizar();
            } else if (e.KeyCode == Keys.F12) {
                //if (MessageBox.Show(null, "Deseja realmente sair do sistema?", Program.Name, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            }
        }

    }
}