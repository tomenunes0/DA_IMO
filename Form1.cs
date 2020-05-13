using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Form1 : Form
    {
        //Assim que o programa inicia
        public Form1()
        {
            //Inicia os componentes iniciais do form 
            InitializeComponent();
        }

        //Quando o form 1 carrega esta funcao ira ser executada!!
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Timer para atualizar a data e hora do form 1 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atualiza o dia da label
            lblDay.Text = DateTime.Now.ToString("dd");
            //Atualiza o mes da label
            lblMouth.Text = DateTime.Now.ToString("y");
            //Atualiza os segundos da label 
            lblSeconds.Text = DateTime.Now.ToString("sss");
            //Atualiza os minutes da label 
            lblMinutes.Text = DateTime.Now.ToString("mmm");
            //Atualiza as horas da label
            lblHours.Text = DateTime.Now.ToString("HHH");
        }

        //Quando o butao de gerir cliente eh percionado
        private void pbGerirClientes_Click(object sender, EventArgs e)
        {
            //Perpara o Form 2 para ser executado
            Form2 frm = new Form2();
            //Mostra o Form2 
            frm.Show();
            //Esconde o form 1 para este nao ser mostrado
            this.Hide();
        }

        //Funcao so eh executada quando o form estiver para ser fechado 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
