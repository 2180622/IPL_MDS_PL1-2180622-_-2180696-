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
        // Cria o container
        public BDStandContainer BDStand;

        bool MoverForm;
        int eixoX;
        int eixoY;
        int indexCliente;

        public FormVenda(int indexCliente)
        {
            InitializeComponent();
            CenterToScreen();
            // instancia container
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
            listBoxVendas.DataSource = BDStand.Vendas.Local.ToList();
            listBoxCarros.DataSource = BDStand.Carros.Local.OfType<CarroVenda>().ToList();

            // Se não existirem clientes ele nao entra no if
            if (BDStand.Clientes.Count() != 0)
            {
                // Traz o index do cliente selecionado dos forms anteriores
                listBoxClientes.SelectedIndex = indexCliente;
            }
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
                
                // atualiza as listboxes
                listBoxVendas.DataSource = null;
                listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList();
                listBoxCarros.DataSource = null;
            }
        }

        private void buttonAddVendaCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            // Criar a venda
            Venda novaVenda = new Venda(decimal.Parse(valorTextBox.Text), estadoComboBox.Text, dataDateTimePicker.Value);
            
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            CarroVenda carroSelecionado = (CarroVenda)listBoxCarros.SelectedItem;
            //Cria o carro
            CarroVenda novoCarro = new CarroVenda(numeroChassisTextBox.Text, marcaTextBox.Text, modeloTextBox.Text, combustivelComboBox.Text, extrasTextBox.Text);
            // Adiciona o novo carro a venda
            novaVenda.CarroVenda = novoCarro;
            // Associa a venda(com o carro) ao cliente selecionado
            clienteSelecionado.Vendas.Add(novaVenda);
            // Grava alterações
            BDStand.SaveChanges();
            // atualiza a listbox
            listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList();

            valorTextBox.Text = "";
            numeroChassisTextBox.Text = "";
            marcaTextBox.Text = "";
            modeloTextBox.Text = "";
            combustivelComboBox.Text = "";
            extrasTextBox.Text = "";
        }

        private void listBoxVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;
            if(vendaSelecionada != null)
            {
                listBoxCarros.DataSource = null;
                listBoxCarros.Items.Clear();
                listBoxCarros.Items.Add(vendaSelecionada.CarroVenda);
            }
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();
            this.Hide();

            formcliente.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {
            indexCliente = listBoxClientes.SelectedIndex;
            
            FormAluguer formaluguer = new FormAluguer(indexCliente);

            this.Dispose();
            formaluguer.ShowDialog();
        }

        private void buttonOficina_Click(object sender, EventArgs e)
        {
            indexCliente = listBoxClientes.SelectedIndex;

            FormOficina formOficina = new FormOficina(indexCliente);

            this.Dispose();
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
