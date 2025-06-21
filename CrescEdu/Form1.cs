using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrescEdu;

namespace CrescEdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Cadastro cads = new Cadastro();
            cads.ShowDialog();
        }
        //NAO DELETAR ISSO
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
