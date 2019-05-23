using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StandAutomoveis
{
    public partial class FormCliente : Form
    {

        public BDStandContainer BDStand;

        public FormCliente()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
        }
        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Close();

            forminicial.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            BDStand.SaveChanges();
        }

        private void buttonOficinaCliente_Click(object sender, EventArgs e)
        {
            FormOficina formoficina = new FormOficina();

            formoficina.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
