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
            cbEstadoInv = new ComboBox();
            lblEstado = new Label();
            BoxPrueba = new ComboBox();
            lblCategoria = new Label();
            textPV = new TextBox();
            lblPrecio = new Label();
            textStock = new TextBox();
            lblStock = new Label();
            textNombre = new TextBox();
            lblNombre = new Label();
            textID = new TextBox();
            lblID = new Label();
            LabelError2 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            llbDetalles = new Label();
            pnlBD = new Panel();
            textBuscarID = new TextBox();
            lbEstado = new Label();
            cbCategoria = new ComboBox();
            cbEstado = new ComboBox();
            lbCategoria = new Label();
            LabelError = new Label();
            dtgBDInv = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPVenta = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            BuscarBD = new Label();
            dataGridView1 = new DataGridView();
            lblTitulo = new Label();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            textBox1 = new TextBox();
            pnlFondo.SuspendLayout();
            Inventario.SuspendLayout();
            pnlDetalles.SuspendLayout();
            pnlBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).BeginInit();
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
            pnlFondo.Size = new Size(1370, 749);
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
            Inventario.Margin = new Padding(3, 5, 3, 5);
            Inventario.Name = "Inventario";
            Inventario.RowCount = 1;
            Inventario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Inventario.Size = new Size(1370, 749);
            Inventario.TabIndex = 0;
            // 
            // pnlDetalles
            // 
            pnlDetalles.BackColor = Color.FromArgb(216, 243, 220);
            pnlDetalles.Controls.Add(cbEstadoInv);
            pnlDetalles.Controls.Add(lblEstado);
            pnlDetalles.Controls.Add(BoxPrueba);
            pnlDetalles.Controls.Add(lblCategoria);
            pnlDetalles.Controls.Add(textPV);
            pnlDetalles.Controls.Add(lblPrecio);
            pnlDetalles.Controls.Add(textStock);
            pnlDetalles.Controls.Add(lblStock);
            pnlDetalles.Controls.Add(textNombre);
            pnlDetalles.Controls.Add(lblNombre);
            pnlDetalles.Controls.Add(textID);
            pnlDetalles.Controls.Add(lblID);
            pnlDetalles.Controls.Add(LabelError2);
            pnlDetalles.Controls.Add(btnEliminar);
            pnlDetalles.Controls.Add(btnGuardar);
            pnlDetalles.Controls.Add(btnNuevo);
            pnlDetalles.Controls.Add(llbDetalles);
            pnlDetalles.Dock = DockStyle.Fill;
            pnlDetalles.Location = new Point(3, 4);
            pnlDetalles.Margin = new Padding(3, 4, 3, 4);
            pnlDetalles.Name = "pnlDetalles";
            pnlDetalles.Size = new Size(610, 741);
            pnlDetalles.TabIndex = 0;
            pnlDetalles.Paint += pnlDetalles_Paint;
            pnlDetalles.Resize += pnlDetalles_Resize;
            // 
            // cbEstadoInv
            // 
            cbEstadoInv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoInv.FormattingEnabled = true;
            cbEstadoInv.Items.AddRange(new object[] { "Activo", "Baja" });
            cbEstadoInv.Location = new Point(130, 433);
            cbEstadoInv.Name = "cbEstadoInv";
            cbEstadoInv.Size = new Size(300, 28);
            cbEstadoInv.TabIndex = 39;
            cbEstadoInv.Visible = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(130, 397);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(77, 23);
            lblEstado.TabIndex = 38;
            lblEstado.Text = "Estado";
            lblEstado.Visible = false;
            // 
            // BoxPrueba
            // 
            BoxPrueba.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxPrueba.FormattingEnabled = true;
            BoxPrueba.Items.AddRange(new object[] { "Pieza", "Kilo" });
            BoxPrueba.Location = new Point(130, 345);
            BoxPrueba.Name = "BoxPrueba";
            BoxPrueba.Size = new Size(300, 28);
            BoxPrueba.TabIndex = 37;
            BoxPrueba.SelectedIndexChanged += BoxPrueba_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(130, 309);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(109, 23);
            lblCategoria.TabIndex = 36;
            lblCategoria.Text = "Categoria";
            // 
            // textPV
            // 
            textPV.BackColor = Color.White;
            textPV.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPV.ForeColor = Color.DimGray;
            textPV.Location = new Point(296, 253);
            textPV.Name = "textPV";
            textPV.Size = new Size(134, 32);
            textPV.TabIndex = 35;
            textPV.Text = "0";
            textPV.Enter += textPV_Enter;
            textPV.KeyPress += textPV_KeyPress;
            textPV.Leave += textPV_Leave;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(295, 228);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 23);
            lblPrecio.TabIndex = 34;
            lblPrecio.Text = "Precio";
            // 
            // textStock
            // 
            textStock.BackColor = Color.White;
            textStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStock.ForeColor = Color.DimGray;
            textStock.Location = new Point(129, 253);
            textStock.Name = "textStock";
            textStock.Size = new Size(134, 32);
            textStock.TabIndex = 33;
            textStock.Text = "0";
            textStock.Enter += textStock_Enter;
            textStock.KeyPress += textStock_KeyPress;
            textStock.Leave += textStock_Leave;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(128, 228);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(63, 23);
            lblStock.TabIndex = 32;
            lblStock.Text = "Stock";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.White;
            textNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(128, 181);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(300, 32);
            textNombre.TabIndex = 31;
            textNombre.Text = "Nombre producto...";
            textNombre.Enter += textNombre_Enter;
            textNombre.KeyPress += textNombre_KeyPress;
            textNombre.Leave += textNombre_Leave;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(127, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 23);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "Nombre";
            // 
            // textID
            // 
            textID.BackColor = Color.White;
            textID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textID.ForeColor = Color.DimGray;
            textID.Location = new Point(128, 111);
            textID.Name = "textID";
            textID.Size = new Size(300, 32);
            textID.TabIndex = 29;
            textID.Text = "Ej: 4011";
            textID.Enter += textID_Enter;
            textID.KeyPress += textID_KeyPress;
            textID.Leave += textID_Leave;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(126, 85);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 23);
            lblID.TabIndex = 28;
            lblID.Text = "ID";
            // 
            // LabelError2
            // 
            LabelError2.Dock = DockStyle.Top;
            LabelError2.ForeColor = Color.Red;
            LabelError2.Location = new Point(0, 0);
            LabelError2.Name = "LabelError2";
            LabelError2.Size = new Size(610, 20);
            LabelError2.TabIndex = 26;
            LabelError2.Text = "LabelError";
            LabelError2.TextAlign = ContentAlignment.TopCenter;
            LabelError2.Visible = false;
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
            btnEliminar.IconSize = 40;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(437, 620);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(179, 55);
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
            btnGuardar.IconSize = 40;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(222, 620);
            btnGuardar.Margin = new Padding(3, 5, 3, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 55);
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
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 50;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(11, 620);
            btnNuevo.Margin = new Padding(3, 5, 3, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(182, 55);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Limpiar";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            btnNuevo.Paint += btnNuevo_Paint;
            // 
            // llbDetalles
            // 
            llbDetalles.AutoSize = true;
            llbDetalles.Font = new Font("Franklin Gothic Medium Cond", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDetalles.Location = new Point(171, 37);
            llbDetalles.Name = "llbDetalles";
            llbDetalles.Size = new Size(251, 39);
            llbDetalles.TabIndex = 0;
            llbDetalles.Text = "Detalles Inventario";
            // 
            // pnlBD
            // 
            pnlBD.BackColor = Color.FromArgb(247, 250, 248);
            pnlBD.Controls.Add(textBuscarID);
            pnlBD.Controls.Add(lbEstado);
            pnlBD.Controls.Add(cbCategoria);
            pnlBD.Controls.Add(cbEstado);
            pnlBD.Controls.Add(lbCategoria);
            pnlBD.Controls.Add(LabelError);
            pnlBD.Controls.Add(dtgBDInv);
            pnlBD.Controls.Add(btnBuscar);
            pnlBD.Controls.Add(BuscarBD);
            pnlBD.Dock = DockStyle.Fill;
            pnlBD.Location = new Point(619, 4);
            pnlBD.Margin = new Padding(3, 4, 3, 4);
            pnlBD.Name = "pnlBD";
            pnlBD.Size = new Size(748, 741);
            pnlBD.TabIndex = 1;
            pnlBD.Paint += pnlBD_Paint;
            pnlBD.Resize += pnlBD_Resize;
            // 
            // textBuscarID
            // 
            textBuscarID.BackColor = Color.White;
            textBuscarID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarID.ForeColor = Color.DimGray;
            textBuscarID.Location = new Point(130, 11);
            textBuscarID.Name = "textBuscarID";
            textBuscarID.Size = new Size(74, 32);
            textBuscarID.TabIndex = 38;
            textBuscarID.Text = "Ej: 4011";
            textBuscarID.Enter += textBuscarID_Enter;
            textBuscarID.KeyPress += textBuscarID_KeyPress;
            textBuscarID.Leave += textBuscarID_Leave;
            // 
            // lbEstado
            // 
            lbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(296, 91);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(77, 29);
            lbEstado.TabIndex = 23;
            lbEstado.Text = "Estado:";
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.None;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "", "Pieza", "Kilo" });
            cbCategoria.Location = new Point(139, 91);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(114, 28);
            cbCategoria.TabIndex = 22;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.None;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "", "Activo", "Inactivo" });
            cbEstado.Location = new Point(411, 91);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(107, 28);
            cbEstado.TabIndex = 21;
            // 
            // lbCategoria
            // 
            lbCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoria.Location = new Point(30, 91);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(100, 29);
            lbCategoria.TabIndex = 20;
            lbCategoria.Text = "Categoría:";
            // 
            // LabelError
            // 
            LabelError.ForeColor = Color.Red;
            LabelError.Location = new Point(0, 0);
            LabelError.Name = "LabelError";
            LabelError.Size = new Size(747, 20);
            LabelError.TabIndex = 19;
            LabelError.Text = "Error";
            LabelError.TextAlign = ContentAlignment.TopCenter;
            LabelError.Visible = false;
            // 
            // dtgBDInv
            // 
            dtgBDInv.AllowUserToAddRows = false;
            dtgBDInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBDInv.BackgroundColor = Color.Silver;
            dtgBDInv.BorderStyle = BorderStyle.None;
            dtgBDInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBDInv.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colCategoria, colStock, colPVenta, colEstado });
            dtgBDInv.Location = new Point(0, 0);
            dtgBDInv.Margin = new Padding(3, 4, 3, 4);
            dtgBDInv.Name = "dtgBDInv";
            dtgBDInv.ReadOnly = true;
            dtgBDInv.RowHeadersVisible = false;
            dtgBDInv.RowHeadersWidth = 51;
            dtgBDInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgBDInv.Size = new Size(747, 741);
            dtgBDInv.TabIndex = 18;
            dtgBDInv.DoubleClick += dtgBDInv_DoubleClick;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 53;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 93;
            // 
            // colCategoria
            // 
            colCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 103;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 74;
            // 
            // colPVenta
            // 
            colPVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPVenta.HeaderText = "P.Venta";
            colPVenta.MinimumWidth = 6;
            colPVenta.Name = "colPVenta";
            colPVenta.ReadOnly = true;
            colPVenta.Width = 86;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 83;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(27, 67, 50);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(220, 37);
            btnBuscar.Margin = new Padding(3, 5, 3, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 32);
            btnBuscar.TabIndex = 17;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            btnBuscar.Paint += btnGuardarBD_Paint;
            // 
            // BuscarBD
            // 
            BuscarBD.AutoSize = true;
            BuscarBD.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarBD.Location = new Point(88, 37);
            BuscarBD.Name = "BuscarBD";
            BuscarBD.Size = new Size(36, 29);
            BuscarBD.TabIndex = 15;
            BuscarBD.Text = "ID:";
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
            ClientSize = new Size(1370, 749);
            Controls.Add(pnlFondo);
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormInventario_Load;
            pnlFondo.ResumeLayout(false);
            Inventario.ResumeLayout(false);
            pnlDetalles.ResumeLayout(false);
            pnlDetalles.PerformLayout();
            pnlBD.ResumeLayout(false);
            pnlBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBDInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private TableLayoutPanel Inventario;
        private Panel pnlDetalles;
        private Label llbDetalles;
        private FontAwesome.Sharp.IconButton btnGuardar;
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
        private DataGridView dtgBDInv;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label BuscarBD;
        private Label LabelError;
        private Label LabelError2;
        private Label lbEstado;
        private ComboBox cbCategoria;
        private ComboBox cbEstado;
        private Label lbCategoria;
        private TextBox textID;
        private Label lblID;
        private TextBox textNombre;
        private Label lblNombre;
        private TextBox textStock;
        private Label lblStock;
        private TextBox textPV;
        private Label lblPrecio;
        private Label lblCategoria;
        private ComboBox BoxPrueba;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPVenta;
        private DataGridViewTextBoxColumn colEstado;
        private TextBox textBuscarID;
        private ComboBox cbEstadoInv;
        private Label lblEstado;
    }
}