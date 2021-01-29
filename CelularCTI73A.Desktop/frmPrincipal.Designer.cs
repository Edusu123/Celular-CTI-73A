namespace CelularCTI73A.Desktop
{
    partial class frmPrincipal
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
            this.lstCelular = new System.Windows.Forms.ListBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtBuscarModelo = new System.Windows.Forms.TextBox();
            this.btnBuscaPreco = new System.Windows.Forms.Button();
            this.grpPesquisarPor = new System.Windows.Forms.GroupBox();
            this.btnBuscaFabricante = new System.Windows.Forms.Button();
            this.btnBuscaModelo = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtPrecoMax = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtPrecoMin = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovoFabricante = new System.Windows.Forms.Button();
            this.grpPesquisarPor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCelular
            // 
            this.lstCelular.FormattingEnabled = true;
            this.lstCelular.Location = new System.Drawing.Point(6, 19);
            this.lstCelular.Name = "lstCelular";
            this.lstCelular.Size = new System.Drawing.Size(336, 303);
            this.lstCelular.TabIndex = 0;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModelo.Location = new System.Drawing.Point(5, 50);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo: ";
            // 
            // txtBuscarModelo
            // 
            this.txtBuscarModelo.Location = new System.Drawing.Point(53, 50);
            this.txtBuscarModelo.Name = "txtBuscarModelo";
            this.txtBuscarModelo.Size = new System.Drawing.Size(227, 20);
            this.txtBuscarModelo.TabIndex = 2;
            // 
            // btnBuscaPreco
            // 
            this.btnBuscaPreco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscaPreco.Location = new System.Drawing.Point(286, 15);
            this.btnBuscaPreco.Name = "btnBuscaPreco";
            this.btnBuscaPreco.Size = new System.Drawing.Size(56, 23);
            this.btnBuscaPreco.TabIndex = 3;
            this.btnBuscaPreco.Text = "==>";
            this.btnBuscaPreco.UseVisualStyleBackColor = true;
            this.btnBuscaPreco.Click += new System.EventHandler(this.btnBuscaPreco_Click);
            // 
            // grpPesquisarPor
            // 
            this.grpPesquisarPor.Controls.Add(this.btnBuscaFabricante);
            this.grpPesquisarPor.Controls.Add(this.btnBuscaModelo);
            this.grpPesquisarPor.Controls.Add(this.cmbFabricante);
            this.grpPesquisarPor.Controls.Add(this.btnBuscaPreco);
            this.grpPesquisarPor.Controls.Add(this.lblFabricante);
            this.grpPesquisarPor.Controls.Add(this.txtPrecoMax);
            this.grpPesquisarPor.Controls.Add(this.lblA);
            this.grpPesquisarPor.Controls.Add(this.txtBuscarModelo);
            this.grpPesquisarPor.Controls.Add(this.txtPrecoMin);
            this.grpPesquisarPor.Controls.Add(this.lblModelo);
            this.grpPesquisarPor.Controls.Add(this.lblPreco);
            this.grpPesquisarPor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpPesquisarPor.Location = new System.Drawing.Point(13, 13);
            this.grpPesquisarPor.Name = "grpPesquisarPor";
            this.grpPesquisarPor.Size = new System.Drawing.Size(354, 113);
            this.grpPesquisarPor.TabIndex = 4;
            this.grpPesquisarPor.TabStop = false;
            this.grpPesquisarPor.Text = "Pesquisar Por";
            // 
            // btnBuscaFabricante
            // 
            this.btnBuscaFabricante.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscaFabricante.Location = new System.Drawing.Point(287, 76);
            this.btnBuscaFabricante.Name = "btnBuscaFabricante";
            this.btnBuscaFabricante.Size = new System.Drawing.Size(55, 23);
            this.btnBuscaFabricante.TabIndex = 7;
            this.btnBuscaFabricante.Text = "==>";
            this.btnBuscaFabricante.UseVisualStyleBackColor = true;
            this.btnBuscaFabricante.Click += new System.EventHandler(this.btnBuscaFabricante_Click_1);
            // 
            // btnBuscaModelo
            // 
            this.btnBuscaModelo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscaModelo.Location = new System.Drawing.Point(287, 46);
            this.btnBuscaModelo.Name = "btnBuscaModelo";
            this.btnBuscaModelo.Size = new System.Drawing.Size(55, 23);
            this.btnBuscaModelo.TabIndex = 6;
            this.btnBuscaModelo.Text = "==>";
            this.btnBuscaModelo.UseVisualStyleBackColor = true;
            this.btnBuscaModelo.Click += new System.EventHandler(this.btnBuscaModelo_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(76, 79);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(204, 21);
            this.cmbFabricante.TabIndex = 5;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFabricante.Location = new System.Drawing.Point(7, 82);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(63, 13);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Fabricante: ";
            // 
            // txtPrecoMax
            // 
            this.txtPrecoMax.Location = new System.Drawing.Point(180, 17);
            this.txtPrecoMax.Name = "txtPrecoMax";
            this.txtPrecoMax.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoMax.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblA.Location = new System.Drawing.Point(160, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "a";
            // 
            // txtPrecoMin
            // 
            this.txtPrecoMin.Location = new System.Drawing.Point(53, 17);
            this.txtPrecoMin.Name = "txtPrecoMin";
            this.txtPrecoMin.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoMin.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreco.Location = new System.Drawing.Point(6, 20);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(41, 13);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovoFabricante);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.lstCelular);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 362);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celulares";
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(248, 328);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(94, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComprar.Location = new System.Drawing.Point(8, 328);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(95, 23);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnNovoFabricante
            // 
            this.btnNovoFabricante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoFabricante.Location = new System.Drawing.Point(109, 328);
            this.btnNovoFabricante.Name = "btnNovoFabricante";
            this.btnNovoFabricante.Size = new System.Drawing.Size(133, 23);
            this.btnNovoFabricante.TabIndex = 3;
            this.btnNovoFabricante.Text = "Novo Fabricante";
            this.btnNovoFabricante.UseVisualStyleBackColor = true;
            this.btnNovoFabricante.Click += new System.EventHandler(this.btnNovoFabricante_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPesquisarPor);
            this.Name = "frmPrincipal";
            this.Text = "Celular - 73A Loja Céu bixu";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpPesquisarPor.ResumeLayout(false);
            this.grpPesquisarPor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCelular;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBuscarModelo;
        private System.Windows.Forms.Button btnBuscaPreco;
        private System.Windows.Forms.GroupBox grpPesquisarPor;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtPrecoMax;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtPrecoMin;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnBuscaFabricante;
        private System.Windows.Forms.Button btnBuscaModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovoFabricante;
    }
}

