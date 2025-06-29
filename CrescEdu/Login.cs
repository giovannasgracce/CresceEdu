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

namespace CrescEdu
{
    public partial class Login : Form
    {
        bool senhaVisivel = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            DAO dao = new DAO();
            bool loginValido = dao.LoginUsuario(email, senha, out string tipoUsuario, out int idUsuario);

            if (loginValido)
            {
                if (tipoUsuario.ToLower() == "admin" || tipoUsuario.ToLower() == "administrador")
                {
                    TelaAdministrador tela = new TelaAdministrador();
                    tela.Show();
                }
                else if (tipoUsuario.ToLower() == "professor")
                {
                    TelaProfessor tela = new TelaProfessor(email); // ✅ Enviando o email do usuário logado
                    tela.Show();
                }
                else
                {
                    MessageBox.Show("Tipo de usuário desconhecido!");
                    return;
                }

                this.Hide(); // Esconde a tela de login após abrir a outra
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos!");
            }
        }

        private void picOlho_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                txtSenha.PasswordChar = '*';
                picOlho.Image = Properties.Resources.eye;  // Coloque aqui o nome correto da sua imagem do olho fechado
                senhaVisivel = false;
            }
            else
            {
                txtSenha.PasswordChar = '\0'; // Deixa o texto visível
                picOlho.Image = Properties.Resources.view; // Coloque aqui o nome correto da sua imagem do olho aberto
                senhaVisivel = true;
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
