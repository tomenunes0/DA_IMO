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
        private CasaVendavel casaVendavelSelecionada;
        //Perparar a variavel para a limpeza selecionada
        private Limpeza limpezaSelecionada;
        //Perparar a variavel para o servico selecionado
        private Servico servicoSelecionado;
        private Cliente clienteSelecionado;

        public DadosVenda(CasaVendavel casaVendavelSelecionada, masterEntities imobiliaria)
        {
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaVendavelSelecionada = casaVendavelSelecionada;
            lblProprientario.Text = "Proprietário: " + casaVendavelSelecionada.Proprientario;
            /* if (casaVendavelSelecionada.Venda.Comprador.Casas.Count() == 0)
                 lblDisponibilidade.Text = "Estado: Disponivel";
             else
                 lblDisponibilidade.Text = "Estado: Não Disponivel";*/
            lblValorBase.Text = " Valor Base: " + casaVendavelSelecionada.ValorBaseVenda + "€";
            lblComissaoBase.Text = "Comissão Base " + casaVendavelSelecionada.ValorComissao + "€";
            //Adicionar os clientes da base de dados na combo box
            cbComparador.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            cbComparador.Text = "";
        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {
            Venda vendaTemp = new Venda();
            vendaTemp.DataVenda = dtpDataVenda.Value;
            vendaTemp.ValorNegociado = Convert.ToDecimal(txtValorNegociado.Text);
            vendaTemp.ComissaoNegocio = Convert.ToDecimal(txtValorDaComissao.Text);
            clienteSelecionado.Aquisicoes.Add(vendaTemp);
            imobiliaria.SaveChanges();
        }

        private void cbComparador_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Marcar o cliente selecionado para null
            clienteSelecionado = null;
            //Carregar o cliente selecionado da text box para a variavel
            clienteSelecionado = (Cliente)cbComparador.SelectedItem;
        }
    }
}
