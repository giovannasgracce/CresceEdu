using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CrescEdu
{
    public partial class ChatListForm : Form
    {
        DAO dao;
        string usuarioAtual; // Email do usuário logado

        // 🔗 Construtor recebendo quem está logado
        public ChatListForm(string emailUsuario)
        {
            InitializeComponent();
            dao = new DAO();
            usuarioAtual = emailUsuario;
        }

        // 🏁 Carregar contatos quando abrir a tela
        private void ChatListForm_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        // 🔄 Atualizar lista de contatos
        private void CarregarContatos()
        {
            listBoxContatos.Items.Clear();
            List<string> contatos = dao.ListarContatos(usuarioAtual);

            foreach (var contato in contatos)
            {
                listBoxContatos.Items.Add(contato);
            }
        }

        // 🔍 Pesquisar contatos na lista
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.ToLower();
            listBoxContatos.Items.Clear();

            List<string> contatos = dao.ListarContatos(usuarioAtual);
            var filtrados = contatos.Where(c => c.ToLower().Contains(termo)).ToList();

            foreach (var contato in filtrados)
            {
                listBoxContatos.Items.Add(contato);
            }
        }

        // ➕ Abrir Nova Conversa
        private void btnNovaConversa_Click(object sender, EventArgs e)
        {
            NovaConversaForm novaConversa = new NovaConversaForm(usuarioAtual);
            novaConversa.ShowDialog();
            CarregarContatos(); // Atualiza lista depois de abrir a nova conversa
        }

        // 📩 Abrir chat ao clicar duas vezes no contato
        private void listBoxContatos_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedItem != null)
            {
                ChatForm chat = new ChatForm(usuarioAtual, contato);
                chat.ShowDialog();
            }
        }

        // Evento que não faz nada (pode até remover se quiser)
        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Não precisa de código aqui, mas pode colocar se quiser fazer algo ao selecionar.
        }

        // Evento do campo pesquisar se quiser usar ao digitar
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // Opcional: se quiser pesquisar em tempo real enquanto digita
        }
    }
}
