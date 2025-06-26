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
    public partial class Agenda : Form
    {
        // Variáveis globais no topo da classe
        DateTime mesAtual = DateTime.Now;
        List<Panel> listaPanels;
        DAO dao = new DAO();
        string turmaUsuario = "3A"; // depois pode puxar do login
        string tipoUsuario = "professor"; // ou "aluno"

        public Agenda()
        {
            InitializeComponent();
            CriarPanelsCalendario(); 
            GerarCalendario(mesAtual);
        }

        private void CriarPanelsCalendario()
        {
            listaPanels = new List<Panel>();
            panelCalendario.Controls.Clear(); // Limpa antes de gerar

            int linhas = 6;
            int colunas = 7;
            int largura = panelCalendario.Width / colunas;
            int altura = panelCalendario.Height / linhas;

            for (int linha = 0; linha < linhas; linha++)
            {
                for (int coluna = 0; coluna < colunas; coluna++)
                {
                    Panel p = new Panel();
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.Width = largura;
                    p.Height = altura;
                    p.Left = coluna * largura;
                    p.Top = linha * altura;
                    p.BackColor = Color.White;

                    panelCalendario.Controls.Add(p);
                    listaPanels.Add(p);
                }
            }
        }

        void GerarCalendario(DateTime mes)
        {
            DateTime primeiroDia = new DateTime(mes.Year, mes.Month, 1);
            int diasNoMes = DateTime.DaysInMonth(mes.Year, mes.Month);
            int diaSemana = ((int)primeiroDia.DayOfWeek + 6) % 7;

            label1.Text = mes.ToString("MMMM yyyy");

            foreach (var panel in listaPanels)
            {
                panel.Controls.Clear();
                panel.BackColor = Color.White;
            }

            DataTable compromissos = dao.BuscarCompromissosPorMes(mes.Year, mes.Month, turmaUsuario, tipoUsuario);

            int dia = 1;
            for (int i = diaSemana; dia <= diasNoMes; i++)
            {
                Panel panelDia = listaPanels[i];

                // 🔸 Label do número do dia
                Label lblDia = new Label();
                lblDia.Text = dia.ToString();
                lblDia.Dock = DockStyle.Top;
                lblDia.TextAlign = ContentAlignment.TopLeft;
                lblDia.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblDia.ForeColor = Color.Black;

                panelDia.Controls.Add(lblDia);

                
                int diaClicado = dia;

                var compromissosDoDia = compromissos.AsEnumerable()
                    .Where(row => Convert.ToDateTime(row["data"]).Day == dia);

                foreach (var item in compromissosDoDia)
                {
                    Label lblComp = new Label();
                    lblComp.Text = "- " + item["titulo"].ToString();
                    lblComp.AutoSize = false;
                    lblComp.Height = 15;
                    lblComp.Dock = DockStyle.Top;
                    lblComp.ForeColor = Color.Blue;

                    lblComp.Click += (s, e) =>
                    {
                        ModalAgenda modal = new ModalAgenda();
                        modal.DataSelecionada = new DateTime(mes.Year, mes.Month, diaClicado);
                        modal.TituloSelecionado = item["titulo"].ToString();
                        modal.Turma = turmaUsuario;
                        modal.Tipo = tipoUsuario;
                        modal.ModoEdicao = true;

                        // Preenche os dados do compromisso
                        modal.txtTitulo.Text = item["titulo"].ToString();
                        modal.txtDescricao.Text = item["descricao"].ToString();
                        modal.cbPrioridade.SelectedItem = item["prioridade"].ToString();

                        modal.ShowDialog();
                        GerarCalendario(mesAtual);
                    };

                    panelDia.Controls.Add(lblComp);
                }

                // 🔸 Clique no quadrado vazio (criar novo compromisso)
                panelDia.Click += (s, e) =>
                {
                    ModalAgenda modal = new ModalAgenda();
                    modal.DataSelecionada = new DateTime(mes.Year, mes.Month, diaClicado);
                    modal.Turma = turmaUsuario;
                    modal.Tipo = tipoUsuario;
                    modal.ModoEdicao = false; // Novo compromisso

                    modal.ShowDialog();
                    GerarCalendario(mesAtual);
                };

                dia++;
            }
        }

        // Botões Navegação e Sair
        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMesAnterior_Click_1(object sender, EventArgs e)
        {
            mesAtual = mesAtual.AddMonths(-1);
            GerarCalendario(mesAtual);
        }

        private void btnMesProximo_Click_1(object sender, EventArgs e)
        {
            mesAtual = mesAtual.AddMonths(1);
            GerarCalendario(mesAtual);
        }

        // Métodos que você já tinha no formulário (vazios, pode manter ou remover)
        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
       
       
    }
}
