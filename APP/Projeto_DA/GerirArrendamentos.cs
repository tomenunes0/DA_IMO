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
        private Cliente clienteSelecionado;
        private Arrendamento arrendamentoSelecionado;

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
            lblLocalidade.Text = "Localidade: " + casaArrendavelSelecionada.Localidade;
            atualizar_Lista();
            if (casaArrendavelSelecionada.Arrendamentos.Count() == 0)
                btnRemover.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //arrendamentoSelecionado.Arrendatario = null;
            //arrendamentoSelecionado.CasaArrendavel = null;
            imobiliaria.SaveChanges();

            //clienteSelecionado.Arrendamentos.Remove(arrendamentoSelecionado);
            //casaArrendavelSelecionada.Arrendamentos.Remove(arrendamentoSelecionado);
            imobiliaria.Arrendamentos.Remove(arrendamentoSelecionado);

            imobiliaria.SaveChanges();
            atualizar_Lista();
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

        private void atualizar_Lista()
        {
            lbListaAlugeres.DataSource = null;
            lbListaAlugeres.DataSource = casaArrendavelSelecionada.Arrendamentos.ToList<Arrendamento>();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

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

        private void lbListaAlugeres_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
