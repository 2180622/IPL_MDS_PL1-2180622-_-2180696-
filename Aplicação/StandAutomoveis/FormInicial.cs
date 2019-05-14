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
        }

        private void buttonGestaoClientes_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();
            //FormInicial forminicial = new FormInicial();
            
            formcliente.Show();
            //forminicial.Enabled = false;
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGestaoOficina_Click(object sender, EventArgs e)
        {
            FormOficina formoficina = new FormOficina();
            //FormInicial forminicial = new FormInicial();

            formoficina.Show();
            //forminicial.Enable = false;
        }
    }
}
