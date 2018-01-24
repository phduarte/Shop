namespace Gadz.Shop.Admin.Forms.Precos
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnkProduto = new System.Windows.Forms.LinkLabel();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkCategoria = new System.Windows.Forms.LinkLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrecoPrazo = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDataInicio = new System.Windows.Forms.DateTimePicker();
            this.chkTermina = new System.Windows.Forms.CheckBox();
            this.cmbDataFim = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lnkProduto);
            this.groupBox1.Controls.Add(this.cmbProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lnkCategoria);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do produto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.produto;
            this.pictureBox2.Location = new System.Drawing.Point(316, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lnkProduto
            // 
            this.lnkProduto.AutoSize = true;
            this.lnkProduto.Location = new System.Drawing.Point(262, 68);
            this.lnkProduto.Name = "lnkProduto";
            this.lnkProduto.Size = new System.Drawing.Size(33, 13);
            this.lnkProduto.TabIndex = 5;
            this.lnkProduto.TabStop = true;
            this.lnkProduto.Text = "Novo";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(8, 84);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(287, 21);
            this.cmbProduto.TabIndex = 4;
            this.cmbProduto.DropDown += new System.EventHandler(this.ListarProdutos);
            this.cmbProduto.Leave += new System.EventHandler(this.BuscarImagem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto *";
            // 
            // lnkCategoria
            // 
            this.lnkCategoria.AutoSize = true;
            this.lnkCategoria.Location = new System.Drawing.Point(262, 23);
            this.lnkCategoria.Name = "lnkCategoria";
            this.lnkCategoria.Size = new System.Drawing.Size(33, 13);
            this.lnkCategoria.TabIndex = 2;
            this.lnkCategoria.TabStop = true;
            this.lnkCategoria.Text = "Novo";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(8, 39);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(287, 21);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.DropDown += new System.EventHandler(this.ListarCategorias);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtPrecoPrazo);
            this.groupBox2.Controls.Add(this.txtPrecoVenda);
            this.groupBox2.Controls.Add(this.cmbTipo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrecoCompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações sobre o preço";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.cifrao;
            this.pictureBox1.Location = new System.Drawing.Point(225, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrecoPrazo
            // 
            this.txtPrecoPrazo.Location = new System.Drawing.Point(113, 105);
            this.txtPrecoPrazo.Mask = "$ 000.99";
            this.txtPrecoPrazo.Name = "txtPrecoPrazo";
            this.txtPrecoPrazo.Size = new System.Drawing.Size(81, 20);
            this.txtPrecoPrazo.TabIndex = 12;
            this.txtPrecoPrazo.Leave += new System.EventHandler(this.ValidarPrecoPrazo);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(113, 79);
            this.txtPrecoVenda.Mask = "$ 000.99";
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(81, 20);
            this.txtPrecoVenda.TabIndex = 11;
            this.txtPrecoVenda.Leave += new System.EventHandler(this.ValidarPrecoVenda);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Normal",
            "Promoção"});
            this.cmbTipo.Location = new System.Drawing.Point(113, 26);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(81, 21);
            this.cmbTipo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo *";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Preço à prazo *";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Preço de venda *";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(113, 53);
            this.txtPrecoCompra.Mask = "$ 000.99";
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(81, 20);
            this.txtPrecoCompra.TabIndex = 7;
            this.txtPrecoCompra.Leave += new System.EventHandler(this.ValidarPrecoCompra);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço de compra *";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Começa em *";
            // 
            // cmbDataInicio
            // 
            this.cmbDataInicio.CustomFormat = "ddd, dd/MM/yyyy";
            this.cmbDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbDataInicio.Location = new System.Drawing.Point(116, 20);
            this.cmbDataInicio.Name = "cmbDataInicio";
            this.cmbDataInicio.Size = new System.Drawing.Size(128, 20);
            this.cmbDataInicio.TabIndex = 1;
            // 
            // chkTermina
            // 
            this.chkTermina.AutoSize = true;
            this.chkTermina.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTermina.Location = new System.Drawing.Point(29, 52);
            this.chkTermina.Name = "chkTermina";
            this.chkTermina.Size = new System.Drawing.Size(81, 17);
            this.chkTermina.TabIndex = 2;
            this.chkTermina.Text = "Termina em";
            this.chkTermina.UseVisualStyleBackColor = true;
            this.chkTermina.Click += new System.EventHandler(this.TestarDataFim);
            // 
            // cmbDataFim
            // 
            this.cmbDataFim.CustomFormat = "ddd, dd/MM/yyyy";
            this.cmbDataFim.Enabled = false;
            this.cmbDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbDataFim.Location = new System.Drawing.Point(116, 49);
            this.cmbDataFim.Name = "cmbDataFim";
            this.cmbDataFim.Size = new System.Drawing.Size(128, 20);
            this.cmbDataFim.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTermina);
            this.groupBox3.Controls.Add(this.cmbDataFim);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbDataInicio);
            this.groupBox3.Location = new System.Drawing.Point(314, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vigência";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "Importante:\r\n\r\nOs campos com * são de preenchimento obrigatório.";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_reset_24x24;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(324, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 54);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_salvar_24x24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(452, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Salvar);
            // 
            // imgProduto
            // 
            this.imgProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProduto.Location = new System.Drawing.Point(398, 16);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(172, 166);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduto.TabIndex = 7;
            this.imgProduto.TabStop = false;
            // 
            // frmCadastrarPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 347);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarPreco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de preços";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtPrecoPrazo;
        private System.Windows.Forms.MaskedTextBox txtPrecoVenda;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPrecoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cmbDataInicio;
        private System.Windows.Forms.CheckBox chkTermina;
        private System.Windows.Forms.DateTimePicker cmbDataFim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgProduto;
    }
}