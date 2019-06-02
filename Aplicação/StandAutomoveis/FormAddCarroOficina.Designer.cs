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
            this.buttonAddCarroOficina = new System.Windows.Forms.Button();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            combustivelLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.BackColor = System.Drawing.Color.Transparent;
            combustivelLabel.Location = new System.Drawing.Point(431, 169);
            combustivelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(88, 17);
            combustivelLabel.TabIndex = 37;
            combustivelLabel.Text = "Combustivel:";
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.BackColor = System.Drawing.Color.Transparent;
            kmsLabel.Location = new System.Drawing.Point(431, 214);
            kmsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(39, 17);
            kmsLabel.TabIndex = 41;
            kmsLabel.Text = "Kms:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.BackColor = System.Drawing.Color.Transparent;
            marcaLabel.Location = new System.Drawing.Point(431, 257);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 43;
            marcaLabel.Text = "Marca:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.BackColor = System.Drawing.Color.Transparent;
            matriculaLabel.Location = new System.Drawing.Point(431, 303);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(69, 17);
            matriculaLabel.TabIndex = 45;
            matriculaLabel.Text = "Matricula:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.BackColor = System.Drawing.Color.Transparent;
            modeloLabel.Location = new System.Drawing.Point(431, 350);
            modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 47;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.BackColor = System.Drawing.Color.Transparent;
            numeroChassisLabel.Location = new System.Drawing.Point(431, 395);
            numeroChassisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(115, 17);
            numeroChassisLabel.TabIndex = 49;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // buttonAddCarroOficina
            // 
            this.buttonAddCarroOficina.Location = new System.Drawing.Point(435, 492);
            this.buttonAddCarroOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCarroOficina.Name = "buttonAddCarroOficina";
            this.buttonAddCarroOficina.Size = new System.Drawing.Size(376, 36);
            this.buttonAddCarroOficina.TabIndex = 34;
            this.buttonAddCarroOficina.Text = "Adicionar Carro";
            this.buttonAddCarroOficina.UseVisualStyleBackColor = true;
            this.buttonAddCarroOficina.Click += new System.EventHandler(this.buttonAddCarroOficina_Click);
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(557, 165);
            this.combustivelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(252, 22);
            this.combustivelTextBox.TabIndex = 38;
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(StandAutomoveis.CarroOficina);
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(557, 210);
            this.kmsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(252, 22);
            this.kmsTextBox.TabIndex = 42;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(557, 254);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(252, 22);
            this.marcaTextBox.TabIndex = 44;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(557, 299);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(252, 22);
            this.matriculaTextBox.TabIndex = 46;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(557, 346);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(252, 22);
            this.modeloTextBox.TabIndex = 48;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(557, 391);
            this.numeroChassisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(252, 22);
            this.numeroChassisTextBox.TabIndex = 50;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(121, 87);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Size = new System.Drawing.Size(289, 502);
            this.groupBoxClientes.TabIndex = 52;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(8, 26);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(272, 468);
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
            this.labelNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelNomeCliente.Location = new System.Drawing.Point(419, 87);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(124, 39);
            this.labelNomeCliente.TabIndex = 53;
            this.labelNomeCliente.Text = "Cliente";
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(827, 80);
            this.panelCarroTop.TabIndex = 54;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitForm.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitForm.Location = new System.Drawing.Point(746, -1);
            this.buttonExitForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(81, 81);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = false;
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39F, System.Drawing.FontStyle.Bold);
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(69, -4);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(644, 80);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // FormAddCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 591);
            this.Controls.Add(this.panelCarroTop);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.groupBoxClientes);
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
            this.Controls.Add(this.buttonAddCarroOficina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddCarroOficina";
            this.Text = "FormAddCarroOficina";
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddCarroOficina;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
    }
}