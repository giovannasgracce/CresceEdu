namespace CrescEdu
{
    partial class Relatório
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
            this.bntExportar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.bntFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntExportar
            // 
            this.bntExportar.Location = new System.Drawing.Point(219, 314);
            this.bntExportar.Margin = new System.Windows.Forms.Padding(2);
            this.bntExportar.Name = "bntExportar";
            this.bntExportar.Size = new System.Drawing.Size(110, 41);
            this.bntExportar.TabIndex = 6;
            this.bntExportar.Text = "Exportar Dados";
            this.bntExportar.UseVisualStyleBackColor = true;
            this.bntExportar.Click += new System.EventHandler(this.bntExportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 248);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbFiltroTipo
            // 
            this.cbFiltroTipo.FormattingEnabled = true;
            this.cbFiltroTipo.Location = new System.Drawing.Point(341, 13);
            this.cbFiltroTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbFiltroTipo.Name = "cbFiltroTipo";
            this.cbFiltroTipo.Size = new System.Drawing.Size(106, 21);
            this.cbFiltroTipo.TabIndex = 9;
            this.cbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTipo_SelectedIndexChanged);
            // 
            // bntFiltrar
            // 
            this.bntFiltrar.Location = new System.Drawing.Point(460, 9);
            this.bntFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.bntFiltrar.Name = "bntFiltrar";
            this.bntFiltrar.Size = new System.Drawing.Size(98, 27);
            this.bntFiltrar.TabIndex = 10;
            this.bntFiltrar.Text = "Filtrar";
            this.bntFiltrar.UseVisualStyleBackColor = true;
            // 
            // Relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 387);
            this.Controls.Add(this.bntFiltrar);
            this.Controls.Add(this.cbFiltroTipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntExportar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Relatório";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.RelatorioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntExportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbFiltroTipo;
        private System.Windows.Forms.Button bntFiltrar;
    }
}