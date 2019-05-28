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
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAluguer = new System.Windows.Forms.GroupBox();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.buttonEditAluguer = new System.Windows.Forms.Button();
            this.buttonAddAluguer = new System.Windows.Forms.Button();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            dataFimLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.groupBoxAluguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            this.panelLeftCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(321, 96);
            dataFimLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(68, 17);
            dataFimLabel.TabIndex = 5;
            dataFimLabel.Text = "Data Fim:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(321, 22);
            dataInicioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(78, 17);
            dataInicioLabel.TabIndex = 7;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(327, 192);
            kmsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(39, 17);
            kmsLabel.TabIndex = 11;
            kmsLabel.Text = "Kms:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(327, 224);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
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
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 4;
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(121, 80);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxClientes.Size = new System.Drawing.Size(289, 502);
            this.groupBoxClientes.TabIndex = 7;
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
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxAluguerClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(421, 140);
            this.labelMoradaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(15, 20);
            this.labelMoradaCliente.TabIndex = 12;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(421, 119);
            this.labelNIFCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(15, 20);
            this.labelNIFCliente.TabIndex = 11;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(419, 84);
            this.labelClienteSelecionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(370, 36);
            this.labelClienteSelecionado.TabIndex = 10;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(1037, 175);
            this.groupBoxAdicionarCarro.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(283, 410);
            this.groupBoxAdicionarCarro.TabIndex = 13;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(7, 372);
            this.buttonAddCarro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(271, 31);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.ItemHeight = 16;
            this.listBoxCarros.Location = new System.Drawing.Point(7, 23);
            this.listBoxCarros.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(269, 340);
            this.listBoxCarros.TabIndex = 0;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(StandAutomoveis.CarroAluguer);
            // 
            // groupBoxAluguer
            // 
            this.groupBoxAluguer.Controls.Add(dataFimLabel);
            this.groupBoxAluguer.Controls.Add(this.dataFimDateTimePicker);
            this.groupBoxAluguer.Controls.Add(dataInicioLabel);
            this.groupBoxAluguer.Controls.Add(this.dataInicioDateTimePicker);
            this.groupBoxAluguer.Controls.Add(kmsLabel);
            this.groupBoxAluguer.Controls.Add(this.kmsTextBox);
            this.groupBoxAluguer.Controls.Add(valorLabel);
            this.groupBoxAluguer.Controls.Add(this.valorTextBox);
            this.groupBoxAluguer.Controls.Add(this.buttonEditAluguer);
            this.groupBoxAluguer.Controls.Add(this.buttonAddAluguer);
            this.groupBoxAluguer.Controls.Add(this.listBoxAlugueres);
            this.groupBoxAluguer.Location = new System.Drawing.Point(419, 175);
            this.groupBoxAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAluguer.Name = "groupBoxAluguer";
            this.groupBoxAluguer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAluguer.Size = new System.Drawing.Size(611, 407);
            this.groupBoxAluguer.TabIndex = 14;
            this.groupBoxAluguer.TabStop = false;
            this.groupBoxAluguer.Text = "Iniciar Aluguer";
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(325, 116);
            this.dataFimDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.dataFimDateTimePicker.TabIndex = 6;
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(325, 42);
            this.dataInicioDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.dataInicioDateTimePicker.TabIndex = 8;
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.Location = new System.Drawing.Point(380, 188);
            this.kmsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(207, 22);
            this.kmsTextBox.TabIndex = 12;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(380, 220);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(207, 22);
            this.valorTextBox.TabIndex = 14;
            // 
            // buttonEditAluguer
            // 
            this.buttonEditAluguer.Location = new System.Drawing.Point(469, 364);
            this.buttonEditAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditAluguer.Name = "buttonEditAluguer";
            this.buttonEditAluguer.Size = new System.Drawing.Size(133, 31);
            this.buttonEditAluguer.TabIndex = 2;
            this.buttonEditAluguer.Text = "Editar Aluguer";
            this.buttonEditAluguer.UseVisualStyleBackColor = true;
            // 
            // buttonAddAluguer
            // 
            this.buttonAddAluguer.Location = new System.Drawing.Point(328, 364);
            this.buttonAddAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAluguer.Name = "buttonAddAluguer";
            this.buttonAddAluguer.Size = new System.Drawing.Size(133, 31);
            this.buttonAddAluguer.TabIndex = 1;
            this.buttonAddAluguer.Text = "Adicionar Aluguer";
            this.buttonAddAluguer.UseVisualStyleBackColor = true;
            this.buttonAddAluguer.Click += new System.EventHandler(this.buttonAddAluguer_Click);
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DataSource = this.aluguerBindingSource;
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.ItemHeight = 16;
            this.listBoxAlugueres.Location = new System.Drawing.Point(8, 23);
            this.listBoxAlugueres.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(304, 372);
            this.listBoxAlugueres.TabIndex = 0;
            this.listBoxAlugueres.SelectedIndexChanged += new System.EventHandler(this.listBoxAlugueres_SelectedIndexChanged);
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.wrench_512;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(992, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 80);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources._72_200;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(249, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 11;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(329, -2);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(672, 84);
            this.labelTituloCliente.TabIndex = 10;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelLeftCliente
            // 
            this.panelLeftCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCliente.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCliente.Controls.Add(this.button1);
            this.panelLeftCliente.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCliente.Controls.Add(this.buttonExitApp);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCliente.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.button1.Location = new System.Drawing.Point(0, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 113);
            this.button1.TabIndex = 24;
            this.button1.Text = "Oficina";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonOficinaCliente
            // 
            this.buttonOficinaCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOficinaCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonOficinaCliente.Location = new System.Drawing.Point(0, 8);
            this.buttonOficinaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOficinaCliente.Name = "buttonOficinaCliente";
            this.buttonOficinaCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonOficinaCliente.TabIndex = 23;
            this.buttonOficinaCliente.Text = "Clientes";
            this.buttonOficinaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficinaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOficinaCliente.UseVisualStyleBackColor = false;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExitApp.Location = new System.Drawing.Point(4, 461);
            this.buttonExitApp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(105, 31);
            this.buttonExitApp.TabIndex = 11;
            this.buttonExitApp.Text = "Sair";
            this.buttonExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExitApp.UseVisualStyleBackColor = true;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(0, 250);
            this.buttonVendasCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonVendasCliente.TabIndex = 25;
            this.buttonVendasCliente.Text = "Vendas";
            this.buttonVendasCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVendasCliente.UseVisualStyleBackColor = false;
            // 
            // FormAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.groupBoxAluguer);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAluguer";
            this.Text = "FormAluguer";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.groupBoxAluguer.ResumeLayout(false);
            this.groupBoxAluguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            this.panelLeftCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.GroupBox groupBoxAdicionarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBoxAluguer;
        private System.Windows.Forms.Button buttonEditAluguer;
        private System.Windows.Forms.Button buttonAddAluguer;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Button buttonVendasCliente;
    }
}