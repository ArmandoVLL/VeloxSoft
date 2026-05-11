using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeloxSoft.Formularios
{
    public partial class FormTablaClientes : Form
    {
            public FormTablaClientes()
            {
                InitializeComponent();
                this.TopLevel = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
            }

            public DataGridView Tabla => dgvClientes;

            public void FiltrarPorNumero(string numero)
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string texto = row.Cells["Numero"].Value?.ToString() ?? "";

                    row.Visible =
                        texto.IndexOf(numero, StringComparison.OrdinalIgnoreCase) >= 0;
                }
             }
            public void FiltrarPorColonia(string colonia)
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string texto = row.Cells["Colonia"].Value?.ToString() ?? "";

                    row.Visible =
                        texto.IndexOf(colonia, StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }

        public void MostrarTodos()
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                    if (!row.IsNewRow) row.Visible = true;
            }
        }
    }