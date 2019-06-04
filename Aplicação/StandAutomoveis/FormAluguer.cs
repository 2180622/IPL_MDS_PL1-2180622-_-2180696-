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

        bool MoverForm;
        int eixoX;
        int eixoY;

        public FormAluguer()
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

            (from aluguer in BDStand.Algueres
             orderby aluguer.IdAluguer
             select aluguer).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

            carroBindingSource.DataSource = BDStand.Carros.Local.ToBindingList().OfType<CarroAluguer>().ToList();
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Dispose();
            forminicial.ShowDialog();
        }

        private void buttonOficinaCliente_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();

            this.Dispose();
            formcliente.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {
            FormOficina formoficina = new FormOficina();

            this.Dispose();
            formoficina.ShowDialog();
        }

        private void buttonVendasCliente_Click(object sender, EventArgs e)
        {
            FormVenda formvenda = new FormVenda();

            this.Dispose();
            formvenda.ShowDialog();
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            FormAddCarroAluguer formadd = new FormAddCarroAluguer();

            this.Dispose();
            formadd.ShowDialog();
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

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxAlugueres.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
            {
                return;
            }

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
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
                MessageBox.Show("Não pode ter mais do que um cliente e/ou carro associado a um aluguer");
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

        // Torna o form draggable
        private void panelCarroTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }
        // "
        private void panelCarroTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }
        // "
        private void panelCarroTop_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }
    }
}