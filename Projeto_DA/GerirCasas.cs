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
        //Perparar a class casa para guardar o casa selecionado
        public static Casa casaSelecionada;
        //Variavel se eh vendavel ou nao
        public static string arrenvendavel;

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
            Home home = new Home();
            //Mostar o form 1
            home.Show();
            //gerirLimpezas.Hide();
            //Fechar o form 
            this.Hide();
        }

        //Fazer o butao guardar mais gostoso
        private void timer_Tick(object sender, EventArgs e)
        {
            if (chkArrendavel.Checked == true)
            {
                gbDadosVenda.Enabled = false;
                // chkVendavel.Checked = false;
                arrenvendavel = chkArrendavel.Text;
            }
            else 
                gbDadosVenda.Enabled = true;

            if (chkVendavel.Checked == true)
            {
                gbDadosArrendamento.Enabled = false;
                //chkArrendavel.Checked = false;
                arrenvendavel = chkVendavel.Text;
            }
            else
                gbDadosArrendamento.Enabled = true;
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
            //Nova casa
            Casa casaTemp = new Casa();
            //Meter os dados da casa para a class para poder assim adicionar
            casaTemp.Rua = txtRua.Text;
            casaTemp.Localidade = txtLocalidade.Text;
            casaTemp.Numero = txtNumero.Text;
            casaTemp.Andar = txtAndar.Text;
            casaTemp.Area = Convert.ToInt32(nudArea.Value);
            casaTemp.NumeroAssoalhada = Convert.ToInt32(nudAssoalhadas.Value);
            casaTemp.NumeroWC = Convert.ToInt32(nudWC.Value);
            casaTemp.NumerosPisos = Convert.ToInt32(nudPisos.Value);
            casaTemp.Tipo = cbTipoDeMoradia.Text;
            //Guarda a casa no cliente selecionado na combo box
            clienteSelecionado.Casas.Add(casaTemp);
            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();
            //Chamar a funcao atualizar a lista
            atualizarListaCasas();
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
                (from cliente in imobiliaria.Clientes
                 where cliente.Nome.ToUpper().Contains(txtLocalidade_Filter.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();
                //Carregar a informaçao pedida acima para a list box
                clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
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
            //Para ir buscar a casa que foi selecionada na data grid view
            casaSelecionada = null;
            casaSelecionada = (Casa)casaDataGridView.CurrentRow.DataBoundItem;
            //Verificar se existe alguma casa ja selecionada
            if (casaSelecionada != null)
            {
                //Carregar as imformaçoes para os respetivos citios
                lblIdCasa.Text = "ID: " + casaSelecionada.IdCasa;
                txtRua.Text = casaSelecionada.Andar;
                txtLocalidade.Text = casaSelecionada.Localidade;
                txtNumero.Text = casaSelecionada.Numero;
                txtAndar.Text = casaSelecionada.Andar;
                nudArea.Value = casaSelecionada.Area;
                nudAssoalhadas.Value = casaSelecionada.NumeroAssoalhada;
                nudWC.Value = casaSelecionada.NumeroWC;
                nudPisos.Value = casaSelecionada.NumerosPisos;
                cbTipoDeMoradia.Text = casaSelecionada.Tipo;
              
                //cb_Clientes.Text = imobiliaria.Client casaSelecionada.IdCasa.ToString();   
                btnGerirLimpezas.Text = "Gerir Limpezas (Total: " + casaSelecionada.Limpezas.Count().ToString() + ")";
            }  
        }

        //Funcao para limpar
        private void limpar_Campos()
        {
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
        }

        //Quando o butao limpar for precionado
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpar_Campos();
        }

        //butao de criar 
        private void btnVerCriarArrendamento_Click(object sender, EventArgs e)
        {

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
            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnVerVenda_Click(object sender, EventArgs e)
        {
            //Perparar para abrir o form 1 
            DadosVenda frm = new DadosVenda(casaSelecionada, arrenvendavel, imobiliaria);
            //Mostar o form 1
            frm.Show();
        }
    }
}
