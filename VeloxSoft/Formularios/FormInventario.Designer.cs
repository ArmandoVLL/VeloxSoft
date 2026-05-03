namespace VeloxSoft.Formularios
{
    partial class FormInventario
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
            pnlFondo = new Panel();
            Inventario = new TableLayoutPanel();
            pnlDetalles = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            pnlPV = new Panel();
            textPV = new TextBox();
            lblVenta = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            pnlStock = new Panel();
            textStock = new TextBox();
            lblStock = new Label();
            pnlPC = new Panel();
            textPC = new TextBox();
            lblPrecioC = new Label();
            pnlNombre = new Panel();
            textNombre = new TextBox();
            lblNombre = new Label();
            panel1 = new Panel();
            textID = new TextBox();
            lblID = new Label();
            lbTitulo = new Label();
            pnlBD = new Panel();
            dtgBDInv = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPVenta = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnGuardarBD = new FontAwesome.Sharp.IconButton();
            pnlBuscarBD = new Panel();
            tbBuscarBD = new TextBox();
            BuscarBD = new Label();
            Titulo = new Label();
            dataGridView1 = new DataGridView();
            lblTitulo = new Label();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            textBox1 = new TextBox();
            pnlFondo.SuspendLayout();
            Inventario.SuspendLayout();
            pnlDetalles.SuspendLayout();
            pnlPV.SuspendLayout();
            pnlStock.SuspendLayout();
            pnlPC.SuspendLayout();
            pnlNombre.SuspendLayout();
            panel1.SuspendLayout();
            pnlBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).BeginInit();
            pnlBuscarBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.FromArgb(192, 255, 192);
            pnlFondo.Controls.Add(Inventario);
            pnlFondo.Dock = DockStyle.Fill;
            pnlFondo.Location = new Point(0, 0);
            pnlFondo.Margin = new Padding(3, 4, 3, 4);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(1394, 638);
            pnlFondo.TabIndex = 0;
            // 
            // Inventario
            // 
            Inventario.BackColor = Color.White;
            Inventario.ColumnCount = 2;
            Inventario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            Inventario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            Inventario.Controls.Add(pnlDetalles, 0, 0);
            Inventario.Controls.Add(pnlBD, 1, 0);
            Inventario.Dock = DockStyle.Fill;
            Inventario.Location = new Point(0, 0);
            Inventario.Margin = new Padding(3, 4, 3, 4);
            Inventario.Name = "Inventario";
            Inventario.RowCount = 1;
            Inventario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Inventario.Size = new Size(1394, 638);
            Inventario.TabIndex = 0;
            Inventario.Paint += tableLayoutPanel1_Paint;
            // 
            // pnlDetalles
            // 
            pnlDetalles.BackColor = Color.FromArgb(216, 243, 220);
            pnlDetalles.Controls.Add(btnBuscar);
            pnlDetalles.Controls.Add(pnlPV);
            pnlDetalles.Controls.Add(lblVenta);
            pnlDetalles.Controls.Add(btnEliminar);
            pnlDetalles.Controls.Add(btnGuardar);
            pnlDetalles.Controls.Add(btnNuevo);
            pnlDetalles.Controls.Add(pnlStock);
            pnlDetalles.Controls.Add(lblStock);
            pnlDetalles.Controls.Add(pnlPC);
            pnlDetalles.Controls.Add(lblPrecioC);
            pnlDetalles.Controls.Add(pnlNombre);
            pnlDetalles.Controls.Add(lblNombre);
            pnlDetalles.Controls.Add(panel1);
            pnlDetalles.Controls.Add(lblID);
            pnlDetalles.Controls.Add(lbTitulo);
            pnlDetalles.Dock = DockStyle.Fill;
            pnlDetalles.Location = new Point(3, 4);
            pnlDetalles.Margin = new Padding(3, 4, 3, 4);
            pnlDetalles.Name = "pnlDetalles";
            pnlDetalles.Size = new Size(621, 630);
            pnlDetalles.TabIndex = 0;
            pnlDetalles.Paint += pnlDetalles_Paint;
            pnlDetalles.Resize += pnlDetalles_Resize;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(27, 67, 50);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.ImageAlign = ContentAlignment.BottomLeft;
            btnBuscar.Location = new Point(424, 81);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 37);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.Paint += btnBuscar_Paint;
            // 
            // pnlPV
            // 
            pnlPV.BackColor = Color.FromArgb(82, 183, 136);
            pnlPV.Controls.Add(textPV);
            pnlPV.Location = new Point(309, 286);
            pnlPV.Margin = new Padding(3, 4, 3, 4);
            pnlPV.Name = "pnlPV";
            pnlPV.Size = new Size(300, 49);
            pnlPV.TabIndex = 24;
            pnlPV.Paint += pnlPV_Paint;
            // 
            // textPV
            // 
            textPV.BackColor = Color.FromArgb(82, 183, 136);
            textPV.BorderStyle = BorderStyle.None;
            textPV.Cursor = Cursors.IBeam;
            textPV.Location = new Point(3, 17);
            textPV.Margin = new Padding(3, 4, 3, 4);
            textPV.Name = "textPV";
            textPV.Size = new Size(243, 20);
            textPV.TabIndex = 0;
            textPV.TextChanged += textPV_TextChanged;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(3, 303);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(228, 32);
            lblVenta.TabIndex = 23;
            lblVenta.Text = "PRECIO DE VENTA:";
            lblVenta.Click += label1_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(230, 57, 70);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(382, 465);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 41);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.Paint += btnEliminar_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(27, 67, 50);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(194, 465);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 41);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.Paint += btnGuardar_Paint;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(27, 67, 50);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 20;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(10, 465);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(159, 41);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            btnNuevo.Paint += btnNuevo_Paint;
            // 
            // pnlStock
            // 
            pnlStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlStock.BackColor = Color.FromArgb(82, 183, 136);
            pnlStock.Controls.Add(textStock);
            pnlStock.Location = new Point(157, 363);
            pnlStock.Margin = new Padding(3, 4, 3, 4);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(452, 45);
            pnlStock.TabIndex = 19;
            pnlStock.Paint += pnlStock_Paint;
            // 
            // textStock
            // 
            textStock.BackColor = Color.FromArgb(82, 183, 136);
            textStock.BorderStyle = BorderStyle.None;
            textStock.Cursor = Cursors.IBeam;
            textStock.Location = new Point(3, 12);
            textStock.Margin = new Padding(3, 4, 3, 4);
            textStock.Name = "textStock";
            textStock.Size = new Size(343, 20);
            textStock.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(10, 363);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(135, 32);
            lblStock.TabIndex = 18;
            lblStock.Text = "EN STOCK:";
            // 
            // pnlPC
            // 
            pnlPC.BackColor = Color.FromArgb(82, 183, 136);
            pnlPC.Controls.Add(textPC);
            pnlPC.Location = new Point(309, 216);
            pnlPC.Margin = new Padding(3, 4, 3, 4);
            pnlPC.Name = "pnlPC";
            pnlPC.Size = new Size(300, 49);
            pnlPC.TabIndex = 17;
            pnlPC.Paint += pnlPC_Paint;
            // 
            // textPC
            // 
            textPC.BackColor = Color.FromArgb(82, 183, 136);
            textPC.BorderStyle = BorderStyle.None;
            textPC.Cursor = Cursors.IBeam;
            textPC.Location = new Point(3, 15);
            textPC.Margin = new Padding(3, 4, 3, 4);
            textPC.Name = "textPC";
            textPC.Size = new Size(243, 20);
            textPC.TabIndex = 0;
            // 
            // lblPrecioC
            // 
            lblPrecioC.AutoSize = true;
            lblPrecioC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioC.Location = new Point(3, 233);
            lblPrecioC.Name = "lblPrecioC";
            lblPrecioC.Size = new Size(255, 32);
            lblPrecioC.TabIndex = 1;
            lblPrecioC.Text = "PRECIO DE COMPRA:";
            lblPrecioC.Click += label1_Click;
            // 
            // pnlNombre
            // 
            pnlNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlNombre.BackColor = Color.FromArgb(82, 183, 136);
            pnlNombre.Controls.Add(textNombre);
            pnlNombre.Location = new Point(223, 141);
            pnlNombre.Margin = new Padding(3, 4, 3, 4);
            pnlNombre.Name = "pnlNombre";
            pnlNombre.Size = new Size(386, 49);
            pnlNombre.TabIndex = 16;
            pnlNombre.Paint += pnlNombre_Paint;
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(82, 183, 136);
            textNombre.BorderStyle = BorderStyle.None;
            textNombre.Cursor = Cursors.IBeam;
            textNombre.Location = new Point(3, 13);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(347, 20);
            textNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(10, 141);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 32);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "NOMBRE:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(82, 183, 136);
            panel1.Controls.Add(textID);
            panel1.Location = new Point(153, 77);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 49);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // textID
            // 
            textID.BackColor = Color.FromArgb(82, 183, 136);
            textID.BorderStyle = BorderStyle.None;
            textID.Cursor = Cursors.IBeam;
            textID.Location = new Point(3, 12);
            textID.Margin = new Padding(3, 4, 3, 4);
            textID.Multiline = true;
            textID.Name = "textID";
            textID.Size = new Size(249, 27);
            textID.TabIndex = 0;
            textID.TextChanged += textID_TextChanged;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(10, 85);
            lblID.Name = "lblID";
            lblID.Size = new Size(147, 32);
            lblID.TabIndex = 1;
            lblID.Text = "BUSCAR ID:";
            lblID.Click += lblID_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(10, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(284, 41);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Detalles Inventario";
            // 
            // pnlBD
            // 
            pnlBD.BackColor = Color.FromArgb(247, 250, 248);
            pnlBD.Controls.Add(dtgBDInv);
            pnlBD.Controls.Add(btnGuardarBD);
            pnlBD.Controls.Add(pnlBuscarBD);
            pnlBD.Controls.Add(BuscarBD);
            pnlBD.Controls.Add(Titulo);
            pnlBD.Dock = DockStyle.Fill;
            pnlBD.Location = new Point(630, 3);
            pnlBD.Name = "pnlBD";
            pnlBD.Size = new Size(761, 632);
            pnlBD.TabIndex = 1;
            pnlBD.Paint += pnlBD_Paint;
            pnlBD.Resize += pnlBD_Resize;
            // 
            // dtgBDInv
            // 
            dtgBDInv.AllowUserToAddRows = false;
            dtgBDInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBDInv.BackgroundColor = Color.Silver;
            dtgBDInv.BorderStyle = BorderStyle.None;
            dtgBDInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBDInv.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colCategoria, colStock, colPVenta, colEstado });
            dtgBDInv.Location = new Point(11, 151);
            dtgBDInv.Name = "dtgBDInv";
            dtgBDInv.ReadOnly = true;
            dtgBDInv.RowHeadersVisible = false;
            dtgBDInv.RowHeadersWidth = 51;
            dtgBDInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgBDInv.Size = new Size(811, 366);
            dtgBDInv.TabIndex = 18;
            dtgBDInv.CellContentClick += dataGridView2_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colPVenta
            // 
            colPVenta.HeaderText = "P.Venta";
            colPVenta.MinimumWidth = 6;
            colPVenta.Name = "colPVenta";
            colPVenta.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // btnGuardarBD
            // 
            btnGuardarBD.BackColor = Color.FromArgb(27, 67, 50);
            btnGuardarBD.Cursor = Cursors.Hand;
            btnGuardarBD.FlatAppearance.BorderSize = 0;
            btnGuardarBD.FlatStyle = FlatStyle.Flat;
            btnGuardarBD.ForeColor = Color.White;
            btnGuardarBD.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnGuardarBD.IconColor = Color.Black;
            btnGuardarBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarBD.IconSize = 20;
            btnGuardarBD.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarBD.Location = new Point(707, 78);
            btnGuardarBD.Margin = new Padding(3, 4, 3, 4);
            btnGuardarBD.Name = "btnGuardarBD";
            btnGuardarBD.Size = new Size(115, 37);
            btnGuardarBD.TabIndex = 17;
            btnGuardarBD.Text = "BUSCAR";
            btnGuardarBD.UseVisualStyleBackColor = false;
            btnGuardarBD.Paint += btnGuardarBD_Paint;
            // 
            // pnlBuscarBD
            // 
            pnlBuscarBD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBuscarBD.BackColor = Color.FromArgb(82, 183, 136);
            pnlBuscarBD.Controls.Add(tbBuscarBD);
            pnlBuscarBD.Location = new Point(154, 78);
            pnlBuscarBD.Margin = new Padding(3, 4, 3, 4);
            pnlBuscarBD.Name = "pnlBuscarBD";
            pnlBuscarBD.Size = new Size(465, 49);
            pnlBuscarBD.TabIndex = 16;
            pnlBuscarBD.Paint += pnlBuscarBD_Paint;
            // 
            // tbBuscarBD
            // 
            tbBuscarBD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbBuscarBD.BackColor = Color.FromArgb(82, 183, 136);
            tbBuscarBD.BorderStyle = BorderStyle.None;
            tbBuscarBD.Cursor = Cursors.IBeam;
            tbBuscarBD.Location = new Point(6, 12);
            tbBuscarBD.Margin = new Padding(3, 4, 3, 4);
            tbBuscarBD.Multiline = true;
            tbBuscarBD.Name = "tbBuscarBD";
            tbBuscarBD.PlaceholderText = "EJ. AA11";
            tbBuscarBD.Size = new Size(450, 33);
            tbBuscarBD.TabIndex = 0;
            tbBuscarBD.TextChanged += tbBuscarBD_TextChanged;
            // 
            // BuscarBD
            // 
            BuscarBD.AutoSize = true;
            BuscarBD.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuscarBD.Location = new Point(11, 86);
            BuscarBD.Name = "BuscarBD";
            BuscarBD.Size = new Size(147, 32);
            BuscarBD.TabIndex = 15;
            BuscarBD.Text = "BUSCAR ID:";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(17, 12);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(379, 38);
            Titulo.TabIndex = 0;
            Titulo.Text = "Base de datos de inventario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(130, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 38);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Base de datos de Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 78);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 29;
            label1.Text = "BUSCAR ID:";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.SeaGreen;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.BottomLeft;
            iconButton1.Location = new Point(539, 74);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(115, 37);
            iconButton1.TabIndex = 31;
            iconButton1.Text = "BUSCAR";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(150, 70);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 49);
            panel5.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(3, 12);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 20);
            textBox1.TabIndex = 0;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 57, 70);
            ClientSize = new Size(1394, 638);
            Controls.Add(pnlFondo);
            Name = "FormInventario";
            Text = "FormInventario";
            pnlFondo.ResumeLayout(false);
            Inventario.ResumeLayout(false);
            pnlDetalles.ResumeLayout(false);
            pnlDetalles.PerformLayout();
            pnlPV.ResumeLayout(false);
            pnlPV.PerformLayout();
            pnlStock.ResumeLayout(false);
            pnlStock.PerformLayout();
            pnlPC.ResumeLayout(false);
            pnlPC.PerformLayout();
            pnlNombre.ResumeLayout(false);
            pnlNombre.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBD.ResumeLayout(false);
            pnlBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).EndInit();
            pnlBuscarBD.ResumeLayout(false);
            pnlBuscarBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private TableLayoutPanel Inventario;
        private Panel pnlDetalles;
        private Label lbTitulo;
        private Panel panel1;
        private Label lblID;
        private TextBox textID;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel pnlNombre;
        private Label lblNombre;
        private Label lblPrecioC;
        private Panel pnlPC;
        private TextBox textPC;
        private TextBox textNombre;
        private Panel pnlStock;
        private TextBox textStock;
        private Label lblStock;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Panel pnlPV;
        private TextBox textPV;
        private Label lblVenta;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Panel pnlTabla;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel5;
        private TextBox textBox1;
        private Label label1;
        private Panel pnlBD;
        private Label Titulo;
        private DataGridView dtgBDInv;
        private FontAwesome.Sharp.IconButton btnGuardarBD;
        private Panel pnlBuscarBD;
        private TextBox tbBuscarBD;
        private Label BuscarBD;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPVenta;
        private DataGridViewTextBoxColumn colEstado;
    }
}