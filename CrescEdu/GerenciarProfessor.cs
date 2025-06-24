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

namespace CrescEdu
{
    public partial class GerenciarProfessor : Form
    {
        
        private DAO dao = new DAO();

        public GerenciarProfessor()
        {
            InitializeComponent();
        }

        private void GerenciarProfessor_Load(object sender, EventArgs e)
        {
            AtualizarListaProfessores();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();

            AtualizarListaProfessores();
        }

        private void AtualizarListaProfessores()
        {
            try
            {
                string query = "SELECT id, nome, nome_social, cpf, email, status FROM usuarios WHERE tipo = 'professor'";
                MySqlCommand cmd = new MySqlCommand(query, dao.conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dvgProfessores.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar lista: " + erro.Message);
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if(dvgProfessores.SelectedRows.Count > 0)
    {
                int id = Convert.ToInt32(dvgProfessores.SelectedRows[0].Cells["id"].Value);
                string nome = dvgProfessores.SelectedRows[0].Cells["nome"].Value.ToString();
                string nomeSocial = dvgProfessores.SelectedRows[0].Cells["nome_social"].Value.ToString();
                string cpf = dvgProfessores.SelectedRows[0].Cells["cpf"].Value.ToString();
                string email = dvgProfessores.SelectedRows[0].Cells["email"].Value.ToString();
                string tipo = "professor";

                EditarProfessor editar = new EditarProfessor(id, nome, nomeSocial, cpf, email, tipo);
                editar.ShowDialog();

                AtualizarListaProfessores();
            }
            else
            {
                MessageBox.Show("Selecione um professor para editar.");
            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (dvgProfessores.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dvgProfessores.SelectedRows[0].Cells["id"].Value);

                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja desativar este professor?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        string query = "UPDATE usuarios SET status = 'inativo' WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, dao.conexao); // Aqui usa dao.conexao
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Professor desativado com sucesso!");
                        AtualizarListaProfessores();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao desativar: " + erro.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um professor para desativar.");
            }
        }

        private void dvgProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
