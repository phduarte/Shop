namespace Gadz.Shop.Stock.Forms.Categorias {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.cmbSubGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpCategoria.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.cmbSubGrupo);
            this.grpCategoria.Controls.Add(this.label4);
            this.grpCategoria.Controls.Add(this.cmbCategoria);
            this.grpCategoria.Controls.Add(this.label3);
            this.grpCategoria.Controls.Add(this.cmbGrupo);
            this.grpCategoria.Controls.Add(this.label1);
            resources.ApplyResources(this.grpCategoria, "grpCategoria");
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.TabStop = false;
            // 
            // cmbSubGrupo
            // 
            this.cmbSubGrupo.DisplayMember = "categoria";
            this.cmbSubGrupo.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSubGrupo, "cmbSubGrupo");
            this.cmbSubGrupo.Name = "cmbSubGrupo";
            this.cmbSubGrupo.ValueMember = "categoria";
            this.cmbSubGrupo.DropDown += new System.EventHandler(this.ListarSubGrupos);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCategoria, "cmbCategoria");
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Sorted = true;
            this.cmbCategoria.DropDown += new System.EventHandler(this.ListarCategorias);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DisplayMember = "macro";
            this.cmbGrupo.FormattingEnabled = true;
            resources.ApplyResources(this.cmbGrupo, "cmbGrupo");
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.ValueMember = "macro";
            this.cmbGrupo.DropDown += new System.EventHandler(this.ListarGrupos);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.grpCategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Name = "panel1";
            // 
            // Cadastrar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastrar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbSubGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}