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
    public partial class FormAddCarroOficina : Form
    {
        public BDStandContainer BDStand;

        public string matricula;
        public string marca;
        public string modelo;
        public string numeroChassis;
        public string kms;
        public string combustivel;
        bool MoverForm;
        int eixoX;
        int eixoY;
        int indexCliente;

        public FormAddCarroOficina(int indexCliente)
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();
            
            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

            listBoxClientes.SelectedIndex = indexCliente;
        }
        

        private void buttonAddCarroOficina_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione primeiro um cliente");
                return;
            }

            if(marcaTextBox.TextLength == 0 || modeloTextBox.TextLength == 0 || matriculaTextBox.TextLength == 0 || numeroChassisTextBox.TextLength == 0 || kmsTextBox.TextLength == 0 || combustivelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            
            CarroOficina novoCarroOficina = new CarroOficina(marcaTextBox.Text, modeloTextBox.Text, matriculaTextBox.Text, numeroChassisTextBox.Text, kmsTextBox.Text, combustivelComboBox.Text);
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            
            clienteSelecionado.CarrosOficina.Add(novoCarroOficina);

            BDStand.SaveChanges();

            FormOficina formOficina = new FormOficina(indexCliente);

            this.Hide();
            formOficina.Show();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if (clienteSelecionado != null)
            {
                labelNomeCliente.Text = clienteSelecionado.Nome;
            }
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormOficina formoficina = new FormOficina(indexCliente);
            this.Hide();
            formoficina.Show();
        }

        private void panelCarroTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }

        private void panelCarroTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }

        private void panelCarroTop_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }
    }
}
