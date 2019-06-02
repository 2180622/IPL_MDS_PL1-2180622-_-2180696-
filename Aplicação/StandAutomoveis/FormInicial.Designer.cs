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
            this.clientesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.alugueresStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendasToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.carrosToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoStandToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.carrosCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.alugueresCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendasCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.buttonGestaoVendas.Location = new System.Drawing.Point(929, 231);
            this.buttonGestaoVendas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(213, 197);
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
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(660, 231);
            this.buttonGestaoAluguer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(213, 197);
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
            this.buttonGestaoOficina.Location = new System.Drawing.Point(397, 231);
            this.buttonGestaoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestaoOficina.Name = "buttonGestaoOficina";
            this.buttonGestaoOficina.Size = new System.Drawing.Size(213, 197);
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
            this.buttonGestaoClientes.Location = new System.Drawing.Point(133, 231);
            this.buttonGestaoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestaoClientes.Name = "buttonGestaoClientes";
            this.buttonGestaoClientes.Size = new System.Drawing.Size(213, 197);
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
            this.panelCarroTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(1320, 80);
            this.panelCarroTop.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_traffic_jam_64;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(995, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 81);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::StandAutomoveis.Properties.Resources.icons8_fiat_500_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 81);
            this.panel1.TabIndex = 12;
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
            this.buttonExitForm.Click += new System.EventHandler(this.buttonExitForm_Click_1);
            // 
            // labelTituloCliente
            // 
            this.labelTituloCliente.AutoSize = true;
            this.labelTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.labelTituloCliente.Location = new System.Drawing.Point(316, -4);
            this.labelTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloCliente.Name = "labelTituloCliente";
            this.labelTituloCliente.Size = new System.Drawing.Size(644, 80);
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
            this.vendasCountToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1320, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // clientesToolStripStatusLabel
            // 
            this.clientesToolStripStatusLabel.Name = "clientesToolStripStatusLabel";
            this.clientesToolStripStatusLabel.Size = new System.Drawing.Size(145, 20);
            this.clientesToolStripStatusLabel.Text = "Número de clientes: ";
            // 
            // alugueresStripStatusLabel
            // 
            this.alugueresStripStatusLabel.Name = "alugueresStripStatusLabel";
            this.alugueresStripStatusLabel.Size = new System.Drawing.Size(159, 20);
            this.alugueresStripStatusLabel.Text = "Número de alugueres: ";
            // 
            // vendasToolStripStatusLabel
            // 
            this.vendasToolStripStatusLabel.Name = "vendasToolStripStatusLabel";
            this.vendasToolStripStatusLabel.Size = new System.Drawing.Size(137, 20);
            this.vendasToolStripStatusLabel.Text = "Número de vendas:";
            // 
            // carrosToolStripStatusLabel
            // 
            this.carrosToolStripStatusLabel.Name = "carrosToolStripStatusLabel";
            this.carrosToolStripStatusLabel.Size = new System.Drawing.Size(131, 20);
            this.carrosToolStripStatusLabel.Text = "Número de carros:";
            // 
            // infoStandToolStripStatusLabel
            // 
            this.infoStandToolStripStatusLabel.Name = "infoStandToolStripStatusLabel";
            this.infoStandToolStripStatusLabel.Size = new System.Drawing.Size(221, 20);
            this.infoStandToolStripStatusLabel.Text = "Informação Stand Automóveis:  ";
            // 
            // clientesCountToolStripStatusLabel
            // 
            this.clientesCountToolStripStatusLabel.Name = "clientesCountToolStripStatusLabel";
            this.clientesCountToolStripStatusLabel.Size = new System.Drawing.Size(33, 20);
            this.clientesCountToolStripStatusLabel.Text = "null";
            // 
            // carrosCountToolStripStatusLabel
            // 
            this.carrosCountToolStripStatusLabel.Name = "carrosCountToolStripStatusLabel";
            this.carrosCountToolStripStatusLabel.Size = new System.Drawing.Size(33, 20);
            this.carrosCountToolStripStatusLabel.Text = "null";
            // 
            // alugueresCountToolStripStatusLabel
            // 
            this.alugueresCountToolStripStatusLabel.Name = "alugueresCountToolStripStatusLabel";
            this.alugueresCountToolStripStatusLabel.Size = new System.Drawing.Size(33, 20);
            this.alugueresCountToolStripStatusLabel.Text = "null";
            // 
            // vendasCountToolStripStatusLabel
            // 
            this.vendasCountToolStripStatusLabel.Name = "vendasCountToolStripStatusLabel";
            this.vendasCountToolStripStatusLabel.Size = new System.Drawing.Size(33, 20);
            this.vendasCountToolStripStatusLabel.Text = "null";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelCarroTop);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

