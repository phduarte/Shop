namespace Gadz.Shop.Admin.Forms.Estoque
{
    partial class Entrada
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkProduto = new System.Windows.Forms.LinkLabel();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkCategoria = new System.Windows.Forms.LinkLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFabricacao = new System.Windows.Forms.CheckBox();
            this.chkValidade = new System.Windows.Forms.CheckBox();
            this.txtDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtDataValidade = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtCompra);
            this.groupBox2.Controls.Add(this.cmbLocal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Location = new System.Drawing.Point(3, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Compra";
            // 
            // dtCompra
            // 
            this.dtCompra.Location = new System.Drawing.Point(92, 26);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(228, 20);
            this.dtCompra.TabIndex = 0;
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "SETOR A",
            "SETOR B",
            "SETOR C",
            "SETOR D",
            "SETOR E",
            "SETOR F"});
            this.cmbLocal.Location = new System.Drawing.Point(92, 83);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(129, 21);
            this.cmbLocal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(92, 57);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(57, 20);
            this.txtQtd.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkProduto);
            this.groupBox1.Controls.Add(this.cmbProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lnkCategoria);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // lnkProduto
            // 
            this.lnkProduto.AutoSize = true;
            this.lnkProduto.Location = new System.Drawing.Point(276, 60);
            this.lnkProduto.Name = "lnkProduto";
            this.lnkProduto.Size = new System.Drawing.Size(52, 13);
            this.lnkProduto.TabIndex = 5;
            this.lnkProduto.TabStop = true;
            this.lnkProduto.Text = "Cadastrar";
            this.lnkProduto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadastrarProduto);
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(92, 57);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(178, 21);
            this.cmbProduto.TabIndex = 1;
            this.cmbProduto.DropDown += new System.EventHandler(this.ListarProdutos);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto";
            // 
            // lnkCategoria
            // 
            this.lnkCategoria.AutoSize = true;
            this.lnkCategoria.Location = new System.Drawing.Point(276, 33);
            this.lnkCategoria.Name = "lnkCategoria";
            this.lnkCategoria.Size = new System.Drawing.Size(52, 13);
            this.lnkCategoria.TabIndex = 2;
            this.lnkCategoria.TabStop = true;
            this.lnkCategoria.Text = "Cadastrar";
            this.lnkCategoria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CadastrarCategoria);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DisplayMember = "categoria";
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(92, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(178, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.ValueMember = "categoria";
            this.cmbCategoria.DropDown += new System.EventHandler(this.ListarCategorias);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 392);
            this.panel1.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_salvar_24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(252, 334);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 50);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // button1
            // 
            this.button1.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_reset_24x24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(136, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Limpar);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFabricacao);
            this.groupBox3.Controls.Add(this.chkValidade);
            this.groupBox3.Controls.Add(this.txtDataFabricacao);
            this.groupBox3.Controls.Add(this.txtDataValidade);
            this.groupBox3.Location = new System.Drawing.Point(4, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 91);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações adicionais";
            // 
            // chkFabricacao
            // 
            this.chkFabricacao.AutoSize = true;
            this.chkFabricacao.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFabricacao.Location = new System.Drawing.Point(23, 31);
            this.chkFabricacao.Name = "chkFabricacao";
            this.chkFabricacao.Size = new System.Drawing.Size(155, 17);
            this.chkFabricacao.TabIndex = 18;
            this.chkFabricacao.Text = "Possui data de fabricação?";
            this.chkFabricacao.UseVisualStyleBackColor = true;
            this.chkFabricacao.Click += new System.EventHandler(this.DataFabricacao);
            // 
            // chkValidade
            // 
            this.chkValidade.AutoSize = true;
            this.chkValidade.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkValidade.Location = new System.Drawing.Point(25, 54);
            this.chkValidade.Name = "chkValidade";
            this.chkValidade.Size = new System.Drawing.Size(153, 17);
            this.chkValidade.TabIndex = 19;
            this.chkValidade.Text = "Possui prazo de validade ?";
            this.chkValidade.UseVisualStyleBackColor = true;
            this.chkValidade.Click += new System.EventHandler(this.DataValidade);
            // 
            // txtDataFabricacao
            // 
            this.txtDataFabricacao.Enabled = false;
            this.txtDataFabricacao.Location = new System.Drawing.Point(184, 29);
            this.txtDataFabricacao.Name = "txtDataFabricacao";
            this.txtDataFabricacao.Size = new System.Drawing.Size(152, 20);
            this.txtDataFabricacao.TabIndex = 14;
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Enabled = false;
            this.txtDataValidade.Location = new System.Drawing.Point(184, 52);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(152, 20);
            this.txtDataValidade.TabIndex = 15;
            // 
            // frmEstoqueAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(392, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoqueAdicionar";
            this.ShowIcon = false;
            this.Text = "Movimentação de Entrada de Estoque";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFabricacao;
        private System.Windows.Forms.CheckBox chkValidade;
        private System.Windows.Forms.DateTimePicker txtDataFabricacao;
        private System.Windows.Forms.DateTimePicker txtDataValidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
    }
}