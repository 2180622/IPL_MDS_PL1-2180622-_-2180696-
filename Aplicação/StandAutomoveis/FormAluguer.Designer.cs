namespace StandAutomoveis
{
    partial class FormAluguer
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
            System.Windows.Forms.Label dataFimLabel;
            System.Windows.Forms.Label dataInicioLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label valorLabel;
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAluguerCarros = new System.Windows.Forms.GroupBox();
            this.buttonCloseAluguer = new System.Windows.Forms.Button();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddAluguer = new System.Windows.Forms.Button();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOficina = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCarroAlugado = new System.Windows.Forms.Label();
            dataFimLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxAluguerCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.panelLeftCarro.SuspendLayout();
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(241, 58);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(52, 13);
            dataFimLabel.TabIndex = 5;
            dataFimLabel.Text = "Data Fim:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(241, 19);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(61, 13);
            dataInicioLabel.TabIndex = 7;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(244, 148);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 11;
            kmsLabel.Text = "Kms:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(244, 102);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 72);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 393);
            this.groupBoxClientes.TabIndex = 7;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(7, 28);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(205, 355);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxAluguerClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(316, 114);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 12;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(316, 97);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 11;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(314, 68);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 10;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(455, 17);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(194, 264);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // groupBoxAluguerCarros
            // 
            this.groupBoxAluguerCarros.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAluguerCarros.Controls.Add(this.buttonCloseAluguer);
            this.groupBoxAluguerCarros.Controls.Add(this.kmsTextBox);
            this.groupBoxAluguerCarros.Controls.Add(kmsLabel);
            this.groupBoxAluguerCarros.Controls.Add(this.buttonAddAluguer);
            this.groupBoxAluguerCarros.Controls.Add(dataFimLabel);
            this.groupBoxAluguerCarros.Controls.Add(this.dataFimDateTimePicker);
            this.groupBoxAluguerCarros.Controls.Add(dataInicioLabel);
            this.groupBoxAluguerCarros.Controls.Add(this.dataInicioDateTimePicker);
            this.groupBoxAluguerCarros.Controls.Add(valorLabel);
            this.groupBoxAluguerCarros.Controls.Add(this.valorTextBox);
            this.groupBoxAluguerCarros.Controls.Add(this.buttonAddCarro);
            this.groupBoxAluguerCarros.Controls.Add(this.listBoxCarros);
            this.groupBoxAluguerCarros.Controls.Add(this.listBoxAlugueres);
            this.groupBoxAluguerCarros.Location = new System.Drawing.Point(319, 133);
            this.groupBoxAluguerCarros.Name = "groupBoxAluguerCarros";
            this.groupBoxAluguerCarros.Size = new System.Drawing.Size(662, 332);
            this.groupBoxAluguerCarros.TabIndex = 14;
            this.groupBoxAluguerCarros.TabStop = false;
            this.groupBoxAluguerCarros.Text = "Lista de Alugueres e Carros";
            // 
            // buttonCloseAluguer
            // 
            this.buttonCloseAluguer.Location = new System.Drawing.Point(244, 287);
            this.buttonCloseAluguer.Name = "buttonCloseAluguer";
            this.buttonCloseAluguer.Size = new System.Drawing.Size(200, 25);
            this.buttonCloseAluguer.TabIndex = 16;
            this.buttonCloseAluguer.Text = "Fechar Aluguer";
            this.buttonCloseAluguer.UseVisualStyleBackColor = true;
            this.buttonCloseAluguer.Click += new System.EventHandler(this.buttonCloseAluguer_Click);
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(244, 164);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(200, 20);
            this.kmsTextBox.TabIndex = 12;
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // buttonAddAluguer
            // 
            this.buttonAddAluguer.Location = new System.Drawing.Point(244, 190);
            this.buttonAddAluguer.Name = "buttonAddAluguer";
            this.buttonAddAluguer.Size = new System.Drawing.Size(200, 23);
            this.buttonAddAluguer.TabIndex = 15;
            this.buttonAddAluguer.Text = "Adicionar Aluguer";
            this.buttonAddAluguer.UseVisualStyleBackColor = true;
            this.buttonAddAluguer.Click += new System.EventHandler(this.buttonAddAluguer_Click);
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aluguerBindingSource, "DataFim", true));
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(244, 74);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataFimDateTimePicker.TabIndex = 6;
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aluguerBindingSource, "DataInicio", true));
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(244, 35);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataInicioDateTimePicker.TabIndex = 8;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aluguerBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(244, 118);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorTextBox.TabIndex = 14;
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(455, 287);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(194, 25);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DisplayMember = "Combustivel";
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(6, 19);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(232, 303);
            this.listBoxAlugueres.TabIndex = 0;
            this.listBoxAlugueres.ValueMember = "Combustivel";
            this.listBoxAlugueres.SelectedIndexChanged += new System.EventHandler(this.listBoxAlugueres_SelectedIndexChanged);
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(StandAutomoveis.CarroAluguer);
            // 
            // buttonOficina
            // 
            this.buttonOficina.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(0, 105);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(85, 92);
            this.buttonOficina.TabIndex = 22;
            this.buttonOficina.Text = "Oficina";
            this.buttonOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficina.UseVisualStyleBackColor = false;
            this.buttonOficina.Click += new System.EventHandler(this.buttonAluguerCliente_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(0, 6);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(85, 92);
            this.buttonCliente.TabIndex = 23;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonOficinaCliente_Click);
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
            this.buttonVenda.Click += new System.EventHandler(this.buttonVendasCliente_Click);
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelLeftCarro.Controls.Add(this.buttonVenda);
            this.panelLeftCarro.Controls.Add(this.buttonCliente);
            this.panelLeftCarro.Controls.Add(this.buttonOficina);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCarro.TabIndex = 5;
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
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(185, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 66);
            this.panel1.TabIndex = 12;
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
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelCarroTop.Controls.Add(this.label1);
            this.panelCarroTop.Controls.Add(this.panel5);
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 4;
            this.panelCarroTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCarroTop_MouseDown);
            this.panelCarroTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCarroTop_MouseMove);
            this.panelCarroTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCarroTop_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Menu Aluguer";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_car_rental_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(2, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 66);
            this.panel5.TabIndex = 15;
            // 
            // labelCarroAlugado
            // 
            this.labelCarroAlugado.AutoSize = true;
            this.labelCarroAlugado.BackColor = System.Drawing.Color.Transparent;
            this.labelCarroAlugado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelCarroAlugado.Location = new System.Drawing.Point(630, 68);
            this.labelCarroAlugado.Name = "labelCarroAlugado";
            this.labelCarroAlugado.Size = new System.Drawing.Size(236, 29);
            this.labelCarroAlugado.TabIndex = 15;
            this.labelCarroAlugado.Text = "Sem carro Alugado";
            // 
            // FormAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.labelCarroAlugado);
            this.Controls.Add(this.groupBoxAluguerCarros);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAluguer";
            this.Text = "FormAluguer";
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBoxAluguerCarros.ResumeLayout(false);
            this.groupBoxAluguerCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.panelLeftCarro.ResumeLayout(false);
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBoxAluguerCarros;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
        private System.Windows.Forms.Button buttonAddAluguer;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.Button buttonOficina;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCloseAluguer;
        private System.Windows.Forms.Label labelCarroAlugado;
    }
}