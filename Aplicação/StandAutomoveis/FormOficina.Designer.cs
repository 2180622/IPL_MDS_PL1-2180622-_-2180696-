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
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
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
            dataEntradaLabel.Location = new System.Drawing.Point(10, 150);
            dataEntradaLabel.Name = "dataEntradaLabel";
            dataEntradaLabel.Size = new System.Drawing.Size(73, 13);
            dataEntradaLabel.TabIndex = 4;
            dataEntradaLabel.Text = "Data Entrada:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(10, 176);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(63, 13);
            dataSaidaLabel.TabIndex = 6;
            dataSaidaLabel.Text = "Data Saida:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(247, 153);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 10;
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
            this.buttonExitForm.Location = new System.Drawing.Point(965, 0);
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
            this.panelLeftCarro.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCarro.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCarro.Controls.Add(this.buttonAluguerCliente);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCarro.TabIndex = 4;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(3, 292);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonVendasCliente.TabIndex = 24;
            this.buttonVendasCliente.UseVisualStyleBackColor = true;
            this.buttonVendasCliente.Click += new System.EventHandler(this.buttonVendasCliente_Click);
            // 
            // buttonOficinaCliente
            // 
            this.buttonOficinaCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonOficinaCliente.Location = new System.Drawing.Point(3, 52);
            this.buttonOficinaCliente.Name = "buttonOficinaCliente";
            this.buttonOficinaCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonOficinaCliente.TabIndex = 23;
            this.buttonOficinaCliente.UseVisualStyleBackColor = true;
            this.buttonOficinaCliente.Click += new System.EventHandler(this.buttonOficinaCliente_Click);
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(3, 171);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonAluguerCliente.TabIndex = 22;
            this.buttonAluguerCliente.UseVisualStyleBackColor = true;
            this.buttonAluguerCliente.Click += new System.EventHandler(this.buttonAluguerCliente_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 21);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(205, 381);
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
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 65);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 408);
            this.groupBoxClientes.TabIndex = 6;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(314, 140);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(212, 333);
            this.groupBoxAdicionarCarro.TabIndex = 11;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(5, 302);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(203, 25);
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
            this.listBoxCarros.Size = new System.Drawing.Size(203, 277);
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
            this.labelClienteSelecionado.Location = new System.Drawing.Point(314, 68);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
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
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(863, 80);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(61, 13);
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
            this.groupBoxServicos.Location = new System.Drawing.Point(532, 100);
            this.groupBoxServicos.Name = "groupBoxServicos";
            this.groupBoxServicos.Size = new System.Drawing.Size(446, 226);
            this.groupBoxServicos.TabIndex = 12;
            this.groupBoxServicos.TabStop = false;
            this.groupBoxServicos.Text = "Criar Serviço";
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
            this.buttonAddServico.Location = new System.Drawing.Point(13, 198);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(427, 25);
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
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 475);
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
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.Button buttonVendasCliente;
        private System.Windows.Forms.DateTimePicker dataEntradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.TextBox tipoTextBox;
    }
}