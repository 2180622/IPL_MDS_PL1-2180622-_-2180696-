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
            System.Windows.Forms.Label clienteIdClienteLabel;
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label idCarroLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.algueresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteIdClienteTextBox = new System.Windows.Forms.TextBox();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            clienteIdClienteLabel = new System.Windows.Forms.Label();
            combustivelLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algueresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.buttonExitForm.Location = new System.Drawing.Point(946, 3);
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
            this.labelTituloCliente.Location = new System.Drawing.Point(229, -1);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(516, 66);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 536);
            this.panelLeftCarro.TabIndex = 4;
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
            // algueresBindingSource
            // 
            this.algueresBindingSource.DataMember = "Algueres";
            this.algueresBindingSource.DataSource = this.clienteBindingSource;
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(StandAutomoveis.CarroOficina);
            // 
            // clienteIdClienteLabel
            // 
            clienteIdClienteLabel.AutoSize = true;
            clienteIdClienteLabel.Location = new System.Drawing.Point(512, 218);
            clienteIdClienteLabel.Name = "clienteIdClienteLabel";
            clienteIdClienteLabel.Size = new System.Drawing.Size(89, 13);
            clienteIdClienteLabel.TabIndex = 10;
            clienteIdClienteLabel.Text = "Cliente Id Cliente:";
            // 
            // clienteIdClienteTextBox
            // 
            this.clienteIdClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "ClienteIdCliente", true));
            this.clienteIdClienteTextBox.Location = new System.Drawing.Point(607, 215);
            this.clienteIdClienteTextBox.Name = "clienteIdClienteTextBox";
            this.clienteIdClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.clienteIdClienteTextBox.TabIndex = 11;
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(512, 244);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 12;
            combustivelLabel.Text = "Combustivel:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(607, 241);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.combustivelTextBox.TabIndex = 13;
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Location = new System.Drawing.Point(512, 270);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(47, 13);
            idCarroLabel.TabIndex = 14;
            idCarroLabel.Text = "Id Carro:";
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "IdCarro", true));
            this.idCarroTextBox.Location = new System.Drawing.Point(607, 267);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCarroTextBox.TabIndex = 15;
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(512, 296);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 16;
            kmsLabel.Text = "Kms:";
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(607, 293);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmsTextBox.TabIndex = 17;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(512, 322);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 18;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(607, 319);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 19;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(512, 348);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 20;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(607, 345);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 21;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(512, 374);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 22;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(607, 371);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 23;
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(512, 400);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 24;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(607, 397);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroChassisTextBox.TabIndex = 25;
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(512, 460);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 25;
            contactoLabel.Text = "Contacto:";
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Cliente.Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(572, 457);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 26;
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(512, 486);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 27;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Cliente.IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(572, 483);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 28;
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(512, 512);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 29;
            moradaLabel.Text = "Morada:";
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Cliente.Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(572, 509);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 30;
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(512, 538);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 31;
            nIFLabel.Text = "NIF:";
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Cliente.NIF", true));
            this.nIFTextBox.Location = new System.Drawing.Point(572, 535);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIFTextBox.TabIndex = 32;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(512, 564);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 33;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Cliente.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(572, 561);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 34;
            // 
            // FormOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 601);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nIFLabel);
            this.Controls.Add(this.nIFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(clienteIdClienteLabel);
            this.Controls.Add(this.clienteIdClienteTextBox);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(kmsLabel);
            this.Controls.Add(this.kmsTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algueresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource algueresBindingSource;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.TextBox clienteIdClienteTextBox;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox idCarroTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}