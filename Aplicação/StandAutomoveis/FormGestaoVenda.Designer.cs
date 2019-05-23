namespace StandAutomoveis
{
    partial class FormGestaoVenda
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
            System.Windows.Forms.Label combustivelLabel1;
            System.Windows.Forms.Label extrasLabel;
            System.Windows.Forms.Label marcaLabel1;
            System.Windows.Forms.Label modeloLabel1;
            System.Windows.Forms.Label numeroChassisLabel1;
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.labelTituloForm1 = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.groupBoxCarros = new System.Windows.Forms.GroupBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteVenda = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.buttonEditCarro = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCriarVenda = new System.Windows.Forms.Button();
            this.numeroChassisTextBox1 = new System.Windows.Forms.TextBox();
            this.marcaTextBox1 = new System.Windows.Forms.TextBox();
            this.modeloTextBox1 = new System.Windows.Forms.TextBox();
            this.combustivelTextBox1 = new System.Windows.Forms.TextBox();
            this.extrasTextBox = new System.Windows.Forms.TextBox();
            combustivelLabel1 = new System.Windows.Forms.Label();
            extrasLabel = new System.Windows.Forms.Label();
            marcaLabel1 = new System.Windows.Forms.Label();
            modeloLabel1 = new System.Windows.Forms.Label();
            numeroChassisLabel1 = new System.Windows.Forms.Label();
            this.panelForm1.SuspendLayout();
            this.panelLeftCliente.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // combustivelLabel1
            // 
            combustivelLabel1.AutoSize = true;
            combustivelLabel1.Location = new System.Drawing.Point(19, 180);
            combustivelLabel1.Name = "combustivelLabel1";
            combustivelLabel1.Size = new System.Drawing.Size(67, 13);
            combustivelLabel1.TabIndex = 33;
            combustivelLabel1.Text = "Combustivel:";
            // 
            // extrasLabel
            // 
            extrasLabel.AutoSize = true;
            extrasLabel.Location = new System.Drawing.Point(19, 206);
            extrasLabel.Name = "extrasLabel";
            extrasLabel.Size = new System.Drawing.Size(39, 13);
            extrasLabel.TabIndex = 35;
            extrasLabel.Text = "Extras:";
            // 
            // marcaLabel1
            // 
            marcaLabel1.AutoSize = true;
            marcaLabel1.Location = new System.Drawing.Point(19, 128);
            marcaLabel1.Name = "marcaLabel1";
            marcaLabel1.Size = new System.Drawing.Size(40, 13);
            marcaLabel1.TabIndex = 39;
            marcaLabel1.Text = "Marca:";
            // 
            // modeloLabel1
            // 
            modeloLabel1.AutoSize = true;
            modeloLabel1.Location = new System.Drawing.Point(19, 154);
            modeloLabel1.Name = "modeloLabel1";
            modeloLabel1.Size = new System.Drawing.Size(45, 13);
            modeloLabel1.TabIndex = 41;
            modeloLabel1.Text = "Modelo:";
            // 
            // numeroChassisLabel1
            // 
            numeroChassisLabel1.AutoSize = true;
            numeroChassisLabel1.Location = new System.Drawing.Point(19, 99);
            numeroChassisLabel1.Name = "numeroChassisLabel1";
            numeroChassisLabel1.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel1.TabIndex = 43;
            numeroChassisLabel1.Text = "Numero Chassis:";
            // 
            // panelForm1
            // 
            this.panelForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelForm1.Controls.Add(this.buttonExitApp);
            this.panelForm1.Controls.Add(this.labelTituloForm1);
            this.panelForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm1.Location = new System.Drawing.Point(0, 0);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(990, 65);
            this.panelForm1.TabIndex = 7;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.Location = new System.Drawing.Point(962, 3);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(25, 25);
            this.buttonExitApp.TabIndex = 7;
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // labelTituloForm1
            // 
            this.labelTituloForm1.AutoSize = true;
            this.labelTituloForm1.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloForm1.Location = new System.Drawing.Point(226, -1);
            this.labelTituloForm1.Name = "labelTituloForm1";
            this.labelTituloForm1.Size = new System.Drawing.Size(516, 66);
            this.labelTituloForm1.TabIndex = 6;
            this.labelTituloForm1.Text = "Stand Automóveis";
            // 
            // panelLeftCliente
            // 
            this.panelLeftCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCliente.Controls.Add(this.buttonGestaoClientes);
            this.panelLeftCliente.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCliente.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCliente.TabIndex = 8;
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonGestaoClientes.Location = new System.Drawing.Point(3, 49);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(79, 79);
            this.buttonGestaoClientes.TabIndex = 23;
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = true;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(3, 292);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonVendasCliente.TabIndex = 22;
            this.buttonVendasCliente.UseVisualStyleBackColor = true;
            // 
            // buttonOficinaCliente
            // 
            this.buttonOficinaCliente.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficinaCliente.Location = new System.Drawing.Point(3, 171);
            this.buttonOficinaCliente.Name = "buttonOficinaCliente";
            this.buttonOficinaCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonOficinaCliente.TabIndex = 20;
            this.buttonOficinaCliente.UseVisualStyleBackColor = true;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 71);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 402);
            this.groupBoxClientes.TabIndex = 9;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um cliente";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelClienteSelecionado);
            this.groupBox3.Controls.Add(this.labelNIFCliente);
            this.groupBox3.Controls.Add(this.labelValorTotalCliente);
            this.groupBox3.Controls.Add(this.labelMoradaCliente);
            this.groupBox3.Location = new System.Drawing.Point(314, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 92);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informação do cliente";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(6, 16);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(8, 45);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 8;
            this.labelNIFCliente.Text = "-";
            // 
            // labelValorTotalCliente
            // 
            this.labelValorTotalCliente.AutoSize = true;
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(541, 16);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(61, 13);
            this.labelValorTotalCliente.TabIndex = 10;
            this.labelValorTotalCliente.Text = "Valor Total:";
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(8, 62);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 9;
            this.labelMoradaCliente.Text = "-";
            // 
            // groupBoxCarros
            // 
            this.groupBoxCarros.Controls.Add(this.listBoxCarros);
            this.groupBoxCarros.Controls.Add(this.buttonDeleteVenda);
            this.groupBoxCarros.Controls.Add(this.buttonAddCarro);
            this.groupBoxCarros.Controls.Add(this.buttonEditCarro);
            this.groupBoxCarros.Location = new System.Drawing.Point(314, 169);
            this.groupBoxCarros.Name = "groupBoxCarros";
            this.groupBoxCarros.Size = new System.Drawing.Size(217, 304);
            this.groupBoxCarros.TabIndex = 32;
            this.groupBoxCarros.TabStop = false;
            this.groupBoxCarros.Text = "Compras do cliente";
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroVendaBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(205, 225);
            this.listBoxCarros.TabIndex = 23;
            // 
            // carroVendaBindingSource
            // 
            this.carroVendaBindingSource.DataSource = typeof(StandAutomoveis.CarroVenda);
            // 
            // buttonDeleteVenda
            // 
            this.buttonDeleteVenda.Location = new System.Drawing.Point(111, 273);
            this.buttonDeleteVenda.Name = "buttonDeleteVenda";
            this.buttonDeleteVenda.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteVenda.TabIndex = 27;
            this.buttonDeleteVenda.Text = "Apagar Venda";
            this.buttonDeleteVenda.UseVisualStyleBackColor = true;
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(6, 244);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(205, 23);
            this.buttonAddCarro.TabIndex = 25;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            // 
            // buttonEditCarro
            // 
            this.buttonEditCarro.Location = new System.Drawing.Point(6, 273);
            this.buttonEditCarro.Name = "buttonEditCarro";
            this.buttonEditCarro.Size = new System.Drawing.Size(100, 23);
            this.buttonEditCarro.TabIndex = 26;
            this.buttonEditCarro.Text = "Editar Carro";
            this.buttonEditCarro.UseVisualStyleBackColor = true;
            this.buttonEditCarro.Click += new System.EventHandler(this.buttonEditCarro_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonCriarVenda);
            this.groupBox4.Controls.Add(this.numeroChassisTextBox1);
            this.groupBox4.Controls.Add(numeroChassisLabel1);
            this.groupBox4.Controls.Add(this.marcaTextBox1);
            this.groupBox4.Controls.Add(this.modeloTextBox1);
            this.groupBox4.Controls.Add(modeloLabel1);
            this.groupBox4.Controls.Add(marcaLabel1);
            this.groupBox4.Controls.Add(this.combustivelTextBox1);
            this.groupBox4.Controls.Add(extrasLabel);
            this.groupBox4.Controls.Add(combustivelLabel1);
            this.groupBox4.Controls.Add(this.extrasTextBox);
            this.groupBox4.Location = new System.Drawing.Point(537, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 303);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserir uma nova venda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Data da venda:";
            // 
            // buttonCriarVenda
            // 
            this.buttonCriarVenda.Location = new System.Drawing.Point(6, 274);
            this.buttonCriarVenda.Name = "buttonCriarVenda";
            this.buttonCriarVenda.Size = new System.Drawing.Size(205, 23);
            this.buttonCriarVenda.TabIndex = 25;
            this.buttonCriarVenda.Text = "Registar Venda";
            this.buttonCriarVenda.UseVisualStyleBackColor = true;
            // 
            // numeroChassisTextBox1
            // 
            this.numeroChassisTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroVendaBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox1.Location = new System.Drawing.Point(111, 96);
            this.numeroChassisTextBox1.Name = "numeroChassisTextBox1";
            this.numeroChassisTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numeroChassisTextBox1.TabIndex = 44;
            // 
            // marcaTextBox1
            // 
            this.marcaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroVendaBindingSource, "Marca", true));
            this.marcaTextBox1.Location = new System.Drawing.Point(111, 125);
            this.marcaTextBox1.Name = "marcaTextBox1";
            this.marcaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox1.TabIndex = 40;
            // 
            // modeloTextBox1
            // 
            this.modeloTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroVendaBindingSource, "Modelo", true));
            this.modeloTextBox1.Location = new System.Drawing.Point(111, 151);
            this.modeloTextBox1.Name = "modeloTextBox1";
            this.modeloTextBox1.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox1.TabIndex = 42;
            // 
            // combustivelTextBox1
            // 
            this.combustivelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroVendaBindingSource, "Combustivel", true));
            this.combustivelTextBox1.Location = new System.Drawing.Point(111, 177);
            this.combustivelTextBox1.Name = "combustivelTextBox1";
            this.combustivelTextBox1.Size = new System.Drawing.Size(100, 20);
            this.combustivelTextBox1.TabIndex = 34;
            // 
            // extrasTextBox
            // 
            this.extrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroVendaBindingSource, "Extras", true));
            this.extrasTextBox.Location = new System.Drawing.Point(111, 203);
            this.extrasTextBox.Name = "extrasTextBox";
            this.extrasTextBox.Size = new System.Drawing.Size(100, 20);
            this.extrasTextBox.TabIndex = 36;
            // 
            // FormGestaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxCarros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.panelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestaoVenda";
            this.Text = "FormGestãoVenda";
            this.panelForm1.ResumeLayout(false);
            this.panelForm1.PerformLayout();
            this.panelLeftCliente.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxCarros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Label labelTituloForm1;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Button buttonVendasCliente;
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelValorTotalCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBoxCarros;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonDeleteVenda;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.Button buttonEditCarro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCriarVenda;
        private System.Windows.Forms.BindingSource carroVendaBindingSource;
        private System.Windows.Forms.TextBox combustivelTextBox1;
        private System.Windows.Forms.TextBox extrasTextBox;
        private System.Windows.Forms.TextBox marcaTextBox1;
        private System.Windows.Forms.TextBox modeloTextBox1;
        private System.Windows.Forms.TextBox numeroChassisTextBox1;
    }
}