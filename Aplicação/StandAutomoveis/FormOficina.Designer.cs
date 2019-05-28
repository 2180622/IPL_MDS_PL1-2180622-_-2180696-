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
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
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
            this.dataEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBoxParcela = new System.Windows.Forms.GroupBox();
            this.buttonAddParcelas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            dataEntradaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            this.groupBoxServicos.SuspendLayout();
            this.groupBoxParcela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.panelLeftCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntradaLabel
            // 
            dataEntradaLabel.AutoSize = true;
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
            valorLabel.Location = new System.Drawing.Point(400, 86);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 3;
            // 
            // buttonOficinaCliente
            // 
            this.buttonOficinaCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOficinaCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonOficinaCliente.Location = new System.Drawing.Point(0, 8);
            this.buttonOficinaCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOficinaCliente.Name = "buttonOficinaCliente";
            this.buttonOficinaCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonOficinaCliente.TabIndex = 23;
            this.buttonOficinaCliente.Text = "Clientes";
            this.buttonOficinaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficinaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOficinaCliente.UseVisualStyleBackColor = false;
            this.buttonOficinaCliente.Click += new System.EventHandler(this.buttonOficinaCliente_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(8, 26);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(272, 468);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(121, 80);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClientes.Size = new System.Drawing.Size(289, 502);
            this.groupBoxClientes.TabIndex = 6;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(419, 172);
            this.groupBoxAdicionarCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(283, 410);
            this.groupBoxAdicionarCarro.TabIndex = 11;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(7, 372);
            this.buttonAddCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(271, 31);
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
            this.listBoxCarros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(269, 340);
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
            this.groupBoxServicos.Controls.Add(dataEntradaLabel);
            this.groupBoxServicos.Controls.Add(this.dataEntradaDateTimePicker);
            this.groupBoxServicos.Controls.Add(dataSaidaLabel);
            this.groupBoxServicos.Controls.Add(this.dataSaidaDateTimePicker);
            this.groupBoxServicos.Controls.Add(tipoLabel);
            this.groupBoxServicos.Controls.Add(this.tipoTextBox);
            this.groupBoxServicos.Controls.Add(this.buttonAddServico);
            this.groupBoxServicos.Controls.Add(this.listBoxServicos);
            this.groupBoxServicos.Location = new System.Drawing.Point(709, 123);
            this.groupBoxServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxServicos.Size = new System.Drawing.Size(595, 278);
            this.groupBoxServicos.TabIndex = 12;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Criar Serviço";
            // 
            // dataEntradaDateTimePicker
            // 
            this.dataEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataEntrada", true));
            this.dataEntradaDateTimePicker.Location = new System.Drawing.Point(111, 180);
            this.dataEntradaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEntradaDateTimePicker.Name = "dataEntradaDateTimePicker";
            this.dataEntradaDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dataEntradaDateTimePicker.TabIndex = 5;
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(111, 212);
            this.dataSaidaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dataSaidaDateTimePicker.TabIndex = 7;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(379, 185);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(207, 22);
            this.tipoTextBox.TabIndex = 11;
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.Location = new System.Drawing.Point(17, 244);
            this.buttonAddServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(569, 31);
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
            this.listBoxServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(579, 148);
            this.listBoxServicos.TabIndex = 0;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // groupBoxParcela
            // 
            this.groupBoxParcela.Controls.Add(this.buttonAddParcelas);
            this.groupBoxParcela.Controls.Add(this.listBox1);
            this.groupBoxParcela.Controls.Add(descricaoLabel);
            this.groupBoxParcela.Controls.Add(this.descricaoTextBox);
            this.groupBoxParcela.Controls.Add(valorLabel);
            this.groupBoxParcela.Controls.Add(this.valorTextBox);
            this.groupBoxParcela.Location = new System.Drawing.Point(709, 409);
            this.groupBoxParcela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParcela.Name = "groupBoxParcela";
            this.groupBoxParcela.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxParcela.Size = new System.Drawing.Size(595, 174);
            this.groupBoxParcela.TabIndex = 13;
            this.groupBoxParcela.TabStop = false;
            this.groupBoxParcela.Text = "Inserir Parcelas";
            // 
            // buttonAddParcelas
            // 
            this.buttonAddParcelas.Location = new System.Drawing.Point(379, 138);
            this.buttonAddParcelas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddParcelas.Name = "buttonAddParcelas";
            this.buttonAddParcelas.Size = new System.Drawing.Size(208, 28);
            this.buttonAddParcelas.TabIndex = 9;
            this.buttonAddParcelas.Text = "Adicionar Parcela";
            this.buttonAddParcelas.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 148);
            this.listBox1.TabIndex = 8;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(453, 31);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(132, 22);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // parcelaBindingSource
            // 
            this.parcelaBindingSource.DataSource = typeof(StandAutomoveis.Parcela);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(453, 82);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(132, 22);
            this.valorTextBox.TabIndex = 7;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(StandAutomoveis.Venda);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.wrench_512;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(992, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources._72_200;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(249, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 11;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(329, -2);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(672, 84);
            this.labelTituloCliente.TabIndex = 10;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelLeftCliente
            // 
            this.panelLeftCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCliente.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCliente.Controls.Add(this.buttonAluguerCliente);
            this.panelLeftCliente.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCliente.Controls.Add(this.buttonExitApp);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCliente.TabIndex = 24;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(0, 250);
            this.buttonVendasCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonVendasCliente.TabIndex = 22;
            this.buttonVendasCliente.Text = "Vendas";
            this.buttonVendasCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVendasCliente.UseVisualStyleBackColor = false;
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(0, 129);
            this.buttonAluguerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonAluguerCliente.TabIndex = 21;
            this.buttonAluguerCliente.Text = "Alugueres";
            this.buttonAluguerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguerCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAluguerCliente.UseVisualStyleBackColor = false;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExitApp.Location = new System.Drawing.Point(4, 461);
            this.buttonExitApp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(105, 31);
            this.buttonExitApp.TabIndex = 11;
            this.buttonExitApp.Text = "Sair";
            this.buttonExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExitApp.UseVisualStyleBackColor = true;
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.groupBoxParcela);
            this.Controls.Add(this.groupBoxServicos);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.labelValorTotalCliente);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOficina";
            this.Text = "FormCarro";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.panelLeftCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
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
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.DateTimePicker dataEntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.GroupBox groupBoxParcela;
        private System.Windows.Forms.Button buttonAddParcelas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.BindingSource parcelaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.Button buttonVendasCliente;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Button buttonExitApp;
    }
}