namespace StandAutomoveis
{
    partial class FormVenda
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label extrasLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonOficina = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.carroVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.groupBoxVendas = new System.Windows.Forms.GroupBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extrasTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddVenda = new System.Windows.Forms.Button();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            combustivelLabel = new System.Windows.Forms.Label();
            extrasLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(267, 62);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(42, 17);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "Data:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(267, 90);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 15;
            estadoLabel.Text = "Estado:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(267, 122);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 19;
            valorLabel.Text = "Valor:";
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(267, 250);
            combustivelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(88, 17);
            combustivelLabel.TabIndex = 20;
            combustivelLabel.Text = "Combustivel:";
            // 
            // extrasLabel
            // 
            extrasLabel.AutoSize = true;
            extrasLabel.Location = new System.Drawing.Point(267, 282);
            extrasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            extrasLabel.Name = "extrasLabel";
            extrasLabel.Size = new System.Drawing.Size(51, 17);
            extrasLabel.TabIndex = 22;
            extrasLabel.Text = "Extras:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(267, 218);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 26;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(267, 186);
            modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 28;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(267, 154);
            numeroChassisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(115, 17);
            numeroChassisLabel.TabIndex = 30;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelTituloCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 80);
            this.panel1.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_price_tag_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 81);
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(972, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 81);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(247, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 81);
            this.panel3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1239, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 81);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(316, -4);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(672, 84);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitForm.Location = new System.Drawing.Point(1287, 0);
            this.buttonExitForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(33, 31);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = true;
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click);
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
            this.panelLeftCarro.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panel4.Controls.Add(this.buttonOficina);
            this.panel4.Controls.Add(this.buttonCliente);
            this.panel4.Controls.Add(this.buttonAluguerCliente);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 505);
            this.panel4.TabIndex = 8;
            // 
            // buttonOficina
            // 
            this.buttonOficina.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(0, 129);
            this.buttonOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(113, 113);
            this.buttonOficina.TabIndex = 28;
            this.buttonOficina.Text = "Oficina";
            this.buttonOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficina.UseVisualStyleBackColor = false;
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
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(0, 250);
            this.buttonAluguerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonAluguerCliente.TabIndex = 26;
            this.buttonAluguerCliente.Text = "Aluguer";
            this.buttonAluguerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguerCliente.UseVisualStyleBackColor = false;
            // 
            // carroVendaBindingSource
            // 
            this.carroVendaBindingSource.DataSource = typeof(StandAutomoveis.CarroVenda);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(117, 84);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Size = new System.Drawing.Size(289, 485);
            this.groupBoxClientes.TabIndex = 7;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(8, 17);
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
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(417, 140);
            this.labelMoradaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(15, 20);
            this.labelMoradaCliente.TabIndex = 17;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(417, 119);
            this.labelNIFCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(15, 20);
            this.labelNIFCliente.TabIndex = 16;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(415, 84);
            this.labelClienteSelecionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(370, 36);
            this.labelClienteSelecionado.TabIndex = 15;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupBoxVendas
            // 
            this.groupBoxVendas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVendas.Controls.Add(this.listBoxCarros);
            this.groupBoxVendas.Controls.Add(combustivelLabel);
            this.groupBoxVendas.Controls.Add(this.combustivelTextBox);
            this.groupBoxVendas.Controls.Add(extrasLabel);
            this.groupBoxVendas.Controls.Add(this.extrasTextBox);
            this.groupBoxVendas.Controls.Add(marcaLabel);
            this.groupBoxVendas.Controls.Add(this.marcaTextBox);
            this.groupBoxVendas.Controls.Add(modeloLabel);
            this.groupBoxVendas.Controls.Add(this.modeloTextBox);
            this.groupBoxVendas.Controls.Add(numeroChassisLabel);
            this.groupBoxVendas.Controls.Add(this.numeroChassisTextBox);
            this.groupBoxVendas.Controls.Add(dataLabel);
            this.groupBoxVendas.Controls.Add(this.dataDateTimePicker);
            this.groupBoxVendas.Controls.Add(estadoLabel);
            this.groupBoxVendas.Controls.Add(this.estadoTextBox);
            this.groupBoxVendas.Controls.Add(valorLabel);
            this.groupBoxVendas.Controls.Add(this.valorTextBox);
            this.groupBoxVendas.Controls.Add(this.buttonAddVenda);
            this.groupBoxVendas.Controls.Add(this.listBoxVendas);
            this.groupBoxVendas.Location = new System.Drawing.Point(415, 165);
            this.groupBoxVendas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVendas.Name = "groupBoxVendas";
            this.groupBoxVendas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVendas.Size = new System.Drawing.Size(889, 404);
            this.groupBoxVendas.TabIndex = 18;
            this.groupBoxVendas.TabStop = false;
            this.groupBoxVendas.Text = "Criar Venda";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroVendaBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.ItemHeight = 16;
            this.listBoxCarros.Location = new System.Drawing.Point(603, 23);
            this.listBoxCarros.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(277, 372);
            this.listBoxCarros.TabIndex = 32;
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CarroVenda.Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(387, 246);
            this.combustivelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(207, 22);
            this.combustivelTextBox.TabIndex = 21;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(StandAutomoveis.Venda);
            // 
            // extrasTextBox
            // 
            this.extrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CarroVenda.Extras", true));
            this.extrasTextBox.Location = new System.Drawing.Point(387, 278);
            this.extrasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.extrasTextBox.Name = "extrasTextBox";
            this.extrasTextBox.Size = new System.Drawing.Size(207, 22);
            this.extrasTextBox.TabIndex = 23;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CarroVenda.Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(387, 214);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(207, 22);
            this.marcaTextBox.TabIndex = 27;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CarroVenda.Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(387, 182);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(207, 22);
            this.modeloTextBox.TabIndex = 29;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CarroVenda.NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(387, 150);
            this.numeroChassisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(207, 22);
            this.numeroChassisTextBox.TabIndex = 31;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(387, 53);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(207, 22);
            this.dataDateTimePicker.TabIndex = 14;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(387, 86);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(207, 22);
            this.estadoTextBox.TabIndex = 16;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(387, 118);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(207, 22);
            this.valorTextBox.TabIndex = 20;
            // 
            // buttonAddVenda
            // 
            this.buttonAddVenda.Location = new System.Drawing.Point(271, 338);
            this.buttonAddVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddVenda.Name = "buttonAddVenda";
            this.buttonAddVenda.Size = new System.Drawing.Size(324, 39);
            this.buttonAddVenda.TabIndex = 11;
            this.buttonAddVenda.Text = "Criar Venda";
            this.buttonAddVenda.UseVisualStyleBackColor = true;
            this.buttonAddVenda.Click += new System.EventHandler(this.buttonAddVenda_Click);
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.DataSource = this.vendaBindingSource;
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.ItemHeight = 16;
            this.listBoxVendas.Location = new System.Drawing.Point(7, 23);
            this.listBoxVendas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(255, 372);
            this.listBoxVendas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Venda";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.groupBoxVendas);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.panelCarroTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLeftCarro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBoxVendas.ResumeLayout(false);
            this.groupBoxVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.BindingSource carroVendaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.GroupBox groupBoxVendas;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.Button buttonAddVenda;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox extrasTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Button buttonOficina;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}