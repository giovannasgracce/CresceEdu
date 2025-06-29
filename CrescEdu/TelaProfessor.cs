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
    public partial class TelaProfessor : Form
    {
        private string usuarioAtual;

        // Construtor que recebe o email do usuário logado
        public TelaProfessor(string usuarioLogado)
        {
            InitializeComponent();
            this.usuarioAtual = usuarioLogado;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAgenda_Click(object sender, EventArgs e)
        {
            Agenda Ag = new Agenda();
            Ag.ShowDialog();
        }

        private void bntAbrirChat_Click(object sender, EventArgs e)
        {
            // Passa o email do usuário atual para abrir o chat
            ChatListForm chatList = new ChatListForm(usuarioAtual);
            chatList.ShowDialog();
        }
    }

}
