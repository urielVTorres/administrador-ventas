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
            this.panelNewClient = new System.Windows.Forms.Panel();
            this.dataGridCarrito = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.buttonAgregarInventario = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.TitleBussiness = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelNewClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelNewClient);
            this.panelContainer.Controls.Add(this.panelSidebar);
            this.panelContainer.Controls.Add(this.panelTopBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1084, 561);
            this.panelContainer.TabIndex = 0;
            // 
            // panelNewClient
            // 
            this.panelNewClient.Controls.Add(this.dataGridCarrito);
            this.panelNewClient.Controls.Add(this.label3);
            this.panelNewClient.Controls.Add(this.label2);
            this.panelNewClient.Controls.Add(this.textBusqueda);
            this.panelNewClient.Controls.Add(this.label1);
            this.panelNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewClient.Location = new System.Drawing.Point(200, 100);
            this.panelNewClient.Name = "panelNewClient";
            this.panelNewClient.Padding = new System.Windows.Forms.Padding(20);
            this.panelNewClient.Size = new System.Drawing.Size(884, 461);
            this.panelNewClient.TabIndex = 2;
            // 
            // dataGridCarrito
            // 
            this.dataGridCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.dataGridCarrito.Location = new System.Drawing.Point(32, 184);
            this.dataGridCarrito.Name = "dataGridCarrito";
            this.dataGridCarrito.RowTemplate.Height = 25;
            this.dataGridCarrito.Size = new System.Drawing.Size(829, 150);
            this.dataGridCarrito.TabIndex = 5;
            this.dataGridCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(461, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "En el carrito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "En el carrito:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBusqueda.Culture = new System.Globalization.CultureInfo("es-MX");
            this.textBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBusqueda.ForeColor = System.Drawing.Color.Teal;
            this.textBusqueda.Location = new System.Drawing.Point(32, 78);
            this.textBusqueda.MaximumSize = new System.Drawing.Size(1100, 46);
            this.textBusqueda.MinimumSize = new System.Drawing.Size(829, 46);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(829, 46);
            this.textBusqueda.TabIndex = 1;
            this.textBusqueda.Text = "sdfa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Producto:";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSidebar.Controls.Add(this.buttonAgregarInventario);
            this.panelSidebar.Controls.Add(this.buttonInventario);
            this.panelSidebar.Controls.Add(this.buttonNewClient);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 461);
            this.panelSidebar.TabIndex = 1;
            // 
            // buttonAgregarInventario
            // 
            this.buttonAgregarInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAgregarInventario.FlatAppearance.BorderSize = 0;
            this.buttonAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregarInventario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonAgregarInventario.Location = new System.Drawing.Point(0, 135);
            this.buttonAgregarInventario.Name = "buttonAgregarInventario";
            this.buttonAgregarInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAgregarInventario.Size = new System.Drawing.Size(200, 50);
            this.buttonAgregarInventario.TabIndex = 2;
            this.buttonAgregarInventario.Text = "Agregar Inventario";
            this.buttonAgregarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarInventario.UseMnemonic = false;
            this.buttonAgregarInventario.UseVisualStyleBackColor = false;
            // 
            // buttonInventario
            // 
            this.buttonInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInventario.FlatAppearance.BorderSize = 0;
            this.buttonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInventario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonInventario.Location = new System.Drawing.Point(0, 79);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonInventario.Size = new System.Drawing.Size(200, 50);
            this.buttonInventario.TabIndex = 1;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventario.UseMnemonic = false;
            this.buttonInventario.UseVisualStyleBackColor = false;
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNewClient.FlatAppearance.BorderSize = 0;
            this.buttonNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewClient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewClient.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonNewClient.Location = new System.Drawing.Point(0, 24);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonNewClient.Size = new System.Drawing.Size(200, 49);
            this.buttonNewClient.TabIndex = 0;
            this.buttonNewClient.Text = "Nuevo Cliente";
            this.buttonNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewClient.UseMnemonic = false;
            this.buttonNewClient.UseVisualStyleBackColor = false;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.TitleBussiness.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBussiness.Location = new System.Drawing.Point(11, 8);
            this.TitleBussiness.Name = "TitleBussiness";
            this.TitleBussiness.Size = new System.Drawing.Size(307, 80);
            this.TitleBussiness.TabIndex = 3;
            this.TitleBussiness.Text = "INTERPATY";
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.BackColor = System.Drawing.Color.LightGray;
            this.restoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreButton.Location = new System.Drawing.Point(985, 0);
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
            this.minimizeButton.Location = new System.Drawing.Point(938, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 30);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1032, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 30);
            this.closeButton.TabIndex = 0;
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
            this.panelNewClient.ResumeLayout(false);
            this.panelNewClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrito)).EndInit();
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
        private Label label2;
        private MaskedTextBox textBusqueda;
        private Label label1;
        private DataGridView dataGridCarrito;
        private Label label3;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
    }
}