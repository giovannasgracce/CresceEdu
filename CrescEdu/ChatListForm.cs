using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrescEdu
{
    public partial class ChatListForm : Form
    {
        DAO dao = new DAO();
        string usuarioAtual;

        public ChatListForm(string emailUsuario)
        {
            InitializeComponent();
            usuarioAtual = emailUsuario;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void ChatListForm_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            listBoxConversas.Items.Clear();
            List<string> contatos = dao.ListarContatos(usuarioAtual);

            foreach (var contato in contatos)
            {
                listBoxConversas.Items.Add(contato);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.ToLower();
            listBoxConversas.Items.Clear();

            List<string> contatos = dao.ListarContatos(usuarioAtual);
            var filtrados = contatos.Where(c => c.ToLower().Contains(termo)).ToList();

            foreach (var contato in filtrados)
            {
                listBoxConversas.Items.Add(contato);
            }
        }

        private void btnNovaConversa_Click(object sender, EventArgs e)
        {
            NovaConversaForm novaConversa = new NovaConversaForm(usuarioAtual);

            if (novaConversa.ShowDialog() == DialogResult.OK)
            {
                string contato = novaConversa.UsuarioSelecionado;
                ChatForm chat = new ChatForm(usuarioAtual, contato);
                chat.ShowDialog();
                CarregarContatos(); // 🔥 Atualiza a lista com a nova conversa
            }
        }


        private void listBoxConversas_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxConversas.SelectedItem != null)
            {
                string contato = listBoxConversas.SelectedItem.ToString();
                ChatForm chat = new ChatForm(usuarioAtual, contato);
                chat.ShowDialog();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
