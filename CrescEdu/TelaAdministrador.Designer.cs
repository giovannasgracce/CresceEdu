namespace CrescEdu
{
    partial class TelaAdministrador
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.bntGerenciar = new System.Windows.Forms.Button();
            this.bntDesativar = new System.Windows.Forms.Button();
            this.bntRelatorio = new System.Windows.Forms.Button();
            this.bntController = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(334, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 38);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(331, 33);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(164, 16);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem-vindo, Administrador!";
            // 
            // bntGerenciar
            // 
            this.bntGerenciar.Location = new System.Drawing.Point(348, 81);
            this.bntGerenciar.Name = "bntGerenciar";
            this.bntGerenciar.Size = new System.Drawing.Size(126, 44);
            this.bntGerenciar.TabIndex = 11;
            this.bntGerenciar.Text = "Gerenciar Professor";
            this.bntGerenciar.UseVisualStyleBackColor = true;
            this.bntGerenciar.Click += new System.EventHandler(this.bntGerenciar_Click);
            // 
            // bntDesativar
            // 
            this.bntDesativar.Location = new System.Drawing.Point(334, 148);
            this.bntDesativar.Name = "bntDesativar";
            this.bntDesativar.Size = new System.Drawing.Size(146, 51);
            this.bntDesativar.TabIndex = 10;
            this.bntDesativar.Text = "Desativar Aluno";
            this.bntDesativar.UseVisualStyleBackColor = true;
            // 
            // bntRelatorio
            // 
            this.bntRelatorio.Location = new System.Drawing.Point(333, 222);
            this.bntRelatorio.Name = "bntRelatorio";
            this.bntRelatorio.Size = new System.Drawing.Size(141, 45);
            this.bntRelatorio.TabIndex = 9;
            this.bntRelatorio.Text = "Relatorio Usuarios";
            this.bntRelatorio.UseVisualStyleBackColor = true;
            this.bntRelatorio.Click += new System.EventHandler(this.bntRelatorio_Click);
            // 
            // bntController
            // 
            this.bntController.Location = new System.Drawing.Point(334, 291);
            this.bntController.Name = "bntController";
            this.bntController.Size = new System.Drawing.Size(145, 37);
            this.bntController.TabIndex = 7;
            this.bntController.Text = "Controle de Turmas";
            this.bntController.UseVisualStyleBackColor = true;
            // 
            // TelaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.bntGerenciar);
            this.Controls.Add(this.bntDesativar);
            this.Controls.Add(this.bntRelatorio);
            this.Controls.Add(this.bntController);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnSair);
            this.Name = "TelaAdministrador";
            this.Text = "TelaAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button bntGerenciar;
        private System.Windows.Forms.Button bntDesativar;
        private System.Windows.Forms.Button bntRelatorio;
        private System.Windows.Forms.Button bntController;
    }
}