namespace Gadz.Shop.Selling.Forms {
    partial class EscolherAcao
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
            this.btnEmitirBoleto = new System.Windows.Forms.Button();
            this.btnReceberPagamento = new System.Windows.Forms.Button();
            this.btnContinuarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmitirBoleto
            // 
            this.btnEmitirBoleto.Location = new System.Drawing.Point(186, 40);
            this.btnEmitirBoleto.Name = "btnEmitirBoleto";
            this.btnEmitirBoleto.Size = new System.Drawing.Size(129, 80);
            this.btnEmitirBoleto.TabIndex = 1;
            this.btnEmitirBoleto.Text = "&Emitir boleto";
            this.btnEmitirBoleto.UseVisualStyleBackColor = true;
            this.btnEmitirBoleto.Click += new System.EventHandler(this.EmitirBoleto);
            // 
            // btnReceberPagamento
            // 
            this.btnReceberPagamento.Location = new System.Drawing.Point(321, 40);
            this.btnReceberPagamento.Name = "btnReceberPagamento";
            this.btnReceberPagamento.Size = new System.Drawing.Size(129, 80);
            this.btnReceberPagamento.TabIndex = 2;
            this.btnReceberPagamento.Text = "&Receber Pagamento";
            this.btnReceberPagamento.UseVisualStyleBackColor = true;
            this.btnReceberPagamento.Click += new System.EventHandler(this.ReceberPagamento);
            // 
            // btnContinuarVenda
            // 
            this.btnContinuarVenda.Location = new System.Drawing.Point(51, 40);
            this.btnContinuarVenda.Name = "btnContinuarVenda";
            this.btnContinuarVenda.Size = new System.Drawing.Size(129, 80);
            this.btnContinuarVenda.TabIndex = 0;
            this.btnContinuarVenda.Text = "&Continuar venda";
            this.btnContinuarVenda.UseVisualStyleBackColor = true;
            this.btnContinuarVenda.Click += new System.EventHandler(this.ContinuarVenda);
            // 
            // frmEscolherAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 176);
            this.Controls.Add(this.btnContinuarVenda);
            this.Controls.Add(this.btnReceberPagamento);
            this.Controls.Add(this.btnEmitirBoleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "frmEscolherAcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha a ação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmitirBoleto;
        private System.Windows.Forms.Button btnReceberPagamento;
        private System.Windows.Forms.Button btnContinuarVenda;
    }
}