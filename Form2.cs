using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Form2 : Form
    {
        //perparar o container para a base de dados
        private Model1Container imobiliaria;

        //Inicio do form 2 
        public Form2()
        {
            //Inicia os componentes do form2 
            InitializeComponent();
            //Marca a imobiliaria como novo container da base de dados 
            imobiliaria = new Model1Container();
            //Seleciona o conteudo da base de dados e organiza - o por nome 
            (from cliente in imobiliaria.Clientes orderby cliente.Nome select cliente).Load();
            //Carrega a informaçao que foi pedida na linha anterior para a listbox que foi gerada
            clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
        }

        //Quando o botao de save for precionado esta funcao sera ativada
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Processo de guardados na base de dados 
            imobiliaria.SaveChanges();
        }

        //Butao de filtro quando sera percionado 
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Verifica se a text box tem alguma cena escrita la dentro
            if (txtNome_Filter.Text.Length > 0)
            {
                //desativa o botao de adicionar novo item para a base de dados
                bindingNavigatorAddNewItem.Enabled = false;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //renovar o container
                imobiliaria = new Model1Container();
                //selecionar o conteudo da base de dados de acordo com o que foi pedido pela text de filtro
                (from pessoa in imobiliaria.Clientes
                 where pessoa.Nome.ToUpper().Contains(txtNome_Filter.Text.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).ToList();
                //Carregar a informaçao pedida acima para a list box
                clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
            }
            //se nao tiver texto
            else
            {
                //o botao de adicionar novo item estara ent ativo
                bindingNavigatorAddNewItem.Enabled = true;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //renovar o container
                imobiliaria = new Model1Container();
                //selecionar o conteudo da base de dados
                (from cliente in imobiliaria.Clientes
                 orderby cliente.Nome
                 select cliente).Load();
                //Carregar a informaçao pedida acima para a list box
                clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
            }
        }

        private void txtNome_Filter_TextChanged(object sender, EventArgs e)
        {
            //Verifica se a text box tem alguma cena escrita la dentro
            if (txtNome_Filter.Text.Length > 0)
            {
                //desativa o botao de adicionar novo item para a base de dados
                bindingNavigatorAddNewItem.Enabled = false;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //renovar o container
                imobiliaria = new Model1Container();
                //selecionar o conteudo da base de dados de acordo com o que foi pedido pela text de filtro
                (from pessoa in imobiliaria.Clientes
                 where pessoa.Nome.ToUpper().Contains(txtNome_Filter.Text.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).ToList();
                //Carregar a informaçao pedida acima para a list box
                clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
            }
            //se nao tiver texto
            else
            {
                //o botao de adicionar novo item estara ent ativo
                bindingNavigatorAddNewItem.Enabled = true;
                //para dar dispose da imobiliaria
                imobiliaria.Dispose();
                //renovar o container
                imobiliaria = new Model1Container();
                //selecionar o conteudo da base de dados
                (from cliente in imobiliaria.Clientes
                 orderby cliente.Nome
                 select cliente).Load();
                //Carregar a informaçao pedida acima para a list box
                clienteBindingSource.DataSource = imobiliaria.Clientes.Local.ToBindingList();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Perparar para abrir o form 1 
            Form1 frm = new Form1();      
            //Mostar o form 1
            frm.Show();
            //Fechar o form 
            this.Hide();
        }
    }
}
