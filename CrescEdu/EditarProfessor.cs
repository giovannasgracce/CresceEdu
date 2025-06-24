using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrescEdu
{
    public partial class EditarProfessor : Form
    {
        private DAO dao = new DAO();
        private int id;
        public EditarProfessor()
        {
            InitializeComponent();
        }

        public EditarProfessor(int id, string nome, string nomeSocial, string cpf, string email, string tipo)
        {
            InitializeComponent();

            this.id = id;

            textBox2.Text = nome;
            txtNomeSocial.Text = nomeSocial;
            txtCpf.Text = cpf;
            txtEmail.Text = email;
            cbTipo.SelectedItem = tipo;
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            // Pega os dados atualizados do formulário
            string nome = textBox2.Text.Trim();
            string nomeSocial = txtNomeSocial.Text.Trim();
            string cpf = txtCpf.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tipo = cbTipo.SelectedItem?.ToString().ToLower() ?? "";

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf)  || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            try
            {
                // Atualiza o professor no banco
                string query = @"UPDATE usuarios SET
                                 nome = @nome,
                                 nome_social = @nome_social,
                                 cpf = @cpf,
                    
                                 email = @email
                                 WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, dao.conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@nome_social", nomeSocial);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Professor atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi feita.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar professor: " + erro.Message);
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

