using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        //cira a variavel para o cliente selecionado
        private Cliente clienteSelecionado;
        //cria variavel para arrendamento selecionado
        private Arrendamento arrendamentoSelecionado;

        //funcao principal
        public GerirArrendamentos(CasaArrendavel casaArrendavelSelecionada, masterEntities imobiliaria)
        {
            //Inicia os componentes basicos do form
            InitializeComponent();
            //transferir os dados das variaveis com os dados transportos do form anterior para as locais
            this.imobiliaria = imobiliaria;
            this.casaArrendavelSelecionada = casaArrendavelSelecionada;
            //Carregar a lista de proprietarios para a combobox
            cbArrendatario.DataSource = imobiliaria.Clientes.ToList<Cliente>();
            //Carregar os dados da casa para as labels
            lblProprietario.Text = "Proprietario: " + casaArrendavelSelecionada.Proprientario;
            lblIdCasa.Text = "Id: " + casaArrendavelSelecionada.IdCasa;
            lblLocalidade.Text = "Localidade: " + casaArrendavelSelecionada.Localidade;
            //atualizar as lista dos arrendamentos
            atualizar_Lista();
            if (casaArrendavelSelecionada.Arrendamentos.Count() == 0)
                btnRemover.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                //Dialogo de messagem para perguntar se o deseja mesmo fechar o programa ou nao 
                DialogResult result = MessageBox.Show("Deseja cancelar este arrendamento?", "Cancelar Arrendamento?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Verifica qual foi a opecao escolhida e se for a opcao nao este ira entrar no if 
                if (result == DialogResult.Yes)
                {
                    //arrendamentoSelecionado.Arrendatario = null;
                    //arrendamentoSelecionado.CasaArrendavel = null;
                    //clienteSelecionado.Arrendamentos.Remove(arrendamentoSelecionado);
                    //casaArrendavelSelecionada.Arrendamentos.Remove(arrendamentoSelecionado);
                    imobiliaria.Arrendamentos.Remove(arrendamentoSelecionado);
                    //Guardar alteracoes
                    imobiliaria.SaveChanges();
                    //Chamar a funcapara  atualizar a lista
                    atualizar_Lista();
                    //Chamar a funcao para limpar os campos
                    limpar_campos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbArrendatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Marcar o cliente selecionado para null
            clienteSelecionado = null;
            //Carregar o cliente selecionado da text box para a variavel
            clienteSelecionado = (Cliente)cbArrendatario.SelectedItem;
        }

        private void btnNovoArrendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaoes() == true)
                {
                    if (clienteSelecionado != null)
                    {
                        Arrendamento arrendamentoTemp = new Arrendamento();
                        arrendamentoTemp.InicioContrado = dtpInicioDoContrato.Value;
                        arrendamentoTemp.DuracaoMeses = Convert.ToInt32(nudDuracaoMeses.Value);
                        arrendamentoTemp.Arrendatario = clienteSelecionado;
                        if (chkRenovavel.Checked == true)
                            arrendamentoTemp.Renovavel = "Sim";
                        else
                            arrendamentoTemp.Renovavel = "Não";


                        //lienteSelecionado.Arrendamentos.Add(arrendamentoTemp);
                        casaArrendavelSelecionada.Arrendamentos.Add(arrendamentoTemp);

                        imobiliaria.SaveChanges();
                        atualizar_Lista();
                    }
                }
                else
                    MessageBox.Show("Porfavor Verifique os campos e tente novamente!", "Adicionar Arrendamento?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //funcao para atualizar a lista
        private void atualizar_Lista()
        {
            lbListaAlugeres.DataSource = null;
            lbListaAlugeres.DataSource = casaArrendavelSelecionada.Arrendamentos.ToList<Arrendamento>();
        }

        //butao para limpar 
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

        //Funcao para limpar
        private void limpar_campos()
        {
            nudDuracaoMeses.Value = 0;
            dtpInicioDoContrato.Value = DateTime.Now;
            cbArrendatario.Text = string.Empty;
            chkRenovavel.Checked = false;
            dtpInicioDoContrato.Enabled = true;
            nudDuracaoMeses.Enabled = true;
            cbArrendatario.Enabled = true;
            chkRenovavel.Enabled = true;
            btnNovoArrendamento.Enabled = true;
        }

        //quando 
        private void lbListaAlugeres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (casaArrendavelSelecionada.Arrendamentos.Count() != 0)
                {
                    arrendamentoSelecionado = (Arrendamento)lbListaAlugeres.SelectedItem;
                    if (arrendamentoSelecionado != null)
                    {
                        dtpInicioDoContrato.Value = arrendamentoSelecionado.InicioContrado;
                        nudDuracaoMeses.Value = arrendamentoSelecionado.DuracaoMeses;
                        if (arrendamentoSelecionado.Renovavel == "Sim")
                            chkRenovavel.Checked = true;
                        else
                            chkRenovavel.Checked = false;

                        dtpInicioDoContrato.Enabled = false;
                        nudDuracaoMeses.Enabled = false;
                        cbArrendatario.Enabled = false;
                        chkRenovavel.Enabled = false;
                        btnNovoArrendamento.Enabled = false;
                        btnRemover.Enabled = true;
                    }
                }
                else
                    btnRemover.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ops Samething went wrong!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool verificaoes()
        {
            bool state = true;
            if (nudDuracaoMeses.Value == 0)
                state = false;
            return state;
        }
    }
}
