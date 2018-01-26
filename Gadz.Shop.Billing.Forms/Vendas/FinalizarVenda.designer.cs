namespace Gadz.Shop.Selling.Forms {
    partial class FinalizarVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRestante = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgPagamentos = new System.Windows.Forms.DataGridView();
            this.id_forma_pgto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstFormaPgto = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorCompra = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 425);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFinalizar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.txtRestante);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPago);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(4, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finalizar pagamento";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Location = new System.Drawing.Point(476, 36);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(130, 57);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.Finalizar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(340, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 57);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // txtRestante
            // 
            this.txtRestante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestante.Location = new System.Drawing.Point(139, 68);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.ReadOnly = true;
            this.txtRestante.Size = new System.Drawing.Size(117, 25);
            this.txtRestante.TabIndex = 5;
            this.txtRestante.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restante";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPago
            // 
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(139, 31);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(117, 25);
            this.txtPago.TabIndex = 3;
            this.txtPago.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Pago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgPagamentos);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.lstFormaPgto);
            this.groupBox2.Location = new System.Drawing.Point(4, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opções Escolhidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opções de pagamento";
            // 
            // dgPagamentos
            // 
            this.dgPagamentos.AllowUserToAddRows = false;
            this.dgPagamentos.AllowUserToDeleteRows = false;
            this.dgPagamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_forma_pgto,
            this.forma_pagamento,
            this.valor});
            this.dgPagamentos.Location = new System.Drawing.Point(310, 51);
            this.dgPagamentos.Name = "dgPagamentos";
            this.dgPagamentos.ReadOnly = true;
            this.dgPagamentos.Size = new System.Drawing.Size(298, 134);
            this.dgPagamentos.TabIndex = 3;
            this.dgPagamentos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Remover);
            this.dgPagamentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Recalcular);
            this.dgPagamentos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Recalcular);
            this.dgPagamentos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Recalcular);
            // 
            // id_forma_pgto
            // 
            this.id_forma_pgto.HeaderText = "id";
            this.id_forma_pgto.Name = "id_forma_pgto";
            this.id_forma_pgto.ReadOnly = true;
            this.id_forma_pgto.Visible = false;
            this.id_forma_pgto.Width = 10;
            // 
            // forma_pagamento
            // 
            this.forma_pagamento.HeaderText = "Forma de Pagamento";
            this.forma_pagamento.Name = "forma_pagamento";
            this.forma_pagamento.ReadOnly = true;
            this.forma_pagamento.Width = 175;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 75;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(211, 125);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(93, 35);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "- &Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.Remover);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(211, 72);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(93, 35);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "+ &Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.Adicionar);
            // 
            // lstFormaPgto
            // 
            this.lstFormaPgto.FormattingEnabled = true;
            this.lstFormaPgto.Location = new System.Drawing.Point(6, 51);
            this.lstFormaPgto.Name = "lstFormaPgto";
            this.lstFormaPgto.Size = new System.Drawing.Size(199, 134);
            this.lstFormaPgto.TabIndex = 0;
            this.lstFormaPgto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Adicionar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da compra";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(139, 29);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.ReadOnly = true;
            this.txtValorCompra.Size = new System.Drawing.Size(117, 25);
            this.txtValorCompra.TabIndex = 1;
            this.txtValorCompra.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da compra";
            // 
            // frmVendaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 449);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(661, 487);
            this.Name = "frmVendaPagamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finalizar Pagamento";
            this.Load += new System.EventHandler(this.ListarFormaPgto);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtRestante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtValorCompra;
        public System.Windows.Forms.DataGridView dgPagamentos;
        public System.Windows.Forms.ListBox lstFormaPgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma_pgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}