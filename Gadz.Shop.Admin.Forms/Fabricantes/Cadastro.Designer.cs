namespace Gadz.Shop.Admin.Forms.Fabricantes {
    partial class Cadastro
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
            this.grpFabricante = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imgLogotipo = new System.Windows.Forms.PictureBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpFabricante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFabricante
            // 
            this.grpFabricante.Controls.Add(this.linkLabel1);
            this.grpFabricante.Controls.Add(this.imgLogotipo);
            this.grpFabricante.Controls.Add(this.txtFabricante);
            this.grpFabricante.Controls.Add(this.label1);
            this.grpFabricante.Location = new System.Drawing.Point(13, 13);
            this.grpFabricante.Name = "grpFabricante";
            this.grpFabricante.Size = new System.Drawing.Size(349, 151);
            this.grpFabricante.TabIndex = 0;
            this.grpFabricante.TabStop = false;
            this.grpFabricante.Text = "Fabricante";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(29, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Alterar logotipo";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AlterarLogotipo);
            // 
            // imgLogotipo
            // 
            this.imgLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogotipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLogotipo.Location = new System.Drawing.Point(6, 19);
            this.imgLogotipo.Name = "imgLogotipo";
            this.imgLogotipo.Size = new System.Drawing.Size(142, 101);
            this.imgLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogotipo.TabIndex = 3;
            this.imgLogotipo.TabStop = false;
            // 
            // txtFabricante
            // 
            this.txtFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFabricante.Location = new System.Drawing.Point(154, 35);
            this.txtFabricante.MaxLength = 50;
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(189, 20);
            this.txtFabricante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_salvar_24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(254, 175);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 54);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Image = global::Gadz.Shop.Commom.Resources.Properties.Resources.img_reset_24x24;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(140, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 54);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // frmCadastrarFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpFabricante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFabricante";
            this.ShowIcon = false;
            this.Text = "Cadastro de fabricantes";
            this.grpFabricante.ResumeLayout(false);
            this.grpFabricante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFabricante;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgLogotipo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLimpar;
    }
}