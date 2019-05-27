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
            this.Hide();
            FormOficina formoficina = new FormOficina();

            formoficina.ShowDialog();
        }

        private void buttonAluguerCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAluguer formaluguer = new FormAluguer();

            formaluguer.ShowDialog();
        }

        private void buttonVendasCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenda formvenda = new FormVenda();

            formvenda.ShowDialog();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = true;
                BDStand.Dispose(); 
                BDStand = new BDStandContainer();

                (from cliente in BDStand.Clientes
                    where cliente.Nome.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                    orderby cliente.Nome
                    select cliente).ToList();

                clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                BDStand.Dispose();
                BDStand = new BDStandContainer();
                (from cliente in BDStand.Clientes
                    orderby cliente.Nome
                    select cliente).Load();

                clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }
    }
}
