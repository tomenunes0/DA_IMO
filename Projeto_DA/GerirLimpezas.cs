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

namespace Projeto_DA
{
    public partial class GerirLimpezas : Form
    {
        //perparar o container para a base de dados
        private masterEntities imobiliaria;
        private Casa casaSelecionada;
        private Limpeza limpezaSelecionada;
        private Servico servicoSelecionado;

        private decimal valor;
        private int index = 0;

        public GerirLimpezas(Casa casaSelecionada, string arrenvendavel, masterEntities imobiliaria)
        {
            InitializeComponent();
            this.imobiliaria = imobiliaria;
            this.casaSelecionada = casaSelecionada;
            lblInformacaoCasa.Text = arrenvendavel + ": " + casaSelecionada.IdCasa + " - " + casaSelecionada.Localidade;
            atualizar_ListaLimpezas();
        }

        private void GerirLimpezas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();
        }

        private void btnNovoServico_Click(object sender, EventArgs e)
        {
            if (limpezaSelecionada != null)
            {
                Servico servicoTemp = new Servico();
                servicoTemp.Descricao = cb_Descricao.Text;
                servicoTemp.Unidades = Convert.ToInt32(nudUnidades.Value);
                servicoTemp.Valor = valor;

                limpezaSelecionada.Servicos.Add(servicoTemp);

                //Guarda a imformaçao para a text box
                imobiliaria.SaveChanges();
                index = lb_ListaDeLimpezas.SelectedIndex;
                atualizar_ListaServicos();
                atualizar_ListaLimpezas();
            }
        }

        private void btnNovaLimpeza_Click(object sender, EventArgs e)
        {
            Limpeza limpezaTemp = new Limpeza();
            limpezaTemp.Data = DateTime.Now;
            casaSelecionada.Limpezas.Add(limpezaTemp);

            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();

            atualizar_ListaLimpezas();
        }

        private void atualizar_ListaLimpezas()
        {
            lb_ListaDeLimpezas.DataSource = null;
            lb_ListaDeLimpezas.DataSource = casaSelecionada.Limpezas.ToList<Limpeza>();
            for (int i = 0; i < casaSelecionada.Limpezas.Count(); i++)
            {
                lb_ListaDeLimpezas.SelectedIndex = i;
                if (casaSelecionada != null)
                {
                    lb_ListaDeLimpezas.DataSource = null;
                    lb_ListaDeLimpezas.DataSource = casaSelecionada.Limpezas.ToList<Limpeza>();
                    lb_ListaDeLimpezas.SelectedIndex = index;
                }
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            casaSelecionada.Limpezas.Remove(limpezaSelecionada);

            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();
            //Chamar a funcao para atualizar a lista de limpezas
            atualizar_ListaLimpezas();
        }

        private void lb_ListaDeLimpezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpezaSelecionada = (Limpeza)lb_ListaDeLimpezas.SelectedItem;
            atualizar_ListaServicos();
        }

        private void cb_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Descricao.SelectedIndex;

            if (index == 0)
            {
                lblValorUnitario.Text = "Valor Unitario: 10 €";
                valor = 10;
            }
            else if (index == 1)
            {
                lblValorUnitario.Text = "Valor Unitario: 20 €";
                valor = 20;
            }
            else if (index == 2)
            {
                lblValorUnitario.Text = "Valor Unitario: 30 €";
                valor = 30;
            }
            else if (index == 3)
            {
                lblValorUnitario.Text = "Valor Unitario: 40 €";
                valor = 40;
            }
        }

        private void atualizar_ListaServicos()
        {
            if (limpezaSelecionada != null)
            {
                lb_ListaDeServicos.DataSource = null;
                lb_ListaDeServicos.DataSource = limpezaSelecionada.Servicos.ToList<Servico>();
            }
        }

        private void btnRemoverServicos_Click(object sender, EventArgs e)
        {
            limpezaSelecionada.Servicos.Remove(servicoSelecionado);

            //Guarda a imformaçao para a text box
            imobiliaria.SaveChanges();

            atualizar_ListaServicos();
            index = lb_ListaDeLimpezas.SelectedIndex;
            atualizar_ListaLimpezas();
        }

        private void lb_ListaDeServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicoSelecionado = (Servico)lb_ListaDeServicos.SelectedItem;
        }


        private void GerirLimpezas_Load(object sender, EventArgs e)
        {
            atualizar_ListaLimpezas();
        }
    }
}
