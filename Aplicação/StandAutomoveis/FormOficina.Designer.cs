namespace StandAutomoveis
{
    partial class FormOficina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataEntradaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAluguer = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
            this.buttonDelCarro = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxServicos = new System.Windows.Forms.GroupBox();
            this.buttonDelServico = new System.Windows.Forms.Button();
            this.dataEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBoxParcela = new System.Windows.Forms.GroupBox();
            this.buttonRemoveParcela = new System.Windows.Forms.Button();
            this.buttonAddParcelas = new System.Windows.Forms.Button();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            dataEntradaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelLeftCarro.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            this.groupBoxServicos.SuspendLayout();
            this.groupBoxParcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).BeginInit();
            this.panelCarroTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntradaLabel
            // 
            dataEntradaLabel.AutoSize = true;
            dataEntradaLabel.BackColor = System.Drawing.Color.Transparent;
            dataEntradaLabel.Location = new System.Drawing.Point(13, 185);
            dataEntradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataEntradaLabel.Name = "dataEntradaLabel";
            dataEntradaLabel.Size = new System.Drawing.Size(96, 17);
            dataEntradaLabel.TabIndex = 4;
            dataEntradaLabel.Text = "Data Entrada:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.BackColor = System.Drawing.Color.Transparent;
            dataSaidaLabel.Location = new System.Drawing.Point(13, 217);
            dataSaidaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(82, 17);
            dataSaidaLabel.TabIndex = 6;
            dataSaidaLabel.Text = "Data Saida:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Location = new System.Drawing.Point(329, 188);
            tipoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(40, 17);
            tipoLabel.TabIndex = 10;
            tipoLabel.Text = "Tipo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.Location = new System.Drawing.Point(368, 34);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(75, 17);
            descricaoLabel.TabIndex = 0;
            descricaoLabel.Text = "Descricao:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(400, 86);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Controls.Add(this.panel4);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCarro.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCarro.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panel4.Controls.Add(this.buttonCliente);
            this.panel4.Controls.Add(this.buttonAluguer);
            this.panel4.Controls.Add(this.buttonVenda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 505);
            this.panel4.TabIndex = 7;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(0, 8);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonCliente.TabIndex = 27;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonAluguer
            // 
            this.buttonAluguer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAluguer.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguer.Location = new System.Drawing.Point(0, 129);
            this.buttonAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluguer.Name = "buttonAluguer";
            this.buttonAluguer.Size = new System.Drawing.Size(113, 113);
            this.buttonAluguer.TabIndex = 26;
            this.buttonAluguer.Text = "Aluguer";
            this.buttonAluguer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguer.UseVisualStyleBackColor = false;
            this.buttonAluguer.Click += new System.EventHandler(this.buttonAluguer_Click);
            // 
            // buttonVenda
            // 
            this.buttonVenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVenda.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVenda.Location = new System.Drawing.Point(0, 250);
            this.buttonVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(113, 113);
            this.buttonVenda.TabIndex = 24;
            this.buttonVenda.Text = "Vendas";
            this.buttonVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVenda.UseVisualStyleBackColor = false;
            this.buttonVenda.Click += new System.EventHandler(this.buttonVenda_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(8, 21);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(272, 452);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(121, 88);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Size = new System.Drawing.Size(289, 486);
            this.groupBoxClientes.TabIndex = 6;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonDelCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(419, 172);
            this.groupBoxAdicionarCarro.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(283, 402);
            this.groupBoxAdicionarCarro.TabIndex = 11;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonDelCarro
            // 
            this.buttonDelCarro.Location = new System.Drawing.Point(148, 355);
            this.buttonDelCarro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelCarro.Name = "buttonDelCarro";
            this.buttonDelCarro.Size = new System.Drawing.Size(127, 31);
            this.buttonDelCarro.TabIndex = 2;
            this.buttonDelCarro.Text = "Remover Carro";
            this.buttonDelCarro.UseVisualStyleBackColor = true;
            this.buttonDelCarro.Click += new System.EventHandler(this.buttonDelCarro_Click);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(6, 355);
            this.buttonAddCarro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(127, 31);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.ItemHeight = 16;
            this.listBoxCarros.Location = new System.Drawing.Point(7, 23);
            this.listBoxCarros.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(269, 324);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(StandAutomoveis.CarroOficina);
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(419, 84);
            this.labelClienteSelecionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(370, 36);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(421, 119);
            this.labelNIFCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(15, 20);
            this.labelNIFCliente.TabIndex = 8;
            this.labelNIFCliente.Text = "-";
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(421, 140);
            this.labelMoradaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(15, 20);
            this.labelMoradaCliente.TabIndex = 9;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelValorTotalCliente
            // 
            this.labelValorTotalCliente.AutoSize = true;
            this.labelValorTotalCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(1151, 98);
            this.labelValorTotalCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(81, 17);
            this.labelValorTotalCliente.TabIndex = 10;
            this.labelValorTotalCliente.Text = "Valor Total:";
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataSource = typeof(StandAutomoveis.Servico);
            // 
            // groupBoxServicos
            // 
            this.groupBoxServicos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxServicos.Controls.Add(this.buttonDelServico);
            this.groupBoxServicos.Controls.Add(dataEntradaLabel);
            this.groupBoxServicos.Controls.Add(this.dataEntradaDateTimePicker);
            this.groupBoxServicos.Controls.Add(dataSaidaLabel);
            this.groupBoxServicos.Controls.Add(this.dataSaidaDateTimePicker);
            this.groupBoxServicos.Controls.Add(tipoLabel);
            this.groupBoxServicos.Controls.Add(this.tipoTextBox);
            this.groupBoxServicos.Controls.Add(this.buttonAddServico);
            this.groupBoxServicos.Controls.Add(this.listBoxServicos);
            this.groupBoxServicos.Location = new System.Drawing.Point(709, 123);
            this.groupBoxServicos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxServicos.Size = new System.Drawing.Size(595, 278);
            this.groupBoxServicos.TabIndex = 12;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Criar Serviço";
            // 
            // buttonDelServico
            // 
            this.buttonDelServico.Location = new System.Drawing.Point(301, 244);
            this.buttonDelServico.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelServico.Name = "buttonDelServico";
            this.buttonDelServico.Size = new System.Drawing.Size(293, 31);
            this.buttonDelServico.TabIndex = 12;
            this.buttonDelServico.Text = "Remover Serviço";
            this.buttonDelServico.UseVisualStyleBackColor = true;
            this.buttonDelServico.Click += new System.EventHandler(this.buttonDelServico_Click);
            // 
            // dataEntradaDateTimePicker
            // 
            this.dataEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataEntrada", true));
            this.dataEntradaDateTimePicker.Location = new System.Drawing.Point(111, 180);
            this.dataEntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataEntradaDateTimePicker.Name = "dataEntradaDateTimePicker";
            this.dataEntradaDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dataEntradaDateTimePicker.TabIndex = 5;
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(111, 212);
            this.dataSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dataSaidaDateTimePicker.TabIndex = 7;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(379, 185);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(207, 22);
            this.tipoTextBox.TabIndex = 11;
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddServico.Location = new System.Drawing.Point(7, 244);
            this.buttonAddServico.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(293, 31);
            this.buttonAddServico.TabIndex = 1;
            this.buttonAddServico.Text = "Criar Serviço";
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.buttonAddServico_Click);
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.DataSource = this.servicosBindingSource;
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.ItemHeight = 16;
            this.listBoxServicos.Location = new System.Drawing.Point(7, 23);
            this.listBoxServicos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(579, 148);
            this.listBoxServicos.TabIndex = 0;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // groupBoxParcela
            // 
            this.groupBoxParcela.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxParcela.Controls.Add(this.buttonRemoveParcela);
            this.groupBoxParcela.Controls.Add(this.buttonAddParcelas);
            this.groupBoxParcela.Controls.Add(this.listBoxParcelas);
            this.groupBoxParcela.Controls.Add(descricaoLabel);
            this.groupBoxParcela.Controls.Add(this.descricaoTextBox);
            this.groupBoxParcela.Controls.Add(valorLabel);
            this.groupBoxParcela.Controls.Add(this.valorTextBox);
            this.groupBoxParcela.Location = new System.Drawing.Point(709, 409);
            this.groupBoxParcela.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParcela.Name = "groupBoxParcela";
            this.groupBoxParcela.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParcela.Size = new System.Drawing.Size(595, 166);
            this.groupBoxParcela.TabIndex = 13;
            this.groupBoxParcela.TabStop = false;
            this.groupBoxParcela.Text = "Inserir Parcelas";
            // 
            // buttonRemoveParcela
            // 
            this.buttonRemoveParcela.Location = new System.Drawing.Point(485, 112);
            this.buttonRemoveParcela.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveParcela.Name = "buttonRemoveParcela";
            this.buttonRemoveParcela.Size = new System.Drawing.Size(100, 43);
            this.buttonRemoveParcela.TabIndex = 10;
            this.buttonRemoveParcela.Text = "Remover Parcela";
            this.buttonRemoveParcela.UseVisualStyleBackColor = true;
            // 
            // buttonAddParcelas
            // 
            this.buttonAddParcelas.Location = new System.Drawing.Point(379, 112);
            this.buttonAddParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddParcelas.Name = "buttonAddParcelas";
            this.buttonAddParcelas.Size = new System.Drawing.Size(100, 43);
            this.buttonAddParcelas.TabIndex = 9;
            this.buttonAddParcelas.Text = "Adicionar Parcela";
            this.buttonAddParcelas.UseVisualStyleBackColor = true;
            this.buttonAddParcelas.Click += new System.EventHandler(this.buttonAddParcelas_Click);
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.DataSource = this.parcelaBindingSource;
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.ItemHeight = 16;
            this.listBoxParcelas.Location = new System.Drawing.Point(8, 23);
            this.listBoxParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(351, 132);
            this.listBoxParcelas.TabIndex = 8;
            // 
            // parcelaBindingSource
            // 
            this.parcelaBindingSource.DataSource = typeof(StandAutomoveis.Parcela);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(453, 31);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(132, 22);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(453, 82);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(132, 22);
            this.valorTextBox.TabIndex = 7;
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonExitForm);
            this.panel1.Controls.Add(this.labelTituloCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 80);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Oficina";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_job_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 81);
            this.panel5.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(995, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 81);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(247, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 81);
            this.panel3.TabIndex = 12;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitForm.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitForm.Location = new System.Drawing.Point(1239, 0);
            this.buttonExitForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(81, 81);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = false;
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click_1);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39F, System.Drawing.FontStyle.Bold);
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(316, -4);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(644, 80);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.groupBoxParcela);
            this.Controls.Add(this.groupBoxServicos);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.labelValorTotalCliente);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOficina";
            this.Text = "FormCarro";
            this.panelLeftCarro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            this.groupBoxServicos.ResumeLayout(false);
            this.groupBoxServicos.PerformLayout();
            this.groupBoxParcela.ResumeLayout(false);
            this.groupBoxParcela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).EndInit();
            this.panelCarroTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelValorTotalCliente;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAdicionarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.GroupBox groupBoxServicos;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.DateTimePicker dataEntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.GroupBox groupBoxParcela;
        private System.Windows.Forms.Button buttonAddParcelas;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource parcelaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button buttonDelCarro;
        private System.Windows.Forms.Button buttonDelServico;
        private System.Windows.Forms.Button buttonRemoveParcela;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAluguer;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}