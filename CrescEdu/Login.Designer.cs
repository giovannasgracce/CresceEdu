namespace CrescEdu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.picOlho = new System.Windows.Forms.PictureBox();
            this.bntSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(141, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(218, 87);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(112, 22);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(148, 85);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(211, 181);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(136, 37);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // picOlho
            // 
            this.picOlho.Image = ((System.Drawing.Image)(resources.GetObject("picOlho.Image")));
            this.picOlho.Location = new System.Drawing.Point(352, 90);
            this.picOlho.Name = "picOlho";
            this.picOlho.Size = new System.Drawing.Size(21, 18);
            this.picOlho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOlho.TabIndex = 6;
            this.picOlho.TabStop = false;
            this.picOlho.Click += new System.EventHandler(this.picOlho_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(214, 247);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(132, 43);
            this.bntSair.TabIndex = 7;
            this.bntSair.Text = "sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.picOlho);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picOlho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox picOlho;
        private System.Windows.Forms.Button bntSair;
    }
}