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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public void buttonGestaoClientes_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();

            this.Hide();
            formcliente.ShowDialog();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGestaoOficina_Click(object sender, EventArgs e)
        {
            FormOficina formOficina = new FormOficina();

            this.Hide();
            formOficina.ShowDialog();
        }

        private void buttonGestaoVendas_Click(object sender, EventArgs e)
        { 
            FormVenda formvenda = new FormVenda();

            this.Hide();
            formvenda.ShowDialog();
        }

        private void buttonGestaoAluguer_Click(object sender, EventArgs e)
        {
            FormAluguer formaluguer = new FormAluguer();

            this.Hide();
            formaluguer.ShowDialog();
        }
    }
}
