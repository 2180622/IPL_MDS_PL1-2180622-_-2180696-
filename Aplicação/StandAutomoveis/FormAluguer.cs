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
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Close();

            forminicial.Show();
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
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            FormAddCarroAluguer formaddcarro = new FormAddCarroAluguer();
            this.Hide();
            CarroAluguer novoCarroAluguer = new CarroAluguer(formaddcarro.combustivel, formaddcarro.estado, formaddcarro.marca, formaddcarro.matricula, formaddcarro.modelo, formaddcarro.numeroChassis);

            formaddcarro.ShowDialog();

            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
        }

        private void buttonAddAluguer_Click(object sender, EventArgs e)
        {
            if(valorTextBox.TextLength == 0 || kmsTextBox.TextLength == 0)
            {
                return;
            }

            Aluguer novoAluguer = new Aluguer(dataInicioDateTimePicker.Value, dataFimDateTimePicker.Value, decimal.Parse(valorTextBox.Text), double.Parse(kmsTextBox.Text));
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            int indexCliente = listBoxClientes.SelectedIndex;
            
            clienteSelecionado.Alugueres.Add(novoAluguer);

            BDStand.SaveChanges();

            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();

            listBoxClientes.SelectedIndex = indexCliente;
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

                // Limpa listBox dos serviços
                listBoxCarros.DataSource = null;
                // Adicionar CarroOficina à listbox
                listBoxAlugueres.DataSource = null;
                listBoxAlugueres.DataSource = aluguerBindingSource;
            }
        }

        private void listBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerSelecionado = (Aluguer)listBoxAlugueres.SelectedItem;
        }
    }
}