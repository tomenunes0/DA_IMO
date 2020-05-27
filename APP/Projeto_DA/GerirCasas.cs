using Projeto_DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Home
{
    public partial class GerirCasas : Form
    {
        //perparar o container para a base de dados
        private masterEntities imobiliaria;
        //Perparar a class cliente para guardar o cliente selecionado
        private Cliente clienteSelecionado;
        //Perparar a classe casa para guardar o casa selecionado
        public static Casa casaSelecionada;
        //Classe da casas vendavel para guardar a casa selecionada
        public static CasaVendavel casaVendavelSelecionada;
        public static CasaArrendavel casaArrendavelSelecionada;
        //Variavel se eh vendavel ou nao
        public static string arrenvendavel;
        //Novo cliente
        private bool novo = false;

        public GerirCasas()
        {
            //Inicia os componentes de gerir as casas 
            InitializeComponent();
            //Atualizar a lista dos clientes sem nenhuma excecao
            atualizarListaCasas();
            //Meter o cliente selecionado a null
            clienteSelecionado = null;
            //Adicionar os clientes da base de dados na combo box
            cb_Clientes.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            //verificar se existe alguma casa na base de dados
            if (imobiliaria.Casas.Local.Count() == 0)
                limpar_Campos();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Chamar a funcao para filtrar as casas pelas localidades 
            filter_Localidade();
        }

        //Quando o form for fechado
        private void GerirCasas_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Perparar para abrir o form 1 
            //GerirLimpezas gerirLimpezas = new GerirLimpezas();
            this.Hide();
            Home home = new Home();
            //Mostar o form 1
            home.ShowDialog();
            //gerirLimpezas.Hide();
            //Fechar o form 
            this.Close();
        }

        //Fazer o butao guardar mais gostoso
        private void timer_Tick(object sender, EventArgs e)
        {
            if (chkArrendavel.Checked == true)
            {
                gbDadosVenda.Enabled = false;
                arrenvendavel = chkArrendavel.Text;
            }
            else
                gbDadosVenda.Enabled = true;

            if (chkVendavel.Checked == true)
            {
                gbDadosArrendamento.Enabled = false;
                arrenvendavel = chkVendavel.Text;
            }
            else
                gbDadosArrendamento.Enabled = true;

            if (novo == false)
            {
                btnNovo.Enabled = false;
                if (verificacoes() == true)
                {
                    btnGuardar.Enabled = true;
                }
                else
                    btnGuardar.Enabled = false;
            }
            else
            {
                btnNovo.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        //Atualizar a data grid view sem excesoes
        private void atualizarListaCasas()
        {
            //Marca a imobiliaria como novo container da base de dados 
            imobiliaria = new masterEntities();
            //Seleciona o conteudo da base de dados e organiza - o por nome 
            (from casa in imobiliaria.Casas orderby casa.Localidade select casa).Load();
            //Carrega a informaçao que foi pedida na linha anterior para a listbox que foi gerada
            casaBindingSource.DataSource = imobiliaria.Casas.Local.ToBindingList();
        }

        //butao novo for precionado
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Chamar a Funcao para adicionar a nova casa
            nova_Casa();

        }
        //Cirar nova casa
        private void nova_Casa()
        {
            if (chkVendavel.Checked == true)
            {
                CasaVendavel casaVendavelTemp = new CasaVendavel();
                //Meter os dados da casa para a class para poder assim adicionar
                casaVendavelTemp.Rua = txtRua.Text;
                casaVendavelTemp.Localidade = txtLocalidade.Text;
                casaVendavelTemp.Numero = txtNumero.Text;
                casaVendavelTemp.Andar = txtAndar.Text;
                casaVendavelTemp.Area = Convert.ToInt32(nudArea.Value);
                casaVendavelTemp.NumeroAssoalhada = Convert.ToInt32(nudAssoalhadas.Value);
                casaVendavelTemp.NumeroWC = Convert.ToInt32(nudWC.Value);
                casaVendavelTemp.NumerosPisos = Convert.ToInt32(nudPisos.Value);
                casaVendavelTemp.Tipo = cbTipoDeMoradia.Text;
                casaVendavelTemp.ValorBaseVenda = Convert.ToDecimal(txtValorBaseNegociavel.Text);
                casaVendavelTemp.ValorComissao = Convert.ToDecimal(txtComissaoBase.Text);

                //Guarda a casa no cliente selecionado na combo box
                clienteSelecionado.Casas.Add(casaVendavelTemp);
                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                //Chamar a funcao atualizar a lista
                atualizarListaCasas();
            }
            else if (chkArrendavel.Checked == true)
            {
                CasaArrendavel casaArrendavelTemp = new CasaArrendavel();
                //Meter os dados da casa para a class para poder assim adicionar
                casaArrendavelTemp.Rua = txtRua.Text;
                casaArrendavelTemp.Localidade = txtLocalidade.Text;
                casaArrendavelTemp.Numero = txtNumero.Text;
                casaArrendavelTemp.Andar = txtAndar.Text;
                casaArrendavelTemp.Area = Convert.ToInt32(nudArea.Value);
                casaArrendavelTemp.NumeroAssoalhada = Convert.ToInt32(nudAssoalhadas.Value);
                casaArrendavelTemp.NumeroWC = Convert.ToInt32(nudWC.Value);
                casaArrendavelTemp.NumerosPisos = Convert.ToInt32(nudPisos.Value);
                casaArrendavelTemp.Tipo = cbTipoDeMoradia.Text;
                casaArrendavelTemp.ValorBaseMes = Convert.ToDecimal(txtArrendavelValorBase.Text);
                casaArrendavelTemp.Comissao = Convert.ToDecimal(txtArrendavelComissao.Text);

                //Guarda a casa no cliente selecionado na combo box
                clienteSelecionado.Casas.Add(casaArrendavelTemp);
                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                //Chamar a funcao atualizar a lista
                atualizarListaCasas();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao adicionar a casa por favor verificar os campos.", "Adicionar Casa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Quando a combo box de proprientario for mudada
        private void cb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Marcar o cliente selecionado para null
            clienteSelecionado = null;
            //Carregar o cliente selecionado da text box para a variavel
            clienteSelecionado = (Cliente)cb_Clientes.SelectedItem;
        }

        //Filtrar a data grid view pela localidade que foi metido na text box
        private void filter_Localidade()
        {
            //Verifica se a text box tem alguma cena escrita la dentro
            if (txtLocalidade_Filter.Text.Length > 0)
            {
                //desativa o botao de adicionar novo item para a base de dados
                btnGuardar.Enabled = false;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //renovar o container
                imobiliaria = new masterEntities();
                //selecionar o conteudo da base de dados de acordo com o que foi pedido pela text de filtro
                (from casa in imobiliaria.Casas
                 where casa.Localidade.ToUpper().Contains(txtLocalidade_Filter.Text.ToUpper())
                 orderby casa.Localidade
                 select casa).ToList();
                //Carregar a informaçao pedida acima para a list box
                casaBindingSource.DataSource = imobiliaria.Casas.Local.ToBindingList();
            }
            //se nao tiver texto
            else
            {
                //o botao de adicionar novo item estara ent ativo
                btnGuardar.Enabled = true;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //Atualizar a lista dos clientes sem nenhuma excecao
                atualizarListaCasas();
            }
        }

        //Funcao corre sempre que o texto da textbox muda
        private void txtLocalidade_Filter_TextChanged(object sender, EventArgs e)
        {
            //Chamar a funcao da textbox
            filter_Localidade();
        }

        //quando a selecao da data grid view for mudada
        private void casaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var current = casaDataGridView.CurrentRow;
            if (current != null) // Means that you've not clicked the column header
            {
                //Para ir buscar a casa que foi selecionada na data grid view
                casaSelecionada = null;
                casaSelecionada = (Casa)casaDataGridView.CurrentRow.DataBoundItem;
                //Verificar se existe alguma casa ja selecionada
                if (casaSelecionada != null)
                {
                    if (casaSelecionada is CasaVendavel)
                    {
                        casaVendavelSelecionada = null;
                        casaVendavelSelecionada = (CasaVendavel)casaDataGridView.CurrentRow.DataBoundItem;
                        //Verificar se existe alguma casa ja selecionada
                        if (casaVendavelSelecionada != null)
                        {
                            limpar_Campos();
                            //Carregar as imformaçoes para os respetivos citios
                            lblIdCasa.Text = "ID: " + casaVendavelSelecionada.IdCasa;
                            txtRua.Text = casaVendavelSelecionada.Rua;
                            txtLocalidade.Text = casaVendavelSelecionada.Localidade;
                            txtNumero.Text = casaVendavelSelecionada.Numero;
                            txtAndar.Text = casaVendavelSelecionada.Andar;
                            nudArea.Value = casaVendavelSelecionada.Area;
                            nudAssoalhadas.Value = casaVendavelSelecionada.NumeroAssoalhada;
                            nudWC.Value = casaVendavelSelecionada.NumeroWC;
                            nudPisos.Value = casaVendavelSelecionada.NumerosPisos;
                            cbTipoDeMoradia.Text = casaVendavelSelecionada.Tipo;
                            cb_Clientes.Text = casaVendavelSelecionada.Proprientario.ToString();
                            txtValorBaseNegociavel.Text = string.Empty;
                            txtComissaoBase.Text = Convert.ToString(casaVendavelSelecionada.ValorComissao);
                            txtValorBaseNegociavel.Text = Convert.ToString(casaVendavelSelecionada.ValorBaseVenda);
                            btnGerirLimpezas.Text = "Gerir Limpezas (Total: " + casaSelecionada.Limpezas.Count().ToString() + ")";
                            chkVendavel.Checked = true;
                            //Desativar os butoes e chk boxs
                            chkVendavel.Enabled = false;
                            chkArrendavel.Enabled = false;
                            btnNovo.Enabled = false;
                            btnVerCriarArrendamento.Enabled = false;
                            //Ativar o butao para guardar
                            btnGuardar.Enabled = true;
                            btnVerVenda.Enabled = true;
                            btnGerirLimpezas.Enabled = true;
                            novo = false;
                        }
                    }

                    if (casaSelecionada is CasaArrendavel)
                    {
                        casaArrendavelSelecionada = (CasaArrendavel)casaDataGridView.CurrentRow.DataBoundItem;
                        //Verificar se existe alguma casa ja selecionada
                        if (casaArrendavelSelecionada != null)
                        {
                            limpar_Campos();
                            //Carregar as imformaçoes para os respetivos citios
                            lblIdCasa.Text = "ID: " + casaArrendavelSelecionada.IdCasa;
                            txtRua.Text = casaArrendavelSelecionada.Rua;
                            txtLocalidade.Text = casaArrendavelSelecionada.Localidade;
                            txtNumero.Text = casaArrendavelSelecionada.Numero;
                            txtAndar.Text = casaArrendavelSelecionada.Andar;
                            nudArea.Value = casaArrendavelSelecionada.Area;
                            nudAssoalhadas.Value = casaArrendavelSelecionada.NumeroAssoalhada;
                            nudWC.Value = casaArrendavelSelecionada.NumeroWC;
                            nudPisos.Value = casaArrendavelSelecionada.NumerosPisos;
                            cbTipoDeMoradia.Text = casaArrendavelSelecionada.Tipo;
                            cb_Clientes.Text = casaArrendavelSelecionada.Proprientario.ToString();
                            txtValorBaseNegociavel.Text = string.Empty;
                            txtArrendavelComissao.Text = Convert.ToString(casaArrendavelSelecionada.Comissao);
                            txtArrendavelValorBase.Text = Convert.ToString(casaArrendavelSelecionada.ValorBaseMes);
                            btnGerirLimpezas.Text = "Gerir Limpezas (Total: " + casaArrendavelSelecionada.Limpezas.Count().ToString() + ")";
                            chkArrendavel.Checked = true;
                            //Desativar os butoes e chk boxs
                            chkVendavel.Enabled = false;
                            chkArrendavel.Enabled = false;
                            btnNovo.Enabled = false;
                            btnVerVenda.Enabled = false;
                            //Ativar o butao para guardar
                            btnGuardar.Enabled = true;
                            btnGerirLimpezas.Enabled = true;
                            btnVerCriarArrendamento.Enabled = true;
                            novo = false;
                        }
                    }
                }
            }
        }

        //Funcao para limpar
        private void limpar_Campos()
        {
            //Meter o cliente selecionado a null
            clienteSelecionado = null;
            //Adicionar os clientes da base de dados na combo box
            cb_Clientes.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            //Limpar textbox
            txtRua.Text = string.Empty;
            txtLocalidade.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtAndar.Text = string.Empty;
            nudArea.Value = 0;
            nudAssoalhadas.Value = 0;
            nudWC.Value = 0;
            nudPisos.Value = 0;
            cbTipoDeMoradia.Text = string.Empty;
            cb_Clientes.Text = string.Empty;
            chkArrendavel.Checked = false;
            chkVendavel.Checked = false;
            txtValorBaseNegociavel.Text = string.Empty;
            txtComissaoBase.Text = string.Empty;
            txtArrendavelValorBase.Text = string.Empty;
            txtArrendavelComissao.Text = string.Empty;
            //Ativar butoes e chk boxs
            chkArrendavel.Enabled = true;
            chkVendavel.Enabled = true;
            btnNovo.Enabled = true;
            gbDadosArrendamento.Enabled = true;
            gbDadosVenda.Enabled = true;
            btnGuardar.Enabled = false;
            btnVerCriarArrendamento.Enabled = false;
            btnVerVenda.Enabled = false;
            btnGerirLimpezas.Enabled = false;
            novo = true;
        }

        //Quando o butao limpar for precionado
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Chamar a funcao para limpar
            limpar_Campos();
        }

        //butao de criar 
        private void btnVerCriarArrendamento_Click(object sender, EventArgs e)
        {
            //Perparar para abrir o form 1 
            GerirArrendamentos frm = new GerirArrendamentos(casaArrendavelSelecionada, imobiliaria);
            //Mostar o form 1
            frm.Show();
        }

        //butao gerir cliente
        private void btnGerirLimpezas_Click(object sender, EventArgs e)
        {
            //Perparar para abrir o form 1 
            GerirLimpezas frm = new GerirLimpezas(casaSelecionada, arrenvendavel, imobiliaria);
            //Mostar o form 1
            frm.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Dialogo de messagem para perguntar se o deseja mesmo fechar o programa ou nao 
            DialogResult result = MessageBox.Show("Deseja alterar os dados desta casa?", "Alterar Dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Verifica qual foi a opecao escolhida e se for a opcao nao este ira entrar no if 
            if (result == DialogResult.Yes)
            {
                atualizar_casas();
            }

        }

        private void atualizar_casas()
        {
            if (verificacoes() == true)
            {
                if (casaSelecionada is CasaArrendavel)
                {
                    casaArrendavelSelecionada = (CasaArrendavel)casaDataGridView.CurrentRow.DataBoundItem;
                    //Verificar se existe alguma casa ja selecionada
                    if (casaArrendavelSelecionada != null)
                    {
                        casaArrendavelSelecionada.Rua = txtRua.Text;
                        casaArrendavelSelecionada.Localidade = txtLocalidade.Text;
                        casaArrendavelSelecionada.Numero = txtNumero.Text;
                        casaArrendavelSelecionada.Andar = txtAndar.Text;
                        casaArrendavelSelecionada.Area = Convert.ToInt32(nudArea.Value);
                        casaArrendavelSelecionada.NumeroAssoalhada = Convert.ToInt32(nudAssoalhadas.Value);
                        casaArrendavelSelecionada.NumeroWC = Convert.ToInt32(nudWC.Value);
                        casaArrendavelSelecionada.NumerosPisos = Convert.ToInt32(nudPisos.Value);
                        casaArrendavelSelecionada.Tipo = cbTipoDeMoradia.Text;
                        casaArrendavelSelecionada.ValorBaseMes = Convert.ToDecimal(txtArrendavelValorBase.Text);
                        casaArrendavelSelecionada.Comissao = Convert.ToDecimal(txtArrendavelComissao.Text);

                        //Guarda a imformaçao para a text box
                        imobiliaria.SaveChanges();
                    }
                }
                if (casaSelecionada is CasaVendavel)
                {
                    casaVendavelSelecionada = (CasaVendavel)casaDataGridView.CurrentRow.DataBoundItem;
                    if (casaVendavelSelecionada != null)
                    {
                        casaVendavelSelecionada.Rua = txtRua.Text;
                        casaVendavelSelecionada.Localidade = txtLocalidade.Text;
                        casaVendavelSelecionada.Numero = txtNumero.Text;
                        casaVendavelSelecionada.Andar = txtAndar.Text;
                        casaVendavelSelecionada.Area = Convert.ToInt32(nudArea.Value);
                        casaVendavelSelecionada.NumeroAssoalhada = Convert.ToInt32(nudAssoalhadas.Value);
                        casaVendavelSelecionada.NumeroWC = Convert.ToInt32(nudWC.Value);
                        casaVendavelSelecionada.NumerosPisos = Convert.ToInt32(nudPisos.Value);
                        casaVendavelSelecionada.Tipo = cbTipoDeMoradia.Text;
                        casaVendavelSelecionada.ValorBaseVenda = Convert.ToDecimal(txtValorBaseNegociavel.Text);
                        casaVendavelSelecionada.ValorComissao = Convert.ToDecimal(txtComissaoBase.Text);

                        //Guarda a imformaçao para a text box
                        imobiliaria.SaveChanges();
                    }
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Dialogo de messagem para perguntar se o deseja mesmo fechar o programa ou nao 
            DialogResult result = MessageBox.Show("Deseja eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Verifica qual foi a opecao escolhida e se for a opcao nao este ira entrar no if 
            if (result == DialogResult.Yes)
            {
                if (casaSelecionada is CasaArrendavel)
                {
                    if (casaArrendavelSelecionada.Arrendamentos.Count() == 0)
                    {
                        //Chamar a funcao para eliminar os clientes
                        imobiliaria.Casas.Remove(casaArrendavelSelecionada);
                        imobiliaria.SaveChanges();
                        //Chamar a funcao para atualizar a lista dos clientes
                        atualizarListaCasas();
                    }
                }
                else
                {
                    if (casaVendavelSelecionada.Venda != null)
                    {
                        //Chamar a funcao para eliminar os clientes
                        imobiliaria.Vendas.Remove(casaVendavelSelecionada.Venda);
                        imobiliaria.Casas.Remove(casaVendavelSelecionada);
                        imobiliaria.SaveChanges();
                        //Chamar a funcao para atualizar a lista dos clientes
                        atualizarListaCasas();
                    }
                    else
                    {
                        imobiliaria.Casas.Remove(casaVendavelSelecionada);
                        imobiliaria.SaveChanges();
                        //Chamar a funcao para atualizar a lista dos clientes
                        atualizarListaCasas();
                    }
                }
            }
        }

        private void btnVerVenda_Click(object sender, EventArgs e)
        {
            //Perparar para abrir o form 1 
            DadosVenda frm = new DadosVenda(casaVendavelSelecionada, imobiliaria);
            //Mostar o form 1
            frm.Show();
        }

        private bool verificacoes()
        {
            bool state = false;

            if (txtRua.Text == string.Empty)
                state = false;
            else if (txtLocalidade.Text == string.Empty)
                state = false;
            else if (txtNumero.Text == string.Empty)
                state = false;
            else if (txtAndar.Text == string.Empty)
                state = false;
            else if (nudArea.Value == 0)
                state = false;
            else if (nudAssoalhadas.Value == 0)
                state = false;
            else if (nudPisos.Value == 0)
                state = false;
            else if (cbTipoDeMoradia.Text == string.Empty)
                state = false;
            else if (cb_Clientes.Text == string.Empty)
                state = false;
            else if (chkArrendavel.Checked == true || chkVendavel.Checked == true)
            {
                if (chkArrendavel.Checked == true)
                {
                    gbDadosVenda.Enabled = false;
                    arrenvendavel = chkArrendavel.Text;
                    if (txtArrendavelComissao.Text == string.Empty)
                        state = false;
                    else if (txtArrendavelValorBase.Text == string.Empty)
                        state = false;
                    else
                        state = true;
                }
                else
                    gbDadosVenda.Enabled = true;

                if (chkVendavel.Checked == true)
                {
                    gbDadosArrendamento.Enabled = false;
                    //chkArrendavel.Checked = false;
                    arrenvendavel = chkVendavel.Text;
                    if (txtValorBaseNegociavel.Text == string.Empty)
                        state = false;
                    else if (txtComissaoBase.Text == string.Empty)
                        state = false;
                    else
                        state = true;
                }
                else
                    gbDadosArrendamento.Enabled = true;
            }
            else if (novo == true)
                state = false;
            else
                state = true;

            return state;
        }
    }
}
