namespace BeLife.Vista.Formularios
{
    partial class MaestroClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaestroClientesForm));
            this.formularioImageList = new System.Windows.Forms.ImageList(this.components);
            this.formularioTabControl = new System.Windows.Forms.TabControl();
            this.datosClienteTabPage = new System.Windows.Forms.TabPage();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.grabarButton = new System.Windows.Forms.Button();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.estadoCivilLabel = new System.Windows.Forms.Label();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nacimientoLabel = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.rutButton = new System.Windows.Forms.Button();
            this.rutTextBox = new System.Windows.Forms.TextBox();
            this.rutLabel = new System.Windows.Forms.Label();
            this.contratosTabPage = new System.Windows.Forms.TabPage();
            this.cantidadContratosLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contratosDataGridView = new System.Windows.Forms.DataGridView();
            this.formularioMenuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioPictureBox = new System.Windows.Forms.PictureBox();
            this.formularioToolStrip = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eliminarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.barraEstadoStatusStrip = new System.Windows.Forms.StatusStrip();
            this.textoSoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.formularioTabControl.SuspendLayout();
            this.datosClienteTabPage.SuspendLayout();
            this.contratosTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratosDataGridView)).BeginInit();
            this.formularioMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).BeginInit();
            this.formularioToolStrip.SuspendLayout();
            this.barraEstadoStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // formularioImageList
            // 
            this.formularioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formularioImageList.ImageStream")));
            this.formularioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.formularioImageList.Images.SetKeyName(0, "DataSearch.png");
            this.formularioImageList.Images.SetKeyName(1, "cancelar.png");
            this.formularioImageList.Images.SetKeyName(2, "grabar.png");
            // 
            // formularioTabControl
            // 
            this.formularioTabControl.Controls.Add(this.datosClienteTabPage);
            this.formularioTabControl.Controls.Add(this.contratosTabPage);
            this.formularioTabControl.Location = new System.Drawing.Point(150, 60);
            this.formularioTabControl.Name = "formularioTabControl";
            this.formularioTabControl.SelectedIndex = 0;
            this.formularioTabControl.Size = new System.Drawing.Size(475, 360);
            this.formularioTabControl.TabIndex = 18;
            // 
            // datosClienteTabPage
            // 
            this.datosClienteTabPage.Controls.Add(this.cancelarButton);
            this.datosClienteTabPage.Controls.Add(this.grabarButton);
            this.datosClienteTabPage.Controls.Add(this.estadoCivilComboBox);
            this.datosClienteTabPage.Controls.Add(this.estadoCivilLabel);
            this.datosClienteTabPage.Controls.Add(this.sexoComboBox);
            this.datosClienteTabPage.Controls.Add(this.sexoLabel);
            this.datosClienteTabPage.Controls.Add(this.nacimientoDateTimePicker);
            this.datosClienteTabPage.Controls.Add(this.nacimientoLabel);
            this.datosClienteTabPage.Controls.Add(this.apellidoTextBox);
            this.datosClienteTabPage.Controls.Add(this.apellidoLabel);
            this.datosClienteTabPage.Controls.Add(this.nombreTextBox);
            this.datosClienteTabPage.Controls.Add(this.nombreLabel);
            this.datosClienteTabPage.Controls.Add(this.rutButton);
            this.datosClienteTabPage.Controls.Add(this.rutTextBox);
            this.datosClienteTabPage.Controls.Add(this.rutLabel);
            this.datosClienteTabPage.Location = new System.Drawing.Point(4, 28);
            this.datosClienteTabPage.Name = "datosClienteTabPage";
            this.datosClienteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.datosClienteTabPage.Size = new System.Drawing.Size(467, 328);
            this.datosClienteTabPage.TabIndex = 0;
            this.datosClienteTabPage.Text = "Datos del cliente.";
            this.datosClienteTabPage.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.AutoSize = true;
            this.cancelarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarButton.ImageKey = "cancelar.png";
            this.cancelarButton.ImageList = this.formularioImageList;
            this.cancelarButton.Location = new System.Drawing.Point(350, 270);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(99, 29);
            this.cancelarButton.TabIndex = 21;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // grabarButton
            // 
            this.grabarButton.AutoSize = true;
            this.grabarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grabarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grabarButton.ImageKey = "grabar.png";
            this.grabarButton.ImageList = this.formularioImageList;
            this.grabarButton.Location = new System.Drawing.Point(225, 270);
            this.grabarButton.Name = "grabarButton";
            this.grabarButton.Size = new System.Drawing.Size(87, 29);
            this.grabarButton.TabIndex = 20;
            this.grabarButton.Text = "&Grabar";
            this.grabarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grabarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grabarButton.UseVisualStyleBackColor = true;
            this.grabarButton.Click += new System.EventHandler(this.grabarButton_Click);
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.AccessibleDescription = "Estado civil cliente.";
            this.estadoCivilComboBox.AccessibleName = "Seleccione estado civil del cliente.";
            this.estadoCivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Location = new System.Drawing.Point(200, 210);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(175, 27);
            this.estadoCivilComboBox.TabIndex = 17;
            // 
            // estadoCivilLabel
            // 
            this.estadoCivilLabel.AutoSize = true;
            this.estadoCivilLabel.Location = new System.Drawing.Point(50, 210);
            this.estadoCivilLabel.Name = "estadoCivilLabel";
            this.estadoCivilLabel.Size = new System.Drawing.Size(94, 19);
            this.estadoCivilLabel.TabIndex = 16;
            this.estadoCivilLabel.Text = "Estado civil:";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.AccessibleDescription = "Sexo cliente.";
            this.sexoComboBox.AccessibleName = "Seleccione sexo del cliente.";
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(200, 180);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(175, 27);
            this.sexoComboBox.TabIndex = 15;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(50, 180);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(49, 19);
            this.sexoLabel.TabIndex = 14;
            this.sexoLabel.Text = "Sexo:";
            // 
            // nacimientoDateTimePicker
            // 
            this.nacimientoDateTimePicker.AccessibleDescription = "Fecha de nacimiento.";
            this.nacimientoDateTimePicker.AccessibleName = "Ingrese fecha de nacimiento.";
            this.nacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimientoDateTimePicker.Location = new System.Drawing.Point(200, 150);
            this.nacimientoDateTimePicker.Name = "nacimientoDateTimePicker";
            this.nacimientoDateTimePicker.Size = new System.Drawing.Size(150, 27);
            this.nacimientoDateTimePicker.TabIndex = 13;
            // 
            // nacimientoLabel
            // 
            this.nacimientoLabel.AutoSize = true;
            this.nacimientoLabel.Location = new System.Drawing.Point(50, 150);
            this.nacimientoLabel.Name = "nacimientoLabel";
            this.nacimientoLabel.Size = new System.Drawing.Size(137, 19);
            this.nacimientoLabel.TabIndex = 12;
            this.nacimientoLabel.Text = "Fecha nacimiento:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.AccessibleDescription = "Apellido cliente.";
            this.apellidoTextBox.AccessibleName = "Ingrese apellido cliente.";
            this.apellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidoTextBox.Location = new System.Drawing.Point(200, 120);
            this.apellidoTextBox.MaxLength = 20;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(150, 27);
            this.apellidoTextBox.TabIndex = 11;
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(50, 120);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(73, 19);
            this.apellidoLabel.TabIndex = 10;
            this.apellidoLabel.Text = "Apellido:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.AccessibleDescription = "Nombre cliente.";
            this.nombreTextBox.AccessibleName = "Ingrese nombre cliente.";
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(200, 90);
            this.nombreTextBox.MaxLength = 20;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(150, 27);
            this.nombreTextBox.TabIndex = 9;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(50, 90);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(72, 19);
            this.nombreLabel.TabIndex = 8;
            this.nombreLabel.Text = "Nombre:";
            // 
            // rutButton
            // 
            this.rutButton.AccessibleDescription = "Buscar botón.";
            this.rutButton.AccessibleName = "Buscar rut";
            this.rutButton.AutoSize = true;
            this.rutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rutButton.ImageKey = "DataSearch.png";
            this.rutButton.ImageList = this.formularioImageList;
            this.rutButton.Location = new System.Drawing.Point(400, 30);
            this.rutButton.Name = "rutButton";
            this.rutButton.Size = new System.Drawing.Size(26, 26);
            this.rutButton.TabIndex = 7;
            this.rutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rutButton.UseVisualStyleBackColor = true;
            this.rutButton.Click += new System.EventHandler(this.rutButton_Click);
            // 
            // rutTextBox
            // 
            this.rutTextBox.AccessibleDescription = "Rut cliente.";
            this.rutTextBox.AccessibleName = "Ingrese rut del cliente, el formato es: numero rut separado por guión mas digito " +
    "verificador.";
            this.rutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rutTextBox.Location = new System.Drawing.Point(200, 30);
            this.rutTextBox.MaxLength = 10;
            this.rutTextBox.Name = "rutTextBox";
            this.rutTextBox.Size = new System.Drawing.Size(125, 27);
            this.rutTextBox.TabIndex = 6;
            // 
            // rutLabel
            // 
            this.rutLabel.AutoSize = true;
            this.rutLabel.Location = new System.Drawing.Point(46, 30);
            this.rutLabel.Name = "rutLabel";
            this.rutLabel.Size = new System.Drawing.Size(39, 19);
            this.rutLabel.TabIndex = 5;
            this.rutLabel.Text = "Rut:";
            // 
            // contratosTabPage
            // 
            this.contratosTabPage.Controls.Add(this.cantidadContratosLabel);
            this.contratosTabPage.Controls.Add(this.statusStrip1);
            this.contratosTabPage.Controls.Add(this.contratosDataGridView);
            this.contratosTabPage.Location = new System.Drawing.Point(4, 28);
            this.contratosTabPage.Name = "contratosTabPage";
            this.contratosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contratosTabPage.Size = new System.Drawing.Size(467, 328);
            this.contratosTabPage.TabIndex = 1;
            this.contratosTabPage.Text = "Contratos del cliente.";
            this.contratosTabPage.UseVisualStyleBackColor = true;
            // 
            // cantidadContratosLabel
            // 
            this.cantidadContratosLabel.AutoSize = true;
            this.cantidadContratosLabel.Location = new System.Drawing.Point(0, 300);
            this.cantidadContratosLabel.Name = "cantidadContratosLabel";
            this.cantidadContratosLabel.Size = new System.Drawing.Size(178, 19);
            this.cantidadContratosLabel.TabIndex = 20;
            this.cantidadContratosLabel.Text = "Cantidad de contratos...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 303);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(461, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contratosDataGridView
            // 
            this.contratosDataGridView.AllowUserToAddRows = false;
            this.contratosDataGridView.AllowUserToDeleteRows = false;
            this.contratosDataGridView.AllowUserToResizeRows = false;
            this.contratosDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.contratosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratosDataGridView.Location = new System.Drawing.Point(25, 30);
            this.contratosDataGridView.MultiSelect = false;
            this.contratosDataGridView.Name = "contratosDataGridView";
            this.contratosDataGridView.ReadOnly = true;
            this.contratosDataGridView.RowTemplate.Height = 23;
            this.contratosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contratosDataGridView.ShowCellErrors = false;
            this.contratosDataGridView.ShowCellToolTips = false;
            this.contratosDataGridView.ShowEditingIcon = false;
            this.contratosDataGridView.ShowRowErrors = false;
            this.contratosDataGridView.Size = new System.Drawing.Size(425, 240);
            this.contratosDataGridView.TabIndex = 17;
            // 
            // formularioMenuStrip
            // 
            this.formularioMenuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.formularioMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formularioMenuStrip.Name = "formularioMenuStrip";
            this.formularioMenuStrip.Size = new System.Drawing.Size(639, 27);
            this.formularioMenuStrip.TabIndex = 19;
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.opcionesToolStripSeparator1,
            this.cerrarToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.ClientAdd;
            this.nuevoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.nuevoToolStripMenuItem.Text = "&Nuevo cliente.";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.ClientUpdate;
            this.editarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.editarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.editarToolStripMenuItem.Text = "&Editar cliente.";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.ClientDelete;
            this.eliminarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.eliminarToolStripMenuItem.Text = "E&liminar cliente.";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // opcionesToolStripSeparator1
            // 
            this.opcionesToolStripSeparator1.Name = "opcionesToolStripSeparator1";
            this.opcionesToolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::BeLife.Vista.Properties.Resources.cerrar;
            this.cerrarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.cerrarToolStripMenuItem.Text = "&Cerrar.";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // formularioPictureBox
            // 
            this.formularioPictureBox.Image = global::BeLife.Vista.Properties.Resources.Clientes;
            this.formularioPictureBox.Location = new System.Drawing.Point(25, 60);
            this.formularioPictureBox.Name = "formularioPictureBox";
            this.formularioPictureBox.Size = new System.Drawing.Size(100, 90);
            this.formularioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formularioPictureBox.TabIndex = 0;
            this.formularioPictureBox.TabStop = false;
            // 
            // formularioToolStrip
            // 
            this.formularioToolStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formularioToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.editarToolStripButton,
            this.eliminarToolStripButton});
            this.formularioToolStrip.Location = new System.Drawing.Point(0, 27);
            this.formularioToolStrip.Name = "formularioToolStrip";
            this.formularioToolStrip.Size = new System.Drawing.Size(639, 27);
            this.formularioToolStrip.TabIndex = 20;
            this.formularioToolStrip.Text = "toolStrip1";
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Image = global::BeLife.Vista.Properties.Resources.ClientAdd;
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.nuevoToolStripButton.Text = "Nuevo cliente.";
            this.nuevoToolStripButton.Click += new System.EventHandler(this.nuevoToolStripButton_Click);
            // 
            // editarToolStripButton
            // 
            this.editarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editarToolStripButton.Image = global::BeLife.Vista.Properties.Resources.ClientUpdate;
            this.editarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarToolStripButton.Name = "editarToolStripButton";
            this.editarToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.editarToolStripButton.Text = "Editar cliente.";
            this.editarToolStripButton.Click += new System.EventHandler(this.editarToolStripButton_Click);
            // 
            // eliminarToolStripButton
            // 
            this.eliminarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eliminarToolStripButton.Image = global::BeLife.Vista.Properties.Resources.ClientDelete;
            this.eliminarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarToolStripButton.Name = "eliminarToolStripButton";
            this.eliminarToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.eliminarToolStripButton.Text = "Eliminar cliente.";
            this.eliminarToolStripButton.Click += new System.EventHandler(this.eliminarToolStripButton_Click);
            // 
            // barraEstadoStatusStrip
            // 
            this.barraEstadoStatusStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraEstadoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoSoolStripStatusLabel});
            this.barraEstadoStatusStrip.Location = new System.Drawing.Point(0, 432);
            this.barraEstadoStatusStrip.Name = "barraEstadoStatusStrip";
            this.barraEstadoStatusStrip.Size = new System.Drawing.Size(639, 22);
            this.barraEstadoStatusStrip.TabIndex = 17;
            this.barraEstadoStatusStrip.Text = "statusStrip1";
            // 
            // textoSoolStripStatusLabel
            // 
            this.textoSoolStripStatusLabel.Name = "textoSoolStripStatusLabel";
            this.textoSoolStripStatusLabel.Size = new System.Drawing.Size(624, 17);
            this.textoSoolStripStatusLabel.Spring = true;
            this.textoSoolStripStatusLabel.Text = "Mensajes del formulario...";
            this.textoSoolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaestroClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 454);
            this.ControlBox = false;
            this.Controls.Add(this.formularioToolStrip);
            this.Controls.Add(this.formularioTabControl);
            this.Controls.Add(this.barraEstadoStatusStrip);
            this.Controls.Add(this.formularioMenuStrip);
            this.Controls.Add(this.formularioPictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.formularioMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MaestroClientesForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros BeLife - Maestro de clientes.";
            this.Activated += new System.EventHandler(this.MaestroClientesForm_Activated);
            this.Load += new System.EventHandler(this.MaestroClientesForm_Load);
            this.formularioTabControl.ResumeLayout(false);
            this.datosClienteTabPage.ResumeLayout(false);
            this.datosClienteTabPage.PerformLayout();
            this.contratosTabPage.ResumeLayout(false);
            this.contratosTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratosDataGridView)).EndInit();
            this.formularioMenuStrip.ResumeLayout(false);
            this.formularioMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formularioPictureBox)).EndInit();
            this.formularioToolStrip.ResumeLayout(false);
            this.formularioToolStrip.PerformLayout();
            this.barraEstadoStatusStrip.ResumeLayout(false);
            this.barraEstadoStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formularioPictureBox;
        private System.Windows.Forms.ImageList formularioImageList;
        private System.Windows.Forms.TabControl formularioTabControl;
        private System.Windows.Forms.TabPage datosClienteTabPage;
        private System.Windows.Forms.Button grabarButton;
        private System.Windows.Forms.ComboBox estadoCivilComboBox;
        private System.Windows.Forms.Label estadoCivilLabel;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.DateTimePicker nacimientoDateTimePicker;
        private System.Windows.Forms.Label nacimientoLabel;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button rutButton;
        private System.Windows.Forms.TextBox rutTextBox;
        private System.Windows.Forms.Label rutLabel;
        private System.Windows.Forms.TabPage contratosTabPage;
        private System.Windows.Forms.DataGridView contratosDataGridView;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.MenuStrip formularioMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator opcionesToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip formularioToolStrip;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton editarToolStripButton;
        private System.Windows.Forms.ToolStripButton eliminarToolStripButton;
        private System.Windows.Forms.Label cantidadContratosLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip barraEstadoStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textoSoolStripStatusLabel;
    }
}