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
    public partial class ModalAgenda : Form
    {
        DAO dao = new DAO();

        // Variáveis públicas para controle
        public bool ModoEdicao = false;
        public DateTime DataSelecionada;
        public string TituloSelecionado = "";
        public string Turma;
        public string Tipo;

        public ModalAgenda()
        {
            InitializeComponent();
        }

        private void ModalAgenda_Load(object sender, EventArgs e)
        {
            cbPrioridade.Items.AddRange(new string[] { "Alta", "Média", "Baixa" });
            cbPrioridade.SelectedIndex = 1;

            txtTurma.Text = Turma;
            txtTipo.Text = Tipo;

            txtTurma.ReadOnly = true;
            txtTipo.ReadOnly = true;

            if (ModoEdicao)
            {
                bntExcluir.Visible = true;

                txtTitulo.Text = TituloSelecionado;

                DataTable dt = dao.BuscarCompromisso(DataSelecionada, TituloSelecionado, Turma, Tipo);
                if (dt.Rows.Count > 0)
                {
                    txtDescricao.Text = dt.Rows[0]["descricao"].ToString();
                    string prioridade = dt.Rows[0]["prioridade"].ToString();
                    cbPrioridade.SelectedItem = prioridade;
                }
            }
            else
            {
                bntExcluir.Visible = false;
            }
        }



        private void bntSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string descricao = txtDescricao.Text.Trim();
            string prioridade = cbPrioridade.SelectedItem?.ToString() ?? "Média";

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Preencha o título.");
                return;
            }

            string resultado;

            if (ModoEdicao)
            {
                resultado = dao.AtualizarCompromisso(DataSelecionada, TituloSelecionado, titulo, descricao, prioridade, Tipo, Turma);
            }
            else
            {
                resultado = dao.CadastrarCompromisso(DataSelecionada, titulo, descricao, prioridade, Tipo, Turma);
            }

            MessageBox.Show(resultado);
            this.Close();
        }


        private void bntExcluir_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Deseja excluir este compromisso?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                string resultado = dao.ExcluirCompromisso(DataSelecionada, TituloSelecionado, Turma, Tipo);
                MessageBox.Show(resultado);
                this.Close();
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
