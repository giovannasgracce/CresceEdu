namespace CrescEdu
{
    partial class TelaProfessor
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.bntProprio = new System.Windows.Forms.Button();
            this.bntAlunos = new System.Windows.Forms.Button();
            this.bntAgenda = new System.Windows.Forms.Button();
            this.bntAbrirChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(293, 26);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(135, 16);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-Vindo,Professor";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(296, 388);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 39);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bntProprio
            // 
            this.bntProprio.Location = new System.Drawing.Point(297, 111);
            this.bntProprio.Margin = new System.Windows.Forms.Padding(4);
            this.bntProprio.Name = "bntProprio";
            this.bntProprio.Size = new System.Drawing.Size(153, 42);
            this.bntProprio.TabIndex = 2;
            this.bntProprio.Text = "Modificar Cadastro";
            this.bntProprio.UseVisualStyleBackColor = true;
            // 
            // bntAlunos
            // 
            this.bntAlunos.Location = new System.Drawing.Point(297, 174);
            this.bntAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.bntAlunos.Name = "bntAlunos";
            this.bntAlunos.Size = new System.Drawing.Size(153, 42);
            this.bntAlunos.TabIndex = 3;
            this.bntAlunos.Text = "Lista de Alunos";
            this.bntAlunos.UseVisualStyleBackColor = true;
            // 
            // bntAgenda
            // 
            this.bntAgenda.Location = new System.Drawing.Point(297, 241);
            this.bntAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.bntAgenda.Name = "bntAgenda";
            this.bntAgenda.Size = new System.Drawing.Size(153, 42);
            this.bntAgenda.TabIndex = 4;
            this.bntAgenda.Text = "Agenda";
            this.bntAgenda.UseVisualStyleBackColor = true;
            this.bntAgenda.Click += new System.EventHandler(this.bntAgenda_Click);
            // 
            // bntAbrirChat
            // 
            this.bntAbrirChat.Location = new System.Drawing.Point(305, 297);
            this.bntAbrirChat.Name = "bntAbrirChat";
            this.bntAbrirChat.Size = new System.Drawing.Size(144, 47);
            this.bntAbrirChat.TabIndex = 5;
            this.bntAbrirChat.Text = "button1";
            this.bntAbrirChat.UseVisualStyleBackColor = true;
            this.bntAbrirChat.Click += new System.EventHandler(this.bntAbrirChat_Click);
            // 
            // TelaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.bntAbrirChat);
            this.Controls.Add(this.bntAgenda);
            this.Controls.Add(this.bntAlunos);
            this.Controls.Add(this.bntProprio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBemVindo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaProfessor";
            this.Text = "TelaProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button bntProprio;
        private System.Windows.Forms.Button bntAlunos;
        private System.Windows.Forms.Button bntAgenda;
        private System.Windows.Forms.Button bntAbrirChat;
    }
}