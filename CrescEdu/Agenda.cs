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

            // Inicializar listaPanels e gerar calendário no load
            listaPanels = new List<Panel>()
            {
                panel1, panel2, panel3, panel4, panel5, panel6, panel7,
                panel8, panel9, panel10, panel11, panel12, panel13, panel14,
                panel15, panel16, panel17, panel18, panel19, panel20, panel21,
                panel22, panel23, panel24, panel25, panel26, panel27, panel28,
                panel29, panel30, panel31, panel32, panel33, panel34, panel35,
                panel36, panel37, panel38, panel39, panel40, panel41, panel42
            };

            GerarCalendario(mesAtual);
        }

        // Função para gerar calendário
        void GerarCalendario(DateTime mes)
        {
            DateTime primeiroDia = new DateTime(mes.Year, mes.Month, 1);
            int diasNoMes = DateTime.DaysInMonth(mes.Year, mes.Month);
            int diaSemana = (int)primeiroDia.DayOfWeek;

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

                Label lbl = new Label();
                lbl.Text = dia.ToString();
                lbl.Dock = DockStyle.Top;
                lbl.TextAlign = ContentAlignment.TopLeft;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                panelDia.Controls.Add(lbl);

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
                    panelDia.Controls.Add(lblComp);
                }

                int diaClicado = dia;
                panelDia.Click += (s, e) =>
                {
                    MessageBox.Show($"Dia {diaClicado}/{mes.Month}/{mes.Year}");
                    // Depois aqui vai a Modal
                };

                dia++;
            }
        }

        // Botões Navegação e Sair
        private void btnMesProximo_Click(object sender, EventArgs e)
        {
            mesAtual = mesAtual.AddMonths(1);
            GerarCalendario(mesAtual);
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            mesAtual = mesAtual.AddMonths(-1);
            GerarCalendario(mesAtual);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos que você já tinha no formulário (vazios, pode manter ou remover)
        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
