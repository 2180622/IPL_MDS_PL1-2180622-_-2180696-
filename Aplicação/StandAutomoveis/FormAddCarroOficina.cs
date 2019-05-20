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

        public FormAddCarroOficina()
        {
            InitializeComponent();

            BDStand = new BDStandContainer();

            (from carrooficina in BDStand.Clientes
             orderby carrooficina.Nome
             select carrooficina).Load();

            carroOficinaBindingSource.DataSource = BDStand.Carros.Local.ToBindingList();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddCarroOficina_Click(object sender, EventArgs e)
        {
            CarroOficina novoCarroOficina = new CarroOficina(marcaTextBox.Text, modeloTextBox.Text, matriculaTextBox.Text, numeroChassisTextBox.Text, kmsTextBox.Text, combustivelTextBox.Text);

            BDStand.Carros.Add(novoCarroOficina);
        }
    }
}
