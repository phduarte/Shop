namespace Gadz.Shop.Stock.Forms.Produtos
{
    partial class Pesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkNome = new System.Windows.Forms.RadioButton();
            this.chkCodigo = new System.Windows.Forms.RadioButton();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(139, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // chkNome
            // 
            this.chkNome.AutoSize = true;
            this.chkNome.Checked = true;
            this.chkNome.Location = new System.Drawing.Point(18, 77);
            this.chkNome.Name = "chkNome";
            this.chkNome.Size = new System.Drawing.Size(107, 17);
            this.chkNome.TabIndex = 3;
            this.chkNome.TabStop = true;
            this.chkNome.Text = "Nome do produto";
            this.chkNome.UseVisualStyleBackColor = true;
            // 
            // chkCodigo
            // 
            this.chkCodigo.AutoSize = true;
            this.chkCodigo.Location = new System.Drawing.Point(18, 39);
            this.chkCodigo.Name = "chkCodigo";
            this.chkCodigo.Size = new System.Drawing.Size(106, 17);
            this.chkCodigo.TabIndex = 2;
            this.chkCodigo.Text = "Código de Barras";
            this.chkCodigo.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_search_24x24;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(27, 22);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(117, 40);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "&Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.Procurar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.chkCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.chkNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de busca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.btnCadastrar);
            this.groupBox2.Location = new System.Drawing.Point(403, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 114);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrar.Location = new System.Drawing.Point(27, 68);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 35);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Cadastrar);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.cod_barras,
            this.nome_produto,
            this.categoria,
            this.grupo,
            this.subgrupo,
            this.estoque_atual,
            this.preco_venda});
            this.dgLista.Location = new System.Drawing.Point(12, 133);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Size = new System.Drawing.Size(960, 217);
            this.dgLista.TabIndex = 1;
            this.dgLista.DoubleClick += new System.EventHandler(this.Editar);
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 80;
            // 
            // cod_barras
            // 
            this.cod_barras.HeaderText = "cod_barras";
            this.cod_barras.Name = "cod_barras";
            this.cod_barras.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.HeaderText = "nome_produto";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            this.nome_produto.Width = 240;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // grupo
            // 
            this.grupo.HeaderText = "grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            // 
            // subgrupo
            // 
            this.subgrupo.HeaderText = "subgrupo";
            this.subgrupo.Name = "subgrupo";
            this.subgrupo.ReadOnly = true;
            // 
            // estoque_atual
            // 
            this.estoque_atual.HeaderText = "estoque_atual";
            this.estoque_atual.Name = "estoque_atual";
            this.estoque_atual.ReadOnly = true;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "preco_venda";
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.ReadOnly = true;
            // 
            // frmPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgLista);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPesquisarProduto";
            this.ShowIcon = false;
            this.Text = "Pesquisa Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton chkNome;
        private System.Windows.Forms.RadioButton chkCodigo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
    }
}