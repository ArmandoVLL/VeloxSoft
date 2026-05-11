namespace VeloxSoft.Formularios
{
    partial class FormTablaDireccion
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
            dgvDireccion = new DataGridView();
            colNumeroCasa = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colCruzamientos = new DataGridViewTextBoxColumn();
            colReferencia = new DataGridViewTextBoxColumn();
            colColonia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDireccion).BeginInit();
            SuspendLayout();

            // --- CONFIGURACIÓN GENERAL DEL DATAGRIDVIEW ---
            dgvDireccion.AllowUserToAddRows = false;
            dgvDireccion.AllowUserToResizeRows = false;
            dgvDireccion.ReadOnly = true;
            dgvDireccion.RowHeadersVisible = false;
            dgvDireccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDireccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDireccion.BackgroundColor = Color.White;
            dgvDireccion.BorderStyle = BorderStyle.None;
            dgvDireccion.Dock = DockStyle.Fill;

            // --- ESTILO DE BORDES Y CUADRÍCULA ---
            // Solo líneas horizontales sutiles para un look limpio
            dgvDireccion.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDireccion.GridColor = Color.FromArgb(235, 235, 235);

            // --- ENCABEZADOS (HEADERS) ---
            dgvDireccion.EnableHeadersVisualStyles = false;
            dgvDireccion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDireccion.ColumnHeadersHeight = 45;
            // Fondo verde claro y texto verde oscuro (idéntico a image_bcd1ba.png)
            dgvDireccion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(234, 243, 222);
            dgvDireccion.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(85, 125, 70);
            dgvDireccion.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDireccion.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 243, 222);

            // --- ESTILO DE FILAS Y CELDAS ---
            dgvDireccion.RowTemplate.Height = 50;
            dgvDireccion.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvDireccion.DefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            dgvDireccion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dgvDireccion.DefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dgvDireccion.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Útil para referencias largas

            // --- CONFIGURACIÓN DE COLUMNAS ---
            dgvDireccion.Columns.AddRange(new DataGridViewColumn[]
            {
                colNumeroCasa, colCalle, colCruzamientos, colReferencia, colColonia
            });
            dgvDireccion.Name = "dgvDireccion";
            dgvDireccion.TabIndex = 0;

            colNumeroCasa.HeaderText = "N° CASA";
            colNumeroCasa.Name = "NumeroCasa";
            colNumeroCasa.FillWeight = 50; // Más angosta

            colCalle.HeaderText = "CALLE";
            colCalle.Name = "Calle";
            colCalle.FillWeight = 100;

            colCruzamientos.HeaderText = "CRUZAMIENTOS";
            colCruzamientos.Name = "Cruzamientos";
            colCruzamientos.FillWeight = 120;

            colReferencia.HeaderText = "REFERENCIA";
            colReferencia.Name = "Referencia";
            colReferencia.FillWeight = 150; // Más espacio para descripciones

            colColonia.HeaderText = "COLONIA";
            colColonia.Name = "Colonia";
            colColonia.FillWeight = 100;

            // --- PROPIEDADES DEL FORMULARIO ---
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500); // Un poco más ancho por la cantidad de columnas
            Controls.Add(dgvDireccion);
            Name = "FormTablaDireccion";
            Text = "Gestión de Direcciones";

            ((System.ComponentModel.ISupportInitialize)dgvDireccion).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvDireccion;
        private DataGridViewTextBoxColumn colNumeroCasa;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colCruzamientos;
        private DataGridViewTextBoxColumn colReferencia;
        private DataGridViewTextBoxColumn colColonia;
    }
}