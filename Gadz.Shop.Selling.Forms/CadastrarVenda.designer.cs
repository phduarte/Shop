using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    partial class CadastrarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarVenda));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lbProtocolo = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlDescricao = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnlValorUnitario = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.pnlQuantidade = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdDisponivel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pnlSubTotal = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProdutosLista = new System.Windows.Forms.Label();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.pnlObservacao = new System.Windows.Forms.Panel();
            this.lbObsTitulo = new System.Windows.Forms.Label();
            this.lbObsDetalhes = new System.Windows.Forms.Label();
            this.pnlButton1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlButton2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlButton3 = new System.Windows.Forms.Panel();
            this.pnlButton5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cod_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venda_itens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.pnlCodigo.SuspendLayout();
            this.pnlDescricao.SuspendLayout();
            this.pnlValorUnitario.SuspendLayout();
            this.pnlQuantidade.SuspendLayout();
            this.pnlSubTotal.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.pnlObservacao.SuspendLayout();
            this.pnlButton1.SuspendLayout();
            this.pnlButton2.SuspendLayout();
            this.pnlButton5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.imgProduto);
            this.pnlMain.Controls.Add(this.pnlCodigo);
            this.pnlMain.Controls.Add(this.pnlDescricao);
            this.pnlMain.Controls.Add(this.pnlValorUnitario);
            this.pnlMain.Controls.Add(this.pnlQuantidade);
            this.pnlMain.Controls.Add(this.pnlSubTotal);
            this.pnlMain.Controls.Add(this.pnlTotal);
            this.pnlMain.Controls.Add(this.pnlLista);
            this.pnlMain.Controls.Add(this.pnlObservacao);
            this.pnlMain.Controls.Add(this.pnlButton1);
            this.pnlMain.Controls.Add(this.pnlButton2);
            this.pnlMain.Controls.Add(this.pnlButton3);
            this.pnlMain.Controls.Add(this.pnlButton5);
            this.pnlMain.Location = new System.Drawing.Point(128, 12);
            this.pnlMain.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.pnlMain.MinimumSize = new System.Drawing.Size(900, 600);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 700);
            this.pnlMain.TabIndex = 27;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = global::Gadz.Shop.Commom.Resources.Properties.Resources.bg_header_silver;
            this.pnlHeader.Controls.Add(this.imgLogo);
            this.pnlHeader.Controls.Add(this.lbProtocolo);
            this.pnlHeader.Controls.Add(this.lbPerfil);
            this.pnlHeader.Location = new System.Drawing.Point(15, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.White;
            this.imgLogo.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.eletromig_logo;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(209, 58);
            this.imgLogo.TabIndex = 22;
            this.imgLogo.TabStop = false;
            // 
            // lbProtocolo
            // 
            this.lbProtocolo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbProtocolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbProtocolo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProtocolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbProtocolo.Location = new System.Drawing.Point(823, 6);
            this.lbProtocolo.Name = "lbProtocolo";
            this.lbProtocolo.Size = new System.Drawing.Size(166, 25);
            this.lbProtocolo.TabIndex = 20;
            this.lbProtocolo.Text = "2012112723590001";
            this.lbProtocolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPerfil
            // 
            this.lbPerfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPerfil.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.ForeColor = System.Drawing.Color.White;
            this.lbPerfil.Location = new System.Drawing.Point(724, 30);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(265, 25);
            this.lbPerfil.TabIndex = 21;
            this.lbPerfil.Text = "PAULO DUARTE - ADM";
            this.lbPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgProduto
            // 
            this.imgProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imgProduto.BackColor = System.Drawing.Color.Black;
            this.imgProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgProduto.Location = new System.Drawing.Point(15, 180);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(380, 369);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduto.TabIndex = 26;
            this.imgProduto.TabStop = false;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BackColor = System.Drawing.Color.White;
            this.pnlCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCodigo.BackgroundImage")));
            this.pnlCodigo.Controls.Add(this.label2);
            this.pnlCodigo.Controls.Add(this.label1);
            this.pnlCodigo.Controls.Add(this.txtCodigo);
            this.pnlCodigo.Location = new System.Drawing.Point(15, 74);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(278, 100);
            this.pnlCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(90, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "SPACE BAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "CÓDIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.Black;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCodigo.Location = new System.Drawing.Point(10, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(258, 33);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Submit);
            this.txtCodigo.Leave += new System.EventHandler(this.ValidaCodigo);
            // 
            // pnlDescricao
            // 
            this.pnlDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescricao.BackColor = System.Drawing.Color.White;
            this.pnlDescricao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDescricao.BackgroundImage")));
            this.pnlDescricao.Controls.Add(this.label4);
            this.pnlDescricao.Controls.Add(this.label3);
            this.pnlDescricao.Controls.Add(this.txtDescricao);
            this.pnlDescricao.Location = new System.Drawing.Point(299, 74);
            this.pnlDescricao.Name = "pnlDescricao";
            this.pnlDescricao.Size = new System.Drawing.Size(519, 100);
            this.pnlDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_search_24x24;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(332, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "PESQUISAR PRODUTO [F1]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.ProcurarProduto);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "DESCRIÇÃO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.Black;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(9, 50);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(499, 33);
            this.txtDescricao.TabIndex = 0;
            // 
            // pnlValorUnitario
            // 
            this.pnlValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValorUnitario.BackColor = System.Drawing.Color.White;
            this.pnlValorUnitario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlValorUnitario.BackgroundImage")));
            this.pnlValorUnitario.Controls.Add(this.label7);
            this.pnlValorUnitario.Controls.Add(this.txtValorUnitario);
            this.pnlValorUnitario.Location = new System.Drawing.Point(824, 74);
            this.pnlValorUnitario.Name = "pnlValorUnitario";
            this.pnlValorUnitario.Size = new System.Drawing.Size(191, 100);
            this.pnlValorUnitario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "VALOR UNITÁRIO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorUnitario.BackColor = System.Drawing.Color.Black;
            this.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorUnitario.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.ForeColor = System.Drawing.Color.White;
            this.txtValorUnitario.Location = new System.Drawing.Point(11, 50);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(168, 33);
            this.txtValorUnitario.TabIndex = 0;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuantidade
            // 
            this.pnlQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuantidade.BackColor = System.Drawing.Color.White;
            this.pnlQuantidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuantidade.BackgroundImage")));
            this.pnlQuantidade.Controls.Add(this.label5);
            this.pnlQuantidade.Controls.Add(this.txtQtdDisponivel);
            this.pnlQuantidade.Controls.Add(this.label9);
            this.pnlQuantidade.Controls.Add(this.txtQuantidade);
            this.pnlQuantidade.Location = new System.Drawing.Point(401, 180);
            this.pnlQuantidade.Name = "pnlQuantidade";
            this.pnlQuantidade.Size = new System.Drawing.Size(224, 100);
            this.pnlQuantidade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(125, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "DISPONIVEL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQtdDisponivel
            // 
            this.txtQtdDisponivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdDisponivel.BackColor = System.Drawing.Color.Black;
            this.txtQtdDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdDisponivel.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdDisponivel.ForeColor = System.Drawing.Color.Blue;
            this.txtQtdDisponivel.Location = new System.Drawing.Point(116, 50);
            this.txtQtdDisponivel.MaxLength = 10;
            this.txtQtdDisponivel.Name = "txtQtdDisponivel";
            this.txtQtdDisponivel.ReadOnly = true;
            this.txtQtdDisponivel.Size = new System.Drawing.Size(96, 33);
            this.txtQtdDisponivel.TabIndex = 19;
            this.txtQtdDisponivel.Text = "1,00";
            this.txtQtdDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "QUANTIDADE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidade.BackColor = System.Drawing.Color.Black;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtQuantidade.Location = new System.Drawing.Point(11, 50);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(99, 33);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.Text = "1,00";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.ValidaEstoque);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaQuantidade);
            this.txtQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DefineQuantidade);
            this.txtQuantidade.Leave += new System.EventHandler(this.GoToCodigo);
            // 
            // pnlSubTotal
            // 
            this.pnlSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubTotal.BackColor = System.Drawing.Color.White;
            this.pnlSubTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSubTotal.BackgroundImage")));
            this.pnlSubTotal.Controls.Add(this.label11);
            this.pnlSubTotal.Controls.Add(this.txtSubTotal);
            this.pnlSubTotal.Location = new System.Drawing.Point(631, 180);
            this.pnlSubTotal.Name = "pnlSubTotal";
            this.pnlSubTotal.Size = new System.Drawing.Size(187, 100);
            this.pnlSubTotal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(15, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "SUB-TOTAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubTotal.BackColor = System.Drawing.Color.Black;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.White;
            this.txtSubTotal.Location = new System.Drawing.Point(14, 50);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(162, 33);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTotal.BackgroundImage")));
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(this.label8);
            this.pnlTotal.Location = new System.Drawing.Point(824, 180);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(192, 100);
            this.pnlTotal.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.BackColor = System.Drawing.Color.Black;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(8, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(173, 33);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "TOTAL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLista
            // 
            this.pnlLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Controls.Add(this.btnAdicionar);
            this.pnlLista.Controls.Add(this.btnExcluir);
            this.pnlLista.Controls.Add(this.pictureBox1);
            this.pnlLista.Controls.Add(this.lbProdutosLista);
            this.pnlLista.Controls.Add(this.dgLista);
            this.pnlLista.Location = new System.Drawing.Point(401, 286);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(615, 355);
            this.pnlLista.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_carrinho_add;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(87, 21);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(153, 44);
            this.btnAdicionar.TabIndex = 27;
            this.btnAdicionar.Text = "ADICIONAR (F3)";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.Adicionar);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_carrinho_remove;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(246, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(153, 44);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "EXCLUIR (F4)";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.Excluir);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.carrinho;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbProdutosLista
            // 
            this.lbProdutosLista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbProdutosLista.BackColor = System.Drawing.Color.Black;
            this.lbProdutosLista.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdutosLista.ForeColor = System.Drawing.Color.White;
            this.lbProdutosLista.Location = new System.Drawing.Point(6, 325);
            this.lbProdutosLista.Name = "lbProdutosLista";
            this.lbProdutosLista.Size = new System.Drawing.Size(600, 23);
            this.lbProdutosLista.TabIndex = 1;
            this.lbProdutosLista.Text = "0 Produto(s) em sua lista";
            this.lbProdutosLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgLista.BackgroundColor = System.Drawing.Color.White;
            this.dgLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_barras,
            this.nome_produto,
            this.preco_venda,
            this.qtd,
            this.subTotal,
            this.id_venda_itens});
            this.dgLista.Location = new System.Drawing.Point(6, 80);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Size = new System.Drawing.Size(600, 242);
            this.dgLista.TabIndex = 0;
            this.dgLista.Enter += new System.EventHandler(this.FuncaoExcluir);
            this.dgLista.Leave += new System.EventHandler(this.FuncaoExcluir);
            // 
            // pnlObservacao
            // 
            this.pnlObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlObservacao.BackColor = System.Drawing.Color.White;
            this.pnlObservacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlObservacao.BackgroundImage")));
            this.pnlObservacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlObservacao.Controls.Add(this.lbObsTitulo);
            this.pnlObservacao.Controls.Add(this.lbObsDetalhes);
            this.pnlObservacao.Location = new System.Drawing.Point(15, 555);
            this.pnlObservacao.Name = "pnlObservacao";
            this.pnlObservacao.Size = new System.Drawing.Size(380, 86);
            this.pnlObservacao.TabIndex = 8;
            // 
            // lbObsTitulo
            // 
            this.lbObsTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbObsTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbObsTitulo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObsTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbObsTitulo.Location = new System.Drawing.Point(12, 15);
            this.lbObsTitulo.Name = "lbObsTitulo";
            this.lbObsTitulo.Size = new System.Drawing.Size(354, 18);
            this.lbObsTitulo.TabIndex = 20;
            this.lbObsTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbObsDetalhes
            // 
            this.lbObsDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbObsDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbObsDetalhes.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObsDetalhes.ForeColor = System.Drawing.Color.Gray;
            this.lbObsDetalhes.Location = new System.Drawing.Point(12, 33);
            this.lbObsDetalhes.Name = "lbObsDetalhes";
            this.lbObsDetalhes.Size = new System.Drawing.Size(354, 42);
            this.lbObsDetalhes.TabIndex = 21;
            // 
            // pnlButton1
            // 
            this.pnlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButton1.BackColor = System.Drawing.Color.White;
            this.pnlButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlButton1.BackgroundImage")));
            this.pnlButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButton1.Controls.Add(this.label6);
            this.pnlButton1.Location = new System.Drawing.Point(15, 647);
            this.pnlButton1.Name = "pnlButton1";
            this.pnlButton1.Size = new System.Drawing.Size(192, 40);
            this.pnlButton1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_carrinho;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "NOVA VENDA (F2)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.NovaVenda);
            // 
            // pnlButton2
            // 
            this.pnlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton2.BackColor = System.Drawing.Color.White;
            this.pnlButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlButton2.BackgroundImage")));
            this.pnlButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButton2.Controls.Add(this.label13);
            this.pnlButton2.Location = new System.Drawing.Point(631, 647);
            this.pnlButton2.Name = "pnlButton2";
            this.pnlButton2.Size = new System.Drawing.Size(192, 40);
            this.pnlButton2.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_dollar;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(8, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "FINALIZAR VENDA (F5)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.FinalizarVenda);
            // 
            // pnlButton3
            // 
            this.pnlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton3.BackColor = System.Drawing.Color.White;
            this.pnlButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlButton3.BackgroundImage")));
            this.pnlButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButton3.Location = new System.Drawing.Point(209, 647);
            this.pnlButton3.Name = "pnlButton3";
            this.pnlButton3.Size = new System.Drawing.Size(421, 40);
            this.pnlButton3.TabIndex = 25;
            // 
            // pnlButton5
            // 
            this.pnlButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton5.BackColor = System.Drawing.Color.White;
            this.pnlButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlButton5.BackgroundImage")));
            this.pnlButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlButton5.Controls.Add(this.label14);
            this.pnlButton5.Location = new System.Drawing.Point(824, 647);
            this.pnlButton5.Name = "pnlButton5";
            this.pnlButton5.Size = new System.Drawing.Size(192, 40);
            this.pnlButton5.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "SAIR (F7)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.Sair);
            // 
            // cod_barras
            // 
            this.cod_barras.HeaderText = "Código";
            this.cod_barras.Name = "cod_barras";
            this.cod_barras.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.HeaderText = "Produto";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            this.nome_produto.Width = 200;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "Vlr. Unt";
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.ReadOnly = true;
            this.preco_venda.Width = 80;
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 80;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub-Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 80;
            // 
            // id_venda_itens
            // 
            this.id_venda_itens.HeaderText = "id_venda_itens";
            this.id_venda_itens.Name = "id_venda_itens";
            this.id_venda_itens.ReadOnly = true;
            // 
            // frmCadastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.pnlMain);
            this.KeyPreview = true;
            this.Name = "frmCadastrarVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - GADESI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fechar);
            this.Load += new System.EventHandler(this.Abrir);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Funcao);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlDescricao.ResumeLayout(false);
            this.pnlDescricao.PerformLayout();
            this.pnlValorUnitario.ResumeLayout(false);
            this.pnlValorUnitario.PerformLayout();
            this.pnlQuantidade.ResumeLayout(false);
            this.pnlQuantidade.PerformLayout();
            this.pnlSubTotal.ResumeLayout(false);
            this.pnlSubTotal.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.pnlObservacao.ResumeLayout(false);
            this.pnlButton1.ResumeLayout(false);
            this.pnlButton2.ResumeLayout(false);
            this.pnlButton5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel pnlCodigo;
        private Label label2;
        private TextBox txtCodigo;
        private Panel pnlDescricao;
        private TextBox txtDescricao;
        private Label label3;
        private Panel pnlValorUnitario;
        private Label label7;
        private Panel pnlQuantidade;
        private TextBox txtQuantidade;
        private Label label9;
        private Panel pnlSubTotal;
        private TextBox txtSubTotal;
        private Label label11;
        private Panel pnlTotal;
        private Label label8;
        private Panel pnlLista;
        private Panel pnlObservacao;
        private Panel pnlButton1;
        private Panel pnlButton2;
        private Panel pnlButton3;
        private Panel pnlButton5;
        private Label lbObsDetalhes;
        private Label lbObsTitulo;
        private Label label6;
        private Label label13;
        private Label label14;
        private DataGridView dgLista;
        private Panel pnlMain;
        private Label lbPerfil;
        private PictureBox imgLogo;
        private Label lbProdutosLista;
        private Label label5;
        private TextBox txtQtdDisponivel;
        private PictureBox imgProduto;
        private TextBox txtValorUnitario;
        public TextBox txtTotal;
        public Label lbProtocolo;
        private PictureBox pictureBox1;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Label label4;
        private DataGridViewTextBoxColumn cod_barras;
        private DataGridViewTextBoxColumn nome_produto;
        private DataGridViewTextBoxColumn preco_venda;
        private DataGridViewTextBoxColumn qtd;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewTextBoxColumn id_venda_itens;
    }
}