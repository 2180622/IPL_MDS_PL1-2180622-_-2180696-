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
            this.Hide();
            FormCliente formcliente = new FormCliente();
            
            formcliente.ShowDialog();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGestaoOficina_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOficina formOficina = new FormOficina();

            formOficina.ShowDialog();
        }
    }
}
