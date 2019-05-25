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
    public partial class FormVenda : Form
    {
        public FormVenda()
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
    }
}
