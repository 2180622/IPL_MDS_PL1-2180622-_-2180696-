namespace StandAutomoveis
{
    partial class FormVenda
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label valorLabel;
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.carroVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAdicionarCarro = new System.Windows.Forms.GroupBox();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.groupBoxVendas = new System.Windows.Forms.GroupBox();
            this.buttonAddVenda = new System.Windows.Forms.Button();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.panelLeftCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(281, 28);
            dataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(42, 17);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(281, 107);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 5;
            estadoLabel.Text = "Estado:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(285, 194);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(45, 17);
            valorLabel.TabIndex = 9;
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
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 4;
            // 
            // carroVendaBindingSource
            // 
            this.carroVendaBindingSource.DataSource = typeof(StandAutomoveis.CarroVenda);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(117, 84);
            this.groupBoxClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(272, 468);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // groupBoxAdicionarCarro
            // 
            this.groupBoxAdicionarCarro.Controls.Add(this.buttonAddCarro);
            this.groupBoxAdicionarCarro.Controls.Add(this.listBoxCarros);
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(971, 165);
            this.groupBoxAdicionarCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(283, 421);
            this.groupBoxAdicionarCarro.TabIndex = 14;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(7, 383);
            this.buttonAddCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(271, 31);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.ItemHeight = 16;
            this.listBoxCarros.Location = new System.Drawing.Point(7, 23);
            this.listBoxCarros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(269, 356);
            this.listBoxCarros.TabIndex = 0;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(StandAutomoveis.Carro);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(417, 140);
            this.labelMoradaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(15, 20);
            this.labelMoradaCliente.TabIndex = 17;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(417, 119);
            this.labelNIFCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(15, 20);
            this.labelNIFCliente.TabIndex = 16;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(415, 84);
            this.labelClienteSelecionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(370, 36);
            this.labelClienteSelecionado.TabIndex = 15;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // groupBoxVendas
            // 
            this.groupBoxVendas.Controls.Add(this.buttonAddVenda);
            this.groupBoxVendas.Controls.Add(dataLabel);
            this.groupBoxVendas.Controls.Add(this.dataDateTimePicker);
            this.groupBoxVendas.Controls.Add(estadoLabel);
            this.groupBoxVendas.Controls.Add(this.estadoTextBox);
            this.groupBoxVendas.Controls.Add(valorLabel);
            this.groupBoxVendas.Controls.Add(this.valorTextBox);
            this.groupBoxVendas.Controls.Add(this.listBoxVendas);
            this.groupBoxVendas.Location = new System.Drawing.Point(415, 165);
            this.groupBoxVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVendas.Name = "groupBoxVendas";
            this.groupBoxVendas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVendas.Size = new System.Drawing.Size(548, 421);
            this.groupBoxVendas.TabIndex = 18;
            this.groupBoxVendas.TabStop = false;
            this.groupBoxVendas.Text = "Criar Venda";
            // 
            // buttonAddVenda
            // 
            this.buttonAddVenda.Location = new System.Drawing.Point(285, 330);
            this.buttonAddVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddVenda.Name = "buttonAddVenda";
            this.buttonAddVenda.Size = new System.Drawing.Size(241, 28);
            this.buttonAddVenda.TabIndex = 11;
            this.buttonAddVenda.Text = "Criar Venda";
            this.buttonAddVenda.UseVisualStyleBackColor = true;
            this.buttonAddVenda.Click += new System.EventHandler(this.buttonAddVenda_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(285, 52);
            this.dataDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(240, 22);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(StandAutomoveis.Venda);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(285, 127);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(240, 22);
            this.estadoTextBox.TabIndex = 6;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(285, 214);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(240, 22);
            this.valorTextBox.TabIndex = 10;
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.DataSource = this.vendaBindingSource;
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.ItemHeight = 16;
            this.listBoxVendas.Location = new System.Drawing.Point(7, 23);
            this.listBoxVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(269, 388);
            this.listBoxVendas.TabIndex = 1;
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
            this.panelLeftCliente.Controls.Add(this.button1);
            this.panelLeftCliente.Controls.Add(this.buttonAluguerCliente);
            this.panelLeftCliente.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCliente.Controls.Add(this.buttonExitApp);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCliente.TabIndex = 25;
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(0, 250);
            this.buttonAluguerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonAluguerCliente.TabIndex = 21;
            this.buttonAluguerCliente.Text = "Alugueres";
            this.buttonAluguerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguerCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAluguerCliente.UseVisualStyleBackColor = false;
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
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.groupBoxVendas);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBoxVendas.ResumeLayout(false);
            this.groupBoxVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.panelLeftCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.BindingSource carroVendaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAdicionarCarro;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.GroupBox groupBoxVendas;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.Button buttonAddVenda;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Button button1;
    }
}