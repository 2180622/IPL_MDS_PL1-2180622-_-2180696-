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

        public FormAddCarroOficina()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
        }

        private void buttonAddCarroOficina_Click(object sender, EventArgs e)
        {
            CarroOficina novoCarroOficina = new CarroOficina(marcaTextBox.Text, modeloTextBox.Text, matriculaTextBox.Text, numeroChassisTextBox.Text, kmsTextBox.Text, combustivelTextBox.Text);
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            FormOficina formOficina = new FormOficina();

            clienteSelecionado.CarrosOficina.Add(novoCarroOficina);

            BDStand.SaveChanges();

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
            FormOficina formoficina = new FormOficina();
            this.Hide();
            formoficina.Show();
        }
    }
}
