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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.listBoxConversas = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovaConversa = new System.Windows.Forms.Button();
            this.btnAbrirConversa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(353, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Minhas Conversas";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.GhostWhite;
            this.lblPesquisar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPesquisar.Location = new System.Drawing.Point(235, 59);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(13, 13);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = ">\r\n";
            this.lblPesquisar.Click += new System.EventHandler(this.lblPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(254, 56);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(369, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // listBoxConversas
            // 
            this.listBoxConversas.FormattingEnabled = true;
            this.listBoxConversas.Location = new System.Drawing.Point(26, 115);
            this.listBoxConversas.Name = "listBoxConversas";
            this.listBoxConversas.Size = new System.Drawing.Size(762, 524);
            this.listBoxConversas.TabIndex = 3;
            this.listBoxConversas.SelectedIndexChanged += new System.EventHandler(this.listBoxConversas_SelectedIndexChanged);
            this.listBoxConversas.DoubleClick += new System.EventHandler(this.listBoxConversas_DoubleClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(127, 30);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(67, 20);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnNovaConversa
            // 
            this.btnNovaConversa.Location = new System.Drawing.Point(41, 19);
            this.btnNovaConversa.Name = "btnNovaConversa";
            this.btnNovaConversa.Size = new System.Drawing.Size(80, 20);
            this.btnNovaConversa.TabIndex = 6;
            this.btnNovaConversa.Text = "btnNovaConversa";
            this.btnNovaConversa.UseVisualStyleBackColor = true;
            this.btnNovaConversa.Click += new System.EventHandler(this.btnNovaConversa_Click);
            // 
            // btnAbrirConversa
            // 
            this.btnAbrirConversa.Location = new System.Drawing.Point(12, 52);
            this.btnAbrirConversa.Name = "btnAbrirConversa";
            this.btnAbrirConversa.Size = new System.Drawing.Size(85, 20);
            this.btnAbrirConversa.TabIndex = 7;
            this.btnAbrirConversa.Text = "btnAbrirConversa";
            this.btnAbrirConversa.UseVisualStyleBackColor = true;
            // 
            // ChatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.btnAbrirConversa);
            this.Controls.Add(this.btnNovaConversa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listBoxConversas);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ChatListForm";
            this.Text = "ChatListForm";
            this.Load += new System.EventHandler(this.ChatListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ListBox listBoxConversas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovaConversa;
        private System.Windows.Forms.Button btnAbrirConversa;
    }
}