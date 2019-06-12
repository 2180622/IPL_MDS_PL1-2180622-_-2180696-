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

            // "Transporta" o cliente selecionado de form para form
            if(BDStand.Clientes.Count() != 0)
            {
                listBoxClientes.SelectedIndex = indexCliente;
            }
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
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            if (clienteSelecionado != null)
            {

                // atualiza as labels de acordo com o cliente selecionado
                labelClienteSelecionado.Text = clienteSelecionado.Nome;
                labelNIFCliente.Text = clienteSelecionado.NIF;
                labelMoradaCliente.Text = clienteSelecionado.Morada;
                if(servicoSelecionado == null)
                {
                    labelValorTotalCliente.Text = "Total do serviço: 0€";
                }

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
            //Verificação
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
            // Adiciona o serviço à base de dados e ao respetivo carro selecionado
            carroSelecionado.Servicos.Add(novoServico);
            BDStand.SaveChanges();

            listBoxServicos.DataSource = null;
            listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();

            tipoTextBox.Text = "";
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
                    labelValorTotalCliente.Text = "Total do serviço: " + servicoSelecionado.Parcelas.Sum(soma => soma.Valor).ToString() + "€";
                }
            }

        }

        private void buttonAddParcelas_Click(object sender, EventArgs e)
        {   
            //Verificação
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
            //Atualiza a label com o valor total do serviço
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            labelValorTotalCliente.Text = "Total do serviço: " + servicoSelecionado.Parcelas.Sum(soma => soma.Valor).ToString() + "€";
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

            // Verifica se há serviços e/ou parcelas associadas ao carro. Caso nao haja remove o carro selecionado
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
                    if (servicoSelecionado != null)
                    {
                        // Cria uma lista de acordo com a lista de serviços associada ao carro
                        List<Servico> listaServicos = carroSelecionado.Servicos.ToList();
                        // Percorre a lista de serviços criada
                        foreach(Servico servico in listaServicos)
                        {
                            if (parcelaSelecionada != null)
                            {
                                // Cria lista de parcelas de acordo com a lista de parcelas associada ao serviço
                                List<Parcela> listaParcelas = servico.Parcelas.ToList();
                                // Percorre a lista de parcelas
                                foreach(Parcela parcela in listaParcelas)
                                {
                                    // Remove todas as parcelas que encontra relacionadas com o serviço selecionado
                                    BDStand.Parcelas.Remove(parcela);
                                }
                            }
                            // Remove todos os serviços que encontra relacionadas com o carro selecionado
                            BDStand.Servicos.Remove(servico);
                        }
                    }
                    // Remove o carro depois de ter eliminado os serviços e parcelas associadas
                    clienteSelecionado.CarrosOficina.Remove((CarroOficina)listBoxCarros.SelectedItem);
                    BDStand.Carros.Remove((CarroOficina)listBoxCarros.SelectedItem);
                    // Grava alterações
                    BDStand.SaveChanges();

                    // Refresh
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
            // Verifica se há parcelas associadas ao serviço. Caso nao haja remove o serviço selecionado
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
                    if(parcelaSelecionada != null)
                    {
                        // Percorre a lista de parcelas
                        List<Parcela> listaParcelas = servicoSelecionado.Parcelas.ToList();
                        // Remove todas as parcelas que encontra relacionadas com o serviço selecionado
                        foreach (Parcela parcela in listaParcelas)
                        {
                            BDStand.Parcelas.Remove(parcela);
                        }
                    }

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
            // Remove a parcela selecionada
            servicoSelecionado.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);
            BDStand.Parcelas.Remove((Parcela)listBoxParcelas.SelectedItem);

            BDStand.SaveChanges();

            listBoxParcelas.DataSource = null;
            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();

            // Atualiza a label para o valor com o total das parcelas do serviço selecionado
            labelValorTotalCliente.Text = "Total do serviço: " + servicoSelecionado.Parcelas.Sum(soma => soma.Valor).ToString() + "€";
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
            // Info do cliente e o carro que está a usar
            GuardaFicheiro.WriteLine(clienteSelecionado + "| Carro: " + carroSelecionado.Marca + " " + carroSelecionado.Modelo);
            GuardaFicheiro.WriteLine("________________________________________________________");
            
            // Percorre todos os serviços do cliente selecionado
            foreach (Servico servicos in carroSelecionado.Servicos)
            {
                // 
                GuardaFicheiro.WriteLine("Efetuada a: " + dataEntradaDateTimePicker.Value.ToString());
                GuardaFicheiro.WriteLine("\n");

                foreach (Parcela linhaDeCompra in servicos.Parcelas)
                {
                    GuardaFicheiro.WriteLine("-" + linhaDeCompra.ToString());
                }
                GuardaFicheiro.WriteLine("\n\n Total: " + servicos.Parcelas.Sum(soma => soma.Valor).ToString() + "€");
                GuardaFicheiro.WriteLine("________________________________________________________");
            }

            MessageBox.Show("Fatura imprimida");
            GuardaFicheiro.Close();
        }
    }
}
