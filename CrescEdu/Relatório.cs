using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.IO;



namespace CrescEdu
{
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void bntExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "Arquivo CSV (*.csv)|*.csv";
                salvar.Title = "Salvar Relatório de Usuários";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();

                    // Cabeçalhos
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        csv.Append(dataGridView1.Columns[i].HeaderText + ";");
                    }
                    csv.AppendLine();

                    // Dados
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                csv.Append(row.Cells[i].Value?.ToString() + ";");
                            }
                            csv.AppendLine();
                        }
                    }

                    File.WriteAllText(salvar.FileName, csv.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exportado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar: " + ex.Message);
            }
        
        }

        private void CarregarUsuarios(string tipoFiltro)
        {
            DAO dao = new DAO();
            dataGridView1.DataSource = dao.ListarUsuariosPorTipo(tipoFiltro);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string tipoSelecionado = cbFiltroTipo.SelectedItem.ToString().ToLower();
            CarregarUsuarios(tipoSelecionado);
        }

        private void RelatorioUsuarios_Load(object sender, EventArgs e)
        {
            cbFiltroTipo.Items.Add("todos");
            cbFiltroTipo.Items.Add("professor");
            cbFiltroTipo.Items.Add("administrador");
            cbFiltroTipo.SelectedIndex = 0;

            CarregarUsuarios("todos");

        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
