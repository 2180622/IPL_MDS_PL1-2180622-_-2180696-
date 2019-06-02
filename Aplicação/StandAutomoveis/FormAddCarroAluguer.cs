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
            CarroAluguer novoCarroAluguer = new CarroAluguer(combustivelTextBox.Text, estadoComboBox.Text, marcaTextBox.Text, matriculaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            BDStand.Carros.Add(novoCarroAluguer);

            BDStand.SaveChanges();

            this.Hide();

            FormAluguer formAluguer = new FormAluguer();
            formAluguer.Show();
        }


        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormAluguer formaluguer = new FormAluguer();
            this.Hide();
            formaluguer.Show();
        }
    }
}
