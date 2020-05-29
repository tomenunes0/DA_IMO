using Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA;
using System.Data.Entity;
using System.Windows.Controls;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Documents;
using System.IO;

namespace Projeto_DA
{
    public partial class GerirLimpezas : Form
    {
        //perparar o container para a base de dados
        private masterEntities imobiliaria;
        //Perparar a variaver para a casa selecionada
        private Casa casaSelecionada;
        //Perparar a variavel para a limpeza selecionada
        private Limpeza limpezaSelecionada;
        //Perparar a variavel para o servico selecionado
        private Servico servicoSelecionado;

        //Variaveis para guardar pequenos valors para correcao de bugs
        //Variavel para guardar o valor do tipo de servico
        private decimal valor;
        //Variavel para guardar o index selecionado da lista das limpezas
        private int index = 0;

        //Funcao de inicializaçao para carregar as variaveis localais
        public GerirLimpezas(Casa casaSelecionada, string arrenvendavel, masterEntities imobiliaria)
        {
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaSelecionada = casaSelecionada;
            //Carregar a imformaçao da casa selecionada para a label
            lblInformacaoCasa.Text = arrenvendavel + ": " + casaSelecionada.IdCasa + " - " + casaSelecionada.Localidade;
            //Chamar a funcao atualizar lista de limpezas 
            atualizar_ListaLimpezas();
            btnRemoverServicos.Enabled = false;
            btnRemover.Enabled = false;
        }

        //Quando este form for fechado esta funcao sera executada
        private void GerirLimpezas_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //esconder este form depois de tar pronto para fechar

                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando o butao novo for precionado esta funcao sera executada
        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar se existe alguma limpeza selecionada
                if (limpezaSelecionada != null && cb_Descricao.Text != string.Empty)
                {
                    //Criar um novo servico
                    Servico servicoTemp = new Servico();
                    servicoTemp.Descricao = cb_Descricao.Text;
                    servicoTemp.Unidades = Convert.ToInt32(nudUnidades.Value);
                    servicoTemp.Valor = valor;
                    //Inserir o novo servico na base de dados 
                    limpezaSelecionada.Servicos.Add(servicoTemp);
                    //Guarda a imformaçao para a text box
                    imobiliaria.SaveChanges();
                    //Carregar o index que esta selecionado para a variavel
                    index = lb_ListaDeLimpezas.SelectedIndex;
                    //Depois de adicionado o serviço atualizar as duas listas
                    atualizar_ListaServicos();
                    atualizar_ListaLimpezas();
                }
                else
                    MessageBox.Show("Verifique os campos e tente novamente!", "Adicionar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando o butao nova limpeza for persionado 
        private void btnNovaLimpeza_Click(object sender, EventArgs e)
        {
            try
            {
                //Fazer nova limpeza
                Limpeza limpezaTemp = new Limpeza();
                limpezaTemp.Data = dtpDataDaLimpeza.Value;
                //adcionar limpeza a base de dados a casa selecionada
                casaSelecionada.Limpezas.Add(limpezaTemp);
                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                //Atualizara lista das limpezas
                atualizar_ListaLimpezas();
                atualizar_ListaServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Funcao para atualizar a lista de limpezas
        private void atualizar_ListaLimpezas()
        {
            try
            {
                //Listar os dados para a lista
                lb_ListaDeLimpezas.DataSource = null;
                lb_ListaDeLimpezas.DataSource = casaSelecionada.Limpezas.ToList<Limpeza>();
                //para correr cada uma dos topicos da lista 
                for (int i = 0; i < casaSelecionada.Limpezas.Count(); i++)
                {
                    //Selecionar o index da lista box
                    lb_ListaDeLimpezas.SelectedIndex = i;
                    //Verificar ser existe uma casa selecionada
                    if (casaSelecionada != null)
                    {
                        lb_ListaDeLimpezas.DataSource = null;
                        lb_ListaDeLimpezas.DataSource = casaSelecionada.Limpezas.ToList<Limpeza>();
                        lb_ListaDeLimpezas.SelectedIndex = index;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando o butao remover for persionado 
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                //Dialogo de messagem para perguntar se o deseja mesmo fechar o programa ou nao 
                DialogResult result = MessageBox.Show("Deseja remover esta limpeza?", "Remover Limpeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Verifica qual foi a opecao escolhida e se for a opcao nao este ira entrar no if 
                if (result == DialogResult.Yes)
                {
                    //Remover da casa selecionada a limpeza
                    casaSelecionada.Limpezas.Remove(limpezaSelecionada);
                    //Guarda a imformaçao para a text box
                    imobiliaria.SaveChanges();
                    //Chamar a funcao para atualizar a lista de limpezas
                    atualizar_ListaLimpezas();
                    atualizar_ListaServicos();
                    if (casaSelecionada.Limpezas.Count() == 0)
                        btnRemover.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando a lista de limpezas for clicada / quando o index da lista for alterado
        private void lb_ListaDeLimpezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Por o item selecionado para a variavel
                limpezaSelecionada = (Limpeza)lb_ListaDeLimpezas.SelectedItem;
                //atualizar as lista de servicos
                atualizar_ListaServicos();
                btnRemover.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando a combox index eh mudada 
        private void cb_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Variavel para guardar o index da combobox
                int index = cb_Descricao.SelectedIndex;
                //Verificar o index da combobox
                if (index == 0)
                {
                    //Muda o valor da label
                    lblValorUnitario.Text = "Valor Unitario: 10 €";
                    valor = 10;
                }
                else if (index == 1)
                {
                    //Muda o valor da label
                    lblValorUnitario.Text = "Valor Unitario: 20 €";
                    valor = 20;
                }
                else if (index == 2)
                {
                    //Muda o valor da label
                    lblValorUnitario.Text = "Valor Unitario: 30 €";
                    valor = 30;
                }
                else if (index == 3)
                {
                    //Muda o valor da label
                    lblValorUnitario.Text = "Valor Unitario: 40 €";
                    valor = 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Funcao para atualizar lista da servicos
        private void atualizar_ListaServicos()
        {
            try
            {
                lb_ListaDeServicos.DataSource = null;
                //verificar ser existe alguama limpeza selecionada
                if (limpezaSelecionada != null)
                {
                    //Lista de servicos
                    lb_ListaDeServicos.DataSource = null;
                    lb_ListaDeServicos.DataSource = limpezaSelecionada.Servicos.ToList<Servico>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //quando o butao de remover servicos 
        private void btnRemoverServicos_Click(object sender, EventArgs e)
        {
            try
            {
                //limpezaselecionada
                limpezaSelecionada.Servicos.Remove(servicoSelecionado);
                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                //Atualizar as listas 
                atualizar_ListaServicos();
                index = lb_ListaDeLimpezas.SelectedIndex;
                atualizar_ListaLimpezas();
                if (limpezaSelecionada.Servicos.Count() == 0)
                    btnRemoverServicos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Quando o index da lista for mudado 
        private void lb_ListaDeServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carregar para a variavel da lista de servicos selecionados
            servicoSelecionado = (Servico)lb_ListaDeServicos.SelectedItem;
            btnRemoverServicos.Enabled = true;
        }

        //Form quando carrega
        private void GerirLimpezas_Load(object sender, EventArgs e)
        {
            //Atualizar as listas
            atualizar_ListaLimpezas();
        }

        private void btnEmiteFatura_Click(object sender, EventArgs e)
        {
            export();
        }

        private void export()
        {
            try
            {
                if (limpezaSelecionada != null)
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    string ficheiro = saveFileDialog.FileName;
                    string header = "\t\t\t\tFATURA EMITIDA A \t\t" + DateTime.Now.ToString() + "\n-----------------------------------------------------------------------------\nProprientario: \n\tNome: " + limpezaSelecionada.Casa.Proprientario.Nome + "\n\tNif: " + limpezaSelecionada.Casa.Proprientario.Nif + "\n\tMorada: "
                         + limpezaSelecionada.Casa.Proprientario.Morada + " \n\tContacto:" +
                        limpezaSelecionada.Casa.Proprientario.Contacto + "\n" + "-----------------------------------------------------------------------------\nCasa: \n\tRua: " + limpezaSelecionada.Casa.Rua + "\n\tNumero: " +
                        limpezaSelecionada.Casa.Numero + "\n\tLocalidade: " + limpezaSelecionada.Casa.Localidade + "\n" + "-----------------------------------------------------------------------------\nLimpeza: \n\tData: " + limpezaSelecionada.Data.ToShortDateString() + "\n-----------------------------------------------------------------------------\n";

                    File.WriteAllText(ficheiro, header);

                    string conteudo;

                    string footer = "-----------------------------------------------------------------------------\n" + "Total: \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + limpezaSelecionada.total + "€\n-----------------------------------------------------------------------------";

                    File.AppendAllText(ficheiro, "Servicos: \n");

                    foreach (Servico servico in limpezaSelecionada.Servicos)
                    {
                        conteudo = "\tDescricao: " + servico.Descricao + " | Qtd: " + servico.Unidades + " | Preço Unidade: " + servico.Valor + "€ |Subtotal: " + servico.total + "€ \n";
                        File.AppendAllText(ficheiro, conteudo);
                    }
                    File.AppendAllText(ficheiro, footer);
                    MessageBox.Show("Fatura emitida com sucesso! 😘", "Emitir Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Nenhuma limpeza está selecionada", "Emitir Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
