namespace VeloxSoft.Formularios
{
    partial class FormTablaColonias
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
            dgvColonias = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colColonia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvColonias).BeginInit();
            SuspendLayout();

            // --- CONFIGURACIÓN GENERAL ---
            dgvColonias.AllowUserToAddRows = false;
            dgvColonias.AllowUserToResizeRows = false;
            dgvColonias.ReadOnly = true;
            dgvColonias.RowHeadersVisible = false;
            dgvColonias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColonias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColonias.BackgroundColor = Color.White;
            dgvColonias.BorderStyle = BorderStyle.None;
            dgvColonias.Dock = DockStyle.Fill;

            // --- ESTILO DE BORDES (Líneas horizontales como en image_bcd1ba.png) ---
            dgvColonias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvColonias.GridColor = Color.FromArgb(235, 235, 235);

            // --- ENCABEZADOS (HEADERS) ---
            dgvColonias.EnableHeadersVisualStyles = false;
            dgvColonias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvColonias.ColumnHeadersHeight = 45;
            // Fondo verde claro y texto verde oscuro para replicar la imagen
            dgvColonias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(234, 243, 222);
            dgvColonias.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(85, 125, 70);
            dgvColonias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvColonias.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 243, 222);

            // --- ESTILO DE FILAS Y CELDAS ---
            dgvColonias.RowTemplate.Height = 50; // Altura para dar aire a los datos
            dgvColonias.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvColonias.DefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            dgvColonias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dgvColonias.DefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dgvColonias.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // --- COLUMNAS ---
            dgvColonias.Columns.AddRange(new DataGridViewColumn[]
            {
                colID, colColonia
            });
            dgvColonias.Name = "dgvColonias";
            dgvColonias.TabIndex = 0;

            colID.HeaderText = "ID";
            colID.Name = "ID";
            // Ajuste opcional: podemos hacer el ID un poco más angosto que el nombre de la colonia
            colID.FillWeight = 40;

            colColonia.HeaderText = "COLONIA";
            colColonia.Name = "Colonia";
            colColonia.FillWeight = 160;

            // --- PROPIEDADES DEL FORMULARIO ---
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(dgvColonias);
            Name = "FormTablaColonias";
            Text = "Gestión de Colonias";

            ((System.ComponentModel.ISupportInitialize)dgvColonias).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvColonias;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colColonia;
    }
}