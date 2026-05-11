namespace VeloxSoft.Formularios
{
    partial class FormTablaClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colApodo = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();

            // --- CONFIGURACIÓN GENERAL ---
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToResizeRows = false; // Bloquea redimensión de filas
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false; // Oculta la columna gris de la izquierda
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.Dock = DockStyle.Fill;

            // --- ESTILO DE LÍNEAS (Para que se vea como en image_bcd1ba.png) ---
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.GridColor = Color.FromArgb(235, 235, 235); // Gris muy tenue

            // --- ENCABEZADOS (HEADERS) ---
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.ColumnHeadersHeight = 45;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(234, 243, 222); // Verde claro de fondo
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(85, 125, 70);   // Verde oscuro para el texto
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Segoe UI es más moderna
            dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 243, 222); // Evita cambio de color al hacer clic

            // --- ESTILO DE CELDAS (FILAS) ---
            dgvClientes.RowTemplate.Height = 50; // Da espacio y aire a las celdas
            dgvClientes.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvClientes.DefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80); // Gris oscuro, no negro puro
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245); // Color de selección sutil
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dgvClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el texto en dos líneas

            // --- COLUMNAS ---
            dgvClientes.Columns.AddRange(new DataGridViewColumn[]
            {
                colNumero, colNombre, colApellido, colApodo, colDireccion
            });
            dgvClientes.Name = "dgvClientes";
            dgvClientes.TabIndex = 0;

            colNumero.HeaderText = "TELÉFONO";
            colNumero.Name = "Numero";
            colNombre.HeaderText = "NOMBRE";
            colNombre.Name = "Nombre";
            colApellido.HeaderText = "APELLIDO";
            colApellido.Name = "Apellido";
            colApodo.HeaderText = "APODO";
            colApodo.Name = "Apodo";
            colDireccion.HeaderText = "DIRECCIÓN";
            colDireccion.Name = "Dieccion";

            // --- FORM PROPERTIES ---
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(dgvClientes);
            Name = "FormTablaClientes";
            Text = "Lista de Clientes";

            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colApodo;
        private DataGridViewTextBoxColumn colDireccion;
    }
}