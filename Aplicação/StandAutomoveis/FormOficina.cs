﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAutomoveis
{
    public partial class FormOficina : Form
    {
        public BDStandContainer BDStand; 

        public FormOficina()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
        }

        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            // fecha o form e abre o menu inicial
            FormInicial forminicial = new FormInicial();

            this.Close();
            forminicial.ShowDialog();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if(clienteSelecionado != null)
            {
                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;

                // Limpa listBox dos serviços e parcelas
                listBoxServicos.DataSource = null;
                listBoxParcelas.DataSource = null;
                // Adicionar CarroOficina à listbox
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();

            }
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            // instancia um novo form para adicionar o carro
            FormAddCarroOficina formaddcarro = new FormAddCarroOficina();
            CarroOficina novoCarroOficina = new CarroOficina(formaddcarro.marca, formaddcarro.modelo, formaddcarro.matricula, formaddcarro.numeroChassis, formaddcarro.kms, formaddcarro.combustivel);

            this.Hide();
            formaddcarro.ShowDialog();

            if (clienteSelecionado != null)
            {
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxClientes.SelectedIndex == -1)
            {
                return;
            }

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            if (carroSelecionado != null)
            {
                listBoxParcelas.DataSource = null;

                listBoxServicos.DataSource = null;
                listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
            }
            
        }

        private void buttonAddServico_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
            {
                return;
            }

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico novoServico = new Servico(tipoTextBox.Text, dataEntradaDateTimePicker.Value, dataSaidaDateTimePicker.Value);
            int indexCarro = listBoxCarros.SelectedIndex;
            
            carroSelecionado.Servicos.Add(novoServico);
            BDStand.SaveChanges();

            listBoxServicos.DataSource = null;
            listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();

            listBoxCarros.SelectedIndex = indexCarro;
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            if(servicoSelecionado != null)
            {
                listBoxParcelas.DataSource = null;

                if(servicoSelecionado.Parcelas != null)
                {
                    listBoxParcelas.DataSource=servicoSelecionado.Parcelas.ToList();
                }
            }
        }

        private void buttonAddParcelas_Click(object sender, EventArgs e)
        {   
            // Vai buscar o serviço e instancia uma nova parcela
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            int indexServico = listBoxServicos.SelectedIndex;

            Parcela novaParcela = new Parcela(Decimal.Parse(valorTextBox.Text), descricaoTextBox.Text);
<<<<<<< HEAD

=======
>>>>>>> 7049352b2916de32a8fef3dce1b5c17236f26726
            if(servicoSelecionado.Parcelas != null)
            {
                // Adiciona a nova parcela às parcelas na
                servicoSelecionado.Parcelas.Add(novaParcela);
            }
            
            // Guarda as alterações
            BDStand.SaveChanges();
            
            // "Refresh" da listbox das parcelas
            if(servicoSelecionado != null)
            {
                listBoxParcelas.DataSource = null;
                listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
                
            }

            listBoxServicos.SelectedIndex = indexServico;
            // Reset as textboxes dentro da groupBoxParcela
            valorTextBox.Text = "";
            descricaoTextBox.Text = "";
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
    }


}
