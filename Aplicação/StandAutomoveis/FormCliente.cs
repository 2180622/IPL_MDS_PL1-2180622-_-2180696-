using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StandAutomoveis
{
    public partial class FormCliente : Form
    {

        public BDStandContainer BDStand;

        bool MoverForm;
        int eixoX;
        int eixoY;
        int indexCliente;

        public FormCliente()
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

            nomeTextBox.Enabled = false;
            nIFTextBox.Enabled = false;
            moradaTextBox.Enabled = false;
            contactoTextBox.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Ciclo que percorre toda a datagrid e elimina a selecionada
            foreach (DataGridViewRow item in this.clienteDataGridView.SelectedRows)
            {
                clienteDataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void toolStripButtonGravar_Click(object sender, EventArgs e)
        {
            //Verifica se há campos em branco nas textboxes
            if(nomeTextBox.TextLength == 0 || nIFTextBox.TextLength == 0 || contactoTextBox.TextLength ==0 || moradaTextBox.TextLength == 0)
            {
                MessageBox.Show("Não pode deixar campos em branco");
                return;
            }

            if (nIFTextBox.TextLength != 9 || contactoTextBox.TextLength != 9)
            {
                MessageBox.Show("O 'NIF' e o 'Contacto' necessitam de 9 dígitos");
            }

            try
            {
                clienteBindingSource.AddNew();
                BDStand.SaveChanges();

                nomeTextBox.Enabled = true;
                nIFTextBox.Enabled = true;
                moradaTextBox.Enabled = true;
                contactoTextBox.Enabled = true;

            }
            catch(Exception)
            {
                MessageBox.Show("Não foi possível guardar as alterações");
            }

            contactoTextBox.Text = "";
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            nIFTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoTextBox.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            nIFTextBox.Enabled = true;
            moradaTextBox.Enabled = true;
            contactoTextBox.Enabled = true;

            contactoTextBox.Text = "";
        }

        // delay de 1 keypress. Try to FIX!
        private void textBoxFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            //Verifica se há conteúdo na textbox para filtrar
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = true;
                BDStand.Dispose();
                BDStand = new BDStandContainer();

                // Faz uma pesquisa na base de dados pelos clientes com o mesmo nome do conteúdo da caixa de texto de filtrar
                (from cliente in BDStand.Clientes
                 where cliente.Nome.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                // Retorna todos os clientes para a datagridview
                BDStand.Dispose();
                BDStand = new BDStandContainer();
                (from cliente in BDStand.Clientes
                 orderby cliente.Nome
                 select cliente).Load();

                clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();
            }
        }

        // Funções para fechar e abrir janelas
        private void buttonExitForm_Click(object sender, EventArgs e)
        {
            // Fecha o form e volta ao menu inicial
            FormInicial forminicial = new FormInicial();

            this.Dispose();
            forminicial.ShowDialog();
        }

        private void buttonOficina_Click(object sender, EventArgs e)
        {
            // Vai para o menu da oficina
            FormOficina formoficina = new FormOficina(indexCliente);
            

            this.Dispose();
            formoficina.ShowDialog();
        }

        private void buttonAluguerCliente_Click_1(object sender, EventArgs e)
        {
            // Vai para o menu de aluguer
            FormAluguer formaluguer = new FormAluguer(indexCliente);

            this.Dispose();
            formaluguer.ShowDialog();
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            // Vai para o menu da venda
            FormVenda formvenda = new FormVenda(indexCliente);

            this.Dispose();
            formvenda.ShowDialog();
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
