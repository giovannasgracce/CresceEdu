namespace CrescEdu
{
    partial class ChatForm
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
            this.lblContato = new System.Windows.Forms.Label();
            this.listBoxMensagens = new System.Windows.Forms.ListBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(351, 21);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(35, 13);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "label1";
            // 
            // listBoxMensagens
            // 
            this.listBoxMensagens.FormattingEnabled = true;
            this.listBoxMensagens.Location = new System.Drawing.Point(12, 44);
            this.listBoxMensagens.Name = "listBoxMensagens";
            this.listBoxMensagens.Size = new System.Drawing.Size(776, 641);
            this.listBoxMensagens.TabIndex = 1;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(26, 659);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(698, 20);
            this.txtMensagem.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(730, 649);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(50, 30);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(57, 24);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.listBoxMensagens);
            this.Controls.Add(this.lblContato);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.ListBox listBoxMensagens;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVoltar;
    }
}