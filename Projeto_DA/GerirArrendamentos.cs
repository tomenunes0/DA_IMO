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
        private CasaArrendavel casaArrendavelSelecionada;
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
            this.casaArrendavelSelecionada = casaArrendavelSelecionada;
            cbArrendatario.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            lblProprietario.Text = "Proprietario: " + casaArrendavelSelecionada.Proprientario;
            lblIdCasa.Text = "Id: " + casaArrendavelSelecionada.IdCasa;
            lblLocalidade.Text = "Localidade" + casaArrendavelSelecionada.Localidade;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void cbArrendatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Marcar o cliente selecionado para null
            clienteSelecionado = null;
            //Carregar o cliente selecionado da text box para a variavel
            clienteSelecionado = (Cliente)cbArrendatario.SelectedItem;
        }
    }
}
