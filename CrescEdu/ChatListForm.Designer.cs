namespace CrescEdu
{
    partial class ChatListForm
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
            this.btnNovaConversa = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBoxConversas = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovaConversa
            // 
            this.btnNovaConversa.Location = new System.Drawing.Point(115, 19);
            this.btnNovaConversa.Name = "btnNovaConversa";
            this.btnNovaConversa.Size = new System.Drawing.Size(86, 35);
            this.btnNovaConversa.TabIndex = 1;
            this.btnNovaConversa.Text = "nOVA CONVERSA";
            this.btnNovaConversa.UseVisualStyleBackColor = true;
            this.btnNovaConversa.Click += new System.EventHandler(this.btnNovaConversa_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(220, 17);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 37);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listBoxConversas
            // 
            this.listBoxConversas.FormattingEnabled = true;
            this.listBoxConversas.ItemHeight = 16;
            this.listBoxConversas.Location = new System.Drawing.Point(15, 71);
            this.listBoxConversas.Name = "listBoxConversas";
            this.listBoxConversas.Size = new System.Drawing.Size(1034, 500);
            this.listBoxConversas.TabIndex = 3;
            this.listBoxConversas.DoubleClick += new System.EventHandler(this.listBoxConversas_DoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(398, 38);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(26, 27);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "button1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(446, 32);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(363, 22);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(506, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // ChatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.listBoxConversas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovaConversa);
            this.Name = "ChatListForm";
            this.Text = "ChatListForm";
            this.Load += new System.EventHandler(this.ChatListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovaConversa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listBoxConversas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTitulo;
    }
}