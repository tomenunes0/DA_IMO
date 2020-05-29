using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Cliente clienteSelecionado;

        public DadosVenda(CasaVendavel casaVendavelSelecionada, masterEntities imobiliaria)
        {
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaVendavelSelecionada = casaVendavelSelecionada;

            arranque();
        }

        private void arranque()
        {
            //preencher as labels
            lblProprientario.Text = "Proprietário: " + casaVendavelSelecionada.Proprientario;
            lblValorBase.Text = "Valor Base: " + casaVendavelSelecionada.ValorBaseVenda + "€";
            lblComissaoBase.Text = "Comissão Base " + casaVendavelSelecionada.ValorComissao + "€";
            //Adicionar os clientes da base de dados na combo box
            cbComparador.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            cbComparador.Text = "";
            //verificar se a casa ja foi vendida ou nao 
            if (casaVendavelSelecionada.Venda != null)
            {
                lblDisponibilidade.Text = "Estado: Não Disponivel";
                dtpDataVenda.Value = casaVendavelSelecionada.Venda.DataVenda;
                txtValorNegociado.Text = casaVendavelSelecionada.Venda.ValorNegociado.ToString();
                txtValorDaComissao.Text = casaVendavelSelecionada.Venda.ComissaoNegocio.ToString();
                cbComparador.Text = casaVendavelSelecionada.Venda.Comprador.ToString();
                gbEfetuarVenda.Enabled = false;
                MessageBox.Show("Casa ja foi vendida", "Venda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                lblDisponibilidade.Text = "Estado: Disponivel";
        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificacoes() == true)
                {
                    if (clienteSelecionado != null)
                    {
                        Venda vendaTemp = new Venda();
                        //casaVendavelSelecionada.Venda = null;
                        vendaTemp.DataVenda = dtpDataVenda.Value;
                        vendaTemp.ValorNegociado = Convert.ToDecimal(txtValorNegociado.Text);
                        vendaTemp.ComissaoNegocio = Convert.ToDecimal(txtValorDaComissao.Text);
                        vendaTemp.CasaVendavel = casaVendavelSelecionada;
                        casaVendavelSelecionada.Proprientario = clienteSelecionado;
                        clienteSelecionado.Aquisicoes.Add(vendaTemp);
                        imobiliaria.SaveChanges();
                        MessageBox.Show("Acabou de Comprar esta casa Obrigado pela Compra!", "Comprar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbEfetuarVenda.Enabled = false;
                        lblDisponibilidade.Text = "Estado: Não Disponivel";
                    }

                }
                else
                    MessageBox.Show("Porfavor verifique os campos de entrada e tente novamente", "Compra de Casa?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                MessageBox.Show("Casa ja foi vendida", "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cbComparador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Marcar o cliente selecionado para null
                clienteSelecionado = null;
                //Carregar o cliente selecionado da text box para a variavel
                clienteSelecionado = (Cliente)cbComparador.SelectedItem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool verificacoes()
        {
            bool state = true;
            if (txtValorNegociado.Text == string.Empty)
                state = false;
            else if (txtValorDaComissao.Text == string.Empty)
                state = false;
            return state;
        }

        private void txtValorNegociado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se a key precionada eh um numero ou nao
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void txtValorDaComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se a key precionada eh um numero ou nao
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }
    }
}
