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
        public BDStandContainer BDStand;
        // Variáveis para poder arrastar o form
        bool MoverForm;
        int eixoX;
        int eixoY;

        int indexCliente;

        public FormInicial()
        {
            InitializeComponent();
            // Centrar a janela
            CenterToScreen();

            // Criar container para a base de dados
            BDStand = new BDStandContainer();

            // Funções para colocar a contagem de registos numa label no status strip
            clientesCountToolStripStatusLabel.Text = BDStand.Clientes.Count().ToString();
            carrosCountToolStripStatusLabel.Text = BDStand.Carros.Count().ToString();
            alugueresCountToolStripStatusLabel.Text = BDStand.Algueres.Count().ToString();
            vendasCountToolStripStatusLabel.Text = BDStand.Vendas.Count().ToString();
        }


        // Botões de atalho e fecho de janelas
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
            FormOficina formOficina = new FormOficina(indexCliente);

            this.Hide();
            formOficina.ShowDialog();
        }

        private void buttonGestaoVendas_Click(object sender, EventArgs e)
        {
            FormVenda formvenda = new FormVenda(indexCliente);

            this.Hide();
            formvenda.ShowDialog();
        }

        private void buttonGestaoAluguer_Click(object sender, EventArgs e)
        {
            FormAluguer formaluguer = new FormAluguer(indexCliente);

            this.Hide();
            formaluguer.ShowDialog();
        }

        private void buttonExitForm_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Label com as horas atuais
        private void timerHorasAtuais_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHoras.Text = DateTime.Now.ToString();
        }

        // Funções para tornar o form arrastável
        private void panelCarroTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }

        private void panelCarroTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }

        private void panelCarroTop_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }
    }
}














