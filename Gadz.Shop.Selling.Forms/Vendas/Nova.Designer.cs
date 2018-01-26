namespace Gadz.Shop.Selling.Forms.Vendas {
    partial class Nova {
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
            this.lbErro = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkLocalizar = new System.Windows.Forms.LinkLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lbErro);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(294, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 255);
            this.panel1.TabIndex = 0;
            // 
            // lbErro
            // 
            this.lbErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbErro.Location = new System.Drawing.Point(28, 205);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(325, 36);
            this.lbErro.TabIndex = 2;
            this.lbErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbErro.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(244, 163);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(109, 39);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkLocalizar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lnkLocalizar
            // 
            this.lnkLocalizar.AutoSize = true;
            this.lnkLocalizar.Location = new System.Drawing.Point(123, 54);
            this.lnkLocalizar.Name = "lnkLocalizar";
            this.lnkLocalizar.Size = new System.Drawing.Size(49, 13);
            this.lnkLocalizar.TabIndex = 4;
            this.lnkLocalizar.TabStop = true;
            this.lnkLocalizar.Text = "Localizar";
            this.lnkLocalizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLocalizar_LinkClicked);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 51);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(111, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // Nova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 397);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Nova";
            this.Text = "Nova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkLocalizar;
        private System.Windows.Forms.Label lbErro;
    }
}