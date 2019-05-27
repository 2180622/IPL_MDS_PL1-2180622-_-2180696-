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
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
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
            this.groupBoxAluguer = new System.Windows.Forms.GroupBox();
            this.buttonEditAluguer = new System.Windows.Forms.Button();
            this.buttonAddAluguer = new System.Windows.Forms.Button();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCarroTop.SuspendLayout();
            this.panelLeftCarro.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBoxAdicionarCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxAluguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.buttonVenda.Location = new System.Drawing.Point(3, 292);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(79, 79);
            this.buttonVenda.TabIndex = 24;
            this.buttonVenda.UseVisualStyleBackColor = true;
            this.buttonVenda.Click += new System.EventHandler(this.buttonVendasCliente_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonCliente.Location = new System.Drawing.Point(3, 52);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonCliente.TabIndex = 23;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonOficinaCliente_Click);
            // 
            // buttonOficina
            // 
            this.buttonOficina.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficina.Location = new System.Drawing.Point(3, 171);
            this.buttonOficina.Name = "buttonOficina";
            this.buttonOficina.Size = new System.Drawing.Size(79, 79);
            this.buttonOficina.TabIndex = 22;
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
            this.groupBoxAdicionarCarro.Location = new System.Drawing.Point(537, 142);
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
            // groupBoxAluguer
            // 
            this.groupBoxAluguer.Controls.Add(this.buttonEditAluguer);
            this.groupBoxAluguer.Controls.Add(this.buttonAddAluguer);
            this.groupBoxAluguer.Controls.Add(this.listBoxAlugueres);
            this.groupBoxAluguer.Location = new System.Drawing.Point(319, 142);
            this.groupBoxAluguer.Name = "groupBoxAluguer";
            this.groupBoxAluguer.Size = new System.Drawing.Size(212, 333);
            this.groupBoxAluguer.TabIndex = 14;
            this.groupBoxAluguer.TabStop = false;
            this.groupBoxAluguer.Text = "Iniciar Aluguer";
            // 
            // buttonEditAluguer
            // 
            this.buttonEditAluguer.Location = new System.Drawing.Point(108, 302);
            this.buttonEditAluguer.Name = "buttonEditAluguer";
            this.buttonEditAluguer.Size = new System.Drawing.Size(100, 25);
            this.buttonEditAluguer.TabIndex = 2;
            this.buttonEditAluguer.Text = "Editar Aluguer";
            this.buttonEditAluguer.UseVisualStyleBackColor = true;
            // 
            // buttonAddAluguer
            // 
            this.buttonAddAluguer.Location = new System.Drawing.Point(5, 302);
            this.buttonAddAluguer.Name = "buttonAddAluguer";
            this.buttonAddAluguer.Size = new System.Drawing.Size(100, 25);
            this.buttonAddAluguer.TabIndex = 1;
            this.buttonAddAluguer.Text = "Adicionar Aluguer";
            this.buttonAddAluguer.UseVisualStyleBackColor = true;
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DataSource = this.aluguerBindingSource;
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(5, 19);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(203, 277);
            this.listBoxAlugueres.TabIndex = 0;
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
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
            this.groupBoxAluguer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Button buttonExitForm;
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
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.GroupBox groupBoxAluguer;
        private System.Windows.Forms.Button buttonEditAluguer;
        private System.Windows.Forms.Button buttonAddAluguer;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
    }
}