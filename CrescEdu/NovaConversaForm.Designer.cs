namespace CrescEdu
{
    partial class NovaConversaForm
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
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIniciarConversa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.ItemHeight = 16;
            this.listBoxUsuarios.Location = new System.Drawing.Point(12, 113);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(1022, 452);
            this.listBoxUsuarios.TabIndex = 0;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(417, 73);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(291, 22);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(366, 73);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(39, 21);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = ">";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnIniciarConversa
            // 
            this.btnIniciarConversa.Location = new System.Drawing.Point(83, 571);
            this.btnIniciarConversa.Name = "btnIniciarConversa";
            this.btnIniciarConversa.Size = new System.Drawing.Size(68, 22);
            this.btnIniciarConversa.TabIndex = 3;
            this.btnIniciarConversa.Text = "iniciar";
            this.btnIniciarConversa.UseVisualStyleBackColor = true;
            this.btnIniciarConversa.Click += new System.EventHandler(this.btnIniciarConversa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(157, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 21);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // NovaConversaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciarConversa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.listBoxUsuarios);
            this.Name = "NovaConversaForm";
            this.Text = "NovaConversaForm";
            this.Load += new System.EventHandler(this.NovaConversaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnIniciarConversa;
        private System.Windows.Forms.Button btnCancelar;


    }
}