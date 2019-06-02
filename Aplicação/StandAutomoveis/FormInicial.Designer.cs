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
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.BackColor = System.Drawing.Color.White;
            this.buttonGestaoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoVendas.Image = global::StandAutomoveis.Properties.Resources.GestaoVendas;
            this.buttonGestaoVendas.Location = new System.Drawing.Point(929, 231);
            this.buttonGestaoVendas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGestaoVendas.Name = "buttonGestaoVendas";
            this.buttonGestaoVendas.Size = new System.Drawing.Size(213, 197);
            this.buttonGestaoVendas.TabIndex = 4;
            this.buttonGestaoVendas.Text = "Gestão de Vendas";
            this.buttonGestaoVendas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGestaoVendas.UseVisualStyleBackColor = false;
            this.buttonGestaoVendas.Click += new System.EventHandler(this.buttonGestaoVendas_Click);
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGestaoAluguer.Image = global::StandAutomoveis.Properties.Resources.GestaoAluguer;
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
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StandAutomoveis.Properties.Resources.abstract_white_transparent_waves_in_motion_at_the_top_and_bottom_on_gradient_blue_background_loop_animation_4vowt3ocg__F0000;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panelCarroTop);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

