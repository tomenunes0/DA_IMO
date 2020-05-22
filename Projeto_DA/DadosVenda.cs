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
    public partial class DadosVenda : Form
    {
        //perparar o container para a base de dados
        private masterEntities imobiliaria;
        //Perparar a variaver para a casa selecionada
        private Casa casaSelecionada;
        //Perparar a variavel para a limpeza selecionada
        private Limpeza limpezaSelecionada;
        //Perparar a variavel para o servico selecionado
        private Servico servicoSelecionado;

        public DadosVenda(Casa casaSelecionada, string arrenvendavel, masterEntities imobiliaria)
        {
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaSelecionada = casaSelecionada;
            lblProprientario.Text =  "Proprietário: " + casaSelecionada.Proprientario;
        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {

        }
    }
}
