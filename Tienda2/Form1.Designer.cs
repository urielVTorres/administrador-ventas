namespace Tienda2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContenedorPaginas = new System.Windows.Forms.Panel();
            this.panelAgregarInventario = new System.Windows.Forms.Panel();
            this.radioButtonExistente = new System.Windows.Forms.RadioButton();
            this.radioButtonNuevo = new System.Windows.Forms.RadioButton();
            this.numericUpDownAgregarPiezas = new System.Windows.Forms.NumericUpDown();
            this.textBoxAgregarPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAgregarPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAgregarCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAgregarNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.labelTotalReporte = new System.Windows.Forms.Label();
            this.dateTimePickerReporte = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewReporte = new System.Windows.Forms.ListView();
            this.panelNewClient = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptarCompra = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRecibido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.listViewInventario = new System.Windows.Forms.ListView();
            this.Index = new System.Windows.Forms.ColumnHeader();
            this.Producto = new System.Windows.Forms.ColumnHeader();
            this.Cantidad = new System.Windows.Forms.ColumnHeader();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonAgregarInventario = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.TitleBussiness = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelContenedorPaginas.SuspendLayout();
            this.panelAgregarInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgregarPiezas)).BeginInit();
            this.panelReporte.SuspendLayout();
            this.panelNewClient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelContenedorPaginas);
            this.panelContainer.Controls.Add(this.panelSidebar);
            this.panelContainer.Controls.Add(this.panelTopBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1084, 561);
            this.panelContainer.TabIndex = 0;
            // 
            // panelContenedorPaginas
            // 
            this.panelContenedorPaginas.Controls.Add(this.panelAgregarInventario);
            this.panelContenedorPaginas.Controls.Add(this.panelReporte);
            this.panelContenedorPaginas.Controls.Add(this.panelNewClient);
            this.panelContenedorPaginas.Controls.Add(this.panelInventario);
            this.panelContenedorPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorPaginas.Location = new System.Drawing.Point(200, 100);
            this.panelContenedorPaginas.Name = "panelContenedorPaginas";
            this.panelContenedorPaginas.Size = new System.Drawing.Size(884, 461);
            this.panelContenedorPaginas.TabIndex = 3;
            // 
            // panelAgregarInventario
            // 
            this.panelAgregarInventario.Controls.Add(this.radioButtonExistente);
            this.panelAgregarInventario.Controls.Add(this.radioButtonNuevo);
            this.panelAgregarInventario.Controls.Add(this.numericUpDownAgregarPiezas);
            this.panelAgregarInventario.Controls.Add(this.textBoxAgregarPrecioUnitario);
            this.panelAgregarInventario.Controls.Add(this.label12);
            this.panelAgregarInventario.Controls.Add(this.textBoxAgregarPrecio);
            this.panelAgregarInventario.Controls.Add(this.label11);
            this.panelAgregarInventario.Controls.Add(this.label10);
            this.panelAgregarInventario.Controls.Add(this.textBoxAgregarCodigo);
            this.panelAgregarInventario.Controls.Add(this.label9);
            this.panelAgregarInventario.Controls.Add(this.label8);
            this.panelAgregarInventario.Controls.Add(this.textBoxAgregarNombre);
            this.panelAgregarInventario.Controls.Add(this.label7);
            this.panelAgregarInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarInventario.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarInventario.Name = "panelAgregarInventario";
            this.panelAgregarInventario.Size = new System.Drawing.Size(884, 461);
            this.panelAgregarInventario.TabIndex = 2;
            // 
            // radioButtonExistente
            // 
            this.radioButtonExistente.AutoSize = true;
            this.radioButtonExistente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonExistente.Location = new System.Drawing.Point(215, 306);
            this.radioButtonExistente.Name = "radioButtonExistente";
            this.radioButtonExistente.Size = new System.Drawing.Size(156, 25);
            this.radioButtonExistente.TabIndex = 13;
            this.radioButtonExistente.TabStop = true;
            this.radioButtonExistente.Text = "Producto Existente";
            this.radioButtonExistente.UseVisualStyleBackColor = true;
            // 
            // radioButtonNuevo
            // 
            this.radioButtonNuevo.AutoSize = true;
            this.radioButtonNuevo.Checked = true;
            this.radioButtonNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNuevo.Location = new System.Drawing.Point(55, 306);
            this.radioButtonNuevo.Name = "radioButtonNuevo";
            this.radioButtonNuevo.Size = new System.Drawing.Size(141, 25);
            this.radioButtonNuevo.TabIndex = 12;
            this.radioButtonNuevo.TabStop = true;
            this.radioButtonNuevo.Text = "Producto Nuevo";
            this.radioButtonNuevo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAgregarPiezas
            // 
            this.numericUpDownAgregarPiezas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownAgregarPiezas.Location = new System.Drawing.Point(669, 303);
            this.numericUpDownAgregarPiezas.Name = "numericUpDownAgregarPiezas";
            this.numericUpDownAgregarPiezas.Size = new System.Drawing.Size(120, 33);
            this.numericUpDownAgregarPiezas.TabIndex = 11;
            // 
            // textBoxAgregarPrecioUnitario
            // 
            this.textBoxAgregarPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgregarPrecioUnitario.Location = new System.Drawing.Point(466, 238);
            this.textBoxAgregarPrecioUnitario.Name = "textBoxAgregarPrecioUnitario";
            this.textBoxAgregarPrecioUnitario.Size = new System.Drawing.Size(323, 33);
            this.textBoxAgregarPrecioUnitario.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(466, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Precio por Pieza:";
            // 
            // textBoxAgregarPrecio
            // 
            this.textBoxAgregarPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgregarPrecio.Location = new System.Drawing.Point(466, 150);
            this.textBoxAgregarPrecio.Name = "textBoxAgregarPrecio";
            this.textBoxAgregarPrecio.Size = new System.Drawing.Size(323, 33);
            this.textBoxAgregarPrecio.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(466, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Precio Paquete:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(466, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Número de Piezas:";
            // 
            // textBoxAgregarCodigo
            // 
            this.textBoxAgregarCodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgregarCodigo.Location = new System.Drawing.Point(53, 238);
            this.textBoxAgregarCodigo.Name = "textBoxAgregarCodigo";
            this.textBoxAgregarCodigo.Size = new System.Drawing.Size(323, 33);
            this.textBoxAgregarCodigo.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(53, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Código de Barras:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(269, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "Agregar un producto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxAgregarNombre
            // 
            this.textBoxAgregarNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgregarNombre.Location = new System.Drawing.Point(53, 150);
            this.textBoxAgregarNombre.Name = "textBoxAgregarNombre";
            this.textBoxAgregarNombre.Size = new System.Drawing.Size(323, 33);
            this.textBoxAgregarNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre del Producto:";
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.labelTotalReporte);
            this.panelReporte.Controls.Add(this.dateTimePickerReporte);
            this.panelReporte.Controls.Add(this.label6);
            this.panelReporte.Controls.Add(this.listViewReporte);
            this.panelReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReporte.Location = new System.Drawing.Point(0, 0);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Padding = new System.Windows.Forms.Padding(20);
            this.panelReporte.Size = new System.Drawing.Size(884, 461);
            this.panelReporte.TabIndex = 2;
            // 
            // labelTotalReporte
            // 
            this.labelTotalReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalReporte.AutoSize = true;
            this.labelTotalReporte.Location = new System.Drawing.Point(637, 403);
            this.labelTotalReporte.Name = "labelTotalReporte";
            this.labelTotalReporte.Size = new System.Drawing.Size(65, 15);
            this.labelTotalReporte.TabIndex = 3;
            this.labelTotalReporte.Text = "Total: $0.00";
            // 
            // dateTimePickerReporte
            // 
            this.dateTimePickerReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReporte.Location = new System.Drawing.Point(637, 32);
            this.dateTimePickerReporte.Name = "dateTimePickerReporte";
            this.dateTimePickerReporte.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerReporte.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reporte";
            // 
            // listViewReporte
            // 
            this.listViewReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewReporte.Location = new System.Drawing.Point(49, 79);
            this.listViewReporte.Name = "listViewReporte";
            this.listViewReporte.Size = new System.Drawing.Size(788, 298);
            this.listViewReporte.TabIndex = 0;
            this.listViewReporte.UseCompatibleStateImageBehavior = false;
            // 
            // panelNewClient
            // 
            this.panelNewClient.Controls.Add(this.buttonAdd);
            this.panelNewClient.Controls.Add(this.panel1);
            this.panelNewClient.Controls.Add(this.textBusqueda);
            this.panelNewClient.Controls.Add(this.label1);
            this.panelNewClient.Controls.Add(this.listBoxCarrito);
            this.panelNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewClient.Location = new System.Drawing.Point(0, 0);
            this.panelNewClient.Name = "panelNewClient";
            this.panelNewClient.Padding = new System.Windows.Forms.Padding(20);
            this.panelNewClient.Size = new System.Drawing.Size(884, 461);
            this.panelNewClient.TabIndex = 2;
            this.panelNewClient.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNewClient_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(819, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 36);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(32, 314);
            this.panel1.MaximumSize = new System.Drawing.Size(1100, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 124);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.buttonCancelar);
            this.panel2.Controls.Add(this.buttonAceptarCompra);
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxRecibido);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(1100, 200);
            this.panel2.MinimumSize = new System.Drawing.Size(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(829, 124);
            this.panel2.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkMagenta;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancelar.Location = new System.Drawing.Point(627, 67);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(178, 34);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptarCompra
            // 
            this.buttonAceptarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptarCompra.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAceptarCompra.FlatAppearance.BorderSize = 0;
            this.buttonAceptarCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.buttonAceptarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonAceptarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptarCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAceptarCompra.Location = new System.Drawing.Point(627, 17);
            this.buttonAceptarCompra.Name = "buttonAceptarCompra";
            this.buttonAceptarCompra.Size = new System.Drawing.Size(178, 33);
            this.buttonAceptarCompra.TabIndex = 9;
            this.buttonAceptarCompra.Text = "ACEPTAR";
            this.buttonAceptarCompra.UseVisualStyleBackColor = false;
            this.buttonAceptarCompra.Click += new System.EventHandler(this.buttonAceptarCompra_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(70, 66);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(59, 24);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(444, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "$0.00";
            // 
            // textBoxRecibido
            // 
            this.textBoxRecibido.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecibido.Location = new System.Drawing.Point(218, 63);
            this.textBoxRecibido.MaximumSize = new System.Drawing.Size(200, 40);
            this.textBoxRecibido.MinimumSize = new System.Drawing.Size(150, 30);
            this.textBoxRecibido.Name = "textBoxRecibido";
            this.textBoxRecibido.Size = new System.Drawing.Size(150, 32);
            this.textBoxRecibido.TabIndex = 6;
            this.textBoxRecibido.TextChanged += new System.EventHandler(this.textBoxRecibido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(434, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "CAMBIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(237, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "RECIBIDO";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(32, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 132);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOTAL";
            // 
            // textBusqueda
            // 
            this.textBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBusqueda.Culture = new System.Globalization.CultureInfo("es-MX");
            this.textBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBusqueda.ForeColor = System.Drawing.Color.Teal;
            this.textBusqueda.Location = new System.Drawing.Point(32, 56);
            this.textBusqueda.MaximumSize = new System.Drawing.Size(1100, 46);
            this.textBusqueda.MinimumSize = new System.Drawing.Size(790, 35);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(790, 36);
            this.textBusqueda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Producto:";
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCarrito.ColumnWidth = 10;
            this.listBoxCarrito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.ItemHeight = 25;
            this.listBoxCarrito.Location = new System.Drawing.Point(32, 113);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.ScrollAlwaysVisible = true;
            this.listBoxCarrito.Size = new System.Drawing.Size(829, 175);
            this.listBoxCarrito.TabIndex = 6;
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.listViewInventario);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Padding = new System.Windows.Forms.Padding(20);
            this.panelInventario.Size = new System.Drawing.Size(884, 461);
            this.panelInventario.TabIndex = 2;
            // 
            // listViewInventario
            // 
            this.listViewInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Producto,
            this.Cantidad});
            this.listViewInventario.Location = new System.Drawing.Point(37, 50);
            this.listViewInventario.Name = "listViewInventario";
            this.listViewInventario.Size = new System.Drawing.Size(810, 359);
            this.listViewInventario.TabIndex = 8;
            this.listViewInventario.UseCompatibleStateImageBehavior = false;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSidebar.Controls.Add(this.buttonReporte);
            this.panelSidebar.Controls.Add(this.buttonAgregarInventario);
            this.panelSidebar.Controls.Add(this.buttonInventario);
            this.panelSidebar.Controls.Add(this.buttonNewClient);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 461);
            this.panelSidebar.TabIndex = 1;
            // 
            // buttonReporte
            // 
            this.buttonReporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReporte.FlatAppearance.BorderSize = 0;
            this.buttonReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporte.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReporte.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonReporte.Location = new System.Drawing.Point(0, 79);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonReporte.Size = new System.Drawing.Size(200, 50);
            this.buttonReporte.TabIndex = 3;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporte.UseMnemonic = false;
            this.buttonReporte.UseVisualStyleBackColor = false;
            this.buttonReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAgregarInventario
            // 
            this.buttonAgregarInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAgregarInventario.FlatAppearance.BorderSize = 0;
            this.buttonAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregarInventario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonAgregarInventario.Location = new System.Drawing.Point(0, 191);
            this.buttonAgregarInventario.Name = "buttonAgregarInventario";
            this.buttonAgregarInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAgregarInventario.Size = new System.Drawing.Size(200, 50);
            this.buttonAgregarInventario.TabIndex = 2;
            this.buttonAgregarInventario.Text = "Agregar Inventario";
            this.buttonAgregarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarInventario.UseMnemonic = false;
            this.buttonAgregarInventario.UseVisualStyleBackColor = false;
            this.buttonAgregarInventario.Click += new System.EventHandler(this.buttonAgregarInventario_Click);
            // 
            // buttonInventario
            // 
            this.buttonInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInventario.FlatAppearance.BorderSize = 0;
            this.buttonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInventario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonInventario.Location = new System.Drawing.Point(0, 135);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonInventario.Size = new System.Drawing.Size(200, 50);
            this.buttonInventario.TabIndex = 2;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventario.UseMnemonic = false;
            this.buttonInventario.UseVisualStyleBackColor = false;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNewClient.FlatAppearance.BorderSize = 0;
            this.buttonNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewClient.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonNewClient.Location = new System.Drawing.Point(0, 24);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonNewClient.Size = new System.Drawing.Size(200, 49);
            this.buttonNewClient.TabIndex = 2;
            this.buttonNewClient.Text = "Nuevo Cliente";
            this.buttonNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewClient.UseMnemonic = false;
            this.buttonNewClient.UseVisualStyleBackColor = false;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.TitleBussiness);
            this.panelTopBar.Controls.Add(this.restoreButton);
            this.panelTopBar.Controls.Add(this.minimizeButton);
            this.panelTopBar.Controls.Add(this.closeButton);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelTopBar.Size = new System.Drawing.Size(1084, 100);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // TitleBussiness
            // 
            this.TitleBussiness.AutoSize = true;
            this.TitleBussiness.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBussiness.Location = new System.Drawing.Point(12, 20);
            this.TitleBussiness.Name = "TitleBussiness";
            this.TitleBussiness.Size = new System.Drawing.Size(259, 66);
            this.TitleBussiness.TabIndex = 2;
            this.TitleBussiness.Text = "INTERPATY";
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.BackColor = System.Drawing.Color.LightGray;
            this.restoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreButton.Location = new System.Drawing.Point(987, 0);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(50, 30);
            this.restoreButton.TabIndex = 2;
            this.restoreButton.TabStop = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Silver;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Location = new System.Drawing.Point(940, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 30);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1034, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelContainer.ResumeLayout(false);
            this.panelContenedorPaginas.ResumeLayout(false);
            this.panelAgregarInventario.ResumeLayout(false);
            this.panelAgregarInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgregarPiezas)).EndInit();
            this.panelReporte.ResumeLayout(false);
            this.panelReporte.PerformLayout();
            this.panelNewClient.ResumeLayout(false);
            this.panelNewClient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelInventario.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private Panel panelSidebar;
        private Panel panelTopBar;
        private PictureBox closeButton;
        private PictureBox restoreButton;
        private PictureBox minimizeButton;
        private Button buttonAgregarInventario;
        private Button buttonInventario;
        private Button buttonNewClient;
        private Label TitleBussiness;
        private Panel panelNewClient;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private MaskedTextBox textBusqueda;
        private Label label1;
        private TextBox textBoxRecibido;
        private Label label4;
        private Label label3;
        private Label labelTotal;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonAceptarCompra;
        private ListBox listBoxCarrito;
        private Button buttonAdd;
        private Panel panelInventario;
        private ListView listViewInventario;
        private ColumnHeader Index;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Button buttonReporte;
        private Panel panelReporte;
        private DateTimePicker dateTimePickerReporte;
        private Label label6;
        private ListView listViewReporte;
        private Panel panelContenedorPaginas;
        private Panel panelAgregarInventario;
        private Label labelTotalReporte;
        private Label label8;
        private TextBox textBoxAgregarNombre;
        private Label label7;
        private RadioButton radioButtonExistente;
        private RadioButton radioButtonNuevo;
        private NumericUpDown numericUpDownAgregarPiezas;
        private TextBox textBoxAgregarPrecioUnitario;
        private Label label12;
        private TextBox textBoxAgregarPrecio;
        private Label label11;
        private Label label10;
        private TextBox textBoxAgregarCodigo;
        private Label label9;
    }
}