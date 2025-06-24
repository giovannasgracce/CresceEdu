namespace CrescEdu
{
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblCodigoSecreto = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.picOlho = new System.Windows.Forms.PictureBox();
            this.bntSair = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.chkNomeSocial = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(206, 36);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(289, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(213, 93);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(295, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(76, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(212, 112);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(295, 112);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(74, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSenha_MaskInputRejected);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(213, 196);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "professor",
            "",
            "",
            "administrador"});
            this.cbTipo.Location = new System.Drawing.Point(296, 193);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(83, 21);
            this.cbTipo.TabIndex = 7;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lblCodigoSecreto
            // 
            this.lblCodigoSecreto.AutoSize = true;
            this.lblCodigoSecreto.Location = new System.Drawing.Point(213, 223);
            this.lblCodigoSecreto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoSecreto.Name = "lblCodigoSecreto";
            this.lblCodigoSecreto.Size = new System.Drawing.Size(80, 13);
            this.lblCodigoSecreto.TabIndex = 8;
            this.lblCodigoSecreto.Text = "Código Secreto";
            this.lblCodigoSecreto.Click += new System.EventHandler(this.lblCodigoSecreto_Click);
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(296, 223);
            this.txtCS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(78, 20);
            this.txtCS.TabIndex = 9;
            this.txtCS.TextChanged += new System.EventHandler(this.txtCS_TextChanged);
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(228, 260);
            this.bntCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(128, 29);
            this.bntCadastrar.TabIndex = 10;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // picOlho
            // 
            this.picOlho.Image = ((System.Drawing.Image)(resources.GetObject("picOlho.Image")));
            this.picOlho.Location = new System.Drawing.Point(381, 115);
            this.picOlho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOlho.Name = "picOlho";
            this.picOlho.Size = new System.Drawing.Size(15, 14);
            this.picOlho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOlho.TabIndex = 11;
            this.picOlho.TabStop = false;
            this.picOlho.Click += new System.EventHandler(this.picOlho_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(250, 310);
            this.bntSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(97, 46);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(295, 144);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(76, 20);
            this.txtCpf.TabIndex = 34;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(213, 149);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(288, 62);
            this.txtNomeSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(76, 20);
            this.txtNomeSocial.TabIndex = 38;
            this.txtNomeSocial.Visible = false;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Location = new System.Drawing.Point(206, 62);
            this.lblNomeSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(67, 13);
            this.lblNomeSocial.TabIndex = 37;
            this.lblNomeSocial.Text = "Nome Social";
            this.lblNomeSocial.Visible = false;
            // 
            // chkNomeSocial
            // 
            this.chkNomeSocial.AutoSize = true;
            this.chkNomeSocial.Location = new System.Drawing.Point(368, 32);
            this.chkNomeSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNomeSocial.Name = "chkNomeSocial";
            this.chkNomeSocial.Size = new System.Drawing.Size(120, 17);
            this.chkNomeSocial.TabIndex = 39;
            this.chkNomeSocial.Text = "Possui Nome Social";
            this.chkNomeSocial.UseVisualStyleBackColor = true;
            this.chkNomeSocial.CheckedChanged += new System.EventHandler(this.chkNomeSocial_CheckedChanged);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.chkNomeSocial);
            this.Controls.Add(this.txtNomeSocial);
            this.Controls.Add(this.lblNomeSocial);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.picOlho);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.txtCS);
            this.Controls.Add(this.lblCodigoSecreto);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblCodigoSecreto;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.PictureBox picOlho;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.CheckBox chkNomeSocial;
    }
}