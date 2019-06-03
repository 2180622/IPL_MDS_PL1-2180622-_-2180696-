namespace StandAutomoveis
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.buttonGestaoVendas = new System.Windows.Forms.Button();
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.buttonGestaoOficina = new System.Windows.Forms.Button();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExitForm = new System.Windows.Forms.Button();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStandToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.carrosToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.carrosCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.alugueresStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.alugueresCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendasToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendasCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHorasAtuais = new System.Windows.Forms.Timer(this.components);
            this.panelCarroTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.BackColor = System.Drawing.Color.White;
            this.buttonGestaoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoVendas.Image = global::StandAutomoveis.Properties.Resources.GestaoVendas;
            this.buttonGestaoVendas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoVendas.Location = new System.Drawing.Point(697, 188);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(160, 160);
            this.buttonGestaoVendas.TabIndex = 4;
            this.buttonGestaoVendas.Text = "Gestão de Vendas";
            this.buttonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoVendas.UseVisualStyleBackColor = true;
            this.buttonGestaoVendas.Click += new System.EventHandler(this.buttonGestaoVendas_Click);
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoAluguer.Image = global::StandAutomoveis.Properties.Resources.GestaoAluguer;
            this.buttonGestaoAluguer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(495, 188);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(160, 160);
            this.buttonGestaoAluguer.TabIndex = 3;
            this.buttonGestaoAluguer.Text = "Gestão de Aluguer";
            this.buttonGestaoAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoAluguer.UseVisualStyleBackColor = true;
            this.buttonGestaoAluguer.Click += new System.EventHandler(this.buttonGestaoAluguer_Click);
            // 
            // buttonGestaoOficina
            // 
            this.buttonGestaoOficina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoOficina.Image = global::StandAutomoveis.Properties.Resources.GestaoOficina;
            this.buttonGestaoOficina.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoOficina.Location = new System.Drawing.Point(298, 188);
            this.buttonGestaoOficina.Name = "buttonGestaoOficina";
            this.buttonGestaoOficina.Size = new System.Drawing.Size(160, 160);
            this.buttonGestaoOficina.TabIndex = 2;
            this.buttonGestaoOficina.Text = "Gestão de Oficina";
            this.buttonGestaoOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoOficina.UseVisualStyleBackColor = true;
            this.buttonGestaoOficina.Click += new System.EventHandler(this.buttonGestaoOficina_Click);
            // 
            // buttonGestaoClientes
            // 
            this.buttonGestaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoClientes.Image = global::StandAutomoveis.Properties.Resources.GestaoClientes;
            this.buttonGestaoClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGestaoClientes.Location = new System.Drawing.Point(100, 188);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(160, 160);
            this.buttonGestaoClientes.TabIndex = 1;
            this.buttonGestaoClientes.Text = "Gestão de Clientes";
            this.buttonGestaoClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoClientes.UseVisualStyleBackColor = true;
            this.buttonGestaoClientes.Click += new System.EventHandler(this.buttonGestaoClientes_Click);
            // 
            // panelCarroTop
            // 
            this.panelCarroTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCarroTop.BackgroundImage = global::StandAutomoveis.Properties.Resources.blue_gradient_background_6518;
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.buttonExitForm);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(746, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 66);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(185, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 66);
            this.panel1.TabIndex = 12;
            // 
            // buttonExitForm
            // 
            this.buttonExitForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitForm.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_delete_48;
            this.buttonExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitForm.Location = new System.Drawing.Point(929, 0);
            this.buttonExitForm.Name = "buttonExitForm";
            this.buttonExitForm.Size = new System.Drawing.Size(61, 66);
            this.buttonExitForm.TabIndex = 11;
            this.buttonExitForm.UseVisualStyleBackColor = false;
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click_1);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(237, -3);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(522, 65);
            this.labelTituloCliente.TabIndex = 7;
            this.labelTituloCliente.Text = "Stand Automóveis";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStandToolStripStatusLabel,
            this.clientesToolStripStatusLabel,
            this.clientesCountToolStripStatusLabel,
            this.carrosToolStripStatusLabel,
            this.carrosCountToolStripStatusLabel,
            this.alugueresStripStatusLabel,
            this.alugueresCountToolStripStatusLabel,
            this.vendasToolStripStatusLabel,
            this.vendasCountToolStripStatusLabel,
            this.toolStripStatusLabelHoras});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoStandToolStripStatusLabel
            // 
            this.infoStandToolStripStatusLabel.Name = "infoStandToolStripStatusLabel";
            this.infoStandToolStripStatusLabel.Size = new System.Drawing.Size(177, 17);
            this.infoStandToolStripStatusLabel.Text = "Informação Stand Automóveis:  ";
            // 
            // clientesToolStripStatusLabel
            // 
            this.clientesToolStripStatusLabel.Name = "clientesToolStripStatusLabel";
            this.clientesToolStripStatusLabel.Size = new System.Drawing.Size(116, 17);
            this.clientesToolStripStatusLabel.Text = "Número de clientes: ";
            // 
            // clientesCountToolStripStatusLabel
            // 
            this.clientesCountToolStripStatusLabel.Name = "clientesCountToolStripStatusLabel";
            this.clientesCountToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.clientesCountToolStripStatusLabel.Text = "null";
            // 
            // carrosToolStripStatusLabel
            // 
            this.carrosToolStripStatusLabel.Name = "carrosToolStripStatusLabel";
            this.carrosToolStripStatusLabel.Size = new System.Drawing.Size(105, 17);
            this.carrosToolStripStatusLabel.Text = "Número de carros:";
            // 
            // carrosCountToolStripStatusLabel
            // 
            this.carrosCountToolStripStatusLabel.Name = "carrosCountToolStripStatusLabel";
            this.carrosCountToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.carrosCountToolStripStatusLabel.Text = "null";
            // 
            // alugueresStripStatusLabel
            // 
            this.alugueresStripStatusLabel.Name = "alugueresStripStatusLabel";
            this.alugueresStripStatusLabel.Size = new System.Drawing.Size(127, 17);
            this.alugueresStripStatusLabel.Text = "Número de alugueres: ";
            // 
            // alugueresCountToolStripStatusLabel
            // 
            this.alugueresCountToolStripStatusLabel.Name = "alugueresCountToolStripStatusLabel";
            this.alugueresCountToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.alugueresCountToolStripStatusLabel.Text = "null";
            // 
            // vendasToolStripStatusLabel
            // 
            this.vendasToolStripStatusLabel.Name = "vendasToolStripStatusLabel";
            this.vendasToolStripStatusLabel.Size = new System.Drawing.Size(110, 17);
            this.vendasToolStripStatusLabel.Text = "Número de vendas:";
            // 
            // vendasCountToolStripStatusLabel
            // 
            this.vendasCountToolStripStatusLabel.Name = "vendasCountToolStripStatusLabel";
            this.vendasCountToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.vendasCountToolStripStatusLabel.Text = "null";
            // 
            // toolStripStatusLabelHoras
            // 
            this.toolStripStatusLabelHoras.Name = "toolStripStatusLabelHoras";
            this.toolStripStatusLabelHoras.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelHoras.Text = "00:00:00";
            // 
            // timerHorasAtuais
            // 
            this.timerHorasAtuais.Enabled = true;
            this.timerHorasAtuais.Interval = 1000;
            this.timerHorasAtuais.Tick += new System.EventHandler(this.timerHorasAtuais_Tick);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelCarroTop);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Button buttonGestaoOficina;
        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.Button buttonGestaoVendas;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExitForm;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel clientesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel alugueresStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel vendasToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel carrosToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel infoStandToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel clientesCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel carrosCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel alugueresCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel vendasCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoras;
        private System.Windows.Forms.Timer timerHorasAtuais;
    }
}

