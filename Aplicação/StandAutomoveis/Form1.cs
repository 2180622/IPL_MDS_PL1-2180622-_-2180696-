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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGestaoClientes_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();

            formcliente.Show();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
