namespace Gadz.Shop.HR.Forms {
    partial class Main {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcessoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcessoLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAcessoTrocarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcessoTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAcessoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhFuncionariosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhFuncionariosPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhEnderecos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhEnderecosCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhEnderecosPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhSalarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRhSalariosPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRhSalariosPromocoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcesso,
            this.menuRh,
            this.menuAjuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuAcesso
            // 
            this.menuAcesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcessoLogin,
            this.menuAcessoLogout,
            this.toolStripSeparator2,
            this.menuAcessoTrocarSenha,
            this.menuAcessoTrocarUsuario,
            this.toolStripSeparator3,
            this.menuAcessoSair});
            this.menuAcesso.Name = "menuAcesso";
            this.menuAcesso.Size = new System.Drawing.Size(56, 20);
            this.menuAcesso.Text = "Acesso";
            // 
            // menuAcessoLogin
            // 
            this.menuAcessoLogin.Name = "menuAcessoLogin";
            this.menuAcessoLogin.Size = new System.Drawing.Size(149, 22);
            this.menuAcessoLogin.Text = "Login";
            this.menuAcessoLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuAcessoLogout
            // 
            this.menuAcessoLogout.Name = "menuAcessoLogout";
            this.menuAcessoLogout.Size = new System.Drawing.Size(149, 22);
            this.menuAcessoLogout.Text = "Logout";
            this.menuAcessoLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // menuAcessoTrocarSenha
            // 
            this.menuAcessoTrocarSenha.Name = "menuAcessoTrocarSenha";
            this.menuAcessoTrocarSenha.Size = new System.Drawing.Size(149, 22);
            this.menuAcessoTrocarSenha.Text = "Trocar senha";
            this.menuAcessoTrocarSenha.Click += new System.EventHandler(this.trocarSenhaToolStripMenuItem_Click);
            // 
            // menuAcessoTrocarUsuario
            // 
            this.menuAcessoTrocarUsuario.Name = "menuAcessoTrocarUsuario";
            this.menuAcessoTrocarUsuario.Size = new System.Drawing.Size(149, 22);
            this.menuAcessoTrocarUsuario.Text = "Trocar usuário";
            this.menuAcessoTrocarUsuario.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // menuAcessoSair
            // 
            this.menuAcessoSair.Name = "menuAcessoSair";
            this.menuAcessoSair.Size = new System.Drawing.Size(149, 22);
            this.menuAcessoSair.Text = "Sair";
            this.menuAcessoSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuRh
            // 
            this.menuRh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRhFuncionarios,
            this.menuRhEnderecos,
            this.menuRhSalarios});
            this.menuRh.Name = "menuRh";
            this.menuRh.Size = new System.Drawing.Size(35, 20);
            this.menuRh.Text = "RH";
            // 
            // menuRhFuncionarios
            // 
            this.menuRhFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRhFuncionariosCadastro,
            this.menuRhFuncionariosPesquisa});
            this.menuRhFuncionarios.Name = "menuRhFuncionarios";
            this.menuRhFuncionarios.Size = new System.Drawing.Size(152, 22);
            this.menuRhFuncionarios.Text = "Funcionários";
            // 
            // menuRhFuncionariosCadastro
            // 
            this.menuRhFuncionariosCadastro.Name = "menuRhFuncionariosCadastro";
            this.menuRhFuncionariosCadastro.Size = new System.Drawing.Size(121, 22);
            this.menuRhFuncionariosCadastro.Text = "Cadastro";
            this.menuRhFuncionariosCadastro.Click += new System.EventHandler(this.menuCadastroFuncionariosCadastro_Click);
            // 
            // menuRhFuncionariosPesquisa
            // 
            this.menuRhFuncionariosPesquisa.Name = "menuRhFuncionariosPesquisa";
            this.menuRhFuncionariosPesquisa.Size = new System.Drawing.Size(121, 22);
            this.menuRhFuncionariosPesquisa.Text = "Pesquisa";
            this.menuRhFuncionariosPesquisa.Click += new System.EventHandler(this.menuCadastroFuncionariosPesquisa_Click);
            // 
            // menuRhEnderecos
            // 
            this.menuRhEnderecos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRhEnderecosCadastro,
            this.menuRhEnderecosPesquisa});
            this.menuRhEnderecos.Name = "menuRhEnderecos";
            this.menuRhEnderecos.Size = new System.Drawing.Size(152, 22);
            this.menuRhEnderecos.Text = "Endereços";
            // 
            // menuRhEnderecosCadastro
            // 
            this.menuRhEnderecosCadastro.Name = "menuRhEnderecosCadastro";
            this.menuRhEnderecosCadastro.Size = new System.Drawing.Size(121, 22);
            this.menuRhEnderecosCadastro.Text = "Cadastro";
            this.menuRhEnderecosCadastro.Click += new System.EventHandler(this.menuCadastroEnderecosCadastro_Click);
            // 
            // menuRhEnderecosPesquisa
            // 
            this.menuRhEnderecosPesquisa.Name = "menuRhEnderecosPesquisa";
            this.menuRhEnderecosPesquisa.Size = new System.Drawing.Size(121, 22);
            this.menuRhEnderecosPesquisa.Text = "Pesquisa";
            this.menuRhEnderecosPesquisa.Click += new System.EventHandler(this.menuCadastroEnderecosPesquisa_Click);
            // 
            // menuRhSalarios
            // 
            this.menuRhSalarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRhSalariosPesquisa,
            this.toolStripSeparator1,
            this.menuRhSalariosPromocoes});
            this.menuRhSalarios.Name = "menuRhSalarios";
            this.menuRhSalarios.Size = new System.Drawing.Size(152, 22);
            this.menuRhSalarios.Text = "Salários";
            // 
            // menuRhSalariosPesquisa
            // 
            this.menuRhSalariosPesquisa.Name = "menuRhSalariosPesquisa";
            this.menuRhSalariosPesquisa.Size = new System.Drawing.Size(134, 22);
            this.menuRhSalariosPesquisa.Text = "Pesquisa";
            this.menuRhSalariosPesquisa.Click += new System.EventHandler(this.menuCadastroSalariosPesquisa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // menuRhSalariosPromocoes
            // 
            this.menuRhSalariosPromocoes.Name = "menuRhSalariosPromocoes";
            this.menuRhSalariosPromocoes.Size = new System.Drawing.Size(134, 22);
            this.menuRhSalariosPromocoes.Text = "Promoções";
            this.menuRhSalariosPromocoes.Click += new System.EventHandler(this.menuCadastroSalariosPromocoes_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuAjuda.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuAcesso;
        private System.Windows.Forms.ToolStripMenuItem menuRh;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoLogin;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoTrocarSenha;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoTrocarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAcessoSair;
        private System.Windows.Forms.ToolStripMenuItem menuRhFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuRhFuncionariosCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuRhFuncionariosPesquisa;
        private System.Windows.Forms.ToolStripMenuItem menuRhEnderecos;
        private System.Windows.Forms.ToolStripMenuItem menuRhEnderecosCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuRhEnderecosPesquisa;
        private System.Windows.Forms.ToolStripMenuItem menuRhSalarios;
        private System.Windows.Forms.ToolStripMenuItem menuRhSalariosPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRhSalariosPromocoes;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}



