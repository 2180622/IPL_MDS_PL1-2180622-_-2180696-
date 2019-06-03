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

namespace StandAutomoveis
{
    public partial class FormVenda : Form
    {
        public BDStandContainer BDStand;

        bool MoverForm;
        int eixoX;
        int eixoY;

        public FormVenda()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            (from carro in BDStand.Carros
             orderby carro.IdCarro
             select carro).Load();

            (from venda in BDStand.Vendas
             orderby venda.IdVenda
             select venda).Load();
            
            listBoxClientes.DataSource = BDStand.Clientes.Local.ToBindingList().ToList();

            listBoxCarros.DataSource = BDStand.Carros.Local.ToBindingList().OfType<CarroVenda>().ToList();
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Dispose();

            forminicial.ShowDialog();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if(clienteSelecionado != null)
            {
                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;
                
                // Adicionar CarroOficina à listbox
                listBoxVendas.DataSource = null;
                listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList();
            }
        }

        private void buttonAddVenda_Click(object sender, EventArgs e)
        {
            // Criar a venda e adicionar ao cliente e BD
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            Venda novaVenda = new Venda(decimal.Parse(valorTextBox.Text), estadoTextBox.Text, dataDateTimePicker.Value);
            
            //Cria o carro e adiciona-o à venda
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            CarroVenda carroSelecionado = (CarroVenda)listBoxCarros.SelectedItem;
            CarroVenda novoCarro = new CarroVenda(numeroChassisTextBox.Text, marcaTextBox.Text, modeloTextBox.Text, combustivelComboBox.Text, extrasTextBox.Text);

            novaVenda.CarroVenda = novoCarro;

            clienteSelecionado.Vendas.Add(novaVenda);

            BDStand.SaveChanges();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();
            this.Hide();

            formcliente.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAluguer formaluguer = new FormAluguer();

            formaluguer.ShowDialog();
        }

        private void buttonOficina_Click(object sender, EventArgs e)
        {
            FormOficina formOficina = new FormOficina();

            this.Hide();
            formOficina.ShowDialog();
        }

        // Torna o form draggable
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }
        // "
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }
        // "
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }
    }
}
