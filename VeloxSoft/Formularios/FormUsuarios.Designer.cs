namespace VeloxSoft.Formularios
{
    partial class FormUsuarios
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
            pnlUsuarios = new Panel();
            pnlBotones = new Panel();
            cbCESTADO = new ComboBox();
            lblCESTADO = new Label();
            cbCSESION = new ComboBox();
            lblCSESION = new Label();
            cbCROL = new ComboBox();
            lblCROL = new Label();
            btnBuscarU = new FontAwesome.Sharp.IconButton();
            textBuscarU = new TextBox();
            lblBuscarID = new Label();
            pnlBD = new Panel();
            dgvUsuariosDB = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colSesion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlFormulario = new Panel();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            boxEstado = new ComboBox();
            lblContraseña = new Label();
            textContra = new TextBox();
            lblEstado = new Label();
            textRol = new TextBox();
            lblRol = new Label();
            textNombre = new TextBox();
            lblNombre = new Label();
            textID = new TextBox();
            lblID = new Label();
            lblTituloForm = new Label();
            pnlUsuarios.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosDB).BeginInit();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUsuarios.BackColor = Color.FromArgb(234, 243, 222);
            pnlUsuarios.Controls.Add(pnlBotones);
            pnlUsuarios.Controls.Add(pnlBD);
            pnlUsuarios.Controls.Add(pnlFormulario);
            pnlUsuarios.Location = new Point(0, 0);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(1368, 658);
            pnlUsuarios.TabIndex = 0;
            pnlUsuarios.Resize += pnlUsuarios_Resize;
            // 
            // pnlBotones
            // 
            pnlBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBotones.BackColor = Color.White;
            pnlBotones.Controls.Add(cbCESTADO);
            pnlBotones.Controls.Add(lblCESTADO);
            pnlBotones.Controls.Add(cbCSESION);
            pnlBotones.Controls.Add(lblCSESION);
            pnlBotones.Controls.Add(cbCROL);
            pnlBotones.Controls.Add(lblCROL);
            pnlBotones.Controls.Add(btnBuscarU);
            pnlBotones.Controls.Add(textBuscarU);
            pnlBotones.Controls.Add(lblBuscarID);
            pnlBotones.Location = new Point(563, 12);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(790, 124);
            pnlBotones.TabIndex = 1;
            pnlBotones.Paint += pnlBotones_Paint;
            pnlBotones.Resize += pnlBotones_Resize;
            // 
            // cbCESTADO
            // 
            cbCESTADO.BackColor = Color.FromArgb(250, 254, 247);
            cbCESTADO.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCESTADO.FormattingEnabled = true;
            cbCESTADO.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbCESTADO.Location = new Point(480, 82);
            cbCESTADO.Name = "cbCESTADO";
            cbCESTADO.Size = new Size(114, 28);
            cbCESTADO.TabIndex = 52;
            // 
            // lblCESTADO
            // 
            lblCESTADO.AutoSize = true;
            lblCESTADO.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCESTADO.Location = new Point(480, 56);
            lblCESTADO.Name = "lblCESTADO";
            lblCESTADO.Size = new Size(82, 23);
            lblCESTADO.TabIndex = 51;
            lblCESTADO.Text = "Estado:";
            // 
            // cbCSESION
            // 
            cbCSESION.BackColor = Color.FromArgb(250, 254, 247);
            cbCSESION.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCSESION.FormattingEnabled = true;
            cbCSESION.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbCSESION.Location = new Point(201, 82);
            cbCSESION.Name = "cbCSESION";
            cbCSESION.Size = new Size(142, 28);
            cbCSESION.TabIndex = 50;
            // 
            // lblCSESION
            // 
            lblCSESION.AutoSize = true;
            lblCSESION.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCSESION.Location = new Point(201, 56);
            lblCSESION.Name = "lblCSESION";
            lblCSESION.Size = new Size(74, 23);
            lblCSESION.TabIndex = 49;
            lblCSESION.Text = "Sesion:";
            // 
            // cbCROL
            // 
            cbCROL.BackColor = Color.FromArgb(250, 254, 247);
            cbCROL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCROL.FormattingEnabled = true;
            cbCROL.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbCROL.Location = new Point(3, 82);
            cbCROL.Name = "cbCROL";
            cbCROL.Size = new Size(118, 28);
            cbCROL.TabIndex = 48;
            // 
            // lblCROL
            // 
            lblCROL.AutoSize = true;
            lblCROL.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCROL.Location = new Point(3, 56);
            lblCROL.Name = "lblCROL";
            lblCROL.Size = new Size(45, 23);
            lblCROL.TabIndex = 42;
            lblCROL.Text = "Rol:";
            // 
            // btnBuscarU
            // 
            btnBuscarU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarU.BackColor = Color.FromArgb(59, 109, 17);
            btnBuscarU.FlatAppearance.BorderSize = 0;
            btnBuscarU.FlatStyle = FlatStyle.Flat;
            btnBuscarU.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarU.IconColor = Color.Black;
            btnBuscarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarU.IconSize = 25;
            btnBuscarU.Location = new Point(411, 10);
            btnBuscarU.Name = "btnBuscarU";
            btnBuscarU.Size = new Size(37, 34);
            btnBuscarU.TabIndex = 41;
            btnBuscarU.UseVisualStyleBackColor = false;
            btnBuscarU.Paint += btnBuscarU_Paint;
            // 
            // textBuscarU
            // 
            textBuscarU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBuscarU.BackColor = Color.FromArgb(250, 254, 247);
            textBuscarU.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarU.ForeColor = Color.DimGray;
            textBuscarU.Location = new Point(201, 17);
            textBuscarU.Name = "textBuscarU";
            textBuscarU.Size = new Size(142, 32);
            textBuscarU.TabIndex = 40;
            textBuscarU.Text = "9991234567";
            textBuscarU.Enter += textBuscarU_Enter;
            textBuscarU.Leave += textBuscarU_Leave;
            // 
            // lblBuscarID
            // 
            lblBuscarID.AutoSize = true;
            lblBuscarID.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarID.Location = new Point(3, 17);
            lblBuscarID.Name = "lblBuscarID";
            lblBuscarID.Size = new Size(118, 27);
            lblBuscarID.TabIndex = 0;
            lblBuscarID.Text = "B.usuario:";
            // 
            // pnlBD
            // 
            pnlBD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBD.BackColor = Color.White;
            pnlBD.Controls.Add(dgvUsuariosDB);
            pnlBD.Location = new Point(563, 142);
            pnlBD.Name = "pnlBD";
            pnlBD.Size = new Size(790, 543);
            pnlBD.TabIndex = 1;
            pnlBD.Paint += pnlBD_Paint;
            pnlBD.Resize += pnlBD_Resize;
            // 
            // dgvUsuariosDB
            // 
            dgvUsuariosDB.AllowUserToAddRows = false;
            dgvUsuariosDB.AllowUserToResizeRows = false;
            dgvUsuariosDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuariosDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuariosDB.BackgroundColor = SystemColors.ButtonFace;
            dgvUsuariosDB.BorderStyle = BorderStyle.None;
            dgvUsuariosDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosDB.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colRol, colSesion, colEstado });
            dgvUsuariosDB.Location = new Point(47, 6);
            dgvUsuariosDB.Name = "dgvUsuariosDB";
            dgvUsuariosDB.RowHeadersVisible = false;
            dgvUsuariosDB.RowHeadersWidth = 51;
            dgvUsuariosDB.Size = new Size(725, 507);
            dgvUsuariosDB.TabIndex = 0;
            dgvUsuariosDB.CellContentClick += dgvUsuariosDB_CellContentClick;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 53;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 93;
            // 
            // colRol
            // 
            colRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colRol.HeaderText = "Rol";
            colRol.MinimumWidth = 6;
            colRol.Name = "colRol";
            colRol.Width = 60;
            // 
            // colSesion
            // 
            colSesion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colSesion.HeaderText = "Sesion";
            colSesion.MinimumWidth = 6;
            colSesion.Name = "colSesion";
            colSesion.Width = 81;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.Width = 83;
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(btnEliminar);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Controls.Add(btnGuardar);
            pnlFormulario.Controls.Add(boxEstado);
            pnlFormulario.Controls.Add(lblContraseña);
            pnlFormulario.Controls.Add(textContra);
            pnlFormulario.Controls.Add(lblEstado);
            pnlFormulario.Controls.Add(textRol);
            pnlFormulario.Controls.Add(lblRol);
            pnlFormulario.Controls.Add(textNombre);
            pnlFormulario.Controls.Add(lblNombre);
            pnlFormulario.Controls.Add(textID);
            pnlFormulario.Controls.Add(lblID);
            pnlFormulario.Controls.Add(lblTituloForm);
            pnlFormulario.Location = new Point(12, 12);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(545, 634);
            pnlFormulario.TabIndex = 0;
            pnlFormulario.Paint += pnlFormulario_Paint;
            pnlFormulario.Resize += pnlFormulario_Resize;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(163, 45, 45);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(257, 506);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 53);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Paint += btnEliminar_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(234, 243, 222);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(39, 83, 10);
            btnLimpiar.Location = new Point(103, 506);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 53);
            btnLimpiar.TabIndex = 49;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.Paint += btnLimpiar_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(59, 109, 17);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(103, 441);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(298, 48);
            btnGuardar.TabIndex = 48;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.Paint += btnGuardar_Paint;
            // 
            // boxEstado
            // 
            boxEstado.BackColor = Color.FromArgb(250, 254, 247);
            boxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            boxEstado.FormattingEnabled = true;
            boxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            boxEstado.Location = new Point(268, 270);
            boxEstado.Name = "boxEstado";
            boxEstado.Size = new Size(133, 28);
            boxEstado.TabIndex = 47;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.FromArgb(59, 109, 17);
            lblContraseña.Location = new Point(103, 325);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(125, 23);
            lblContraseña.TabIndex = 46;
            lblContraseña.Text = "Contraseña";
            // 
            // textContra
            // 
            textContra.BackColor = Color.FromArgb(250, 254, 247);
            textContra.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContra.ForeColor = Color.DimGray;
            textContra.Location = new Point(103, 364);
            textContra.Name = "textContra";
            textContra.Size = new Size(298, 32);
            textContra.TabIndex = 45;
            textContra.Text = "********";
            textContra.Enter += textContra_Enter;
            textContra.Leave += textContra_Leave;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(59, 109, 17);
            lblEstado.Location = new Point(268, 244);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(77, 23);
            lblEstado.TabIndex = 44;
            lblEstado.Text = "Estado";
            // 
            // textRol
            // 
            textRol.BackColor = Color.FromArgb(250, 254, 247);
            textRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textRol.ForeColor = Color.DimGray;
            textRol.Location = new Point(102, 270);
            textRol.Name = "textRol";
            textRol.Size = new Size(134, 32);
            textRol.TabIndex = 43;
            textRol.Text = "Rol del usuario...";
            textRol.Enter += textRol_Enter;
            textRol.Leave += textRol_Leave;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(59, 109, 17);
            lblRol.Location = new Point(101, 244);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(40, 23);
            lblRol.TabIndex = 42;
            lblRol.Text = "Rol";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(250, 254, 247);
            textNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(101, 197);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(300, 32);
            textNombre.TabIndex = 41;
            textNombre.Text = "Nombre cliente...";
            textNombre.Enter += textNombre_Enter;
            textNombre.Leave += textNombre_Leave;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(59, 109, 17);
            lblNombre.Location = new Point(100, 171);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 23);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre";
            // 
            // textID
            // 
            textID.BackColor = Color.FromArgb(250, 254, 247);
            textID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textID.ForeColor = Color.DimGray;
            textID.Location = new Point(101, 127);
            textID.Name = "textID";
            textID.Size = new Size(300, 32);
            textID.TabIndex = 39;
            textID.Text = "9991234567";
            textID.TextChanged += textID_TextChanged;
            textID.Enter += textID_Enter;
            textID.Leave += textID_Leave;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.FromArgb(59, 109, 17);
            lblID.Location = new Point(99, 101);
            lblID.Name = "lblID";
            lblID.Size = new Size(192, 23);
            lblID.TabIndex = 38;
            lblID.Text = "Numero telefonico";
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloForm.Location = new Point(17, 17);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(162, 51);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Usuarios";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 658);
            Controls.Add(pnlUsuarios);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            pnlUsuarios.ResumeLayout(false);
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            pnlBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosDB).EndInit();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuarios;
        private Panel pnlBD;
        private Panel pnlFormulario;
        private Label lblTituloForm;
        private ComboBox boxEstado;
        private Label lblContraseña;
        private TextBox textContra;
        private Label lblEstado;
        private TextBox textRol;
        private Label lblRol;
        private TextBox textNombre;
        private Label lblNombre;
        private TextBox textID;
        private Label lblID;
        private DataGridView dgvUsuariosDB;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colSesion;
        private DataGridViewTextBoxColumn colEstado;
        private Panel pnlBotones;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Label lblBuscarID;
        private TextBox textBuscarU;
        private FontAwesome.Sharp.IconButton btnBuscarU;
        private Label lblCROL;
        private ComboBox cbCESTADO;
        private Label lblCESTADO;
        private ComboBox cbCSESION;
        private Label lblCSESION;
        private ComboBox cbCROL;
    }
}