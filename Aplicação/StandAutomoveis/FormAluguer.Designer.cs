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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonOficina = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            dataFimLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.groupBoxAluguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(241, 78);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(52, 13);
            dataFimLabel.TabIndex = 5;
            dataFimLabel.Text = "Data Fim:";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(241, 18);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(61, 13);
            dataInicioLabel.TabIndex = 7;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(245, 156);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 11;
            kmsLabel.Text = "Kms:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(245, 182);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
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
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.wrench_512;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(754, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 65);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources._72_200;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 65);
            this.panel1.TabIndex = 8;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(226, -1);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(532, 66);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            this.labelTituloCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Controls.Add(this.button1);
            this.panelLeftCarro.Controls.Add(this.buttonVenda);
            this.panelLeftCarro.Controls.Add(this.buttonCliente);
            this.panelLeftCarro.Controls.Add(this.buttonOficina);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCarro.TabIndex = 5;
            // 
            // buttonVenda
            // 
            this.buttonVenda.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVenda.Location = new System.Drawing.Point(0, 218);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(85, 98);
            this.buttonVenda.TabIndex = 24;
            this.buttonVenda.Text = "Vendas";
            this.buttonVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVenda.UseVisualStyleBackColor = true;
            this.buttonVenda.Click += new System.EventHandler(this.buttonVendasCliente_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(0, 8);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(85, 97);
            this.buttonCliente.TabIndex = 23;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonOficinaCliente_Click);
            // 
            // buttonOficina
            // 
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(0, 111);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(85, 101);
            this.buttonOficina.TabIndex = 22;
            this.buttonOficina.Text = "Oficina";
            this.buttonOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOficina.UseVisualStyleBackColor = true;
            this.buttonOficina.Click += new System.EventHandler(this.buttonAluguerCliente_Click);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 65);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 408);
            this.groupBoxClientes.TabIndex = 7;
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
            this.labelMoradaCliente.Location = new System.Drawing.Point(316, 114);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 12;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(316, 97);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 11;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(314, 68);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 10;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(778, 142);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(212, 333);
            this.groupBoxAdicionarCarro.TabIndex = 13;
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
            this.groupBoxAluguer.Location = new System.Drawing.Point(314, 142);
            this.groupBoxAluguer.Name = "groupBoxAluguer";
            this.groupBoxAluguer.Size = new System.Drawing.Size(458, 331);
            this.groupBoxAluguer.TabIndex = 14;
            this.groupBoxAluguer.TabStop = false;
            this.groupBoxAluguer.Text = "Iniciar Aluguer";
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(244, 94);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dataFimDateTimePicker.TabIndex = 6;
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(244, 34);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dataInicioDateTimePicker.TabIndex = 8;
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.Location = new System.Drawing.Point(285, 153);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(156, 20);
            this.kmsTextBox.TabIndex = 12;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(285, 179);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(156, 20);
            this.valorTextBox.TabIndex = 14;
            // 
            // buttonEditAluguer
            // 
            this.buttonEditAluguer.Location = new System.Drawing.Point(352, 296);
            this.buttonEditAluguer.Name = "buttonEditAluguer";
            this.buttonEditAluguer.Size = new System.Drawing.Size(100, 25);
            this.buttonEditAluguer.TabIndex = 2;
            this.buttonEditAluguer.Text = "Editar Aluguer";
            this.buttonEditAluguer.UseVisualStyleBackColor = true;
            // 
            // buttonAddAluguer
            // 
            this.buttonAddAluguer.Location = new System.Drawing.Point(246, 296);
            this.buttonAddAluguer.Name = "buttonAddAluguer";
            this.buttonAddAluguer.Size = new System.Drawing.Size(100, 25);
            this.buttonAddAluguer.TabIndex = 1;
            this.buttonAddAluguer.Text = "Adicionar Aluguer";
            this.buttonAddAluguer.UseVisualStyleBackColor = true;
            this.buttonAddAluguer.Click += new System.EventHandler(this.buttonAddAluguer_Click);
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DataSource = this.aluguerBindingSource;
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(6, 19);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(229, 303);
            this.listBoxAlugueres.TabIndex = 0;
            this.listBoxAlugueres.SelectedIndexChanged += new System.EventHandler(this.listBoxAlugueres_SelectedIndexChanged);
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // button1
            // 
            this.button1.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.groupBoxAluguer);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAluguer";
            this.Text = "FormAluguer";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.panelLeftCarro.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.groupBoxAluguer.ResumeLayout(false);
            this.groupBoxAluguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonOficina;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}