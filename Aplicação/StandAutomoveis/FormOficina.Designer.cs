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
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
            this.buttonDelCarro = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.parcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dataEntradaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelLeftCarro.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxAdicionarCarro.SuspendLayout();
            this.groupBoxServicos.SuspendLayout();
            this.groupBoxParcela.SuspendLayout();
            this.panelCarroTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEntradaLabel
            // 
            dataEntradaLabel.AutoSize = true;
            dataEntradaLabel.BackColor = System.Drawing.Color.Transparent;
            dataEntradaLabel.Location = new System.Drawing.Point(10, 150);
            dataEntradaLabel.Name = "dataEntradaLabel";
            dataEntradaLabel.Size = new System.Drawing.Size(73, 13);
            dataEntradaLabel.TabIndex = 4;
            dataEntradaLabel.Text = "Data Entrada:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.BackColor = System.Drawing.Color.Transparent;
            dataSaidaLabel.Location = new System.Drawing.Point(10, 176);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(63, 13);
            dataSaidaLabel.TabIndex = 6;
            dataSaidaLabel.Text = "Data Saida:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Location = new System.Drawing.Point(247, 153);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 10;
            tipoLabel.Text = "Tipo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.Location = new System.Drawing.Point(276, 28);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 0;
            descricaoLabel.Text = "Descricao:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(300, 70);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Controls.Add(this.panel4);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 410);
            this.panel4.TabIndex = 7;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(0, 6);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(85, 92);
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
            this.buttonAluguer.Location = new System.Drawing.Point(0, 105);
            this.buttonAluguer.Name = "buttonAluguer";
            this.buttonAluguer.Size = new System.Drawing.Size(85, 92);
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
            this.buttonVenda.Location = new System.Drawing.Point(0, 203);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(85, 92);
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
            this.listBoxClientes.Location = new System.Drawing.Point(6, 17);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(205, 368);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 72);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 395);
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
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(314, 140);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(212, 327);
            this.groupBoxAdicionarCarro.TabIndex = 11;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonDelCarro
            // 
            this.buttonDelCarro.Location = new System.Drawing.Point(111, 292);
            this.buttonDelCarro.Name = "buttonDelCarro";
            this.buttonDelCarro.Size = new System.Drawing.Size(95, 25);
            this.buttonDelCarro.TabIndex = 2;
            this.buttonDelCarro.Text = "Remover Carro";
            this.buttonDelCarro.UseVisualStyleBackColor = true;
            this.buttonDelCarro.Click += new System.EventHandler(this.buttonDelCarro_Click);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(5, 292);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(95, 25);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(5, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(203, 264);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(314, 68);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(316, 97);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 8;
            this.labelNIFCliente.Text = "-";
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(316, 114);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 9;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelValorTotalCliente
            // 
            this.labelValorTotalCliente.AutoSize = true;
            this.labelValorTotalCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(863, 80);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(61, 13);
            this.labelValorTotalCliente.TabIndex = 10;
            this.labelValorTotalCliente.Text = "Valor Total:";
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
            this.groupBoxServicos.Location = new System.Drawing.Point(532, 100);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Size = new System.Drawing.Size(446, 226);
            this.groupBoxServicos.TabIndex = 12;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Criar Serviço";
            // 
            // buttonDelServico
            // 
            this.buttonDelServico.Location = new System.Drawing.Point(226, 198);
            this.buttonDelServico.Name = "buttonDelServico";
            this.buttonDelServico.Size = new System.Drawing.Size(220, 25);
            this.buttonDelServico.TabIndex = 12;
            this.buttonDelServico.Text = "Remover Serviço";
            this.buttonDelServico.UseVisualStyleBackColor = true;
            this.buttonDelServico.Click += new System.EventHandler(this.buttonDelServico_Click);
            // 
            // dataEntradaDateTimePicker
            // 
            this.dataEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataEntrada", true));
            this.dataEntradaDateTimePicker.Location = new System.Drawing.Point(83, 146);
            this.dataEntradaDateTimePicker.Name = "dataEntradaDateTimePicker";
            this.dataEntradaDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.dataEntradaDateTimePicker.TabIndex = 5;
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(83, 172);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.dataSaidaDateTimePicker.TabIndex = 7;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(284, 150);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(156, 20);
            this.tipoTextBox.TabIndex = 11;
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddServico.Location = new System.Drawing.Point(5, 198);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(220, 25);
            this.buttonAddServico.TabIndex = 1;
            this.buttonAddServico.Text = "Criar Serviço";
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.buttonAddServico_Click);
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.DataSource = this.servicosBindingSource;
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(5, 19);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(435, 121);
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
            this.groupBoxParcela.Location = new System.Drawing.Point(532, 332);
            this.groupBoxParcela.Name = "groupBoxParcela";
            this.groupBoxParcela.Size = new System.Drawing.Size(446, 135);
            this.groupBoxParcela.TabIndex = 13;
            this.groupBoxParcela.TabStop = false;
            this.groupBoxParcela.Text = "Inserir Parcelas";
            // 
            // buttonRemoveParcela
            // 
            this.buttonRemoveParcela.Location = new System.Drawing.Point(364, 91);
            this.buttonRemoveParcela.Name = "buttonRemoveParcela";
            this.buttonRemoveParcela.Size = new System.Drawing.Size(75, 35);
            this.buttonRemoveParcela.TabIndex = 10;
            this.buttonRemoveParcela.Text = "Remover Parcela";
            this.buttonRemoveParcela.UseVisualStyleBackColor = true;
            this.buttonRemoveParcela.Click += new System.EventHandler(this.buttonRemoveParcela_Click);
            // 
            // buttonAddParcelas
            // 
            this.buttonAddParcelas.Location = new System.Drawing.Point(284, 91);
            this.buttonAddParcelas.Name = "buttonAddParcelas";
            this.buttonAddParcelas.Size = new System.Drawing.Size(75, 35);
            this.buttonAddParcelas.TabIndex = 9;
            this.buttonAddParcelas.Text = "Adicionar Parcela";
            this.buttonAddParcelas.UseVisualStyleBackColor = true;
            this.buttonAddParcelas.Click += new System.EventHandler(this.buttonAddParcelas_Click);
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.DataSource = this.parcelaBindingSource;
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(6, 19);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(264, 108);
            this.listBoxParcelas.TabIndex = 8;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(340, 25);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(340, 67);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 65);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Oficina";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_job_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 66);
            this.panel5.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(746, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 66);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(185, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 66);
            this.panel3.TabIndex = 12;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitForm.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitForm.Location = new System.Drawing.Point(929, 0);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(61, 66);
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
            this.labelTituloCliente.Location = new System.Drawing.Point(237, -3);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(522, 65);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(757, 75);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 22);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "Imprimir Fatura";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // parcelaBindingSource
            // 
            this.parcelaBindingSource.DataSource = typeof(StandAutomoveis.Parcela);
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataSource = typeof(StandAutomoveis.Servico);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(StandAutomoveis.CarroOficina);
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.buttonPrint);
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
            this.Name = "FormOficina";
            this.Text = "FormCarro";
            this.panelLeftCarro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            this.groupBoxServicos.ResumeLayout(false);
            this.groupBoxServicos.PerformLayout();
            this.groupBoxParcela.ResumeLayout(false);
            this.groupBoxParcela.PerformLayout();
            this.panelCarroTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonPrint;
    }
}