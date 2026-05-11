namespace VeloxSoft.Formularios
{
    partial class FormClientes
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
            pnlClientes = new Panel();
            pnlBD = new Panel();
            pnlBotones = new Panel();
            cbColonia = new ComboBox();
            cbTablas = new ComboBox();
            btnBuscarC = new FontAwesome.Sharp.IconButton();
            textBuscarC = new TextBox();
            lblBuscarC = new Label();
            pnlFormulario = new Panel();
            btnBuscarF = new FontAwesome.Sharp.IconButton();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            textDIreccion = new TextBox();
            lblDireccion = new Label();
            textApodo = new TextBox();
            lblApodo = new Label();
            textApellido = new TextBox();
            lblApellido = new Label();
            textNombre = new TextBox();
            lblNombre = new Label();
            textNumero = new TextBox();
            lblNumero = new Label();
            lblTituloForm = new Label();
            pnlClientes.SuspendLayout();
            pnlBotones.SuspendLayout();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientes
            // 
            pnlClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClientes.BackColor = Color.FromArgb(245, 247, 242);
            pnlClientes.Controls.Add(pnlBD);
            pnlClientes.Controls.Add(pnlBotones);
            pnlClientes.Controls.Add(pnlFormulario);
            pnlClientes.Location = new Point(-2, -2);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(1352, 612);
            pnlClientes.TabIndex = 0;
            pnlClientes.Resize += pnlClientes_Resize;
            // 
            // pnlBD
            // 
            pnlBD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBD.BackColor = Color.White;
            pnlBD.Location = new Point(604, 107);
            pnlBD.Name = "pnlBD";
            pnlBD.Size = new Size(737, 494);
            pnlBD.TabIndex = 2;
            pnlBD.Paint += pnlBD_Paint;
            // 
            // pnlBotones
            // 
            pnlBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBotones.BackColor = Color.White;
            pnlBotones.Controls.Add(cbColonia);
            pnlBotones.Controls.Add(cbTablas);
            pnlBotones.Controls.Add(btnBuscarC);
            pnlBotones.Controls.Add(textBuscarC);
            pnlBotones.Controls.Add(lblBuscarC);
            pnlBotones.Location = new Point(604, 14);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(737, 87);
            pnlBotones.TabIndex = 1;
            pnlBotones.Paint += pnlBotones_Paint;
            pnlBotones.Resize += pnlBotones_Resize;
            // 
            // cbColonia
            // 
            cbColonia.BackColor = Color.FromArgb(250, 254, 247);
            cbColonia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColonia.FormattingEnabled = true;
            cbColonia.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbColonia.Location = new Point(297, 50);
            cbColonia.Name = "cbColonia";
            cbColonia.Size = new Size(142, 23);
            cbColonia.TabIndex = 59;
            // 
            // cbTablas
            // 
            cbTablas.BackColor = Color.FromArgb(250, 254, 247);
            cbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTablas.FormattingEnabled = true;
            cbTablas.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbTablas.Location = new Point(67, 50);
            cbTablas.Name = "cbTablas";
            cbTablas.Size = new Size(118, 23);
            cbTablas.TabIndex = 57;
            // 
            // btnBuscarC
            // 
            btnBuscarC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscarC.BackColor = Color.FromArgb(59, 109, 17);
            btnBuscarC.FlatAppearance.BorderSize = 0;
            btnBuscarC.FlatStyle = FlatStyle.Flat;
            btnBuscarC.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarC.IconColor = Color.Black;
            btnBuscarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarC.IconSize = 25;
            btnBuscarC.Location = new Point(284, 6);
            btnBuscarC.Name = "btnBuscarC";
            btnBuscarC.Size = new Size(37, 34);
            btnBuscarC.TabIndex = 55;
            btnBuscarC.UseVisualStyleBackColor = false;
            btnBuscarC.Click += btnBuscarC_Click;
            // 
            // textBuscarC
            // 
            textBuscarC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBuscarC.BackColor = Color.FromArgb(250, 254, 247);
            textBuscarC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarC.ForeColor = Color.DimGray;
            textBuscarC.Location = new Point(127, 8);
            textBuscarC.Name = "textBuscarC";
            textBuscarC.Size = new Size(142, 27);
            textBuscarC.TabIndex = 54;
            textBuscarC.Text = "Cliente...";
            // 
            // lblBuscarC
            // 
            lblBuscarC.AutoSize = true;
            lblBuscarC.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarC.Location = new Point(16, 11);
            lblBuscarC.Name = "lblBuscarC";
            lblBuscarC.Size = new Size(95, 22);
            lblBuscarC.TabIndex = 53;
            lblBuscarC.Text = "B.Cliente:";
            // 
            // pnlFormulario
            // 
            pnlFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.Controls.Add(btnBuscarF);
            pnlFormulario.Controls.Add(btnEliminar);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Controls.Add(btnGuardar);
            pnlFormulario.Controls.Add(textDIreccion);
            pnlFormulario.Controls.Add(lblDireccion);
            pnlFormulario.Controls.Add(textApodo);
            pnlFormulario.Controls.Add(lblApodo);
            pnlFormulario.Controls.Add(textApellido);
            pnlFormulario.Controls.Add(lblApellido);
            pnlFormulario.Controls.Add(textNombre);
            pnlFormulario.Controls.Add(lblNombre);
            pnlFormulario.Controls.Add(textNumero);
            pnlFormulario.Controls.Add(lblNumero);
            pnlFormulario.Controls.Add(lblTituloForm);
            pnlFormulario.Location = new Point(14, 14);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(584, 587);
            pnlFormulario.TabIndex = 0;
            pnlFormulario.Paint += pnlFormulario_Paint;
            pnlFormulario.Resize += pnlFormulario_Resize;
            // 
            // btnBuscarF
            // 
            btnBuscarF.BackColor = Color.FromArgb(59, 109, 17);
            btnBuscarF.FlatAppearance.BorderSize = 0;
            btnBuscarF.FlatStyle = FlatStyle.Flat;
            btnBuscarF.IconChar = FontAwesome.Sharp.IconChar.File;
            btnBuscarF.IconColor = Color.Black;
            btnBuscarF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarF.IconSize = 29;
            btnBuscarF.Location = new Point(391, 360);
            btnBuscarF.Name = "btnBuscarF";
            btnBuscarF.Size = new Size(36, 32);
            btnBuscarF.TabIndex = 54;
            btnBuscarF.UseVisualStyleBackColor = false;
            btnBuscarF.Click += btnBuscarF_Click;
            btnBuscarF.Paint += btnBuscarF_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(163, 45, 45);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(240, 489);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 53);
            btnEliminar.TabIndex = 53;
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
            btnLimpiar.Location = new Point(86, 489);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 53);
            btnLimpiar.TabIndex = 52;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Paint += btnLimpiar_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(59, 109, 17);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(86, 424);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(298, 48);
            btnGuardar.TabIndex = 51;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Paint += btnGuardar_Paint;
            // 
            // textDIreccion
            // 
            textDIreccion.BackColor = Color.FromArgb(250, 254, 247);
            textDIreccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDIreccion.ForeColor = Color.DimGray;
            textDIreccion.Location = new Point(84, 360);
            textDIreccion.Name = "textDIreccion";
            textDIreccion.Size = new Size(300, 27);
            textDIreccion.TabIndex = 49;
            textDIreccion.Text = "Calle 33 & Calle 96 y Calle 98";
            textDIreccion.Enter += textDIreccion_Enter;
            textDIreccion.Leave += textDIreccion_Leave;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.FromArgb(59, 109, 17);
            lblDireccion.Location = new Point(82, 334);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(83, 21);
            lblDireccion.TabIndex = 48;
            lblDireccion.Text = "Direccion";
            // 
            // textApodo
            // 
            textApodo.BackColor = Color.FromArgb(250, 254, 247);
            textApodo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textApodo.ForeColor = Color.DimGray;
            textApodo.Location = new Point(82, 298);
            textApodo.Name = "textApodo";
            textApodo.Size = new Size(300, 27);
            textApodo.TabIndex = 47;
            textApodo.Text = "Apodo...";
            textApodo.Enter += textApodo_Enter;
            textApodo.Leave += textApodo_Leave;
            // 
            // lblApodo
            // 
            lblApodo.AutoSize = true;
            lblApodo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApodo.ForeColor = Color.FromArgb(59, 109, 17);
            lblApodo.Location = new Point(80, 272);
            lblApodo.Name = "lblApodo";
            lblApodo.Size = new Size(150, 21);
            lblApodo.TabIndex = 46;
            lblApodo.Text = "Apodo del cliente";
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.FromArgb(250, 254, 247);
            textApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textApellido.ForeColor = Color.DimGray;
            textApellido.Location = new Point(80, 231);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(300, 27);
            textApellido.TabIndex = 45;
            textApellido.Text = "Apellido...";
            textApellido.Enter += textApellido_Enter;
            textApellido.Leave += textApellido_Leave;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.FromArgb(59, 109, 17);
            lblApellido.Location = new Point(78, 205);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(159, 21);
            lblApellido.TabIndex = 44;
            lblApellido.Text = "Apellido del cliente";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.FromArgb(250, 254, 247);
            textNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.ForeColor = Color.DimGray;
            textNombre.Location = new Point(78, 167);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(300, 27);
            textNombre.TabIndex = 43;
            textNombre.Text = "Cliente...";
            textNombre.Enter += textNombre_Enter;
            textNombre.Leave += textNombre_Leave;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(59, 109, 17);
            lblNombre.Location = new Point(76, 141);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(158, 21);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre del cliente";
            // 
            // textNumero
            // 
            textNumero.BackColor = Color.FromArgb(250, 254, 247);
            textNumero.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumero.ForeColor = Color.DimGray;
            textNumero.Location = new Point(76, 104);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(300, 27);
            textNumero.TabIndex = 41;
            textNumero.Text = "9991234567";
            textNumero.Enter += textNumero_Enter;
            textNumero.Leave += textNumero_Leave;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.FromArgb(59, 109, 17);
            lblNumero.Location = new Point(74, 78);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(154, 21);
            lblNumero.TabIndex = 40;
            lblNumero.Text = "Numero telefonico";
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Franklin Gothic Medium Cond", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloForm.Location = new Point(17, 11);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(131, 44);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Clientes";
            // 
            // FormClientes
            // 
            ClientSize = new Size(1351, 611);
            Controls.Add(pnlClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            pnlClientes.ResumeLayout(false);
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlClientes;
        private Panel pnlBD;
        private Panel pnlBotones;
        private Panel pnlFormulario;
        private Label lblTituloForm;
        private TextBox textNumero;
        private Label lblNumero;
        private TextBox textNombre;
        private Label lblNombre;
        private TextBox textApellido;
        private Label lblApellido;
        private TextBox textApodo;
        private Label lblApodo;
        private TextBox textDIreccion;
        private Label lblDireccion;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cbColonia;
        private ComboBox cbTablas;
        private FontAwesome.Sharp.IconButton btnBuscarC;
        private TextBox textBuscarC;
        private Label lblBuscarC;
        private FontAwesome.Sharp.IconButton btnBuscarF;
    }
}