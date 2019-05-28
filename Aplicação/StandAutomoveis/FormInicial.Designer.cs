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
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.labelTituloForm1 = new System.Windows.Forms.Label();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.buttonGestaoVendas = new System.Windows.Forms.Button();
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.buttonGestaoOficina = new System.Windows.Forms.Button();
            this.buttonGestaoClientes = new System.Windows.Forms.Button();
            this.panelCarroTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelForm1.SuspendLayout();
            this.panelCarroTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm1
            // 
            this.panelForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelForm1.Controls.Add(this.panelCarroTop);
            this.panelForm1.Controls.Add(this.buttonExitApp);
            this.panelForm1.Controls.Add(this.labelTituloForm1);
            this.panelForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm1.Location = new System.Drawing.Point(0, 0);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(990, 65);
            this.panelForm1.TabIndex = 5;
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
            // buttonGestaoVendas
            // 
            this.buttonGestaoVendas.Image = global::StandAutomoveis.Properties.Resources.GestaoVendas;
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
            this.buttonGestaoAluguer.Image = global::StandAutomoveis.Properties.Resources.GestaoAluguer;
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
            this.buttonGestaoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestaoOficina.Image = global::StandAutomoveis.Properties.Resources.GestaoOficina;
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
            this.buttonGestaoClientes.Image = global::StandAutomoveis.Properties.Resources.GestaoClientes;
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
            this.panelCarroTop.Controls.Add(this.button1);
            this.panelCarroTop.Controls.Add(this.panel2);
            this.panelCarroTop.Controls.Add(this.panel1);
            this.panelCarroTop.Controls.Add(this.labelTituloCliente);
            this.panelCarroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarroTop.Location = new System.Drawing.Point(0, 0);
            this.panelCarroTop.Name = "panelCarroTop";
            this.panelCarroTop.Size = new System.Drawing.Size(990, 65);
            this.panelCarroTop.TabIndex = 8;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::StandAutomoveis.Properties.Resources.actions_exit_application;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(905, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.panelForm1);
            this.Controls.Add(this.buttonGestaoVendas);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoOficina);
            this.Controls.Add(this.buttonGestaoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.panelForm1.ResumeLayout(false);
            this.panelForm1.PerformLayout();
            this.panelCarroTop.ResumeLayout(false);
            this.panelCarroTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGestaoClientes;
        private System.Windows.Forms.Button buttonGestaoOficina;
        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.Button buttonGestaoVendas;
        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Label labelTituloForm1;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Panel panelCarroTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloCliente;
        private System.Windows.Forms.Button button1;
    }
}

