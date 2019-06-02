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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            (from aluguer in BDStand.Algueres
             orderby aluguer.IdAluguer
             select aluguer).Load();

=======
>>>>>>> 7049352b2916de32a8fef3dce1b5c17236f26726
            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

=======
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros
=======
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros
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
<<<<<<< HEAD
<<<<<<< HEAD
        }       
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros
        }

        private void buttonAddAluguerCarro_Click(object sender, EventArgs e)
        {


            /*clienteSelecionado.Alugueres.Add(novoAluguer);

            BDStand.SaveChanges();

            listBoxAlugueres.DataSource = null;
            listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();

            listBoxClientes.SelectedIndex = indexCliente;*/
        }
        
<<<<<<< HEAD
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros
=======
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros

        private void listBoxAluguerClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            

            if (clienteSelecionado != null)
            {
                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;

                if (listBoxClientes.SelectedIndex != -1)
                {
                    // Adicionar CarroOficina à listbox
                    listBoxAlugueres.DataSource = null;
                    listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();
                }
            }
        }

        private void listBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
=======
>>>>>>> 7049352b2916de32a8fef3dce1b5c17236f26726

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(listBoxAlugueres.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
            {
                return;
            }

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
<<<<<<< HEAD
=======
                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;
                
                // Adicionar CarroOficina à listbox
>>>>>>> 7049352b2916de32a8fef3dce1b5c17236f26726
                listBoxAlugueres.DataSource = null;
                listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();
            }
        }

        private void buttonAddAluguer_Click(object sender, EventArgs e)
        {
            if(kmsTextBox.TextLength == 0 || valorTextBox.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarros.SelectedItem;
            Aluguer novoAluguer = new Aluguer(dataInicioDateTimePicker.Value, dataFimDateTimePicker.Value, Decimal.Parse(valorTextBox.Text), double.Parse(kmsTextBox.Text));
            int indexCliente = listBoxClientes.SelectedIndex;
            
            if (clienteSelecionado.Alugueres.Count != 0 || carroSelecionado.Aluguer.Count != 0)
            {
                MessageBox.Show("Já tem um aluguer associado a este cliente");
                return;
            }
            else
            {
                clienteSelecionado.Alugueres.Add(novoAluguer);
                carroSelecionado.Aluguer.Add(novoAluguer);

                carroSelecionado.Estado = "Indisponivel";

                BDStand.SaveChanges();

                if(clienteSelecionado != null)
                {
                    listBoxAlugueres.DataSource = null;
                    listBoxAlugueres.DataSource = clienteSelecionado.Alugueres.ToList();

                    listBoxCarros.DataSource = null;
                    listBoxCarros.DataSource = BDStand.Carros.Local.ToBindingList().OfType<CarroAluguer>().ToList();
                }
                listBoxClientes.SelectedIndex = indexCliente;
            }

            valorTextBox.Text = "";
            kmsTextBox.Text = "";
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
=======
>>>>>>> parent of 7049352... mostra carros e clientes. Associação de alugueres a clientes e carros
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