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
                
                // Adicionar CarroOficina à listbox
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            // fecha o form
            this.Close();
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            // instancia um novo form para adicionar o carro
            FormAddCarroOficina formaddcarro = new FormAddCarroOficina();
            this.Hide();
            if (formaddcarro.ShowDialog() == DialogResult.OK)
            {
                CarroOficina novoCarroOficina = new CarroOficina(formaddcarro.marca, formaddcarro.modelo, formaddcarro.matricula, formaddcarro.numeroChassis, formaddcarro.kms, formaddcarro.combustivel);
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

                clienteSelecionado.CarrosOficina.Add(novoCarroOficina);
            }
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = carroOficinaBindingSource;
            }*/
        }
    }


}
