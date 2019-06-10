using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAutomoveis
{
    public partial class FormOficina : Form
    {
        public BDStandContainer BDStand;

        bool MoverForm;
        int eixoX;
        int eixoY;
        int indexCliente;

        public FormOficina(int indexCliente)
        {
            InitializeComponent();
            CenterToScreen();

            BDStand = new BDStandContainer();

            (from cliente in BDStand.Clientes
             orderby cliente.Nome
             select cliente).Load();

            (from carro in BDStand.Carros
             orderby carro.IdCarro
             select carro).Load();

            clienteBindingSource.DataSource = BDStand.Clientes.Local.ToBindingList();

            listBoxClientes.SelectedIndex = indexCliente;
        }

        private void buttonExitForm_Click_1(object sender, EventArgs e)
        {
            FormInicial forminicial = new FormInicial();

            this.Hide();

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
            if(listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione primeiro um cliente");
                return;
            }

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            indexCliente = listBoxClientes.SelectedIndex;
            // instancia um novo form para adicionar o carro
            FormAddCarroOficina formaddcarro = new FormAddCarroOficina(indexCliente);
            CarroOficina novoCarroOficina = new CarroOficina(formaddcarro.marca, formaddcarro.modelo, formaddcarro.matricula, formaddcarro.numeroChassis, formaddcarro.kms, formaddcarro.combustivel);

            if (clienteSelecionado != null)
            {
                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }

            this.Hide();
            formaddcarro.ShowDialog();            
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if(tipoTextBox.TextLength == 0)
            {
                MessageBox.Show("Preencha o campo 'tipo'");
                return;
            }

            if(dataEntradaDateTimePicker.Value > dataSaidaDateTimePicker.Value)
            {
                MessageBox.Show("A data de entrada não pode ser mais recente que a data de saída");
                return;
            }

            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
            {
                return;
            }

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico novoServico = new Servico(tipoTextBox.Text, dataEntradaDateTimePicker.Value, dataSaidaDateTimePicker.Value);
            
            carroSelecionado.Servicos.Add(novoServico);
            BDStand.SaveChanges();

            listBoxServicos.DataSource = null;
            listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            if(servicoSelecionado != null)
            {
                listBoxParcelas.DataSource = null;

                if(servicoSelecionado.Parcelas != null)
                {
                    listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
                }
            }
        }

        private void buttonAddParcelas_Click(object sender, EventArgs e)
        {   
            if(descricaoTextBox.TextLength == 0 || valorTextBox.TextLength == 0)
            {
                MessageBox.Show("Preencha os campos 'descrição' e 'valor'");
                return;
            }

            // Vai buscar o serviço e instancia uma nova parcela
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            int indexServico = listBoxServicos.SelectedIndex;

            Parcela novaParcela = new Parcela(Decimal.Parse(valorTextBox.Text), descricaoTextBox.Text);
            
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
            
            // Reset as textboxes dentro da groupBoxParcela
            valorTextBox.Text = "";
            descricaoTextBox.Text = "";

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            labelValorTotalCliente.Text = "Valor Total: " + clienteSelecionado.Total.ToString();
        }


        private void buttonDelCarro_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
            {
                return;
            }

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;

            if(servicoSelecionado == null && parcelaSelecionada == null)
            {
                clienteSelecionado.CarrosOficina.Remove((CarroOficina)listBoxCarros.SelectedItem);
                BDStand.Carros.Remove((Carro)listBoxCarros.SelectedItem);

                BDStand.SaveChanges();

                listBoxParcelas.DataSource = null;
                listBoxServicos.DataSource = null;

                listBoxCarros.DataSource = null;
                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            }
            else
            {
                if (MessageBox.Show("Os dados dos CARROS, SERVIÇOS E PARCELAS serão eliminados.\nDeseja continuar?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    clienteSelecionado.CarrosOficina.Remove((CarroOficina)listBoxCarros.SelectedItem);
                    BDStand.Carros.Remove((CarroOficina)listBoxCarros.SelectedItem);

                    if (servicoSelecionado != null)
                    {
                        carroSelecionado.Servicos.Remove((Servico)listBoxServicos.SelectedItem);
                        BDStand.Servicos.Remove((Servico)listBoxServicos.SelectedItem);
                    }
                    if(parcelaSelecionada != null)
                    {
                        servicoSelecionado.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);
                        BDStand.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);
                    }
                    
                    BDStand.SaveChanges();

                    listBoxParcelas.DataSource = null;
                    listBoxServicos.DataSource = null;

                    listBoxCarros.DataSource = null;
                    listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
                }
            }
        }

        private void buttonDelServico_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1 || listBoxServicos.SelectedIndex == -1)
            {
                return;
            }

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;

            if (parcelaSelecionada == null)
            {
                carroSelecionado.Servicos.Remove((Servico)listBoxServicos.SelectedItem);
                BDStand.Servicos.Remove((Servico)listBoxServicos.SelectedItem);

                BDStand.SaveChanges();

                listBoxServicos.DataSource = null;
                listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
            }
            else
            {
                if (MessageBox.Show("Os dados dos SERVIÇOS E PARCELAS serão eliminados.\nDeseja continuar?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    carroSelecionado.Servicos.Remove((Servico)listBoxServicos.SelectedItem);
                    BDStand.Servicos.Remove((Servico)listBoxServicos.SelectedItem);

                    servicoSelecionado.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);
                    BDStand.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);

                    BDStand.SaveChanges();

                    listBoxParcelas.DataSource = null;

                    listBoxServicos.DataSource = null;
                    listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
                }
            }

        }

        private void buttonRemoveParcela_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1 || listBoxServicos.SelectedIndex == -1 || listBoxParcelas.SelectedIndex == -1)
            {
                return;
            }

            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            servicoSelecionado.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);
            BDStand.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);

            BDStand.SaveChanges();

            listBoxParcelas.DataSource = null;
            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();
           
            this.Dispose();
            formcliente.ShowDialog();
        }

        private void buttonAluguer_Click(object sender, EventArgs e)
        {
            indexCliente = listBoxClientes.SelectedIndex;

            FormAluguer formaluguer = new FormAluguer(indexCliente);

            this.Dispose();
            formaluguer.ShowDialog();
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            indexCliente = listBoxClientes.SelectedIndex;

            FormVenda formvenda = new FormVenda(indexCliente);

            this.Dispose();
            formvenda.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm = true;
            eixoX = e.X;
            eixoY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverForm == true)
            {
                SetDesktopLocation(MousePosition.X - eixoX, MousePosition.Y - eixoY);
            }
        }
       
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverForm = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            StreamWriter GuardaFicheiro = new StreamWriter("FaturaDoCliente.txt");
            GuardaFicheiro.WriteLine(clienteSelecionado + "| Carro: " + carroSelecionado.Marca + " " + carroSelecionado.Modelo);
            GuardaFicheiro.WriteLine("________________________________________________________");
            
            foreach (Servico servicos in carroSelecionado.Servicos)
            {
                GuardaFicheiro.WriteLine("Efetuada a: " + dataSaidaDateTimePicker.Value.ToShortDateString());
                GuardaFicheiro.WriteLine("________________________________________________________");
                GuardaFicheiro.WriteLine(" ");

                foreach (Parcela linhaDeCompra in servicos.Parcelas)
                {
                    GuardaFicheiro.WriteLine("-" + linhaDeCompra.ToString());
                }
                GuardaFicheiro.WriteLine("Total: " + //servicos.Total + 
                    "€");
                GuardaFicheiro.WriteLine("________________________________________________________");
            }

            MessageBox.Show("Fatura imprimida");
            GuardaFicheiro.Close();
        }
    }
}
