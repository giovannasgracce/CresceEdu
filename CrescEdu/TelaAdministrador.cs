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
    public partial class TelaAdministrador : Form
    {
        public TelaAdministrador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntGerenciar_Click(object sender, EventArgs e)
        {
            GerenciarProfessor Gr = new GerenciarProfessor();
            Gr.ShowDialog();
        }

        private void bntRelatorio_Click(object sender, EventArgs e)
        {
            Relatório re = new Relatório();
            re.ShowDialog();
        }
    }
}
