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
    public partial class FormAddCarroAluguer : Form
    {
        public BDStandContainer BDStand;

        public string matricula;
        public string marca;
        public string modelo;
        public string numeroChassis;
        public string combustivel;
        public string estado;
        bool MoverForm;
        int eixoX;
        int eixoY;
        int indexCliente;

        public FormAddCarroAluguer()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            aluguerBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
        }

        private void buttonAddCarroAluguer_Click(object sender, EventArgs e)
        {
            if (combustivelComboBox.SelectedIndex == -1 || estadoComboBox.SelectedIndex == -1 || marcaTextBox.TextLength == 0 || matriculaTextBox.TextLength == 0  || modeloTextBox.TextLength == 0 || numeroChassisTextBox.TextLength == 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            CarroAluguer novoCarroAluguer = new CarroAluguer(combustivelComboBox.Text, estadoComboBox.Text, marcaTextBox.Text, matriculaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            BDStand.Carros.Add(novoCarroAluguer);

            BDStand.SaveChanges();

            this.Hide();

            FormAluguer formAluguer = new FormAluguer(indexCliente);
            formAluguer.Show();
        }


        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormAluguer formaluguer = new FormAluguer(indexCliente);
            this.Hide();
            formaluguer.Show();
        }

        private void panelCarroTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }

        private void panelCarroTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(MoverForm == true)
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
