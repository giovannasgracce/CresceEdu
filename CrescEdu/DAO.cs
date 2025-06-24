using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mysqlx.Crud;
using System.Data;

namespace CrescEdu
{
    class DAO
    {
        public MySqlConnection conexao;
        public int i;
        public int contador;

        // Alterados para listas dinâmicas
        public List<int> idUsuario = new List<int>();
        public List<string> nomeUsuario = new List<string>();
        public List<string> nomeSocialUsuario = new List<string>();
        public List<string> cpfUsuario = new List<string>();
        public List<string> emailUsuario = new List<string>();
        public List<string> tipoUsuario = new List<string>();
        public List<string> statusUsuario = new List<string>();
        public List<DateTime> criadoEmUsuario = new List<DateTime>();


        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=CrescEdu;Uid=root;password=");
            try
            {
                conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + erro.Message);
            }
        }

        // MÉTODO CADASTRAR USUÁRIO
        public string CadastrarUsuario(string nome, string nomeSocial, string cpf, string email, string senha, string tipo, string codigoSecreto)
        {
            const string codigoSecretoProfessor = "PROF123";
            const string codigoSecretoAdmin = "ADMIN123";

            if (tipo.ToLower() == "professor" && codigoSecreto != codigoSecretoProfessor)
                return "Código secreto incorreto para cadastro de professor.";

            if (tipo.ToLower() == "administrador" && codigoSecreto != codigoSecretoAdmin)
                return "Código secreto incorreto para cadastro de administrador.";


            try
            {
                string query = @"INSERT INTO usuarios 
                        (nome, nome_social, cpf, email, senha, tipo, status, criado_em)
                        VALUES 
                        (@nome, @nome_social, @cpf, @email, @senha, @tipo, 'ativo', NOW())";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@nome_social", nomeSocial);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                int resultado = cmd.ExecuteNonQuery();
                MessageBox.Show("Tipo recebido no DAO: " + tipo);  // mostra antes de retornar
                return resultado + " Usuário cadastrado com sucesso!";

            }
            catch (MySqlException erro)
            {
                return "Erro ao cadastrar: " + erro.Message;
            }
        }




        // MÉTODO LOGIN USUÁRIO
        public bool LoginUsuario(string email, string senha, out string tipoUsuario, out int idUsuario)
        {
            tipoUsuario = "";
            idUsuario = -1;

            try
            {
                string query = "SELECT id, tipo FROM usuarios WHERE email = @email AND senha = @senha AND status = 'ativo'";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    idUsuario = Convert.ToInt32(leitura["id"]);
                    tipoUsuario = leitura["tipo"].ToString();
                    leitura.Close();
                    return true;
                }

                leitura.Close();
                return false;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao fazer login: " + erro.Message);
                return false;
            }
        }


        // MÉTODO PRA LISTAR USUÁRIOS (Futuramente na tela do administrador)
        public void PreencherVetorUsuarios()
        {
            string query = "SELECT * FROM usuarios";

            // Limpa as listas pra evitar duplicação
            idUsuario.Clear();
            nomeUsuario.Clear();
            nomeSocialUsuario.Clear();
            cpfUsuario.Clear();
            emailUsuario.Clear();
            tipoUsuario.Clear();
            statusUsuario.Clear();
            criadoEmUsuario.Clear();

            MySqlCommand cmd = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = cmd.ExecuteReader();

            contador = 0;

            while (leitura.Read())
            {
                idUsuario.Add(Convert.ToInt32(leitura["id"]));
                nomeUsuario.Add(leitura["nome"].ToString());
                nomeSocialUsuario.Add(leitura["nome_social"]?.ToString() ?? "");
                cpfUsuario.Add(leitura["cpf"]?.ToString() ?? "");
                emailUsuario.Add(leitura["email"].ToString());
                tipoUsuario.Add(leitura["tipo"].ToString());
                statusUsuario.Add(leitura["status"].ToString());
                criadoEmUsuario.Add(Convert.ToDateTime(leitura["criado_em"]));

                contador++;
            }

            leitura.Close();
        }


        public int QuantidadeDeUsuarios()
        {
            return contador;
        }

        public bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            // Invalidos conhecidos
            string[] cpfsInvalidos = new string[]
            {
        "00000000000", "11111111111", "22222222222", "33333333333",
        "44444444444", "55555555555", "66666666666", "77777777777",
        "88888888888", "99999999999"
            };

            if (cpfsInvalidos.Contains(cpf))
                return false;

            // Validação dos dígitos
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }


        public bool ValidarEmail(string email)
        {
            try
            {
                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public DataTable ListarUsuariosPorTipo(string tipo)
        {
            DataTable tabela = new DataTable();

            try
            {
                string query;

                if (tipo == "todos")
                {
                    query = "SELECT id, nome, nome_social, cpf, email, tipo, status, criado_em FROM usuarios";
                }
                else
                {
                    query = "SELECT id, nome, nome_social, cpf, email, tipo, status, criado_em FROM usuarios WHERE tipo = @tipo";
                }

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                if (tipo != "todos")
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                }

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar usuários: " + ex.Message);
            }

            return tabela;
        }


    }
}
