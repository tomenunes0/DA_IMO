using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Quando o butao de gerir cliente eh percionado
        private void pbGerirClientes_Click(object sender, EventArgs e)
        {
            //Perpara o Form 3 para ser executado
            GerirClientes frm = new GerirClientes();
            //Mostra o GerirCasas 
            frm.Show();
            //Esconde o form 1 para este nao ser mostrado
            this.Hide();
        }

        //Quando o butao de gerir casa eh percionado
        private void pbGerirCasas_Click(object sender, EventArgs e)
        {
            //Perpara o Form 2 para ser executado
            GerirCasas frm = new GerirCasas();
            //Mostra o GerirClientes 
            frm.Show();
            //Esconde o GerirClientes para este nao ser mostrado
            this.Hide();
        }

        //Timer para atualizar a data e hora do form 1 
        private void timer_Tick(object sender, EventArgs e)
        {
            //Atualiza o dia da label
            lblDay.Text = DateTime.Now.ToString("dd");
            //Atualiza o mes da label
            lblMouth.Text = DateTime.Now.ToString("yyy");
            //Atualiza os segundos da label 
            lblSeconds.Text = DateTime.Now.ToString("sss");
            //Atualiza os minutes da label 
            lblMinutes.Text = DateTime.Now.ToString("mmm");
            //Atualiza as horas da label
            lblHours.Text = DateTime.Now.ToString("HHH");
        }

        //Funcao so eh executada quando o form estiver para ser fechado
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dialogo de messagem para perguntar se o deseja mesmo fechar o programa ou nao 
            DialogResult result = MessageBox.Show("Deseja fechar o projeto?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Verifica qual foi a opecao escolhida e se for a opcao nao este ira entrar no if 
            if (result == DialogResult.No)
            {
                //ira cancelar a operacao 
                e.Cancel = true;
            }
            else
            {
                //Forcar o programa a fechar
                Environment.Exit(0);
            }
        }
    }
}
