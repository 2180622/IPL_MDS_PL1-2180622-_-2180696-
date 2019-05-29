namespace StandAutomoveis
{
    partial class FormAddCarroAluguer
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
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.labelTituloForm1 = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddCarroAluguer = new System.Windows.Forms.Button();
            combustivelLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            this.panelForm1.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(321, 147);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 54;
            combustivelLabel.Text = "Combustivel:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(321, 182);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 56;
            estadoLabel.Text = "Estado:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(321, 217);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 60;
            marcaLabel.Text = "Marca:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(321, 252);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 62;
            matriculaLabel.Text = "Matricula:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(321, 287);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 64;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(321, 322);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 66;
            numeroChassisLabel.Text = "Numero Chassis:";
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
            this.panelForm1.TabIndex = 7;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.Location = new System.Drawing.Point(592, 3);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(25, 25);
            this.buttonExitApp.TabIndex = 7;
            this.buttonExitApp.UseVisualStyleBackColor = true;
            // 
            // labelTituloForm1
            // 
            this.labelTituloForm1.AutoSize = true;
            this.labelTituloForm1.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloForm1.Location = new System.Drawing.Point(51, 0);
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
            this.panelLeftCarro.TabIndex = 8;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.listBoxCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(91, 69);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(217, 410);
            this.groupBoxCliente.TabIndex = 53;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Selecione um cliente";
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.DataSource = this.aluguerBindingSource;
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.Location = new System.Drawing.Point(6, 21);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(205, 381);
            this.listBoxCliente.TabIndex = 5;
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxAluguer_SelectedIndexChanged);
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(StandAutomoveis.CarroAluguer);
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(413, 144);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(189, 20);
            this.combustivelTextBox.TabIndex = 55;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(413, 179);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(189, 20);
            this.estadoTextBox.TabIndex = 57;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(413, 214);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(189, 20);
            this.marcaTextBox.TabIndex = 61;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(413, 249);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(189, 20);
            this.matriculaTextBox.TabIndex = 63;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(413, 284);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(189, 20);
            this.modeloTextBox.TabIndex = 65;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(413, 319);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(189, 20);
            this.numeroChassisTextBox.TabIndex = 67;
            // 
            // buttonAddCarroAluguer
            // 
            this.buttonAddCarroAluguer.Location = new System.Drawing.Point(320, 401);
            this.buttonAddCarroAluguer.Name = "buttonAddCarroAluguer";
            this.buttonAddCarroAluguer.Size = new System.Drawing.Size(282, 29);
            this.buttonAddCarroAluguer.TabIndex = 68;
            this.buttonAddCarroAluguer.Text = "Adicionar Carro";
            this.buttonAddCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonAddCarroAluguer.Click += new System.EventHandler(this.buttonAddCarroAluguer_Click);
            // 
            // FormAddCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.buttonAddCarroAluguer);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCarroAluguer";
            this.Text = "FormAddCarroAluguer";
            this.panelForm1.ResumeLayout(false);
            this.panelForm1.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Label labelTituloForm1;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.Button buttonAddCarroAluguer;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
    }
}