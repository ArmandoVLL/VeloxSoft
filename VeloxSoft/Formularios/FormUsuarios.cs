using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VeloxSoft.Formularios
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            pnlUsuarios_Resize(this, EventArgs.Empty); // ← AGREGA
            pnlFormulario_Resize(this, EventArgs.Empty);
            pnlBotones_Resize(this, EventArgs.Empty);
        }

        //Diseño estetico de esteticos y botonoes


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


        /////////////////Fin diseño/////////////////



        private void textID_Enter(object sender, EventArgs e)
        {
            if (textID.Text == "9991234567")
            {
                textID.Text = "";
                textID.ForeColor = Color.Black;
            }
        }

        private void textID_Leave(object sender, EventArgs e)
        {
            if (textID.Text == "")
            {
                textID.Text = "9991234567";
                textID.ForeColor = Color.DarkGray;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "Nombre cliente...";
                textNombre.ForeColor = Color.DarkGray;
            }
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre cliente...")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.Black;
            }
        }

        private void textRol_Leave(object sender, EventArgs e)
        {
            if (textRol.Text == "")
            {
                textRol.Text = "Rol del usuario...";
                textRol.ForeColor = Color.DarkGray;
            }
        }

        private void textRol_Enter(object sender, EventArgs e)
        {
            if (textRol.Text == "Rol del usuario...")
            {
                textRol.Text = "";
                textRol.ForeColor = Color.Black;
            }
        }

        private void textContra_Leave(object sender, EventArgs e)
        {
            if (textContra.Text == "")
            {
                textContra.Text = "********";
                textContra.ForeColor = Color.DarkGray;
            }
        }

        private void textContra_Enter(object sender, EventArgs e)
        {
            if (textContra.Text == "********")
            {
                textContra.Text = "";
                textContra.ForeColor = Color.Black;
            }
        }

        private void textBuscarU_Enter(object sender, EventArgs e)
        {
            if (textBuscarU.Text == "9991234567")
            {
                textBuscarU.Text = "";
                textBuscarU.ForeColor = Color.Black;
            }
        }

        private void textBuscarU_Leave(object sender, EventArgs e)
        {
            if (textBuscarU.Text == "")
            {
                textBuscarU.Text = "9991234567";
                textBuscarU.ForeColor = Color.DarkGray;
            }
        }

        private void dgvUsuariosDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlBD_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel((Panel)sender, e, 15);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnGuardar, e, 15);
        }

        private void btnLimpiar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnLimpiar, e, 15);
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnEliminar, e, 15);
        }

        private void pnlFormulario_Resize(object sender, EventArgs e)
        {
            int w = pnlFormulario.Width;
            int h = pnlFormulario.Height;
            int margenGral = 40;
            int anchoInput = w - (margenGral * 2);

            int altoInput = 32;
            int altoLabel = 23;
            int espacioEntreGrupos = 18;

            // --- TÍTULO, ID, NOMBRE, ROL/ESTADO y CONTRASEÑA ---
            // (Mantenemos la lógica anterior para la parte superior)
            lblTituloForm.Location = new Point(margenGral - 10, 25);

            int yID = 100;
            lblID.Location = new Point(margenGral, yID);
            textID.Location = new Point(margenGral, yID + altoLabel + 2);
            textID.Size = new Size(anchoInput, altoInput);

            int yNombre = textID.Bottom + espacioEntreGrupos;
            lblNombre.Location = new Point(margenGral, yNombre);
            textNombre.Location = new Point(margenGral, yNombre + altoLabel + 2);
            textNombre.Size = new Size(anchoInput, altoInput);

            int yFilaDoble = textNombre.Bottom + espacioEntreGrupos;
            int anchoMedio = (anchoInput - 15) / 2;
            lblRol.Location = new Point(margenGral, yFilaDoble);
            textRol.Location = new Point(margenGral, yFilaDoble + altoLabel + 2);
            textRol.Size = new Size(anchoMedio, altoInput);

            lblEstado.Location = new Point(margenGral + anchoMedio + 15, yFilaDoble);
            boxEstado.Location = new Point(margenGral + anchoMedio + 15, yFilaDoble + altoLabel + 2);
            boxEstado.Size = new Size(anchoMedio, altoInput);

            int yContra = textRol.Bottom + espacioEntreGrupos;
            lblContraseña.Location = new Point(margenGral, yContra);
            textContra.Location = new Point(margenGral, yContra + altoLabel + 2);
            textContra.Size = new Size(anchoInput, altoInput);

            // --- BLOQUE DE BOTONES (SEGÚN TU DISEÑO CS) ---
            // Queremos: Guardar (Ancho completo) arriba
            //           Limpiar y Eliminar (Mitad y mitad) abajo

            int altoBotones = 48;
            int espacioEntreBotones = 10;
            // Calculamos desde el fondo hacia arriba
            int yFilaBotonesAbajo = h - altoBotones - 40;
            int yFilaBotonGuardar = yFilaBotonesAbajo - altoBotones - espacioEntreBotones;

            // 1. Botón Guardar (Ocupa todo el ancho disponible)
            btnGuardar.Location = new Point(margenGral, yFilaBotonGuardar);
            btnGuardar.Size = new Size(anchoInput, altoBotones);

            // 2. Botones de abajo (Mitad del ancho cada uno)
            int anchoBotonesPequenos = (anchoInput - espacioEntreBotones) / 2;

            btnLimpiar.Location = new Point(margenGral, yFilaBotonesAbajo);
            btnLimpiar.Size = new Size(anchoBotonesPequenos, altoBotones);

            btnEliminar.Location = new Point(margenGral + anchoBotonesPequenos + espacioEntreBotones, yFilaBotonesAbajo);
            btnEliminar.Size = new Size(anchoBotonesPequenos, altoBotones);

            pnlFormulario.Invalidate();
        }

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

                // Anchos proporcionales
                int anchoLblBusc = 85;
                int anchoBuscar = (int)(w * 0.20);
                int anchoBtn = 42;
                int anchoLblCmb = 45;
                int anchoCmb = (int)(w * 0.12);

                lblBuscarID.Location = new Point(x, y + 4);
                lblBuscarID.Size = new Size(anchoLblBusc, 20);
                x += anchoLblBusc + 4;

                textBuscarU.Location = new Point(x, y);
                textBuscarU.Size = new Size(anchoBuscar, altoControl);
                x += anchoBuscar + 4;

                btnBuscarU.Location = new Point(x, y);
                btnBuscarU.Size = new Size(anchoBtn, altoControl);
                x += anchoBtn + 14;

                // ROL
                lblCROL.Location = new Point(x, y + 4);
                lblCROL.Size = new Size(anchoLblCmb, 20);
                x += anchoLblCmb + 4;
                cbCROL.Location = new Point(x, y);
                cbCROL.Size = new Size(anchoCmb, altoControl);
                x += anchoCmb + 10;

                // SESIÓN
                lblCSESION.Location = new Point(x, y + 4);
                lblCSESION.Size = new Size(anchoLblCmb + 10, 20);
                x += anchoLblCmb + 14;
                cbCSESION.Location = new Point(x, y);
                cbCSESION.Size = new Size(anchoCmb, altoControl);
                x += anchoCmb + 10;

                // ESTADO
                lblCESTADO.Location = new Point(x, y + 4);
                lblCESTADO.Size = new Size(anchoLblCmb + 10, 20);
                x += anchoLblCmb + 14;
                cbCESTADO.Location = new Point(x, y);
                cbCESTADO.Size = new Size(w - x - margen, altoControl);
            }
            else
            {
                // ── DOS LÍNEAS ──
                int anchoTotal = w - margen * 2;
                int anchoBtn = 42;
                int anchoCmbPeq = (int)((anchoTotal - 160) / 3);

                int y1 = 8;
                lblBuscarID.Location = new Point(margen, y1 + 4);
                lblBuscarID.Size = new Size(85, 20);
                textBuscarU.Location = new Point(margen + 88, y1);
                textBuscarU.Size = new Size(anchoTotal - 88 - anchoBtn - 6, altoControl);
                btnBuscarU.Location = new Point(w - margen - anchoBtn, y1);
                btnBuscarU.Size = new Size(anchoBtn, altoControl);

                int y2 = y1 + altoControl + 8;
                int xCmb = margen;

                lblCROL.Location = new Point(xCmb, y2 + 4);
                lblCROL.Size = new Size(35, 20);
                xCmb += 38;
                cbCROL.Location = new Point(xCmb, y2);
                cbCROL.Size = new Size(anchoCmbPeq, altoControl);
                xCmb += anchoCmbPeq + 6;

                lblCSESION.Location = new Point(xCmb, y2 + 4);
                lblCSESION.Size = new Size(48, 20);
                xCmb += 51;
                cbCSESION.Location = new Point(xCmb, y2);
                cbCSESION.Size = new Size(anchoCmbPeq, altoControl);
                xCmb += anchoCmbPeq + 6;

                lblCESTADO.Location = new Point(xCmb, y2 + 4);
                lblCESTADO.Size = new Size(48, 20);
                xCmb += 51;
                cbCESTADO.Location = new Point(xCmb, y2);
                cbCESTADO.Size = new Size(w - xCmb - margen, altoControl);
            }

            pnlBotones.Invalidate();
        }

        private void pnlBD_Resize(object sender, EventArgs e)
        {
            int w = pnlBD.Width;
            int h = pnlBD.Height;
            int margen = 15; // Espacio para que no choque con el borde redondeado

            // Ajustar el DataGridView para que llene el panel
            dgvUsuariosDB.Location = new Point(margen, margen);
            dgvUsuariosDB.Size = new Size(w - (margen * 2), h - (margen * 2));

            // Asegurar que las columnas se repartan el ancho
            dgvUsuariosDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pnlBD.Invalidate(); // Refresca los bordes redondeados
        }

        private void pnlUsuarios_Resize(object sender, EventArgs e)
        {
            int w = pnlUsuarios.Width;
            int h = pnlUsuarios.Height;
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

            pnlUsuarios.Invalidate();
        }

        private void btnBuscarU_Paint(object sender, PaintEventArgs e)
        {
            RedondearBoton(btnBuscarU, e, 15);
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
