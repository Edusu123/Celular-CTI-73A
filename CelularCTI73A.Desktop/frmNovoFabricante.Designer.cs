namespace CelularCTI73A.Desktop
{
    partial class frmNovoFabricante
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
            this.lblNomeFabricante = new System.Windows.Forms.Label();
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeFabricante
            // 
            this.lblNomeFabricante.AutoSize = true;
            this.lblNomeFabricante.Location = new System.Drawing.Point(13, 13);
            this.lblNomeFabricante.Name = "lblNomeFabricante";
            this.lblNomeFabricante.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFabricante.TabIndex = 0;
            this.lblNomeFabricante.Text = "Nome:";
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Location = new System.Drawing.Point(57, 10);
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new System.Drawing.Size(194, 20);
            this.txtNomeFabricante.TabIndex = 1;
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(57, 37);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(112, 20);
            this.mskCnpj.TabIndex = 2;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(13, 43);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 3;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 74);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmNovoFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 109);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.txtNomeFabricante);
            this.Controls.Add(this.lblNomeFabricante);
            this.Name = "frmNovoFabricante";
            this.Text = "Cadastro de Fabricantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFabricante;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnCadastrar;
    }
}