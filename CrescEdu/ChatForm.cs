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
    public partial class ChatForm : Form
    {
        DAO dao = new DAO();
        string usuarioAtual;
        string contato;

        public ChatForm(string usuarioAtual, string contato)
        {
            InitializeComponent();
            this.usuarioAtual = usuarioAtual;
            this.contato = contato;
            lblContato.Text = $"Conversando com: {contato}";
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            CarregarMensagens();
        }

        private void CarregarMensagens()
        {
            listBoxMensagens.Items.Clear();
            DataTable mensagens = dao.BuscarMensagens(usuarioAtual, contato);

            foreach (DataRow linha in mensagens.Rows)
            {
                string remetente = linha["remetente"].ToString();
                string texto = linha["mensagem"].ToString();
                string hora = Convert.ToDateTime(linha["dataHora"]).ToString("dd/MM/yyyy HH:mm");

                string msg = $"{remetente} [{hora}]: {texto}";
                listBoxMensagens.Items.Add(msg);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensagem = txtMensagem.Text.Trim();

            if (!string.IsNullOrEmpty(mensagem))
            {
                dao.EnviarMensagem(usuarioAtual, contato, mensagem);
                txtMensagem.Clear();
                CarregarMensagens();
            }
            else
            {
                MessageBox.Show("Digite uma mensagem antes de enviar.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }
    }
}
