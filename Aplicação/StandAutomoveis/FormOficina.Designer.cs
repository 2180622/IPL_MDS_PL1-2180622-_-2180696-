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
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxServicos = new System.Windows.Forms.GroupBox();
            this.dataEntradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            dataEntradaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            this.groupBoxServicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntradaLabel
            // 
            dataEntradaLabel.AutoSize = true;
            dataEntradaLabel.Location = new System.Drawing.Point(6, 233);
            dataEntradaLabel.Name = "dataEntradaLabel";
            dataEntradaLabel.Size = new System.Drawing.Size(73, 13);
            dataEntradaLabel.TabIndex = 14;
            dataEntradaLabel.Text = "Data Entrada:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(6, 259);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(63, 13);
            dataSaidaLabel.TabIndex = 16;
            dataSaidaLabel.Text = "Data Saida:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(6, 283);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 20;
            tipoLabel.Text = "Tipo:";
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 3;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitForm.Location = new System.Drawing.Point(962, 3);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(25, 25);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = true;
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(226, -1);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(516, 66);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Controls.Add(this.buttonAluguerCliente);
            this.panelLeftCarro.Controls.Add(this.buttonGestaoClientes);
            this.panelLeftCarro.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCarro.TabIndex = 4;
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(3, 165);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonAluguerCliente.TabIndex = 27;
            this.buttonAluguerCliente.UseVisualStyleBackColor = true;
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonGestaoClientes.Location = new System.Drawing.Point(3, 51);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(79, 79);
            this.buttonGestaoClientes.TabIndex = 26;
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = true;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(3, 285);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonVendasCliente.TabIndex = 25;
            this.buttonVendasCliente.UseVisualStyleBackColor = true;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 21);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(205, 368);
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
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 71);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 399);
            this.groupBoxClientes.TabIndex = 6;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um cliente";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(314, 137);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(217, 333);
            this.groupBoxAdicionarCarro.TabIndex = 11;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(5, 302);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(206, 25);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroOficinaBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(5, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(206, 277);
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
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataSource = typeof(StandAutomoveis.Servico);
            // 
            // groupBoxServicos
            // 
            this.groupBoxServicos.Controls.Add(this.dataEntradaDateTimePicker);
            this.groupBoxServicos.Controls.Add(this.dataSaidaDateTimePicker);
            this.groupBoxServicos.Controls.Add(dataEntradaLabel);
            this.groupBoxServicos.Controls.Add(this.buttonAddServico);
            this.groupBoxServicos.Controls.Add(dataSaidaLabel);
            this.groupBoxServicos.Controls.Add(this.listBoxServicos);
            this.groupBoxServicos.Controls.Add(tipoLabel);
            this.groupBoxServicos.Controls.Add(this.tipoTextBox);
            this.groupBoxServicos.Location = new System.Drawing.Point(537, 137);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Size = new System.Drawing.Size(244, 333);
            this.groupBoxServicos.TabIndex = 13;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Criar Serviço";
            // 
            // dataEntradaDateTimePicker
            // 
            this.dataEntradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataEntrada", true));
            this.dataEntradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEntradaDateTimePicker.Location = new System.Drawing.Point(95, 227);
            this.dataEntradaDateTimePicker.Name = "dataEntradaDateTimePicker";
            this.dataEntradaDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dataEntradaDateTimePicker.TabIndex = 15;
            this.dataEntradaDateTimePicker.Value = new System.DateTime(2019, 5, 22, 0, 0, 0, 0);
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicosBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(95, 253);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dataSaidaDateTimePicker.TabIndex = 17;
            this.dataSaidaDateTimePicker.Value = new System.DateTime(2019, 5, 22, 0, 0, 0, 0);
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.Location = new System.Drawing.Point(5, 302);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(234, 25);
            this.buttonAddServico.TabIndex = 1;
            this.buttonAddServico.Text = "Criar Serviços";
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.buttonAddServico_Click);
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.DataSource = this.servicosBindingSource;
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(5, 19);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(234, 199);
            this.listBoxServicos.TabIndex = 0;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(43, 280);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(195, 20);
            this.tipoTextBox.TabIndex = 21;
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(316, 118);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 9;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelValorTotalCliente
            // 
            this.labelValorTotalCliente.AutoSize = true;
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(853, 83);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(61, 13);
            this.labelValorTotalCliente.TabIndex = 10;
            this.labelValorTotalCliente.Text = "Valor Total:";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(316, 100);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 8;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(314, 71);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.groupBoxServicos);
            this.Controls.Add(this.labelValorTotalCliente);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOficina";
            this.Text = "FormCarro";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.panelLeftCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            this.groupBoxServicos.ResumeLayout(false);
            this.groupBoxServicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAdicionarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Button buttonVendasCliente;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.GroupBox groupBoxServicos;
        private System.Windows.Forms.DateTimePicker dataEntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelValorTotalCliente;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.BindingSource carroBindingSource;
    }
}