using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using VeloxSoft.Services;

namespace VeloxSoft.Formularios
{
    public partial class FormInventario : Form
    {
        private readonly ServicioInventario _ServicioInventario;
        public FormInventario(ServicioInventario ServicioInventario)
        {
            InitializeComponent();
            _ServicioInventario = ServicioInventario;
            // Esto obliga al formulario a redibujarse mientras el usuario arrastra el mouse
            this.ResizeRedraw = true;
            // Evita el efecto de "congelado" o parpadeo
            this.DoubleBuffered = true;


        }

        //BORDES REDONDOS PARA LOS PANEL, SOLO LO LLAMAMOS EN LOS EVENTOS PAINT DE LOS PANEL, ASÍ SE DIBUJAN LOS BORDES CUANDO SE REDIMENSIONA LA VENTANA
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDetalles_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnBuscar, e, 15);
        }

        private void pnlNombre_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPC_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlStock_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textPV_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlPV_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un producto en la tabla
            if (dtgBDInv.SelectedRows.Count == 0)
            {
                LabelError.Text = "Debe seleccionar un producto para eliminar.";
                LabelError.Visible = true;
                LabelError.ForeColor = Color.Red;
                return;
            }

            // Obtener el ID del producto seleccionado en la tabla
            string idProducto = dtgBDInv.SelectedRows[0].Cells[0].Value.ToString(); // O el nombre de la columna que corresponda

            // Mostrar un cuadro de diálogo de confirmación antes de eliminar el producto
            var Evitemos_Errores = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el producto con ID: {idProducto}?", //confirmación de eliminación, se muestra el ID del producto para que el usuario pueda verificar que está eliminando el producto correcto
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            // Si el usuario selecciona "No", se cancela la operación de eliminación
            if (Evitemos_Errores == DialogResult.No) return;

            //Llamar al serivico para eliminar el producto.
            _ServicioInventario.Eliminar_Producto(idProducto, out string errorMessage);

            //Mostrar mensaje de error o éxito dependiendo del resultado de la operación
            if (!string.IsNullOrEmpty(errorMessage))
            {
                LabelError.Text = errorMessage;
                LabelError.Visible = true;
            }
            else
            {
                LabelError.Text = "Producto eliminado correctamente.";
                LabelError.ForeColor = Color.Green;
                LabelError.Visible = true;
                CargarInventario();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textID.Text) ||
                string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textPV.Text) ||
                string.IsNullOrWhiteSpace(textStock.Text))
            {
                LabelError2.Text = "Todos los campos son obligatorios.";
                LabelError2.Visible = true;
                LabelError2.ForeColor = Color.Red;
                return;
            }

            // 2. Validar que precio y cantidad sean números
            if (!decimal.TryParse(textPV.Text, out decimal precio))
            {
                LabelError2.Text = "El precio debe ser un número válido.";
                LabelError2.ForeColor = Color.Red;
                return;
            }
            if (!decimal.TryParse(textStock.Text, out decimal cantidad))
            {
                LabelError2.Text = "El stock debe ser un número válido.";
                LabelError2.ForeColor = Color.Red;
                return;
            }

            // 3. Obtener categoría del ComboBox
            if (BoxPrueba.SelectedItem == null)
            {
                LabelError2.Text = "Debe seleccionar una categoría.";
                LabelError2.ForeColor = Color.Red;
                LabelError2.Visible = true;
                return;
            }

            string categoria = BoxPrueba.SelectedItem.ToString();
            // DEBUG - borrar después
            MessageBox.Show($"ID: {textID.Text.Trim()}\nNombre: {textNombre.Text.Trim()}\nCantidad: {cantidad}\nPrecio: {precio}\nCategoria: {categoria}");

            // 4. Llamar al servicio para insertar el producto
            string mensaje = _ServicioInventario.Insertar_Producto(textID.Text.Trim(), textNombre.Text.Trim(), cantidad, precio, categoria, out string errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                LabelError2.Text = errorMessage;
                LabelError2.Visible = true;
                LabelError2.ForeColor = Color.Red;
                CargarInventario();
                return;
            }
            else
            {

                LabelError2.Text = mensaje; // "Producto agregado correctamente."
                LabelError2.Visible = true;
                LabelError2.ForeColor = Color.Green;
                CargarInventario(); // Recarga la tabla para mostrar el nuevo producto

                //Limpiamos los campos después de guardar
                textID.Text = string.Empty;
                textNombre.Text = string.Empty;
                textPV.Text = string.Empty;
                textStock.Text = string.Empty;
                BoxPrueba.SelectedItem = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnNuevo, e, 15);
        }

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardar, e, 15);
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnEliminar, e, 15);
        }

        private void pnlDetalles_Resize(object sender, EventArgs e)
        {
            int w = pnlDetalles.Width;
            int h = pnlDetalles.Height;

            int margenIzq = 20;
            int xInput = (int)(w * 0.40);
            int anchoInput = w - xInput - 20;

            // TÍTULO
            lbTitulo.Location = new Point(margenIzq, 15);
            lbTitulo.Size = new Size(w - 40, 40);

            // BUSCAR ID
            int yID = (int)(h * 0.12);
            lblID.Location = new Point(margenIzq, yID + 12);
            panel1.Location = new Point(xInput, yID);
            panel1.Size = new Size(anchoInput - 95, 45);
            textID.Location = new Point(5, 12);
            textID.Size = new Size(panel1.Width - 10, 22);
            btnBuscar.Location = new Point(xInput + anchoInput - 90, yID);
            btnBuscar.Size = new Size(90, 45);

            // NOMBRE
            int yNombre = (int)(h * 0.25);
            lblNombre.Location = new Point(margenIzq, yNombre + 12);
            pnlNombre.Location = new Point(xInput, yNombre);
            pnlNombre.Size = new Size(anchoInput, 45);
            textNombre.Location = new Point(5, 12);
            textNombre.Size = new Size(pnlNombre.Width - 10, 22);


            // PRECIO DE VENTA
            int yPV = (int)(h * 0.51);
            lblVenta.Location = new Point(margenIzq, yPV + 12);
            pnlPV.Location = new Point(xInput, yPV);
            pnlPV.Size = new Size(anchoInput, 45);
            textPV.Location = new Point(5, 12);
            textPV.Size = new Size(pnlPV.Width - 10, 22);

            // EN STOCK
            int yStock = (int)(h * 0.64);
            lblStock.Location = new Point(margenIzq, yStock + 12);
            pnlStock.Location = new Point(xInput, yStock);
            pnlStock.Size = new Size(anchoInput, 45);
            textStock.Location = new Point(5, 12);
            textStock.Size = new Size(pnlStock.Width - 10, 22);

            // BOTONES
            int yBotones = (int)(h * 0.82);
            int anchoBtn = (int)(w * 0.25);
            int espacioBtn = (int)(w * 0.03);
            btnNuevo.Location = new Point(margenIzq, yBotones);
            btnNuevo.Size = new Size(anchoBtn, 45);
            btnGuardar.Location = new Point(margenIzq + anchoBtn + espacioBtn, yBotones);
            btnGuardar.Size = new Size(anchoBtn, 45);
            btnEliminar.Location = new Point(margenIzq + (anchoBtn + espacioBtn) * 2, yBotones);
            btnEliminar.Size = new Size(anchoBtn, 45);

            pnlDetalles.Invalidate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
            pnlDetalles_Resize(this, EventArgs.Empty);
            pnlBD_Resize(this, EventArgs.Empty);  // ← AGREGA ESTO
            CargarInventario();                   // LLAMAMOS AL MÉTODO PARA CARGAR LOS DATOS DE PRUEBA EN LA TABLA, LUEGO LO ELIMINAMOS O LO MODIFICAMOS PARA QUE CARGUE LOS DATOS REALES DESDE LA BASE DE DATOS

        }
        private void CargarInventario() // CON ESTE MÉTODO LLENAMOS LA TABLA CON DATOS DE PRUEBA PARA VER CÓMO QUEDA, LUEGO LO ELIMINAMOS O LO MODIFICAMOS PARA QUE CARGUE LOS DATOS REALES DESDE LA BASE DE DATOS
        {
            var lista = _ServicioInventario.Ver_Productos(out String errorMessage);//OBTENEMOS LA LISTA DE PRODUCTOS DESDE EL SERVICIO DE INVENTARIO, SI OCURRE UN ERROR SE ASIGNA UN MENSAJE A errorMessage

            if (!string.IsNullOrEmpty(errorMessage))
            {
                LabelError.Text = errorMessage;
                LabelError.Visible = true;
                return;
            }

            dtgBDInv.Rows.Clear(); // Limpio la tabla antes de cargar los datos

            foreach (var producto in lista)
            {
                dtgBDInv.Rows.Add( //añade una nueva fila a la tabla con los datos del producto
                    producto.IdProducto,
                    producto.Nombre,
                    producto.IdCategoria,
                    producto.Cantidad,
                    producto.Precio,
                    producto.Estado ? "Activo" : "Inactivo");
            }

        }

        private void pnlBD_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBuscarBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlBuscarBD_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void btnGuardarBD_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardarBD, e, 15);
        }

        private void pnlBD_Resize(object sender, EventArgs e)
        {
            int w = pnlBD.Width;
            int h = pnlBD.Height;

            // TÍTULO
            Titulo.Location = new Point(17, 12);
            Titulo.Size = new Size(w - 30, 35);

            // TODO EN UNA SOLA LÍNEA — Y: 55
            int y = 55;
            int anchoCmb = (int)(w * 0.18);
            int anchoBuscar = (int)(w * 0.22);
            int altoControl = 38;
            int x = 17;

            // BUSCAR ID
            BuscarBD.Location = new Point(x, y + 8);
            x += BuscarBD.Width + 5;
            pnlBuscarBD.Location = new Point(x, y);
            pnlBuscarBD.Size = new Size(anchoBuscar, altoControl);
            tbBuscarBD.Location = new Point(5, 9);
            tbBuscarBD.Size = new Size(pnlBuscarBD.Width - 10, 22);
            x += anchoBuscar + 8;

            btnGuardarBD.Location = new Point(x, y);
            btnGuardarBD.Size = new Size(70, altoControl);
            x += 70 + 15;

            // CATEGORÍA
            lbCategoria.Location = new Point(x, y);
            x += lbCategoria.Width + 5;
            cbCategoria.Location = new Point(x, y);
            cbCategoria.Size = new Size(160, altoControl);
            x += anchoCmb + 15;

            // ESTADO
            lbEstado.Location = new Point(x, y);
            x += lbEstado.Width + 5;
            cbEstado.Location = new Point(x, y);
            cbEstado.Size = new Size(100, altoControl);

            // TABLA
            dtgBDInv.Location = new Point(11, y + altoControl + 10);
            dtgBDInv.Size = new Size(w - 22, h - (y + altoControl + 25));

            pnlBD.Invalidate();
        }
        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
