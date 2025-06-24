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
    
    public partial class Cadastro : Form
    {
        bool senhaVisivel = false;
        public Cadastro()
        {
            InitializeComponent();

            var tipos = new List<KeyValuePair<string, string>>()
    {
        new KeyValuePair<string, string>("administrador", "Administrador"),
        new KeyValuePair<string, string>("professor", "Professor")
    };

            cbTipo.DataSource = tipos;
            cbTipo.ValueMember = "Key";
            cbTipo.DisplayMember = "Value";
            cbTipo.SelectedIndex = 0;

            // Esconde o campo Nome Social por padrão
            lblNomeSocial.Visible = false;
            txtNomeSocial.Visible = false;

            lblCodigoSecreto.Visible = false;
            txtCS.Visible = false;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = cbTipo.SelectedValue?.ToString() ?? "";

            if (tipoSelecionado == "professor" || tipoSelecionado == "administrador")
            {
                lblCodigoSecreto.Visible = true;
                txtCS.Visible = true;
            }
            else
            {
                lblCodigoSecreto.Visible = false;
                txtCS.Visible = false;
                txtCS.Text = "";
            }
        }


        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string nomeSocial = chkNomeSocial.Checked ? txtNomeSocial.Text.Trim() : "";
            string cpf = txtCpf.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string tipo = cbTipo.SelectedValue?.ToString().Trim().ToLower() ?? "";

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) ||
               string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            if ((tipo == "professor" || tipo == "administrador") && string.IsNullOrEmpty(txtCS.Text.Trim()))
            {
                MessageBox.Show("Digite o código secreto para este tipo de usuário.");
                return;
            }

            // Só para garantir que o tipo é um dos dois
            if (tipo != "professor" && tipo != "administrador")
            {
                MessageBox.Show("Tipo inválido.");
                return;
            }

            DAO dao = new DAO();
            // Validação de CPF
            if (!dao.ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido! Digite um CPF válido.");
                return;
            }

            

            // Validação de Email
            if (!dao.ValidarEmail(email))
            {
                MessageBox.Show("E-mail inválido! Informe um e-mail no formato correto (exemplo: nome@dominio.com).");
                return;
            }
            string resultado = dao.CadastrarUsuario(nome, nomeSocial, cpf, email, senha, tipo, txtCS.Text.Trim());

            MessageBox.Show(resultado);
            this.Close();
        }

        private void txtCS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCodigoSecreto_Click(object sender, EventArgs e)
        {

        }

        private void picOlho_Click(object sender, EventArgs e)
        {
           
            if (senhaVisivel)
                {
                    // Ocultar senha
                    txtSenha.PasswordChar = '*';
                    picOlho.Image = Properties.Resources.eye;  // Troque pelo nome correto da sua imagem
                    senhaVisivel = false;
                }
                else
                {
                    // Mostrar senha
                    txtSenha.PasswordChar = '\0';  // Deixa o texto visível
                    picOlho.Image = Properties.Resources.view;  // Troque pelo nome correto da sua imagem
                    senhaVisivel = true;
                }

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void chkNomeSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNomeSocial.Checked)
            {
                lblNomeSocial.Visible = true;
                txtNomeSocial.Visible = true;
            }
            else
            {
                lblNomeSocial.Visible = false;
                txtNomeSocial.Visible = false;
                txtNomeSocial.Text = "";
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
