using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAutomoveis
{
    public partial class FormAluguer : Form
    {
        public FormAluguer()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Close();

            forminicial.Show();
        }

        private void buttonOficinaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente formcliente = new FormCliente();

            formcliente.ShowDialog();
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

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCarroAluguer formaddcarro = new FormAddCarroAluguer();

            formaddcarro.ShowDialog();
        }
    }
}
