namespace CrescEdu
{
    partial class ModalAgenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Turma";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(379, 98);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(164, 22);
            this.txtTitulo.TabIndex = 5;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(389, 147);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(153, 20);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Location = new System.Drawing.Point(389, 201);
            this.cbPrioridade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(136, 24);
            this.cbPrioridade.TabIndex = 7;
            this.cbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cbPrioridade_SelectedIndexChanged);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(389, 261);
            this.txtTurma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(159, 22);
            this.txtTurma.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(389, 323);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(159, 22);
            this.txtTipo.TabIndex = 10;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(425, 392);
            this.bntSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(91, 30);
            this.bntSalvar.TabIndex = 11;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(425, 429);
            this.bntExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(91, 30);
            this.bntExcluir.TabIndex = 12;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(425, 465);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(91, 30);
            this.bntCancelar.TabIndex = 13;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // ModalAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModalAgenda";
            this.Text = "ModalAgenda";
            this.Load += new System.EventHandler(this.ModalAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntCancelar;
    }
}