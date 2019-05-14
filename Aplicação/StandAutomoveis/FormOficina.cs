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
    public partial class FormOficina : Form
    {
        public FormOficina()
        {
            InitializeComponent();
        }
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = clienteBindingSource;
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
