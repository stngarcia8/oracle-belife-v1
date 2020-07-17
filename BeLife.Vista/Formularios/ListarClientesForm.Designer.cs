namespace BeLife.Vista.Formularios
{
    partial class ListarClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarClientesForm));
            this.formularioMenuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioPictureBox = new System.Windows.Forms.PictureBox();
            this.FiltrosLabel = new System.Windows.Forms.Label();
            this.filtrosComboBox = new System.Windows.Forms.ComboBox();
            this.valorFiltroLabel = new System.Windows.Forms.Label();
            this.valorFiltroComboBox = new System.Windows.Forms.ComboBox();
            this.valorFiltroTextBox = new System.Windows.Forms.TextBox();
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.listadoLabel = new System.Windows.Forms.Label();
            this.formularioStatusStrip = new System.Windows.Forms.StatusStrip();
            this.textoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.formularioToolStrip = new System.Windows.Forms.ToolStrip();
            this.actualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscarButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.formularioMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.formularioStatusStrip.SuspendLayout();
            this.formularioToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formularioMenuStrip
            // 
            this.formularioMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.formularioMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formularioMenuStrip.Name = "formularioMenuStrip";
            this.formularioMenuStrip.Size = new System.Drawing.Size(767, 27);
            this.formularioMenuStrip.TabIndex = 0;
            this.formularioMenuStrip.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.actualizar;
            this.actualizarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.actualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.actualizarToolStripMenuItem.Text = "&Actualizar lista.";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // formularioPictureBox
            // 
            this.formularioPictureBox.Image = global::BeLife.Vista.Properties.Resources.DataSearch;
            this.formularioPictureBox.Location = new System.Drawing.Point(0, 60);
            this.formularioPictureBox.Name = "formularioPictureBox";
            this.formularioPictureBox.Size = new System.Drawing.Size(100, 90);
            this.formularioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formularioPictureBox.TabIndex = 1;
            this.formularioPictureBox.TabStop = false;
            // 
            // FiltrosLabel
            // 
            this.FiltrosLabel.AutoSize = true;
            this.FiltrosLabel.Location = new System.Drawing.Point(125, 60);
            this.FiltrosLabel.Name = "FiltrosLabel";
            this.FiltrosLabel.Size = new System.Drawing.Size(58, 19);
            this.FiltrosLabel.TabIndex = 2;
            this.FiltrosLabel.Text = "Filtros:";
            // 
            // filtrosComboBox
            // 
            this.filtrosComboBox.AccessibleDescription = "Filtro";
            this.filtrosComboBox.AccessibleName = "Seleccione filtro.";
            this.filtrosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrosComboBox.FormattingEnabled = true;
            this.filtrosComboBox.Items.AddRange(new object[] {
            "Sin filtro.",
            "Por rut.",
            "Por estado civil.",
            "Por sexo."});
            this.filtrosComboBox.Location = new System.Drawing.Point(200, 60);
            this.filtrosComboBox.Name = "filtrosComboBox";
            this.filtrosComboBox.Size = new System.Drawing.Size(150, 27);
            this.filtrosComboBox.TabIndex = 3;
            this.filtrosComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrosComboBox_SelectedIndexChanged);
            // 
            // valorFiltroLabel
            // 
            this.valorFiltroLabel.AutoSize = true;
            this.valorFiltroLabel.Location = new System.Drawing.Point(375, 60);
            this.valorFiltroLabel.Name = "valorFiltroLabel";
            this.valorFiltroLabel.Size = new System.Drawing.Size(90, 19);
            this.valorFiltroLabel.TabIndex = 4;
            this.valorFiltroLabel.Text = "Valor filtro:";
            // 
            // valorFiltroComboBox
            // 
            this.valorFiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valorFiltroComboBox.FormattingEnabled = true;
            this.valorFiltroComboBox.Location = new System.Drawing.Point(475, 60);
            this.valorFiltroComboBox.Name = "valorFiltroComboBox";
            this.valorFiltroComboBox.Size = new System.Drawing.Size(125, 27);
            this.valorFiltroComboBox.TabIndex = 5;
            // 
            // valorFiltroTextBox
            // 
            this.valorFiltroTextBox.AccessibleDescription = "Rut cliente";
            this.valorFiltroTextBox.AccessibleName = "Ingrese rut del cliente que desea filtrar, el formato es: numero rut separado por" +
    " guión mas digito verificador.";
            this.valorFiltroTextBox.Location = new System.Drawing.Point(475, 60);
            this.valorFiltroTextBox.MaxLength = 10;
            this.valorFiltroTextBox.Name = "valorFiltroTextBox";
            this.valorFiltroTextBox.Size = new System.Drawing.Size(125, 27);
            this.valorFiltroTextBox.TabIndex = 6;
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "aceptar.png");
            this.formularioImageList.Images.SetKeyName(1, "cancelar.png");
            this.formularioImageList.Images.SetKeyName(2, "ClientSearch.png");
            this.formularioImageList.Images.SetKeyName(3, "ClientAdd.png");
            this.formularioImageList.Images.SetKeyName(4, "ClientUpdate.png");
            // 
            // cancelarButton
            // 
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.ImageKey = "cancelar.png";
            this.cancelarButton.ImageList = this.formularioImageList;
            this.cancelarButton.Location = new System.Drawing.Point(625, 420);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(125, 23);
            this.cancelarButton.TabIndex = 13;
            this.cancelarButton.Text = "Cerrar";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarButton.ImageKey = "aceptar.png";
            this.aceptarButton.ImageList = this.formularioImageList;
            this.aceptarButton.Location = new System.Drawing.Point(500, 420);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(100, 23);
            this.aceptarButton.TabIndex = 12;
            this.aceptarButton.Text = "&Aceptar";
            this.aceptarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.AllowUserToOrderColumns = true;
            this.listadoDataGridView.AllowUserToResizeRows = false;
            this.listadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(125, 120);
            this.listadoDataGridView.MultiSelect = false;
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.RowTemplate.Height = 23;
            this.listadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDataGridView.ShowCellErrors = false;
            this.listadoDataGridView.ShowCellToolTips = false;
            this.listadoDataGridView.ShowEditingIcon = false;
            this.listadoDataGridView.ShowRowErrors = false;
            this.listadoDataGridView.Size = new System.Drawing.Size(625, 270);
            this.listadoDataGridView.TabIndex = 9;
            this.listadoDataGridView.SelectionChanged += new System.EventHandler(this.listadoDataGridView_SelectionChanged);
            this.listadoDataGridView.DoubleClick += new System.EventHandler(this.listadoDataGridView_DoubleClick);
            // 
            // listadoLabel
            // 
            this.listadoLabel.AutoSize = true;
            this.listadoLabel.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoLabel.Location = new System.Drawing.Point(125, 90);
            this.listadoLabel.Name = "listadoLabel";
            this.listadoLabel.Size = new System.Drawing.Size(242, 19);
            this.listadoLabel.TabIndex = 8;
            this.listadoLabel.Text = "Lista de clientes disponibles.";
            // 
            // formularioStatusStrip
            // 
            this.formularioStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripStatusLabel});
            this.formularioStatusStrip.Location = new System.Drawing.Point(0, 453);
            this.formularioStatusStrip.Name = "formularioStatusStrip";
            this.formularioStatusStrip.Size = new System.Drawing.Size(767, 22);
            this.formularioStatusStrip.TabIndex = 12;
            this.formularioStatusStrip.Text = "statusStrip1";
            // 
            // textoToolStripStatusLabel
            // 
            this.textoToolStripStatusLabel.Name = "textoToolStripStatusLabel";
            this.textoToolStripStatusLabel.Size = new System.Drawing.Size(752, 17);
            this.textoToolStripStatusLabel.Spring = true;
            this.textoToolStripStatusLabel.Text = "Mensajes";
            this.textoToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formularioToolStrip
            // 
            this.formularioToolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripButton});
            this.formularioToolStrip.Location = new System.Drawing.Point(0, 27);
            this.formularioToolStrip.Name = "formularioToolStrip";
            this.formularioToolStrip.Size = new System.Drawing.Size(767, 25);
            this.formularioToolStrip.TabIndex = 13;
            this.formularioToolStrip.Text = "toolStrip1";
            // 
            // actualizarToolStripButton
            // 
            this.actualizarToolStripButton.AccessibleDescription = "Actualizar";
            this.actualizarToolStripButton.AccessibleName = "Actualizar lista.";
            this.actualizarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actualizarToolStripButton.Image = global::BeLife.Vista.Properties.Resources.actualizar;
            this.actualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizarToolStripButton.Name = "actualizarToolStripButton";
            this.actualizarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.actualizarToolStripButton.Text = "&Actualizar";
            this.actualizarToolStripButton.Click += new System.EventHandler(this.actualizarToolStripButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.ImageKey = "ClientSearch.png";
            this.buscarButton.ImageList = this.formularioImageList;
            this.buscarButton.Location = new System.Drawing.Point(625, 60);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(125, 23);
            this.buscarButton.TabIndex = 7;
            this.buscarButton.Text = "&Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.AutoSize = true;
            this.agregarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.ImageKey = "ClientAdd.png";
            this.agregarButton.ImageList = this.formularioImageList;
            this.agregarButton.Location = new System.Drawing.Point(125, 420);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(134, 29);
            this.agregarButton.TabIndex = 10;
            this.agregarButton.Text = "&Nuevo cliente";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.AutoSize = true;
            this.editarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editarButton.ImageKey = "ClientUpdate.png";
            this.editarButton.ImageList = this.formularioImageList;
            this.editarButton.Location = new System.Drawing.Point(275, 420);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(130, 29);
            this.editarButton.TabIndex = 11;
            this.editarButton.Text = "&Editar cliente";
            this.editarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // ListarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(767, 475);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.formularioToolStrip);
            this.Controls.Add(this.formularioStatusStrip);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.listadoDataGridView);
            this.Controls.Add(this.listadoLabel);
            this.Controls.Add(this.valorFiltroTextBox);
            this.Controls.Add(this.valorFiltroComboBox);
            this.Controls.Add(this.valorFiltroLabel);
            this.Controls.Add(this.filtrosComboBox);
            this.Controls.Add(this.FiltrosLabel);
            this.Controls.Add(this.formularioPictureBox);
            this.Controls.Add(this.formularioMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.formularioMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListarClientesForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros BeLife - Buscar clientes.";
            this.Load += new System.EventHandler(this.ListarClientesForm_Load);
            this.formularioMenuStrip.ResumeLayout(false);
            this.formularioMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.formularioStatusStrip.ResumeLayout(false);
            this.formularioStatusStrip.PerformLayout();
            this.formularioToolStrip.ResumeLayout(false);
            this.formularioToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formularioMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.PictureBox formularioPictureBox;
        private System.Windows.Forms.Label FiltrosLabel;
        private System.Windows.Forms.ComboBox filtrosComboBox;
        private System.Windows.Forms.Label valorFiltroLabel;
        private System.Windows.Forms.ComboBox valorFiltroComboBox;
        private System.Windows.Forms.TextBox valorFiltroTextBox;
        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Label listadoLabel;
        private System.Windows.Forms.StatusStrip formularioStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textoToolStripStatusLabel;
        private System.Windows.Forms.ToolStrip formularioToolStrip;
        private System.Windows.Forms.ToolStripButton actualizarToolStripButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button editarButton;
    }
}