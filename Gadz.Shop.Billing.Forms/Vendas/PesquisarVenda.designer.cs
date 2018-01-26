namespace Gadz.Shop.Selling.Forms {
    partial class PesquisarVenda
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.txtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.chkDataCompra = new System.Windows.Forms.RadioButton();
            this.chkCliente = new System.Windows.Forms.RadioButton();
            this.chkProtocolo = new System.Windows.Forms.RadioButton();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.btnEmitirPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(138, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(232, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.Location = new System.Drawing.Point(139, 55);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.Size = new System.Drawing.Size(120, 20);
            this.txtProtocolo.TabIndex = 1;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.CustomFormat = "{dd/MM/yyyy}";
            this.txtDataCompra.Location = new System.Drawing.Point(138, 81);
            this.txtDataCompra.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.txtDataCompra.MinDate = new System.DateTime(2012, 12, 1, 0, 0, 0, 0);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(231, 20);
            this.txtDataCompra.TabIndex = 2;
            // 
            // chkDataCompra
            // 
            this.chkDataCompra.AutoSize = true;
            this.chkDataCompra.Location = new System.Drawing.Point(17, 81);
            this.chkDataCompra.Name = "chkDataCompra";
            this.chkDataCompra.Size = new System.Drawing.Size(101, 17);
            this.chkDataCompra.TabIndex = 4;
            this.chkDataCompra.Text = "Data da compra";
            this.chkDataCompra.UseVisualStyleBackColor = true;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Checked = true;
            this.chkCliente.Location = new System.Drawing.Point(17, 30);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(102, 17);
            this.chkCliente.TabIndex = 3;
            this.chkCliente.TabStop = true;
            this.chkCliente.Text = "Nome do cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkProtocolo
            // 
            this.chkProtocolo.AutoSize = true;
            this.chkProtocolo.Location = new System.Drawing.Point(18, 56);
            this.chkProtocolo.Name = "chkProtocolo";
            this.chkProtocolo.Size = new System.Drawing.Size(70, 17);
            this.chkProtocolo.TabIndex = 2;
            this.chkProtocolo.Text = "Protocolo";
            this.chkProtocolo.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.icon_search_24x24;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(31, 29);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(117, 39);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "&Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.Procurar);
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
            this.id_venda,
            this.data_venda,
            this.cliente,
            this.status_venda,
            this.preco_venda,
            this.preco_pago});
            this.dgLista.Location = new System.Drawing.Point(11, 140);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(745, 160);
            this.dgLista.TabIndex = 1;
            this.dgLista.DoubleClick += new System.EventHandler(this.EscolherAcao);
            // 
            // btnEmitirPedido
            // 
            this.btnEmitirPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEmitirPedido.Location = new System.Drawing.Point(31, 74);
            this.btnEmitirPedido.Name = "btnEmitirPedido";
            this.btnEmitirPedido.Size = new System.Drawing.Size(117, 35);
            this.btnEmitirPedido.TabIndex = 1;
            this.btnEmitirPedido.Text = "&Emitir Pedido";
            this.btnEmitirPedido.UseVisualStyleBackColor = true;
            this.btnEmitirPedido.Click += new System.EventHandler(this.EmitirPedido);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.chkProtocolo);
            this.groupBox1.Controls.Add(this.txtProtocolo);
            this.groupBox1.Controls.Add(this.chkCliente);
            this.groupBox1.Controls.Add(this.txtDataCompra);
            this.groupBox1.Controls.Add(this.chkDataCompra);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de busca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.btnEmitirPedido);
            this.groupBox2.Location = new System.Drawing.Point(403, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // id_venda
            // 
            this.id_venda.HeaderText = "id";
            this.id_venda.Name = "id_venda";
            this.id_venda.ReadOnly = true;
            this.id_venda.Width = 50;
            // 
            // data_venda
            // 
            this.data_venda.HeaderText = "data";
            this.data_venda.Name = "data_venda";
            this.data_venda.ReadOnly = true;
            this.data_venda.Width = 125;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 290;
            // 
            // status_venda
            // 
            this.status_venda.HeaderText = "status";
            this.status_venda.Name = "status_venda";
            this.status_venda.ReadOnly = true;
            this.status_venda.Width = 95;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "preco";
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.ReadOnly = true;
            this.preco_venda.Width = 70;
            // 
            // preco_pago
            // 
            this.preco_pago.HeaderText = "pago";
            this.preco_pago.Name = "preco_pago";
            this.preco_pago.ReadOnly = true;
            this.preco_pago.Width = 70;
            // 
            // frmPesquisarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(769, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgLista);
            this.MinimumSize = new System.Drawing.Size(785, 350);
            this.Name = "frmPesquisarVenda";
            this.ShowIcon = false;
            this.Text = "Pesquisa Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.DateTimePicker txtDataCompra;
        private System.Windows.Forms.RadioButton chkDataCompra;
        private System.Windows.Forms.RadioButton chkCliente;
        private System.Windows.Forms.RadioButton chkProtocolo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnEmitirPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_pago;
    }
}