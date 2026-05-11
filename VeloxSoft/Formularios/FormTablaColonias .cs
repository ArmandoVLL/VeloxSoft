using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeloxSoft.Formularios
{
    public partial class FormTablaColonias : Form
    {
        public FormTablaColonias()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        public DataGridView Tabla => dgvColonias;

        public void FiltrarPorColonia(string valor)
        {
            foreach (DataGridViewRow row in dgvColonias.Rows)
            {
                if (row.IsNewRow) continue;
                string? celda = row.Cells["Colonia"].Value?.ToString();
                row.Visible = string.IsNullOrEmpty(valor) ||
                              (celda != null && celda.IndexOf(valor,
                               StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        public void MostrarTodos()
        {
            foreach (DataGridViewRow row in dgvColonias.Rows)
                if (!row.IsNewRow) row.Visible = true;
        }
    }
}
