namespace Gadz.Shop.Selling.Forms.Clientes
{
    partial class Cadastro {
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
            this.grpIdentificacao = new System.Windows.Forms.GroupBox();
            this.lbSituacaoCPF = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIndicacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbEnderecoTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpContato = new System.Windows.Forms.GroupBox();
            this.txtComercial = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEmailDominio = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cmbIndicao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpIdentificacao.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.grpContato.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIdentificacao
            // 
            this.grpIdentificacao.Controls.Add(this.lbSituacaoCPF);
            this.grpIdentificacao.Controls.Add(this.txtDataNascimento);
            this.grpIdentificacao.Controls.Add(this.cmbNome);
            this.grpIdentificacao.Controls.Add(this.label14);
            this.grpIdentificacao.Controls.Add(this.cmbSexo);
            this.grpIdentificacao.Controls.Add(this.label9);
            this.grpIdentificacao.Controls.Add(this.txtCPF);
            this.grpIdentificacao.Controls.Add(this.label3);
            this.grpIdentificacao.Controls.Add(this.label1);
            this.grpIdentificacao.Location = new System.Drawing.Point(3, 3);
            this.grpIdentificacao.Name = "grpIdentificacao";
            this.grpIdentificacao.Size = new System.Drawing.Size(635, 87);
            this.grpIdentificacao.TabIndex = 0;
            this.grpIdentificacao.TabStop = false;
            this.grpIdentificacao.Text = "Identificação";
            // 
            // lbSituacaoCPF
            // 
            this.lbSituacaoCPF.AutoSize = true;
            this.lbSituacaoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacaoCPF.ForeColor = System.Drawing.Color.Red;
            this.lbSituacaoCPF.Location = new System.Drawing.Point(187, 25);
            this.lbSituacaoCPF.Name = "lbSituacaoCPF";
            this.lbSituacaoCPF.Size = new System.Drawing.Size(79, 13);
            this.lbSituacaoCPF.TabIndex = 99;
            this.lbSituacaoCPF.Text = "CPF Inválido";
            this.lbSituacaoCPF.Visible = false;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.CustomFormat = "";
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(477, 48);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(105, 20);
            this.txtDataNascimento.TabIndex = 3;
            // 
            // cmbNome
            // 
            this.cmbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(90, 48);
            this.cmbNome.MaxLength = 75;
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(262, 21);
            this.cmbNome.TabIndex = 1;
            this.cmbNome.DropDown += new System.EventHandler(this.ListarClientes);
            this.cmbNome.Leave += new System.EventHandler(this.MudarCliente);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Data de Nascimento";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cmbSexo.Location = new System.Drawing.Point(477, 22);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(105, 21);
            this.cmbSexo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sexo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCPF.Location = new System.Drawing.Point(90, 22);
            this.txtCPF.Mask = "999\\.999\\.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(91, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Validated += new System.EventHandler(this.PreencherCliente);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIndicacao
            // 
            this.lbIndicacao.AutoSize = true;
            this.lbIndicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndicacao.Location = new System.Drawing.Point(21, 97);
            this.lbIndicacao.Name = "lbIndicacao";
            this.lbIndicacao.Size = new System.Drawing.Size(63, 13);
            this.lbIndicacao.TabIndex = 11;
            this.lbIndicacao.Text = "Indicação";
            this.lbIndicacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Residencial";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(91, 32);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(91, 20);
            this.txtTelefone.TabIndex = 0;
            this.txtTelefone.Text = "31";
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.cmbCidade);
            this.grpEndereco.Controls.Add(this.label13);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.label11);
            this.grpEndereco.Controls.Add(this.linkLabel1);
            this.grpEndereco.Controls.Add(this.cmbEnderecoTipo);
            this.grpEndereco.Controls.Add(this.label8);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.label7);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.label5);
            this.grpEndereco.Controls.Add(this.txtEndereco);
            this.grpEndereco.Controls.Add(this.label2);
            this.grpEndereco.Location = new System.Drawing.Point(3, 196);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(635, 122);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCEP.Location = new System.Drawing.Point(91, 31);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(73, 20);
            this.txtCEP.TabIndex = 21;
            this.txtCEP.Leave += new System.EventHandler(this.PreencherEndereco);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "BELO HORIZONTE",
            "BETIM",
            "CONTAGEM",
            "IBIRITE",
            "SANTA LUZIA"});
            this.cmbCidade.Location = new System.Drawing.Point(490, 84);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(131, 21);
            this.cmbCidade.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cidade";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBairro.Location = new System.Drawing.Point(282, 84);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(147, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bairro";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(165, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pesquisar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PesquisarEndereco);
            // 
            // cmbEnderecoTipo
            // 
            this.cmbEnderecoTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbEnderecoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnderecoTipo.FormattingEnabled = true;
            this.cmbEnderecoTipo.Items.AddRange(new object[] {
            "",
            "Avenida",
            "Beco",
            "Estrada",
            "Rua",
            "Travessa",
            "Outros"});
            this.cmbEnderecoTipo.Location = new System.Drawing.Point(91, 57);
            this.cmbEnderecoTipo.Name = "cmbEnderecoTipo";
            this.cmbEnderecoTipo.Size = new System.Drawing.Size(61, 21);
            this.cmbEnderecoTipo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CEP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.Location = new System.Drawing.Point(91, 84);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(131, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Complemento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumero.Location = new System.Drawing.Point(490, 58);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEndereco.Location = new System.Drawing.Point(158, 58);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(271, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lougradouro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpContato
            // 
            this.grpContato.Controls.Add(this.txtComercial);
            this.grpContato.Controls.Add(this.label15);
            this.grpContato.Controls.Add(this.txtCelular);
            this.grpContato.Controls.Add(this.label10);
            this.grpContato.Controls.Add(this.cmbEmailDominio);
            this.grpContato.Controls.Add(this.txtEmail);
            this.grpContato.Controls.Add(this.label12);
            this.grpContato.Controls.Add(this.txtTelefone);
            this.grpContato.Controls.Add(this.label4);
            this.grpContato.Location = new System.Drawing.Point(3, 96);
            this.grpContato.Name = "grpContato";
            this.grpContato.Size = new System.Drawing.Size(635, 94);
            this.grpContato.TabIndex = 1;
            this.grpContato.TabStop = false;
            this.grpContato.Text = "Contato";
            // 
            // txtComercial
            // 
            this.txtComercial.Location = new System.Drawing.Point(91, 58);
            this.txtComercial.Mask = "(99) 0000-0000";
            this.txtComercial.Name = "txtComercial";
            this.txtComercial.Size = new System.Drawing.Size(91, 20);
            this.txtComercial.TabIndex = 2;
            this.txtComercial.Text = "31";
            this.txtComercial.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Comercial";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(255, 32);
            this.txtCelular.Mask = "(99) 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(91, 20);
            this.txtCelular.TabIndex = 1;
            this.txtCelular.Text = "31";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Celular";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEmailDominio
            // 
            this.cmbEmailDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbEmailDominio.FormattingEnabled = true;
            this.cmbEmailDominio.Items.AddRange(new object[] {
            "",
            "@hotmail.com",
            "@yahoo.com.br",
            "@gmail.com"});
            this.cmbEmailDominio.Location = new System.Drawing.Point(358, 58);
            this.cmbEmailDominio.MaxLength = 15;
            this.cmbEmailDominio.Name = "cmbEmailDominio";
            this.cmbEmailDominio.Size = new System.Drawing.Size(96, 21);
            this.cmbEmailDominio.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmail.Location = new System.Drawing.Point(255, 58);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(97, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "E-mail";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.btnSalvar);
            this.pnlMain.Controls.Add(this.btnLimpar);
            this.pnlMain.Controls.Add(this.grpIdentificacao);
            this.pnlMain.Controls.Add(this.grpContato);
            this.pnlMain.Controls.Add(this.grpEndereco);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(641, 526);
            this.pnlMain.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.cmbIndicao);
            this.groupBox1.Controls.Add(this.lbIndicacao);
            this.groupBox1.Location = new System.Drawing.Point(4, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 134);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Adicionais";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(434, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(186, 86);
            this.label17.TabIndex = 14;
            this.label17.Text = "Use este campo para anotações importantes que ajudam a descrever o perfil, compor" +
                "tamento e/ou temperamento do cliente. Isso ajudará a melhor atendê-lo em futuras" +
                " negociações.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Observações";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(90, 29);
            this.txtObs.MaxLength = 120;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(338, 59);
            this.txtObs.TabIndex = 12;
            // 
            // cmbIndicao
            // 
            this.cmbIndicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndicao.FormattingEnabled = true;
            this.cmbIndicao.Items.AddRange(new object[] {
            "AMIGO",
            "VIZINHO",
            "FAMILIAR",
            "INTERNET",
            "FOLHETO"});
            this.cmbIndicao.Location = new System.Drawing.Point(90, 94);
            this.cmbIndicao.Name = "cmbIndicao";
            this.cmbIndicao.Size = new System.Drawing.Size(147, 21);
            this.cmbIndicao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_salvar_24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(528, 464);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_reset_24x24;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(412, 464);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 50);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // frmAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 562);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(523, 494);
            this.Name = "frmAddCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.Abrir);
            this.grpIdentificacao.ResumeLayout(false);
            this.grpIdentificacao.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.grpContato.ResumeLayout(false);
            this.grpContato.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentificacao;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbIndicacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEnderecoTipo;
        private System.Windows.Forms.GroupBox grpContato;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEmailDominio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtComercial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.Label lbSituacaoCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbIndicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}