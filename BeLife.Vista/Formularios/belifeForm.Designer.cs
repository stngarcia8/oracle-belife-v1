namespace BeLife.Vista.Formularios
{
    partial class belifeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(belifeForm));
            this.formularioMenuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesSalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.listadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.listadoContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioToolStrip = new System.Windows.Forms.ToolStrip();
            this.maestroClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listadoClientesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.separadorToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maestroContratosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listadoContratosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.barraStatusStrip = new System.Windows.Forms.StatusStrip();
            this.textoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.beLifeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.formularioMenuStrip.SuspendLayout();
            this.formularioToolStrip.SuspendLayout();
            this.barraStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formularioMenuStrip
            // 
            this.formularioMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.contratosToolStripMenuItem});
            this.formularioMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formularioMenuStrip.Name = "formularioMenuStrip";
            this.formularioMenuStrip.Size = new System.Drawing.Size(426, 27);
            this.formularioMenuStrip.TabIndex = 0;
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesSalirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // opcionesSalirToolStripMenuItem
            // 
            this.opcionesSalirToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.cerrar;
            this.opcionesSalirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcionesSalirToolStripMenuItem.Name = "opcionesSalirToolStripMenuItem";
            this.opcionesSalirToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.opcionesSalirToolStripMenuItem.Text = "&Salir.";
            this.opcionesSalirToolStripMenuItem.Click += new System.EventHandler(this.opcionesSalirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroClientesToolStripMenuItem,
            this.clientesToolStripSeparator,
            this.listadoClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // maestroClientesToolStripMenuItem
            // 
            this.maestroClientesToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.Clientes;
            this.maestroClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maestroClientesToolStripMenuItem.Name = "maestroClientesToolStripMenuItem";
            this.maestroClientesToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.maestroClientesToolStripMenuItem.Text = "&Maestro de clientes.";
            this.maestroClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maestroClientesToolStripMenuItem.Click += new System.EventHandler(this.maestroClientesToolStripMenuItem_Click);
            // 
            // clientesToolStripSeparator
            // 
            this.clientesToolStripSeparator.Name = "clientesToolStripSeparator";
            this.clientesToolStripSeparator.Size = new System.Drawing.Size(214, 6);
            // 
            // listadoClientesToolStripMenuItem
            // 
            this.listadoClientesToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.ClientSearch;
            this.listadoClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listadoClientesToolStripMenuItem.Name = "listadoClientesToolStripMenuItem";
            this.listadoClientesToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.listadoClientesToolStripMenuItem.Text = "&Listado de clientes.";
            this.listadoClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listadoClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoClientesToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroContratosToolStripMenuItem,
            this.contratosToolStripSeparator,
            this.listadoContratosToolStripMenuItem});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.contratosToolStripMenuItem.Text = "Co&ntratos";
            // 
            // maestroContratosToolStripMenuItem
            // 
            this.maestroContratosToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.Contratos;
            this.maestroContratosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maestroContratosToolStripMenuItem.Name = "maestroContratosToolStripMenuItem";
            this.maestroContratosToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.maestroContratosToolStripMenuItem.Text = "&Maestro de contratos.";
            this.maestroContratosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maestroContratosToolStripMenuItem.Click += new System.EventHandler(this.maestroContratosToolStripMenuItem_Click);
            // 
            // contratosToolStripSeparator
            // 
            this.contratosToolStripSeparator.Name = "contratosToolStripSeparator";
            this.contratosToolStripSeparator.Size = new System.Drawing.Size(227, 6);
            // 
            // listadoContratosToolStripMenuItem
            // 
            this.listadoContratosToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.ContractSearch;
            this.listadoContratosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listadoContratosToolStripMenuItem.Name = "listadoContratosToolStripMenuItem";
            this.listadoContratosToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.listadoContratosToolStripMenuItem.Text = "&Listado de contratos.";
            this.listadoContratosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listadoContratosToolStripMenuItem.Click += new System.EventHandler(this.listadoContratosToolStripMenuItem_Click);
            // 
            // formularioToolStrip
            // 
            this.formularioToolStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formularioToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroClientesToolStripButton,
            this.listadoClientesToolStripButton,
            this.separadorToolStripSeparator1,
            this.maestroContratosToolStripButton,
            this.listadoContratosToolStripButton});
            this.formularioToolStrip.Location = new System.Drawing.Point(0, 27);
            this.formularioToolStrip.Name = "formularioToolStrip";
            this.formularioToolStrip.Size = new System.Drawing.Size(426, 27);
            this.formularioToolStrip.Stretch = true;
            this.formularioToolStrip.TabIndex = 2;
            this.formularioToolStrip.TabStop = true;
            // 
            // maestroClientesToolStripButton
            // 
            this.maestroClientesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maestroClientesToolStripButton.Image = global::BeLife.Vista.Properties.Resources.Clientes;
            this.maestroClientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maestroClientesToolStripButton.Name = "maestroClientesToolStripButton";
            this.maestroClientesToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.maestroClientesToolStripButton.Text = "Maestro de clientes.";
            this.maestroClientesToolStripButton.Click += new System.EventHandler(this.maestroClientesToolStripButton_Click);
            // 
            // listadoClientesToolStripButton
            // 
            this.listadoClientesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadoClientesToolStripButton.Image = global::BeLife.Vista.Properties.Resources.ClientSearch;
            this.listadoClientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listadoClientesToolStripButton.Name = "listadoClientesToolStripButton";
            this.listadoClientesToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.listadoClientesToolStripButton.Text = "Listado de clientes.";
            this.listadoClientesToolStripButton.Click += new System.EventHandler(this.listadoClientesToolStripButton_Click);
            // 
            // separadorToolStripSeparator1
            // 
            this.separadorToolStripSeparator1.Name = "separadorToolStripSeparator1";
            this.separadorToolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // maestroContratosToolStripButton
            // 
            this.maestroContratosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maestroContratosToolStripButton.Image = global::BeLife.Vista.Properties.Resources.Contratos;
            this.maestroContratosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maestroContratosToolStripButton.Name = "maestroContratosToolStripButton";
            this.maestroContratosToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.maestroContratosToolStripButton.Text = "Maestro de contratos.";
            this.maestroContratosToolStripButton.Click += new System.EventHandler(this.maestroContratosToolStripButton_Click);
            // 
            // listadoContratosToolStripButton
            // 
            this.listadoContratosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadoContratosToolStripButton.Image = global::BeLife.Vista.Properties.Resources.ContractSearch;
            this.listadoContratosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listadoContratosToolStripButton.Name = "listadoContratosToolStripButton";
            this.listadoContratosToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.listadoContratosToolStripButton.Text = "Listado de contratos.";
            this.listadoContratosToolStripButton.Click += new System.EventHandler(this.listadoContratosToolStripButton_Click);
            // 
            // barraStatusStrip
            // 
            this.barraStatusStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripStatusLabel,
            this.beLifeToolStripStatusLabel});
            this.barraStatusStrip.Location = new System.Drawing.Point(0, 216);
            this.barraStatusStrip.Name = "barraStatusStrip";
            this.barraStatusStrip.Size = new System.Drawing.Size(426, 24);
            this.barraStatusStrip.TabIndex = 3;
            // 
            // textoToolStripStatusLabel
            // 
            this.textoToolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoToolStripStatusLabel.Name = "textoToolStripStatusLabel";
            this.textoToolStripStatusLabel.Size = new System.Drawing.Size(320, 19);
            this.textoToolStripStatusLabel.Spring = true;
            this.textoToolStripStatusLabel.Text = "Compañía de seguros \'BeLife\'";
            this.textoToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // beLifeToolStripStatusLabel
            // 
            this.beLifeToolStripStatusLabel.DoubleClickEnabled = true;
            this.beLifeToolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beLifeToolStripStatusLabel.Image = global::BeLife.Vista.Properties.Resources.LogoBeLife;
            this.beLifeToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beLifeToolStripStatusLabel.Name = "beLifeToolStripStatusLabel";
            this.beLifeToolStripStatusLabel.Size = new System.Drawing.Size(91, 19);
            this.beLifeToolStripStatusLabel.Text = "Belife v0.0.1";
            this.beLifeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.beLifeToolStripStatusLabel.DoubleClick += new System.EventHandler(this.beLifeToolStripStatusLabel_DoubleClick);
            // 
            // belifeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeLife.Vista.Properties.Resources.LogoBeLife;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(426, 240);
            this.Controls.Add(this.barraStatusStrip);
            this.Controls.Add(this.formularioToolStrip);
            this.Controls.Add(this.formularioMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.formularioMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 279);
            this.Name = "belifeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Seguros BeLife.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.belifeForm_FormClosing);
            this.Load += new System.EventHandler(this.belifeForm_Load);
            this.formularioMenuStrip.ResumeLayout(false);
            this.formularioMenuStrip.PerformLayout();
            this.formularioToolStrip.ResumeLayout(false);
            this.formularioToolStrip.PerformLayout();
            this.barraStatusStrip.ResumeLayout(false);
            this.barraStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formularioMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesSalirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip formularioToolStrip;
        private System.Windows.Forms.ToolStripSeparator separadorToolStripSeparator1;
        private System.Windows.Forms.StatusStrip barraStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel beLifeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator clientesToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem listadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton maestroClientesToolStripButton;
        private System.Windows.Forms.ToolStripButton listadoClientesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem maestroContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator contratosToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem listadoContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton maestroContratosToolStripButton;
        private System.Windows.Forms.ToolStripButton listadoContratosToolStripButton;
    }
}