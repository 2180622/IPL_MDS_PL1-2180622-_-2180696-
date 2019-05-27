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
            CarroAluguer novoCarroAluguer = new CarroAluguer();
            Cliente clienteSelecionado = (Cliente)listBoxAluguer.SelectedItem;
            FormAluguer formAluguer = new FormAluguer();

            BDStand.Carros.Add(novoCarroAluguer);

            BDStand.SaveChanges();

            this.Close();

            formAluguer.ShowDialog();
        }
    }
}
