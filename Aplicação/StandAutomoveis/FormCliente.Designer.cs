namespace StandAutomoveis
{
    partial class FormCliente
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
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.panelLeftCarro = new System.Windows.Forms.Panel();
            this.buttonAluguerCliente = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.buttonOficina = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGravar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.panelClienteTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panelLeftCliente.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelCarroTop.SuspendLayout();
            this.panelClienteTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.BackColor = System.Drawing.Color.Transparent;
            contactoLabel.Location = new System.Drawing.Point(137, 309);
            contactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(68, 17);
            contactoLabel.TabIndex = 10;
            contactoLabel.Text = "Contacto:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.BackColor = System.Drawing.Color.Transparent;
            moradaLabel.Location = new System.Drawing.Point(137, 341);
            moradaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(60, 17);
            moradaLabel.TabIndex = 14;
            moradaLabel.Text = "Morada:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.BackColor = System.Drawing.Color.Transparent;
            nIFLabel.Location = new System.Drawing.Point(137, 277);
            nIFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(33, 17);
            nIFLabel.TabIndex = 16;
            nIFLabel.Text = "NIF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Location = new System.Drawing.Point(137, 245);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 18;
            nomeLabel.Text = "Nome:";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.clienteDataGridView.Location = new System.Drawing.Point(580, 144);
            this.clienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.Size = new System.Drawing.Size(724, 393);
            this.clienteDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(231, 306);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(272, 22);
            this.contactoTextBox.TabIndex = 11;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(231, 338);
            this.moradaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(272, 22);
            this.moradaTextBox.TabIndex = 15;
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NIF", true));
            this.nIFTextBox.Location = new System.Drawing.Point(231, 274);
            this.nIFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(272, 22);
            this.nIFTextBox.TabIndex = 17;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(231, 242);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(272, 22);
            this.nomeTextBox.TabIndex = 19;
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.Location = new System.Drawing.Point(192, 476);
            this.textBoxFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(311, 22);
            this.textBoxFiltrar.TabIndex = 20;
            this.textBoxFiltrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFiltrar_KeyDown);
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.labelFiltrar.Location = new System.Drawing.Point(137, 480);
            this.labelFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(48, 17);
            this.labelFiltrar.TabIndex = 21;
            this.labelFiltrar.Text = "Filtrar:";
            // 
            // panelLeftCliente
            // 
            this.panelLeftCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCliente.Controls.Add(this.panelLeftCarro);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 80);
            this.panelLeftCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCliente.TabIndex = 3;
            // 
            // panelLeftCarro
            // 
            this.panelLeftCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCarro.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelLeftCarro.Controls.Add(this.buttonAluguerCliente);
            this.panelLeftCarro.Controls.Add(this.buttonVenda);
            this.panelLeftCarro.Controls.Add(this.buttonOficina);
            this.panelLeftCarro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCarro.Location = new System.Drawing.Point(0, 0);
            this.panelLeftCarro.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftCarro.Name = "panelLeftCarro";
            this.panelLeftCarro.Size = new System.Drawing.Size(113, 505);
            this.panelLeftCarro.TabIndex = 6;
            // 
            // buttonAluguerCliente
            // 
            this.buttonAluguerCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAluguerCliente.Image = global::StandAutomoveis.Properties.Resources.iconeAluguer;
            this.buttonAluguerCliente.Location = new System.Drawing.Point(0, 129);
            this.buttonAluguerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAluguerCliente.Name = "buttonAluguerCliente";
            this.buttonAluguerCliente.Size = new System.Drawing.Size(113, 113);
            this.buttonAluguerCliente.TabIndex = 26;
            this.buttonAluguerCliente.Text = "Aluguer";
            this.buttonAluguerCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAluguerCliente.UseVisualStyleBackColor = false;
            // 
            // buttonVenda
            // 
            this.buttonVenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonVenda.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVenda.Location = new System.Drawing.Point(0, 250);
            this.buttonVenda.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(113, 113);
            this.buttonVenda.TabIndex = 24;
            this.buttonVenda.Text = "Vendas";
            this.buttonVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVenda.UseVisualStyleBackColor = false;
            // 
            // buttonOficina
            // 
            this.buttonOficina.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(0, 8);
            this.buttonOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(113, 113);
            this.buttonOficina.TabIndex = 22;
            this.buttonOficina.Text = "Oficina";
            this.buttonOficina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOficina.UseVisualStyleBackColor = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(132, 24);
            this.bindingNavigatorDeleteItem.Text = "Apagar Cliente";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.Image = global::StandAutomoveis.Properties.Resources.iconEdit;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(72, 24);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(136, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Linha";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripButtonGravar
            // 
            this.toolStripButtonGravar.Image = global::StandAutomoveis.Properties.Resources.iconSave;
            this.toolStripButtonGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGravar.Name = "toolStripButtonGravar";
            this.toolStripButtonGravar.Size = new System.Drawing.Size(76, 24);
            this.toolStripButtonGravar.Text = "Gravar";
            this.toolStripButtonGravar.Click += new System.EventHandler(this.toolStripButtonGravar_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.AliceBlue;
            this.bindingNavigator1.BindingSource = this.clienteBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonEditar,
            this.bindingNavigatorAddNewItem,
            this.toolStripButtonGravar});
            this.bindingNavigator1.Location = new System.Drawing.Point(113, 80);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1207, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitForm.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitForm.Location = new System.Drawing.Point(1239, 0);
            this.buttonExitForm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(81, 81);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = false;
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelCarroTop.Controls.Add(this.label1);
            this.panelCarroTop.Controls.Add(this.panel5);
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_profile_64;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 81);
            this.panel5.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(972, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 81);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 81);
            this.panel1.TabIndex = 12;
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(316, -4);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(672, 84);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // panelClienteTop
            // 
            this.panelClienteTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelClienteTop.Controls.Add(this.panelCarroTop);
            this.panelClienteTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteTop.Location = new System.Drawing.Point(0, 0);
            this.panelClienteTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelClienteTop.Name = "panelClienteTop";
            this.panelClienteTop.Size = new System.Drawing.Size(1320, 80);
            this.panelClienteTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menu Cliente";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.textBoxFiltrar);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nIFLabel);
            this.Controls.Add(this.nIFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.panelClienteTop);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panelLeftCliente.ResumeLayout(false);
            this.panelLeftCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.panelClienteTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGravar;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Panel panelClienteTop;
        private System.Windows.Forms.Panel panelLeftCarro;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonOficina;
        private System.Windows.Forms.Button buttonAluguerCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}