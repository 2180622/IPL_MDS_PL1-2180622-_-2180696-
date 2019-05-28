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
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.buttonAluguer = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonOficina = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            dataLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panelCarroTop.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(211, 23);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(211, 87);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 5;
            estadoLabel.Text = "Estado:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(214, 158);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor:";
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 4;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitForm.Location = new System.Drawing.Point(965, 0);
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
            this.labelTituloCliente.Location = new System.Drawing.Point(226, -1);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(516, 66);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.Controls.Add(this.panel4);
            this.panelLeftCarro.Controls.Add(this.buttonAluguer);
            this.panelLeftCarro.Controls.Add(this.buttonCliente);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCarro.TabIndex = 5;
            // 
            // buttonAluguer
            // 
            this.buttonAluguer.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguer.Location = new System.Drawing.Point(3, 292);
            this.buttonAluguer.Name = "buttonAluguer";
            this.buttonAluguer.Size = new System.Drawing.Size(79, 79);
            this.buttonAluguer.TabIndex = 24;
            this.buttonAluguer.UseVisualStyleBackColor = true;
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(3, 52);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonCliente.TabIndex = 23;
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // buttonOficina
            // 
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(0, 218);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(85, 98);
            this.buttonOficina.TabIndex = 22;
            this.buttonOficina.Text = "Vendas";
            this.buttonOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOficina.UseVisualStyleBackColor = true;
            // 
            // carroVendaBindingSource
            // 
            this.carroVendaBindingSource.DataSource = typeof(StandAutomoveis.CarroVenda);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(88, 68);
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
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(728, 134);
            this.groupBoxAdicionarCarro.Name = "groupBoxAdicionarCarro";
            this.groupBoxAdicionarCarro.Size = new System.Drawing.Size(212, 342);
            this.groupBoxAdicionarCarro.TabIndex = 14;
            this.groupBoxAdicionarCarro.TabStop = false;
            this.groupBoxAdicionarCarro.Text = "Adicionar Carro";
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(5, 311);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(203, 25);
            this.buttonAddCarro.TabIndex = 1;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.DataSource = this.carroBindingSource;
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(5, 19);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(203, 290);
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
            this.labelMoradaCliente.Location = new System.Drawing.Point(313, 114);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 17;
            this.labelMoradaCliente.Text = "-";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(313, 97);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 16;
            this.labelNIFCliente.Text = "-";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(311, 68);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
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
            this.groupBoxVendas.Location = new System.Drawing.Point(311, 134);
            this.groupBoxVendas.Name = "groupBoxVendas";
            this.groupBoxVendas.Size = new System.Drawing.Size(411, 342);
            this.groupBoxVendas.TabIndex = 18;
            this.groupBoxVendas.TabStop = false;
            this.groupBoxVendas.Text = "Criar Venda";
            // 
            // buttonAddVenda
            // 
            this.buttonAddVenda.Location = new System.Drawing.Point(214, 268);
            this.buttonAddVenda.Name = "buttonAddVenda";
            this.buttonAddVenda.Size = new System.Drawing.Size(181, 23);
            this.buttonAddVenda.TabIndex = 11;
            this.buttonAddVenda.Text = "Criar Venda";
            this.buttonAddVenda.UseVisualStyleBackColor = true;
            this.buttonAddVenda.Click += new System.EventHandler(this.buttonAddVenda_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(214, 42);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(StandAutomoveis.Venda);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(214, 103);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(181, 20);
            this.estadoTextBox.TabIndex = 6;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(214, 174);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(181, 20);
            this.valorTextBox.TabIndex = 10;
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.DataSource = this.vendaBindingSource;
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.Location = new System.Drawing.Point(5, 19);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(203, 316);
            this.listBoxVendas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 65);
            this.panel1.TabIndex = 12;
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
            // panel3
            // 
            this.panel3.BackgroundImage = global::StandAutomoveis.Properties.Resources._72_200;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(154, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 65);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(226, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stand Automóveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.buttonAluguerCliente);
            this.panel4.Controls.Add(this.buttonOficina);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 410);
            this.panel4.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(0, 111);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(85, 101);
            this.buttonAluguerCliente.TabIndex = 22;
            this.buttonAluguerCliente.Text = "Aluguer";
            this.buttonAluguerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguerCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAluguerCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.button2.Location = new System.Drawing.Point(0, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 97);
            this.button2.TabIndex = 23;
            this.button2.Text = "Clientes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.groupBoxVendas);
            this.Controls.Add(this.labelMoradaCliente);
            this.Controls.Add(this.labelNIFCliente);
            this.Controls.Add(this.labelClienteSelecionado);
            this.Controls.Add(this.groupBoxAdicionarCarro);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.panelLeftCarro);
            this.Controls.Add(this.panelCarroTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.panelLeftCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroVendaBindingSource)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBoxAdicionarCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBoxVendas.ResumeLayout(false);
            this.groupBoxVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.Button buttonAluguer;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonOficina;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Button button2;
    }
}