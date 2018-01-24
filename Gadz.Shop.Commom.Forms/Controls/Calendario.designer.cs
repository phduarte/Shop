namespace Gadz.Shop.Commom.Forms.Controls {
    partial class Calendario {
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
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.chkFeriado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscala = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.calendario.Location = new System.Drawing.Point(18, 18);
            this.calendario.Name = "Calendario";
            this.calendario.TabIndex = 0;
            // 
            // chkFeriado
            // 
            this.chkFeriado.AutoSize = true;
            this.chkFeriado.Location = new System.Drawing.Point(18, 228);
            this.chkFeriado.Name = "chkFeriado";
            this.chkFeriado.Size = new System.Drawing.Size(61, 17);
            this.chkFeriado.TabIndex = 1;
            this.chkFeriado.Text = "Feriado";
            this.chkFeriado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escala";
            // 
            // txtEscala
            // 
            this.txtEscala.Location = new System.Drawing.Point(77, 192);
            this.txtEscala.Name = "txtEscala";
            this.txtEscala.Size = new System.Drawing.Size(168, 20);
            this.txtEscala.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageKey = "(none)";
            this.btnSalvar.Location = new System.Drawing.Point(142, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 32);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmAddCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 298);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEscala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFeriado);
            this.Controls.Add(this.calendario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCalendario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.CheckBox chkFeriado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEscala;
        private System.Windows.Forms.Button btnSalvar;
    }
}