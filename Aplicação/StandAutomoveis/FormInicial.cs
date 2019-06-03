﻿using System;
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
        
        bool MoverForm;
        int eixoX;
        int eixoY;

        public FormInicial()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            clientesCountToolStripStatusLabel.Text =  BDStand.Clientes.Count().ToString();
            carrosCountToolStripStatusLabel.Text = BDStand.Carros.Count().ToString();
            alugueresCountToolStripStatusLabel.Text = BDStand.Algueres.Count().ToString();
            vendasCountToolStripStatusLabel.Text = BDStand.Vendas.Count().ToString();
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

        private void buttonExitForm_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerHorasAtuais_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHoras.Text = DateTime.Now.ToString();
        }

        // Torna o form draggable
        private void panelCarroTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }
        // "
        private void panelCarroTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }
        // "
        private void panelCarroTop_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }
    }
}
