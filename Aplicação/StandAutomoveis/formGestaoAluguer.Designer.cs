namespace StandAutomoveis
{
    partial class FormGestaoAluguer
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
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.labelTituloForm1 = new System.Windows.Forms.Label();
            this.panelLeftCliente = new System.Windows.Forms.Panel();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.buttonVendasCliente = new System.Windows.Forms.Button();
            this.buttonOficinaCliente = new System.Windows.Forms.Button();
            this.listBoxCarrosAluguer = new System.Windows.Forms.ListBox();
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.buttonEditCarro = new System.Windows.Forms.Button();
            this.buttonDeleteCarro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteAluguer = new System.Windows.Forms.Button();
            this.buttonFatura = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelClienteSelecionado = new System.Windows.Forms.Label();
            this.labelNIFCliente = new System.Windows.Forms.Label();
            this.labelValorTotalCliente = new System.Windows.Forms.Label();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddAluguer = new System.Windows.Forms.Button();
            this.panelForm1.SuspendLayout();
            this.panelLeftCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm1
            // 
            this.panelForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelForm1.Controls.Add(this.buttonExitApp);
            this.panelForm1.Controls.Add(this.labelTituloForm1);
            this.panelForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm1.Location = new System.Drawing.Point(0, 0);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(990, 65);
            this.panelForm1.TabIndex = 6;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.buttonExitApp.Location = new System.Drawing.Point(962, 3);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(25, 25);
            this.buttonExitApp.TabIndex = 7;
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // labelTituloForm1
            // 
            this.labelTituloForm1.AutoSize = true;
            this.labelTituloForm1.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloForm1.Location = new System.Drawing.Point(226, -1);
            this.labelTituloForm1.Name = "labelTituloForm1";
            this.labelTituloForm1.Size = new System.Drawing.Size(516, 66);
            this.labelTituloForm1.TabIndex = 6;
            this.labelTituloForm1.Text = "Stand Automóveis";
            // 
            // panelLeftCliente
            // 
            this.panelLeftCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeftCliente.Controls.Add(this.buttonGestaoClientes);
            this.panelLeftCliente.Controls.Add(this.buttonVendasCliente);
            this.panelLeftCliente.Controls.Add(this.buttonOficinaCliente);
            this.panelLeftCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCliente.Location = new System.Drawing.Point(0, 65);
            this.panelLeftCliente.Name = "panelLeftCliente";
            this.panelLeftCliente.Size = new System.Drawing.Size(85, 410);
            this.panelLeftCliente.TabIndex = 7;
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.Image = global::StandAutomoveis.Properties.Resources.iconeClientes;
            this.buttonGestaoClientes.Location = new System.Drawing.Point(3, 49);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(79, 79);
            this.buttonGestaoClientes.TabIndex = 23;
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = true;
            // 
            // buttonVendasCliente
            // 
            this.buttonVendasCliente.Image = global::StandAutomoveis.Properties.Resources.iconeVenda;
            this.buttonVendasCliente.Location = new System.Drawing.Point(3, 292);
            this.buttonVendasCliente.Name = "buttonVendasCliente";
            this.buttonVendasCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonVendasCliente.TabIndex = 22;
            this.buttonVendasCliente.UseVisualStyleBackColor = true;
            // 
            // buttonOficinaCliente
            // 
            this.buttonOficinaCliente.Image = global::StandAutomoveis.Properties.Resources.iconeOficina;
            this.buttonOficinaCliente.Location = new System.Drawing.Point(3, 171);
            this.buttonOficinaCliente.Name = "buttonOficinaCliente";
            this.buttonOficinaCliente.Size = new System.Drawing.Size(79, 79);
            this.buttonOficinaCliente.TabIndex = 20;
            this.buttonOficinaCliente.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosAluguer
            // 
            this.listBoxCarrosAluguer.DataSource = this.carroAluguerBindingSource;
            this.listBoxCarrosAluguer.FormattingEnabled = true;
            this.listBoxCarrosAluguer.Location = new System.Drawing.Point(6, 19);
            this.listBoxCarrosAluguer.Name = "listBoxCarrosAluguer";
            this.listBoxCarrosAluguer.Size = new System.Drawing.Size(205, 225);
            this.listBoxCarrosAluguer.TabIndex = 23;
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(StandAutomoveis.CarroAluguer);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(6, 244);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(205, 23);
            this.buttonAddCarro.TabIndex = 25;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            // 
            // buttonEditCarro
            // 
            this.buttonEditCarro.Location = new System.Drawing.Point(6, 273);
            this.buttonEditCarro.Name = "buttonEditCarro";
            this.buttonEditCarro.Size = new System.Drawing.Size(100, 23);
            this.buttonEditCarro.TabIndex = 26;
            this.buttonEditCarro.Text = "Editar Carro";
            this.buttonEditCarro.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCarro
            // 
            this.buttonDeleteCarro.Location = new System.Drawing.Point(111, 273);
            this.buttonDeleteCarro.Name = "buttonDeleteCarro";
            this.buttonDeleteCarro.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteCarro.TabIndex = 27;
            this.buttonDeleteCarro.Text = "Apagar Carro";
            this.buttonDeleteCarro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxCarrosAluguer);
            this.groupBox1.Controls.Add(this.buttonDeleteCarro);
            this.groupBox1.Controls.Add(this.buttonAddCarro);
            this.groupBox1.Controls.Add(this.buttonEditCarro);
            this.groupBox1.Location = new System.Drawing.Point(314, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 300);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponíveis para aluguer";
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.listBoxClientes);
            this.groupBoxClientes.Location = new System.Drawing.Point(91, 71);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(217, 398);
            this.groupBoxClientes.TabIndex = 29;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Selecione um Cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 21);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(205, 368);
            this.listBoxClientes.TabIndex = 5;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(StandAutomoveis.Cliente);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAlugueres);
            this.groupBox2.Controls.Add(this.buttonDeleteAluguer);
            this.groupBox2.Controls.Add(this.buttonFatura);
            this.groupBox2.Location = new System.Drawing.Point(537, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 300);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alugueres do cliente";
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DataSource = this.aluguerBindingSource;
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.Location = new System.Drawing.Point(6, 19);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(205, 251);
            this.listBoxAlugueres.TabIndex = 23;
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(StandAutomoveis.Aluguer);
            // 
            // buttonDeleteAluguer
            // 
            this.buttonDeleteAluguer.Location = new System.Drawing.Point(111, 271);
            this.buttonDeleteAluguer.Name = "buttonDeleteAluguer";
            this.buttonDeleteAluguer.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteAluguer.TabIndex = 27;
            this.buttonDeleteAluguer.Text = "Apagar Aluguer";
            this.buttonDeleteAluguer.UseVisualStyleBackColor = true;
            // 
            // buttonFatura
            // 
            this.buttonFatura.Location = new System.Drawing.Point(6, 271);
            this.buttonFatura.Name = "buttonFatura";
            this.buttonFatura.Size = new System.Drawing.Size(100, 23);
            this.buttonFatura.TabIndex = 26;
            this.buttonFatura.Text = "Emitir Fatura";
            this.buttonFatura.UseVisualStyleBackColor = true;
            this.buttonFatura.Click += new System.EventHandler(this.buttonFatura_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelClienteSelecionado);
            this.groupBox3.Controls.Add(this.labelNIFCliente);
            this.groupBox3.Controls.Add(this.labelValorTotalCliente);
            this.groupBox3.Controls.Add(this.labelMoradaCliente);
            this.groupBox3.Location = new System.Drawing.Point(314, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 92);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informação do cliente";
            // 
            // labelClienteSelecionado
            // 
            this.labelClienteSelecionado.AutoSize = true;
            this.labelClienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelClienteSelecionado.Location = new System.Drawing.Point(6, 16);
            this.labelClienteSelecionado.Name = "labelClienteSelecionado";
            this.labelClienteSelecionado.Size = new System.Drawing.Size(310, 29);
            this.labelClienteSelecionado.TabIndex = 7;
            this.labelClienteSelecionado.Text = "Sem Cliente Selecionado";
            // 
            // labelNIFCliente
            // 
            this.labelNIFCliente.AutoSize = true;
            this.labelNIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIFCliente.Location = new System.Drawing.Point(8, 45);
            this.labelNIFCliente.Name = "labelNIFCliente";
            this.labelNIFCliente.Size = new System.Drawing.Size(13, 17);
            this.labelNIFCliente.TabIndex = 8;
            this.labelNIFCliente.Text = "-";
            // 
            // labelValorTotalCliente
            // 
            this.labelValorTotalCliente.AutoSize = true;
            this.labelValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelValorTotalCliente.Location = new System.Drawing.Point(541, 16);
            this.labelValorTotalCliente.Name = "labelValorTotalCliente";
            this.labelValorTotalCliente.Size = new System.Drawing.Size(61, 13);
            this.labelValorTotalCliente.TabIndex = 10;
            this.labelValorTotalCliente.Text = "Valor Total:";
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(8, 62);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(13, 17);
            this.labelMoradaCliente.TabIndex = 9;
            this.labelMoradaCliente.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kmsTextBox);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.valorTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePickerFim);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dateTimePickerInicio);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.buttonAddAluguer);
            this.groupBox4.Location = new System.Drawing.Point(761, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 300);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informação do aluguer";
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.Location = new System.Drawing.Point(50, 169);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(151, 20);
            this.kmsTextBox.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 32;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(50, 143);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(151, 20);
            this.valorTextBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Valor:";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(6, 94);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerFim.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fim do aluguer:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(6, 35);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerInicio.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Inicio do aluguer:";
            // 
            // buttonAddAluguer
            // 
            this.buttonAddAluguer.Location = new System.Drawing.Point(6, 271);
            this.buttonAddAluguer.Name = "buttonAddAluguer";
            this.buttonAddAluguer.Size = new System.Drawing.Size(205, 23);
            this.buttonAddAluguer.TabIndex = 25;
            this.buttonAddAluguer.Text = "Registar Novo Aluguer";
            this.buttonAddAluguer.UseVisualStyleBackColor = true;
            // 
            // FormGestaoAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelLeftCliente);
            this.Controls.Add(this.panelForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestaoAluguer";
            this.Text = "formGestaoAluguer";
            this.panelForm1.ResumeLayout(false);
            this.panelForm1.PerformLayout();
            this.panelLeftCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Label labelTituloForm1;
        private System.Windows.Forms.Panel panelLeftCliente;
        private System.Windows.Forms.Button buttonVendasCliente;
        private System.Windows.Forms.Button buttonOficinaCliente;
        private System.Windows.Forms.ListBox listBoxCarrosAluguer;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.Button buttonEditCarro;
        private System.Windows.Forms.Button buttonDeleteCarro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.Button buttonDeleteAluguer;
        private System.Windows.Forms.Button buttonFatura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelClienteSelecionado;
        private System.Windows.Forms.Label labelNIFCliente;
        private System.Windows.Forms.Label labelValorTotalCliente;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAddAluguer;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
    }
}