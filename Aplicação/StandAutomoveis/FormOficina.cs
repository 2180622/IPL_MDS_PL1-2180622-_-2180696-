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
    public partial class FormOficina : Form
    {
        public BDStandContainer BDStand;

        public FormOficina()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
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

                // Limpa listBox dos serviços
                listBoxServicos.DataSource = null;
                // Adicionar CarroOficina à listbox
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();

            }
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            // fecha o form e abre o menu inicial
            FormInicial forminicial = new FormInicial();

            this.Close();

            forminicial.Show();
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            // instancia um novo form para adicionar o carro
            FormAddCarroOficina formaddcarro = new FormAddCarroOficina();
            this.Hide();
            CarroOficina novoCarroOficina = new CarroOficina(formaddcarro.marca, formaddcarro.modelo, formaddcarro.matricula, formaddcarro.numeroChassis, formaddcarro.kms, formaddcarro.combustivel);
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            formaddcarro.ShowDialog();
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            if (carroSelecionado != null)
            {
                listBoxServicos.DataSource = null;
                listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
            }
            
        }

        private void buttonAddServico_Click(object sender, EventArgs e)
        {
            Servico novoServico = new Servico(tipoTextBox.Text, dataEntradaDateTimePicker.Value, dataSaidaDateTimePicker.Value);
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            int indexCarro = listBoxCarros.SelectedIndex;
            
            carroSelecionado.Servicos.Add(novoServico);
            BDStand.SaveChanges();

            listBoxServicos.DataSource = null;
            listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();

            listBoxCarros.SelectedIndex = indexCarro;
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            if(servicoSelecionado != null)
            {

            }
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
            FormAluguer formaluguer = new FormAluguer();

            formaluguer.ShowDialog();
        }

        private void buttonVendasCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenda formvenda = new FormVenda();

            formvenda.ShowDialog();
        }
        
    }


}
