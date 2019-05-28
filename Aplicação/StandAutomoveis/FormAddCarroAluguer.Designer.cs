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
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.groupBoxAluguer = new System.Windows.Forms.GroupBox();
            this.listBoxAluguer = new System.Windows.Forms.ListBox();
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
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            combustivelLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            this.panelForm1.SuspendLayout();
            this.groupBoxAluguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(428, 181);
            combustivelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(88, 17);
            combustivelLabel.TabIndex = 54;
            combustivelLabel.Text = "Combustivel:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(428, 224);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 56;
            estadoLabel.Text = "Estado:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(428, 267);
            marcaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 60;
            marcaLabel.Text = "Marca:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(428, 310);
            matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(69, 17);
            matriculaLabel.TabIndex = 62;
            matriculaLabel.Text = "Matricula:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(428, 353);
            modeloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 64;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(428, 396);
            numeroChassisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(115, 17);
            numeroChassisLabel.TabIndex = 66;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // panelForm1
            // 
            this.panelForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelForm1.Controls.Add(this.panelCarroTop);
            this.panelForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm1.Location = new System.Drawing.Point(0, 0);
            this.panelForm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(827, 80);
            this.panelForm1.TabIndex = 7;
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(113, 511);
            this.panelLeftCarro.TabIndex = 8;
            // 
            // groupBoxAluguer
            // 
            this.groupBoxAluguer.Controls.Add(this.listBoxAluguer);
            this.groupBoxAluguer.Location = new System.Drawing.Point(121, 85);
            this.groupBoxAluguer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAluguer.Name = "groupBoxAluguer";
            this.groupBoxAluguer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAluguer.Size = new System.Drawing.Size(289, 505);
            this.groupBoxAluguer.TabIndex = 53;
            this.groupBoxAluguer.TabStop = false;
            this.groupBoxAluguer.Text = "Selecione um aluguer";
            // 
            // listBoxAluguer
            // 
            this.listBoxAluguer.DataSource = this.aluguerBindingSource;
            this.listBoxAluguer.FormattingEnabled = true;
            this.listBoxAluguer.ItemHeight = 16;
            this.listBoxAluguer.Location = new System.Drawing.Point(8, 26);
            this.listBoxAluguer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxAluguer.Name = "listBoxAluguer";
            this.listBoxAluguer.Size = new System.Drawing.Size(272, 468);
            this.listBoxAluguer.TabIndex = 5;
            this.listBoxAluguer.SelectedIndexChanged += new System.EventHandler(this.listBoxAluguer_SelectedIndexChanged);
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
            this.combustivelTextBox.Location = new System.Drawing.Point(551, 177);
            this.combustivelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(251, 22);
            this.combustivelTextBox.TabIndex = 55;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(551, 220);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(251, 22);
            this.estadoTextBox.TabIndex = 57;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(551, 263);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(251, 22);
            this.marcaTextBox.TabIndex = 61;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(551, 306);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(251, 22);
            this.matriculaTextBox.TabIndex = 63;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(551, 350);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(251, 22);
            this.modeloTextBox.TabIndex = 65;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroAluguerBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(551, 393);
            this.numeroChassisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(251, 22);
            this.numeroChassisTextBox.TabIndex = 67;
            // 
            // buttonAddCarroAluguer
            // 
            this.buttonAddCarroAluguer.Location = new System.Drawing.Point(427, 494);
            this.buttonAddCarroAluguer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCarroAluguer.Name = "buttonAddCarroAluguer";
            this.buttonAddCarroAluguer.Size = new System.Drawing.Size(376, 36);
            this.buttonAddCarroAluguer.TabIndex = 68;
            this.buttonAddCarroAluguer.Text = "Adicionar Carro";
            this.buttonAddCarroAluguer.UseVisualStyleBackColor = true;
            this.buttonAddCarroAluguer.Click += new System.EventHandler(this.buttonAddCarroAluguer_Click);
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(827, 80);
            this.panelCarroTop.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.wrench_512;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(747, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources._72_200;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 8;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(78, 0);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(672, 84);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // FormAddCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 591);
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
            this.Controls.Add(this.groupBoxAluguer);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddCarroAluguer";
            this.Text = "FormAddCarroAluguer";
            this.panelForm1.ResumeLayout(false);
            this.groupBoxAluguer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.GroupBox groupBoxAluguer;
        private System.Windows.Forms.ListBox listBoxAluguer;
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
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
    }
}