namespace BuscaTexto {
    partial class FormPesquisa {
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPadrao = new System.Windows.Forms.Label();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.txtPadrao = new System.Windows.Forms.TextBox();
            this.txtSubistituir = new System.Windows.Forms.TextBox();
            this.lblSubistituir = new System.Windows.Forms.Label();
            this.chkSubistituir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(100, 160);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(19, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPadrao
            // 
            this.lblPadrao.AutoSize = true;
            this.lblPadrao.Location = new System.Drawing.Point(16, 3);
            this.lblPadrao.Name = "lblPadrao";
            this.lblPadrao.Size = new System.Drawing.Size(41, 13);
            this.lblPadrao.TabIndex = 2;
            this.lblPadrao.Text = "Padrao";
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(19, 50);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.chkCaseSensitive.TabIndex = 3;
            this.chkCaseSensitive.Text = "Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            this.chkCaseSensitive.CheckedChanged += new System.EventHandler(this.chkCaseSensitive_CheckedChanged);
            // 
            // txtPadrao
            // 
            this.txtPadrao.Location = new System.Drawing.Point(19, 19);
            this.txtPadrao.Name = "txtPadrao";
            this.txtPadrao.Size = new System.Drawing.Size(156, 20);
            this.txtPadrao.TabIndex = 4;
            // 
            // txtSubistituir
            // 
            this.txtSubistituir.Location = new System.Drawing.Point(19, 134);
            this.txtSubistituir.Name = "txtSubistituir";
            this.txtSubistituir.Size = new System.Drawing.Size(156, 20);
            this.txtSubistituir.TabIndex = 5;
            // 
            // lblSubistituir
            // 
            this.lblSubistituir.AutoSize = true;
            this.lblSubistituir.Location = new System.Drawing.Point(16, 118);
            this.lblSubistituir.Name = "lblSubistituir";
            this.lblSubistituir.Size = new System.Drawing.Size(52, 13);
            this.lblSubistituir.TabIndex = 6;
            this.lblSubistituir.Text = "Subistituir";
            // 
            // chkSubistituir
            // 
            this.chkSubistituir.AutoSize = true;
            this.chkSubistituir.Location = new System.Drawing.Point(19, 82);
            this.chkSubistituir.Name = "chkSubistituir";
            this.chkSubistituir.Size = new System.Drawing.Size(101, 17);
            this.chkSubistituir.TabIndex = 7;
            this.chkSubistituir.Text = "Subistituir Texto";
            this.chkSubistituir.UseVisualStyleBackColor = true;
            this.chkSubistituir.CheckedChanged += new System.EventHandler(this.chkSubistituir_CheckedChanged);
            // 
            // FormPesquisa
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.chkSubistituir);
            this.Controls.Add(this.lblSubistituir);
            this.Controls.Add(this.txtSubistituir);
            this.Controls.Add(this.txtPadrao);
            this.Controls.Add(this.chkCaseSensitive);
            this.Controls.Add(this.lblPadrao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesquisa";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPadrao;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.TextBox txtPadrao;
        private System.Windows.Forms.TextBox txtSubistituir;
        private System.Windows.Forms.Label lblSubistituir;
        private System.Windows.Forms.CheckBox chkSubistituir;
    }
}