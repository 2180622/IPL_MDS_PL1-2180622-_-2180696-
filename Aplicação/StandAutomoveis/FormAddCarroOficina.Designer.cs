namespace StandAutomoveis
{
    partial class FormAddCarroOficina
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
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.labelTituloForm1 = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.buttonAddCarroOficina = new System.Windows.Forms.Button();
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            combustivelLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            this.panelForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm1
            // 
            this.panelForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelForm1.Controls.Add(this.buttonExitApp);
            this.panelForm1.Controls.Add(this.labelTituloForm1);
            this.panelForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm1.Location = new System.Drawing.Point(0, 0);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(620, 65);
            this.panelForm1.TabIndex = 6;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.Location = new System.Drawing.Point(592, 3);
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
            this.labelTituloForm1.Location = new System.Drawing.Point(58, 0);
            this.labelTituloForm1.Name = "labelTituloForm1";
            this.labelTituloForm1.Size = new System.Drawing.Size(516, 66);
            this.labelTituloForm1.TabIndex = 6;
            this.labelTituloForm1.Text = "Stand Automóveis";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 415);
            this.panelLeftCarro.TabIndex = 7;
            // 
            // buttonAddCarroOficina
            // 
            this.buttonAddCarroOficina.Location = new System.Drawing.Point(325, 399);
            this.buttonAddCarroOficina.Name = "buttonAddCarroOficina";
            this.buttonAddCarroOficina.Size = new System.Drawing.Size(278, 29);
            this.buttonAddCarroOficina.TabIndex = 34;
            this.buttonAddCarroOficina.Text = "Adicionar carro";
            this.buttonAddCarroOficina.UseVisualStyleBackColor = true;
            this.buttonAddCarroOficina.Click += new System.EventHandler(this.buttonAddCarroOficina_Click);
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(StandAutomoveis.CarroOficina);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 71);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 408);
            this.groupBoxClientes.TabIndex = 53;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
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
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelNomeCliente.Location = new System.Drawing.Point(319, 92);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(99, 31);
            this.labelNomeCliente.TabIndex = 54;
            this.labelNomeCliente.Text = "Cliente";
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(322, 175);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 56;
            combustivelLabel.Text = "Combustivel:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(417, 172);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(186, 20);
            this.combustivelTextBox.TabIndex = 57;
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(322, 201);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 60;
            kmsLabel.Text = "Kms:";
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(417, 198);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(186, 20);
            this.kmsTextBox.TabIndex = 61;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(322, 227);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 62;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(417, 224);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(186, 20);
            this.marcaTextBox.TabIndex = 63;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(322, 253);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 64;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(417, 250);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(186, 20);
            this.matriculaTextBox.TabIndex = 65;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(322, 279);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 66;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(417, 276);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(186, 20);
            this.modeloTextBox.TabIndex = 67;
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(322, 305);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 68;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(417, 302);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(186, 20);
            this.numeroChassisTextBox.TabIndex = 69;
            // 
            // FormAddCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
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
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.buttonAddCarroOficina);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCarroOficina";
            this.Text = "FormAddCarroOficina";
            this.panelForm1.ResumeLayout(false);
            this.panelForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Label labelTituloForm1;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.Button buttonAddCarroOficina;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
    }
}