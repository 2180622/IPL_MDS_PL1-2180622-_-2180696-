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

        public FormVenda()
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
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            Venda novaVenda = new Venda(decimal.Parse(valorTextBox.Text), estadoTextBox.Text, dataDateTimePicker.Value);
            int indexCliente = listBoxClientes.SelectedIndex;
            
            BDStand.Vendas.Add(novaVenda);

            
        }
    }
}
