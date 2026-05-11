using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace VeloxSoft.Formularios
{
    public partial class FormClientes : Form
    {
        private Panel? pnlMiniFormulario;
        private Panel? pnlBarraMiniFormulario;
        private Button? btnCerrarMiniFormulario;

        private bool moviendoMiniFormulario = false;
        private Point puntoInicioMouse;
        private Point puntoInicioPanel;

        public FormClientes()
        {
            InitializeComponent();
            CrearMiniFormulario();
            btnBuscarF.Click += btnBuscarF_Click;
            this.DoubleBuffered = true;
            pnlClientes_Resize(this, EventArgs.Empty);
            pnlFormulario_Resize(this, EventArgs.Empty);
            InicializarFormulariosBD();
            InicializarFiltros();

        }


        private void CrearMiniFormulario()
        {
            pnlMiniFormulario = new Panel();
            btnCerrarMiniFormulario = new Button();

            pnlMiniFormulario.Name = "pnlMiniFormulario";
            pnlMiniFormulario.Size = new Size(420, 390);
            pnlMiniFormulario.BackColor = Color.White;
            pnlMiniFormulario.BorderStyle = BorderStyle.None;
            pnlMiniFormulario.Visible = false;

            pnlMiniFormulario.Location = new Point(
                (this.ClientSize.Width - pnlMiniFormulario.Width) / 2,
                (this.ClientSize.Height - pnlMiniFormulario.Height) / 2
            );

            // Barra superior
            pnlBarraMiniFormulario = new Panel();
            pnlBarraMiniFormulario.Height = 36;
            pnlBarraMiniFormulario.Dock = DockStyle.Top;
            pnlBarraMiniFormulario.BackColor = Color.FromArgb(234, 243, 222);

            pnlBarraMiniFormulario.MouseDown += pnlMiniFormulario_MouseDown;
            pnlBarraMiniFormulario.MouseMove += pnlMiniFormulario_MouseMove;
            pnlBarraMiniFormulario.MouseUp += pnlMiniFormulario_MouseUp;

            Label lblTituloMini = new Label();
            lblTituloMini.AutoSize = true;
            lblTituloMini.Text = "Editar dirección";
            lblTituloMini.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMini.ForeColor = Color.FromArgb(59, 109, 17);
            lblTituloMini.Location = new Point(12, 8);

            // para que también se pueda arrastrar al tocar el título
            lblTituloMini.MouseDown += pnlMiniFormulario_MouseDown;
            lblTituloMini.MouseMove += pnlMiniFormulario_MouseMove;
            lblTituloMini.MouseUp += pnlMiniFormulario_MouseUp;

            pnlBarraMiniFormulario.Controls.Add(lblTituloMini);

            pnlMiniFormulario.Controls.Add(pnlBarraMiniFormulario);

            Font fuente = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Color colorLabel = Color.FromArgb(59, 109, 17);
            Color colorInput = Color.FromArgb(250, 254, 247);

            // Número de casa
            Label lblNumeroCasa = new Label();
            lblNumeroCasa.AutoSize = true;
            lblNumeroCasa.Font = fuente;
            lblNumeroCasa.ForeColor = colorLabel;
            lblNumeroCasa.Location = new Point(20, 55);
            lblNumeroCasa.Name = "lblNumeroCasa";
            lblNumeroCasa.Text = "Número de casa";

            TextBox txtNumeroCasa = new TextBox();
            txtNumeroCasa.BackColor = colorInput;
            txtNumeroCasa.Font = fuente;
            txtNumeroCasa.ForeColor = Color.DimGray;
            txtNumeroCasa.Location = new Point(20, 80);
            txtNumeroCasa.Name = "txtNumeroCasa";
            txtNumeroCasa.Size = new Size(150, 32);

            // Calle
            Label lblCalle = new Label();
            lblCalle.AutoSize = true;
            lblCalle.Font = fuente;
            lblCalle.ForeColor = colorLabel;
            lblCalle.Location = new Point(200, 55);
            lblCalle.Name = "lblCalle";
            lblCalle.Text = "Calle";

            TextBox txtCalle = new TextBox();
            txtCalle.BackColor = colorInput;
            txtCalle.Font = fuente;
            txtCalle.ForeColor = Color.DimGray;
            txtCalle.Location = new Point(200, 80);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(180, 32);

            // Cruzamiento
            Label lblCruzamiento = new Label();
            lblCruzamiento.AutoSize = true;
            lblCruzamiento.Font = fuente;
            lblCruzamiento.ForeColor = colorLabel;
            lblCruzamiento.Location = new Point(20, 125);
            lblCruzamiento.Name = "lblCruzamiento";
            lblCruzamiento.Text = "Cruzamiento";

            TextBox txtCruzamiento = new TextBox();
            txtCruzamiento.BackColor = colorInput;
            txtCruzamiento.Font = fuente;
            txtCruzamiento.ForeColor = Color.DimGray;
            txtCruzamiento.Location = new Point(20, 150);
            txtCruzamiento.Name = "txtCruzamiento";
            txtCruzamiento.Size = new Size(170, 32);

            // Referencia
            Label lblReferencia = new Label();
            lblReferencia.AutoSize = true;
            lblReferencia.Font = fuente;
            lblReferencia.ForeColor = colorLabel;
            lblReferencia.Location = new Point(210, 125);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Text = "Referencia";

            TextBox txtReferencia = new TextBox();
            txtReferencia.BackColor = colorInput;
            txtReferencia.Font = fuente;
            txtReferencia.ForeColor = Color.DimGray;
            txtReferencia.Location = new Point(210, 150);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(170, 32);

            // Colonia
            Label lblColonia = new Label();
            lblColonia.AutoSize = true;
            lblColonia.Font = fuente;
            lblColonia.ForeColor = colorLabel;
            lblColonia.Location = new Point(20, 195);
            lblColonia.Name = "lblColonia";
            lblColonia.Text = "Colonia";

            ComboBox cbColonia = new ComboBox();
            cbColonia.BackColor = colorInput;
            cbColonia.Font = fuente;
            cbColonia.Location = new Point(20, 220);
            cbColonia.Name = "cbColonia";
            cbColonia.Size = new Size(220, 31);
            cbColonia.DropDownStyle = ComboBoxStyle.DropDownList;

            // Dirección
            Label lblDireccionCompleta = new Label();
            lblDireccionCompleta.AutoSize = true;
            lblDireccionCompleta.Font = fuente;
            lblDireccionCompleta.ForeColor = colorLabel;
            lblDireccionCompleta.Location = new Point(20, 265);
            lblDireccionCompleta.Name = "lblDireccionCompleta";
            lblDireccionCompleta.Text = "Dirección";

            TextBox txtDireccionCompleta = new TextBox();
            txtDireccionCompleta.BackColor = colorInput;
            txtDireccionCompleta.Font = fuente;
            txtDireccionCompleta.ForeColor = Color.DimGray;
            txtDireccionCompleta.Location = new Point(20, 290);
            txtDireccionCompleta.Name = "txtDireccionCompleta";
            txtDireccionCompleta.Size = new Size(250, 32);

            // Botón guardar
            Button btnGuardarMini = new Button();
            btnGuardarMini.BackColor = Color.FromArgb(59, 109, 17);
            btnGuardarMini.FlatAppearance.BorderSize = 0;
            btnGuardarMini.FlatStyle = FlatStyle.Flat;
            btnGuardarMini.ForeColor = Color.White;
            btnGuardarMini.Font = fuente;
            btnGuardarMini.Location = new Point(285, 288);
            btnGuardarMini.Name = "btnGuardarMini";
            btnGuardarMini.Size = new Size(100, 36);
            btnGuardarMini.Text = "Guardar";
            btnGuardarMini.UseVisualStyleBackColor = false;

            // Agregar controles
            pnlMiniFormulario.Controls.Add(lblNumeroCasa);
            pnlMiniFormulario.Controls.Add(txtNumeroCasa);

            pnlMiniFormulario.Controls.Add(lblCalle);
            pnlMiniFormulario.Controls.Add(txtCalle);

            pnlMiniFormulario.Controls.Add(lblCruzamiento);
            pnlMiniFormulario.Controls.Add(txtCruzamiento);

            pnlMiniFormulario.Controls.Add(lblReferencia);
            pnlMiniFormulario.Controls.Add(txtReferencia);

            pnlMiniFormulario.Controls.Add(lblColonia);
            pnlMiniFormulario.Controls.Add(cbColonia);

            pnlMiniFormulario.Controls.Add(lblDireccionCompleta);
            pnlMiniFormulario.Controls.Add(txtDireccionCompleta);

            pnlMiniFormulario.Controls.Add(btnGuardarMini);

            // Botón cerrar
            btnCerrarMiniFormulario.Text = "X";
            btnCerrarMiniFormulario.Size = new Size(30, 26);
            btnCerrarMiniFormulario.Location = new Point(
                pnlMiniFormulario.Width - 40,
                5
            );

            btnCerrarMiniFormulario.FlatStyle = FlatStyle.Flat;
            btnCerrarMiniFormulario.FlatAppearance.BorderSize = 0;
            btnCerrarMiniFormulario.BackColor = Color.FromArgb(163, 45, 45);
            btnCerrarMiniFormulario.ForeColor = Color.White;

            btnCerrarMiniFormulario.Click += btnCerrarMiniFormulario_Click;

            pnlBarraMiniFormulario.Controls.Add(btnCerrarMiniFormulario);

            this.Controls.Add(pnlMiniFormulario);
            pnlMiniFormulario.BringToFront();
        }

        //Diseño estetico de esteticos y botonoes

        private void pnlMiniFormulario_MouseDown(object? sender, MouseEventArgs e)
        {
            if (pnlMiniFormulario == null) return;

            if (e.Button == MouseButtons.Left)
            {
                moviendoMiniFormulario = true;
                puntoInicioMouse = Cursor.Position;
                puntoInicioPanel = pnlMiniFormulario.Location;
            }
        }

        private void pnlMiniFormulario_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!moviendoMiniFormulario || pnlMiniFormulario == null) return;

            Point delta = new Point(
                Cursor.Position.X - puntoInicioMouse.X,
                Cursor.Position.Y - puntoInicioMouse.Y
            );

            int nuevaX = puntoInicioPanel.X + delta.X;
            int nuevaY = puntoInicioPanel.Y + delta.Y;

            int minX = pnlClientes.Left;
            int minY = pnlClientes.Top;

            int maxX = pnlClientes.Right - pnlMiniFormulario.Width;
            int maxY = pnlClientes.Bottom - pnlMiniFormulario.Height;

            if (nuevaX < minX) nuevaX = minX;
            if (nuevaY < minY) nuevaY = minY;

            if (nuevaX > maxX) nuevaX = maxX;
            if (nuevaY > maxY) nuevaY = maxY;

            pnlMiniFormulario.Location = new Point(nuevaX, nuevaY);
        }

        private void pnlMiniFormulario_MouseUp(object? sender, MouseEventArgs e)
        {
            moviendoMiniFormulario = false;
        }

        private void RedondearPanel(Panel p, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();

            // Dibujamos el camino de las esquinas
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(p.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(p.Width - radio, p.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, p.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            // Aplicamos la forma al panel para que sea "físicamente" redondo
            p.Region = new Region(path);

            // Dibuja un borde sutil con el verde #A4D1A5 de tu paleta Fruit Salad
            // Esto hace que el cuadro resalte sobre el fondo verde oscuro
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#A4D1A5"), 2))
            {
                e.Graphics.DrawPath(pen, path);
            }

        }

        // Variables
        private FormTablaClientes? _formTablaClientes;
        private FormTablaColonias? _formTablaColonias;
        private FormTablaDireccion? _formTablaDireccion;
        private Form? _formActual;

        private void MostrarFormEnPanel(Form form)
        {
            if (_formActual != null)
                _formActual.Hide();

            if (!pnlBD.Controls.Contains(form))
                pnlBD.Controls.Add(form);

            form.Show();
            _formActual = form;
        }

        private void InicializarFormulariosBD()
        {
            _formTablaClientes = new FormTablaClientes();
            _formTablaColonias = new FormTablaColonias();
            _formTablaDireccion = new FormTablaDireccion();

            pnlBD.Controls.Add(_formTablaClientes);
            pnlBD.Controls.Add(_formTablaColonias);
            pnlBD.Controls.Add(_formTablaDireccion);

            _formTablaColonias.Hide();
            _formTablaDireccion.Hide();
            _formTablaClientes.Show();
            _formActual = _formTablaClientes;
        }

        private void InicializarFiltros()
        {
            // cbTablas — selecciona qué tabla ver
            cbTablas.Items.Clear();
            cbTablas.Items.Add("Clientes");
            cbTablas.Items.Add("Colonias");
            cbTablas.Items.Add("Dirección");
            cbTablas.SelectedIndex = 0;
            cbTablas.SelectedIndexChanged += cbTablas_SelectedIndexChanged;

            // cbColonia — se llena cuando se carguen datos de BD
            cbColonia.Items.Clear();
            cbColonia.Items.Add("Todas");
            cbColonia.SelectedIndex = 0;
            cbColonia.SelectedIndexChanged += cbColonia_SelectedIndexChanged;

            // btnBuscarC — busca por número de teléfono
            btnBuscarC.Click += btnBuscarC_Click;
        }

        // ── EVENTOS ────────────────────────────────────────
        private void cbTablas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cbTablas.SelectedItem?.ToString())
            {
                case "Clientes":
                    if (_formTablaClientes != null)
                        MostrarFormEnPanel(_formTablaClientes);
                    break;
                case "Colonias":
                    if (_formTablaColonias != null)
                        MostrarFormEnPanel(_formTablaColonias);
                    break;
                case "Dirección":
                    if (_formTablaDireccion != null)
                        MostrarFormEnPanel(_formTablaDireccion);
                    break;
            }
        }

        private void cbColonia_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string colonia = cbColonia.SelectedItem?.ToString() ?? "Todas";

            if (colonia == "Todas")
            {
                _formTablaClientes?.MostrarTodos();
                _formTablaDireccion?.MostrarTodos();
                return;
            }

            // Filtra según la tabla activa
            if (_formActual == _formTablaClientes)
                _formTablaClientes?.FiltrarPorColonia(colonia);
            else if (_formActual == _formTablaDireccion)
                _formTablaDireccion?.FiltrarPorColonia(colonia);
        }


        private void btnBuscarC_Click(object? sender, EventArgs e)
        {
            string buscar = textBuscarC.Text.Trim();

            if (string.IsNullOrEmpty(buscar) || buscar == "Cliente...")
            {
                _formTablaClientes?.MostrarTodos();
                return;
            }

            // Busca siempre en clientes por número
            if (_formTablaClientes != null)
            {
                MostrarFormEnPanel(_formTablaClientes);
                cbTablas.SelectedIndex = 0;
                _formTablaClientes.FiltrarPorNumero(buscar);
            }
        }

        //////////// FIN DE LAS TABLAS ////////////////

        // ── RESIZE DEL PANEL BOTONES ───────────────────────
        private void pnlBotones_Resize(object sender, EventArgs e)
        {
            int w = pnlBotones.Width;
            int h = pnlBotones.Height;
            int margen = 15;
            int altoControl = 28;
            int x = margen;
            bool dosLineas = w < 700;

            if (!dosLineas)
            {
                // ── UNA LÍNEA ──
                int y = (h - altoControl) / 2;

                int anchoLbl = 85;
                int anchoBuscar = (int)(w * 0.18);
                int anchoBtn = 42;
                int anchoTablas = (int)(w * 0.14);
                int anchoColonia = (int)(w * 0.16);

                // BUSCAR CLIENTE
                lblBuscarC.Location = new Point(x, y + 4);
                lblBuscarC.Size = new Size(anchoLbl, 20);
                x += anchoLbl + 4;

                textBuscarC.Location = new Point(x, y);
                textBuscarC.Size = new Size(anchoBuscar, altoControl);
                x += anchoBuscar + 4;

                btnBuscarC.Location = new Point(x, y);
                btnBuscarC.Size = new Size(anchoBtn, altoControl);
                x += anchoBtn + 14;

                // TABLA
                Label lblTablas = ObtenerLabel("lblTablas", "Tabla:");
                lblTablas.Location = new Point(x, y + 4);
                lblTablas.Size = new Size(55, 20);
                x += 58;

                cbTablas.Location = new Point(x, y);
                cbTablas.Size = new Size(anchoTablas, altoControl);
                x += anchoTablas + 14;

                // COLONIA
                Label lblColonia = ObtenerLabel("lblColonia", "Colonia:");
                lblColonia.Location = new Point(x, y + 4);
                lblColonia.Size = new Size(65, 20);
                x += 68;

                cbColonia.Location = new Point(x, y);
                cbColonia.Size = new Size(w - x - margen, altoControl);
            }
            else
            {
                // ── DOS LÍNEAS ──
                int anchoTotal = w - margen * 2;
                int anchoBtn = 42;
                int anchoBuscar = anchoTotal - anchoBtn - 90 - 8;

                // FILA 1 — BUSCAR
                int y1 = 8;
                lblBuscarC.Location = new Point(margen, y1 + 4);
                lblBuscarC.Size = new Size(85, 20);
                textBuscarC.Location = new Point(margen + 88, y1);
                textBuscarC.Size = new Size(anchoBuscar, altoControl);
                btnBuscarC.Location = new Point(w - margen - anchoBtn, y1);
                btnBuscarC.Size = new Size(anchoBtn, altoControl);

                // FILA 2 — COMBOS
                int y2 = y1 + altoControl + 8;
                int xCmb = margen;
                int anchoCmb = (int)((anchoTotal - 130) / 2);

                Label lblTablas = ObtenerLabel("lblTablas", "Tabla:");
                lblTablas.Location = new Point(xCmb, y2 + 4);
                lblTablas.Size = new Size(50, 20);
                xCmb += 53;
                cbTablas.Location = new Point(xCmb, y2);
                cbTablas.Size = new Size(anchoCmb, altoControl);
                xCmb += anchoCmb + 10;

                Label lblColonia = ObtenerLabel("lblColonia", "Colonia:");
                lblColonia.Location = new Point(xCmb, y2 + 4);
                lblColonia.Size = new Size(60, 20);
                xCmb += 63;
                cbColonia.Location = new Point(xCmb, y2);
                cbColonia.Size = new Size(w - xCmb - margen, altoControl);
            }

            pnlBotones.Invalidate();
        }

        // Helper para crear labels dinámicos una sola vez
        private Label ObtenerLabel(string nombre, string texto)
        {
            foreach (Control c in pnlBotones.Controls)
                if (c.Name == nombre) return (Label)c;

            Label lbl = new Label();
            lbl.Name = nombre;
            lbl.Text = texto;
            lbl.AutoSize = false;
            lbl.Font = new Font("Century Gothic", 10F);
            lbl.ForeColor = Color.FromArgb(59, 109, 17);
            pnlBotones.Controls.Add(lbl);
            return lbl;
        }



        private void RedondearBoton(Button btn, PaintEventArgs e, int radio)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Hace que el borde se vea suave

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radio, radio, 180, 90);
                path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
                path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
                path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
                path.CloseAllFigures();

                // Aplicamos la región redondeada al botón
                btn.Region = new Region(path);
            }
        }


        /////////////////Fin diseño/////////////////

        //Resize de los paneles para ajustar el tamaño de los internos
        private void pnlClientes_Resize(object sender, EventArgs e)
        {
            int w = pnlClientes.Width;
            int h = pnlClientes.Height;
            int margen = 12;
            int espacioH = 10;

            int anchoIzq = (int)(w * 0.40) - margen;
            int anchoDer = w - anchoIzq - (margen * 3) - espacioH;

            // Alto del pnlBotones — más alto en pantalla pequeña para 2 filas
            int altoBotones = anchoDer < 600 ? 110 : 60;

            // PANEL FORMULARIO
            pnlFormulario.Location = new Point(margen, margen);
            pnlFormulario.Size = new Size(anchoIzq, h - margen * 2);

            // PANEL BOTONES
            pnlBotones.Location = new Point(anchoIzq + margen * 2, margen);
            pnlBotones.Size = new Size(anchoDer, altoBotones);

            // PANEL BD
            int yBD = margen + altoBotones + espacioH;
            pnlBD.Location = new Point(anchoIzq + margen * 2, yBD);
            pnlBD.Size = new Size(anchoDer, h - yBD - margen);

            pnlClientes.Invalidate();

        }



        //Fin de los resize de los paneles para ajustar el tamaño de los internos

        //Rezise del Formulario para ajustar el tamaño de los elementos internos

        private void pnlFormulario_Resize(object sender, EventArgs e)
        {

            int w = pnlFormulario.Width;
            int h = pnlFormulario.Height;
            int margen = 40;
            int anchoInput = w - (margen * 2);
            int altoInput = 32;
            int altoLabel = 23;
            int espacioEntreGrupos = 18;

            // TÍTULO
            lblTituloForm.Location = new Point(margen - 10, 15);

            // NÚMERO TELEFÓNICO
            int yNumero = 80;
            lblNumero.Location = new Point(margen, yNumero);
            textNumero.Location = new Point(margen, yNumero + altoLabel + 2);
            textNumero.Size = new Size(anchoInput, altoInput);

            // NOMBRE
            int yNombre = textNumero.Bottom + espacioEntreGrupos;
            lblNombre.Location = new Point(margen, yNombre);
            textNombre.Location = new Point(margen, yNombre + altoLabel + 2);
            textNombre.Size = new Size(anchoInput, altoInput);

            // APELLIDO
            int yApellido = textNombre.Bottom + espacioEntreGrupos;
            lblApellido.Location = new Point(margen, yApellido);
            textApellido.Location = new Point(margen, yApellido + altoLabel + 2);
            textApellido.Size = new Size(anchoInput, altoInput);

            // APODO
            int yApodo = textApellido.Bottom + espacioEntreGrupos;
            lblApodo.Location = new Point(margen, yApodo);
            textApodo.Location = new Point(margen, yApodo + altoLabel + 2);
            textApodo.Size = new Size(anchoInput, altoInput);

            // DIRECCIÓN
            int yDireccion = textApodo.Bottom + espacioEntreGrupos;
            lblDireccion.Location = new Point(margen, yDireccion);

            int anchoBuscar = 42;
            int espacioBuscar = 8;

            textDIreccion.Location = new Point(margen, yDireccion + altoLabel + 2);
            textDIreccion.Size = new Size(anchoInput - anchoBuscar - espacioBuscar, altoInput);

            btnBuscarF.Location = new Point(textDIreccion.Right + espacioBuscar, textDIreccion.Top);
            btnBuscarF.Size = new Size(anchoBuscar, altoInput);

            // BOTONES — pegados al fondo
            int altoBotones = 48;
            int espacioBtn = 10;
            int yGuardar = h - altoBotones * 2 - espacioBtn - 30;
            int yFilaAbajo = yGuardar + altoBotones + espacioBtn;
            int anchoBtnPeq = (anchoInput - espacioBtn) / 2;

            btnGuardar.Location = new Point(margen, yGuardar);
            btnGuardar.Size = new Size(anchoInput, altoBotones);

            btnLimpiar.Location = new Point(margen, yFilaAbajo);
            btnLimpiar.Size = new Size(anchoBtnPeq, altoBotones);

            btnEliminar.Location = new Point(margen + anchoBtnPeq + espacioBtn, yFilaAbajo);
            btnEliminar.Size = new Size(anchoBtnPeq, altoBotones);



            pnlFormulario.Invalidate();
        }


        //FIn del resize del Formulario para ajustar el tamaño de los elementos internos




        //Redibujar el panel formulario con bordes redondeados cada vez que se pinta
        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlBD_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        //Fin de redibujar el panel formulario con bordes redondeados cada vez que se pinta


        //Redibujar los botones con bordes redondeados cada vez que se pinta

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardar, e, 15);
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnEliminar, e, 15);
        }


        private void btnLimpiar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnLimpiar, e, 15);
        }

        private void btnBuscarF_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnBuscarF, e, 5);
        }

        //Fin de redibujar los botones con bordes redondeados cada vez que se pinta

        //Diseño de los textbox para que tengan un texto de ejemplo y se borre al hacer click, y vuelva a aparecer si no se escribe nada

        //Numero
        private void textNumero_Leave(object sender, EventArgs e)
        {
            if (textNumero.Text == "")
            {
                textNumero.Text = "9991234567";
                textNumero.ForeColor = Color.DarkGray;
            }
        }

        private void textNumero_Enter(object sender, EventArgs e)
        {
            if (textNumero.Text == "9991234567")
            {
                textNumero.Text = "";
                textNumero.ForeColor = Color.Black;
            }
        }

        //Nombre
        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Cliente...")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.Black;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Cliente...";
                textNombre.ForeColor = Color.DarkGray;
            }
        }

        //Apellido
        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "Apellido...")
            {
                textApellido.Text = "";
                textApellido.ForeColor = Color.Black;
            }
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "Apellido...";
                textApellido.ForeColor = Color.DarkGray;
            }
        }

        //Apodo
        private void textApodo_Enter(object sender, EventArgs e)
        {
            if (textApodo.Text == "Apodo...")
            {
                textApodo.Text = "";
                textApodo.ForeColor = Color.Black;
            }
        }

        private void textApodo_Leave(object sender, EventArgs e)
        {
            if (textApodo.Text == "")
            {
                textApodo.Text = "Apodo...";
                textApodo.ForeColor = Color.DarkGray;
            }
        }

        //Direccion
        private void textDIreccion_Enter(object sender, EventArgs e)
        {
            if (textDIreccion.Text == "Calle 33 & Calle 96 y Calle 98")
            {
                textDIreccion.Text = "";
                textDIreccion.ForeColor = Color.Black;
            }
        }

        private void textDIreccion_Leave(object sender, EventArgs e)
        {
            if (textDIreccion.Text == "")
            {
                textDIreccion.Text = "Calle 33 & Calle 96 y Calle 98";
                textDIreccion.ForeColor = Color.DarkGray;
            }
        }

        private void btnBuscarF_Click(object? sender, EventArgs e)
        {
            if (pnlMiniFormulario != null)
            {
                pnlMiniFormulario.Visible = true;
                pnlMiniFormulario.BringToFront();
            }
        }

        private void btnCerrarMiniFormulario_Click(object? sender, EventArgs e)
        {
            if (pnlMiniFormulario != null)
            {
                pnlMiniFormulario.Visible = false;
            }
        }




        //Fin de diseño de los textbox para que tengan un texto de ejemplo y se borre al hacer click, y vuelva a aparecer si no se escribe nada


    }
}
