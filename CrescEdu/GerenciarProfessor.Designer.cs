﻿namespace CrescEdu
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
            this.lblTíulo.Location = new System.Drawing.Point(362, 66);
            this.lblTíulo.Name = "lblTíulo";
            this.lblTíulo.Size = new System.Drawing.Size(142, 16);
            this.lblTíulo.TabIndex = 0;
            this.lblTíulo.Text = "Gerenciar Professores";
            // 
            // dvgProfessores
            // 
            this.dvgProfessores.AllowUserToOrderColumns = true;
            this.dvgProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProfessores.Location = new System.Drawing.Point(198, 126);
            this.dvgProfessores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProfessores.Name = "dvgProfessores";
            this.dvgProfessores.RowHeadersWidth = 51;
            this.dvgProfessores.RowTemplate.Height = 24;
            this.dvgProfessores.Size = new System.Drawing.Size(596, 231);
            this.dvgProfessores.TabIndex = 1;
            this.dvgProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProfessores_CellContentClick);
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(170, 401);
            this.bntCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(109, 39);
            this.bntCadastrar.TabIndex = 2;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(313, 399);
            this.bntEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(123, 49);
            this.bntEditar.TabIndex = 3;
            this.bntEditar.Text = "Editar Professor";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(489, 399);
            this.bntExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(124, 39);
            this.bntExcluir.TabIndex = 4;
            this.bntExcluir.Text = "Excluir Professor";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // GerenciarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 597);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.dvgProfessores);
            this.Controls.Add(this.lblTíulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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