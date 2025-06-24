namespace CrescEdu
{
    partial class EditarProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProfessor));
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.chkNomeSocial = new System.Windows.Forms.CheckBox();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.picOlho = new System.Windows.Forms.PictureBox();
            this.bntEditar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(206, 136);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(76, 20);
            this.txtCpf.TabIndex = 50;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(124, 141);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 49;
            this.lblCPF.Text = "CPF";
            // 
            // chkNomeSocial
            // 
            this.chkNomeSocial.AutoSize = true;
            this.chkNomeSocial.Location = new System.Drawing.Point(286, 46);
            this.chkNomeSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNomeSocial.Name = "chkNomeSocial";
            this.chkNomeSocial.Size = new System.Drawing.Size(120, 17);
            this.chkNomeSocial.TabIndex = 48;
            this.chkNomeSocial.Text = "Possui Nome Social";
            this.chkNomeSocial.UseVisualStyleBackColor = true;
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(206, 67);
            this.txtNomeSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(76, 20);
            this.txtNomeSocial.TabIndex = 47;
            this.txtNomeSocial.Visible = false;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Location = new System.Drawing.Point(124, 67);
            this.lblNomeSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(67, 13);
            this.lblNomeSocial.TabIndex = 46;
            this.lblNomeSocial.Text = "Nome Social";
            this.lblNomeSocial.Visible = false;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(176, 313);
            this.bntSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(97, 46);
            this.bntSair.TabIndex = 45;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // picOlho
            // 
            this.picOlho.Image = ((System.Drawing.Image)(resources.GetObject("picOlho.Image")));
            this.picOlho.Location = new System.Drawing.Point(292, 117);
            this.picOlho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOlho.Name = "picOlho";
            this.picOlho.Size = new System.Drawing.Size(15, 14);
            this.picOlho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOlho.TabIndex = 44;
            this.picOlho.TabStop = false;
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(154, 262);
            this.bntEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(128, 29);
            this.bntEditar.TabIndex = 43;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Professor",
            "Administrador"});
            this.cbTipo.Location = new System.Drawing.Point(205, 196);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(83, 21);
            this.cbTipo.TabIndex = 40;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(122, 198);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(206, 114);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(74, 20);
            this.txtSenha.TabIndex = 38;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(124, 114);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 37;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 90);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(76, 20);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(124, 95);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "E-mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nome";
            // 
            // EditarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.chkNomeSocial);
            this.Controls.Add(this.txtNomeSocial);
            this.Controls.Add(this.lblNomeSocial);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.picOlho);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditarProfessor";
            this.Text = "EditarProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.CheckBox chkNomeSocial;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.PictureBox picOlho;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}