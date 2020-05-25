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
    public partial class GerirArrendamentos : Form
    {
        //perparar o container para a base de dados
        private masterEntities imobiliaria;
        //Perparar a variaver para a casa selecionada
        private CasaVendavel casaVendavelSelecionada;
        //Perparar a variavel para a limpeza selecionada
        private Limpeza limpezaSelecionada;
        //Perparar a variavel para o servico selecionado
        private Servico servicoSelecionado;
        private Cliente clienteSelecionado;
        public GerirArrendamentos(CasaArrendavel casaArrendavelSelecionada, masterEntities imobiliaria)
        {        
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaVendavelSelecionada = casaVendavelSelecionada;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
