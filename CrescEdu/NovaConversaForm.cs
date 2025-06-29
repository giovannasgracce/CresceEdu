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
    public partial class NovaConversaForm : Form
    {
        private DAO dao;
        private string usuarioAtual;

        public string UsuarioSelecionado { get; private set; }

        public NovaConversaForm(string usuarioAtual)
        {
            InitializeComponent();
            dao = new DAO();
            this.usuarioAtual = usuarioAtual;
            CarregarUsuarios();
        }


        private void CarregarUsuarios()
        {
            listBoxUsuarios.Items.Clear();
            var usuarios = dao.ListarTodosUsuarios(usuarioAtual);
            foreach (var u in usuarios)
                listBoxUsuarios.Items.Add(u);
        }

        private void NovaConversaForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.ToLower();
            listBoxUsuarios.Items.Clear();

            var usuarios = dao.ListarTodosUsuarios(usuarioAtual);
            var filtrados = usuarios.Where(u => u.ToLower().Contains(termo));

            foreach (var u in filtrados)
                listBoxUsuarios.Items.Add(u);
        }

        private void btnIniciarConversa_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                UsuarioSelecionado = listBoxUsuarios.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK; // Fecha modal retornando OK
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para iniciar a conversa.");
            }
        }
    }
}
