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

            nomeTextBox.Enabled = false;
            nIFTextBox.Enabled = false;
            moradaTextBox.Enabled = false;
            contactoTextBox.Enabled = false;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.clienteDataGridView.SelectedRows)
            {
                clienteDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void toolStripButtonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.AddNew();
                BDStand.SaveChanges();

                nomeTextBox.Enabled = true;
                nIFTextBox.Enabled = true;
                moradaTextBox.Enabled = true;
                contactoTextBox.Enabled = true;

                contactoTextBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            nIFTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoTextBox.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            nIFTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoTextBox.Enabled = true;

            contactoTextBox.Text = "";
        }

        // delay de 1 keypress. Try to FIX!
        private void textBoxFiltrar_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Dispose();
            forminicial.ShowDialog();
        }

        private void buttonOficina_Click(object sender, EventArgs e)
        {
            FormOficina formoficina = new FormOficina();

            this.Dispose();
            formoficina.ShowDialog();
        }

        private void buttonAluguerCliente_Click_1(object sender, EventArgs e)
        {
            FormAluguer formaluguer = new FormAluguer();

            this.Dispose();
            formaluguer.ShowDialog();
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            FormVenda formvenda = new FormVenda();

            this.Dispose();
            formvenda.ShowDialog();
        }
    }
}
