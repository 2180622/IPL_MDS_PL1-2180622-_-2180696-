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
    public partial class FormAluguer : Form
    {
        public BDStandContainer BDStand;

        public FormAluguer()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

            (from carro in BDStand.Carros
             orderby carro.IdCarro
             select carro).Load();

            listBoxCarros.DataSource = BDStand.Carros.Local.ToBindingList().OfType<CarroAluguer>().ToList();
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Close();

            forminicial.ShowDialog();
        }

        private void buttonOficinaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente formcliente = new FormCliente();

            formcliente.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOficina formoficina = new FormOficina();

            formoficina.ShowDialog();
        }

        private void buttonVendasCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenda formvenda = new FormVenda();

            formvenda.ShowDialog();
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            FormAddCarroAluguer formadd = new FormAddCarroAluguer();

            this.Hide();
            formadd.ShowDialog();
        }

        private void buttonAddAluguerCarro_Click(object sender, EventArgs e)
        {


            /*clienteSelecionado.Alugueres.Add(novoAluguer);

            BDStand.SaveChanges();

            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();

            listBoxClientes.SelectedIndex = indexCliente;*/
        }
        

        private void listBoxAluguerClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;
                
                // Adicionar CarroOficina à listbox
                listBoxAlugueres.DataSource = null;
                listBoxAlugueres.DataSource = aluguerBindingSource;
            }
        }

        private void listBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarros.SelectedItem;

            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = BDStand.Carros.ToList();

            if(carroSelecionado != null)
            {
                listBoxAlugueres.DataSource = null;
                listBoxAlugueres.DataSource = carroSelecionado.Aluguer.ToList();
            }
        }

        private void groupBoxAluguerCarros_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddAluguer_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            Aluguer novoAluguer = new Aluguer(dataInicioDateTimePicker.Value, dataFimDateTimePicker.Value, Decimal.Parse(valorTextBox.Text), double.Parse(kmsTextBox.Text));


        }
    }
}