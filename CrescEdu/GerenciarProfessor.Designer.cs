namespace CrescEdu
{
    partial class GerenciarProfessor
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
            this.lblTíulo = new System.Windows.Forms.Label();
            this.dvgProfessores = new System.Windows.Forms.DataGridView();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTíulo
            // 
            this.lblTíulo.AutoSize = true;
            this.lblTíulo.Location = new System.Drawing.Point(230, 19);
            this.lblTíulo.Name = "lblTíulo";
            this.lblTíulo.Size = new System.Drawing.Size(142, 16);
            this.lblTíulo.TabIndex = 0;
            this.lblTíulo.Text = "Gerenciar Professores";
            // 
            // dvgProfessores
            // 
            this.dvgProfessores.AllowUserToOrderColumns = true;
            this.dvgProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProfessores.Location = new System.Drawing.Point(65, 78);
            this.dvgProfessores.Name = "dvgProfessores";
            this.dvgProfessores.RowHeadersWidth = 51;
            this.dvgProfessores.RowTemplate.Height = 24;
            this.dvgProfessores.Size = new System.Drawing.Size(596, 232);
            this.dvgProfessores.TabIndex = 1;
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(37, 353);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(109, 39);
            this.bntCadastrar.TabIndex = 2;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(180, 351);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(122, 49);
            this.bntEditar.TabIndex = 3;
            this.bntEditar.Text = "Editar Professor";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(356, 351);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(124, 40);
            this.bntExcluir.TabIndex = 4;
            this.bntExcluir.Text = "Excluir Professor";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // GerenciarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.dvgProfessores);
            this.Controls.Add(this.lblTíulo);
            this.Name = "GerenciarProfessor";
            this.Text = "GerenciarProfessor";
            this.Load += new System.EventHandler(this.GerenciarProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProfessores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTíulo;
        private System.Windows.Forms.DataGridView dvgProfessores;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntExcluir;
    }
}