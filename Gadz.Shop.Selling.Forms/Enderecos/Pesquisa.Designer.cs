namespace Gadz.Shop.Selling.Forms.Enderecos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lougradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frete_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 109);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de busca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cidade";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(89, 30);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lougradouro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(89, 57);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(248, 20);
            this.txtEndereco.TabIndex = 3;
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
            this.cep,
            this.tipo,
            this.lougradouro,
            this.bairro,
            this.cidade,
            this.frete_1,
            this.frete_2,
            this.frete_3,
            this.frete_4,
            this.frete_5,
            this.frete_6,
            this.frete_7,
            this.frete_8,
            this.frete_9});
            this.dgLista.Location = new System.Drawing.Point(12, 127);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Size = new System.Drawing.Size(633, 174);
            this.dgLista.TabIndex = 11;
            this.dgLista.DoubleClick += new System.EventHandler(this.EnviarCEP);
            // 
            // cep
            // 
            this.cep.HeaderText = "cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 70;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 70;
            // 
            // lougradouro
            // 
            this.lougradouro.HeaderText = "lougradouro";
            this.lougradouro.Name = "lougradouro";
            this.lougradouro.ReadOnly = true;
            this.lougradouro.Width = 200;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 150;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // frete_1
            // 
            this.frete_1.HeaderText = "frete_1";
            this.frete_1.Name = "frete_1";
            this.frete_1.ReadOnly = true;
            this.frete_1.Width = 58;
            // 
            // frete_2
            // 
            this.frete_2.HeaderText = "frete_2";
            this.frete_2.Name = "frete_2";
            this.frete_2.ReadOnly = true;
            this.frete_2.Width = 58;
            // 
            // frete_3
            // 
            this.frete_3.HeaderText = "frete_3";
            this.frete_3.Name = "frete_3";
            this.frete_3.ReadOnly = true;
            this.frete_3.Width = 58;
            // 
            // frete_4
            // 
            this.frete_4.HeaderText = "frete_4";
            this.frete_4.Name = "frete_4";
            this.frete_4.ReadOnly = true;
            this.frete_4.Width = 58;
            // 
            // frete_5
            // 
            this.frete_5.HeaderText = "frete_5";
            this.frete_5.Name = "frete_5";
            this.frete_5.ReadOnly = true;
            this.frete_5.Width = 58;
            // 
            // frete_6
            // 
            this.frete_6.HeaderText = "frete_6";
            this.frete_6.Name = "frete_6";
            this.frete_6.ReadOnly = true;
            this.frete_6.Width = 58;
            // 
            // frete_7
            // 
            this.frete_7.HeaderText = "frete_7";
            this.frete_7.Name = "frete_7";
            this.frete_7.ReadOnly = true;
            this.frete_7.Width = 58;
            // 
            // frete_8
            // 
            this.frete_8.HeaderText = "frete_8";
            this.frete_8.Name = "frete_8";
            this.frete_8.ReadOnly = true;
            this.frete_8.Width = 58;
            // 
            // frete_9
            // 
            this.frete_9.HeaderText = "frete_9";
            this.frete_9.Name = "frete_9";
            this.frete_9.ReadOnly = true;
            this.frete_9.Width = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 109);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_search_24x24;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(23, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 50);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.Procurar);
            // 
            // frmEnderecoPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgLista);
            this.MinimumSize = new System.Drawing.Size(673, 38);
            this.Name = "frmEnderecoPesquisar";
            this.ShowIcon = false;
            this.Text = "Pesquisar Endereço";
            this.Load += new System.EventHandler(this.Abrir);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lougradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_8;
        private System.Windows.Forms.DataGridViewTextBoxColumn frete_9;
    }
}