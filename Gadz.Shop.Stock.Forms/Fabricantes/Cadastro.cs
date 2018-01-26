using Gadz.Shop.Commom.Forms;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Stock.Forms.Fabricantes {
    public partial class Cadastro : MdiBaseForm
    {
        public Cadastro() {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e) {

            //string sql;

            ////salvar a imagem para a pasta do aplicativo.

            //String origem = imgLogotipo.ImageLocation;
            //String destino;

            //if (origem != ""){

            //    destino = (Path.GetDirectoryName(Application.ExecutablePath) + "\\imagens\\fabricantes\\" + txtFabricante.Text.ToLower() + Path.GetExtension(origem).ToLower().Replace(" ", "-"));

            //    if (!Directory.Exists(Path.GetDirectoryName(destino))) {
            //        Directory.CreateDirectory(Path.GetDirectoryName(destino));
            //    }

            //    File.Copy(origem, destino, true);

            //} else {
            //    destino = "";
            //}

            //sql = string.Format("INSERT tb_fabricantes(fabricante,logotipo) VALUES('{0}','{1}')", txtFabricante.Text, "imagens\\fabricantes\\" + Path.GetFileName(destino));

            //if (conn.ExecuteNonQuery(sql)) {
            //    MessageBox.Show("Cadastro realizado com sucesso.");
            //    Limpar(sender, e);
            //} else
            //    MessageBox.Show("Erro ao realizar cadastro.");
        }

        private void Limpar(object sender, EventArgs e) {

            //
            imgLogotipo.ImageLocation = "";
            txtFabricante.Text = "";

            //
            txtFabricante.Focus();
        }

        private void AlterarLogotipo(object sender, LinkLabelLinkClickedEventArgs e) {

            //
            OpenFileDialog op = new OpenFileDialog();

            op.InitialDirectory = Application.LocalUserAppDataPath;
            op.ShowDialog();

            imgLogotipo.ImageLocation = op.FileName;
        }
    }
}
