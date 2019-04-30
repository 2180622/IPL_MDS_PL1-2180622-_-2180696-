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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public BDStandContainer BDStand;

        private void toolStripButtonGuardaAlteracoes_Click(object sender, EventArgs e)
        {

            Cliente novocliente = new Cliente();

            novocliente.Nome = textBoxNome.Text;
            novocliente.NIF = textBoxNIF.Text;
            novocliente.Morada = textBoxMorada.Text;
            novocliente.Contacto = int.Parse(textBoxContacto.Text);

            BDStand = new BDStandContainer();
            
            BDStand.Clientes.Add(novocliente);
            

            BDStand.SaveChanges();

            dataGridViewClientes.DataSource = BDStand.Clientes.ToList<Cliente>();

            dataGridViewClientes.Rows.Add(novocliente.Nome, novocliente.NIF);
        }
    }
}
