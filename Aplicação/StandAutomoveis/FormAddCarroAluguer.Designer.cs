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
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            System.Windows.Forms.Label estadoLabel;
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddCarroAluguer = new System.Windows.Forms.Button();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            combustivelLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.BackColor = System.Drawing.Color.Transparent;
            combustivelLabel.Location = new System.Drawing.Point(240, 143);
            combustivelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(88, 17);
            combustivelLabel.TabIndex = 54;
            combustivelLabel.Text = "Combustivel:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.BackColor = System.Drawing.Color.Transparent;
            marcaLabel.Location = new System.Drawing.Point(240, 234);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 60;
            marcaLabel.Text = "Marca:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.BackColor = System.Drawing.Color.Transparent;
            matriculaLabel.Location = new System.Drawing.Point(240, 278);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(69, 17);
            matriculaLabel.TabIndex = 62;
            matriculaLabel.Text = "Matricula:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.BackColor = System.Drawing.Color.Transparent;
            modeloLabel.Location = new System.Drawing.Point(240, 321);
            modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 64;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.BackColor = System.Drawing.Color.Transparent;
            numeroChassisLabel.Location = new System.Drawing.Point(240, 364);
            numeroChassisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(115, 17);
            numeroChassisLabel.TabIndex = 66;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Location = new System.Drawing.Point(240, 191);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 68;
            estadoLabel.Text = "Estado:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(363, 140);
            this.combustivelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(251, 22);
            this.combustivelTextBox.TabIndex = 55;
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(StandAutomoveis.CarroAluguer);
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(363, 231);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(251, 22);
            this.marcaTextBox.TabIndex = 61;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(363, 274);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(251, 22);
            this.matriculaTextBox.TabIndex = 63;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(363, 317);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(251, 22);
            this.modeloTextBox.TabIndex = 65;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(363, 360);
            this.numeroChassisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(251, 22);
            this.numeroChassisTextBox.TabIndex = 67;
            // 
            // buttonAddCarroAluguer
            // 
            this.buttonAddCarroAluguer.Location = new System.Drawing.Point(239, 461);
            this.buttonAddCarroAluguer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCarroAluguer.Name = "buttonAddCarroAluguer";
            this.buttonAddCarroAluguer.Size = new System.Drawing.Size(376, 36);
            this.buttonAddCarroAluguer.TabIndex = 68;
            this.buttonAddCarroAluguer.Text = "Adicionar Carro";
            this.buttonAddCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonAddCarroAluguer.Click += new System.EventHandler(this.buttonAddCarroAluguer_Click);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Novo",
            "Usado",
            "Comercial"});
            this.estadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.estadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Disponivel",
            "Indisponivel"});
            this.estadoComboBox.Location = new System.Drawing.Point(363, 184);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(251, 24);
            this.estadoComboBox.TabIndex = 69;
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
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
            this.panelCarroTop.TabIndex = 70;
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
            // FormAddCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 591);
            this.Controls.Add(this.panelCarroTop);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.buttonAddCarroAluguer);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddCarroAluguer";
            this.Text = "FormAddCarroAluguer";
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.Button buttonAddCarroAluguer;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
    }
}