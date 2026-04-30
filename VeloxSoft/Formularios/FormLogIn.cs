using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VeloxSoft.Services;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Formularios
{
    public partial class FormLogIn : Form
    {
        private readonly AutenticarUsuario _autenticarUsuario;

        public FormLogIn(AutenticarUsuario autenticarUsuario)
        {
            InitializeComponent();
            LabelSalir.BringToFront();
            _autenticarUsuario = autenticarUsuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void NavPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void LabelLimpiar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtPassword.Clear();
            TxtUsuario.Focus();
            LabelError.Visible = false;
        }

        private void LabelSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread(); // Detiene el hilo actual
            Application.Exit();       // Envía la señal de cierre a la app
        }

        private void LabelSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            LabelError.Text = string.Empty;
            string errorMessage = null;
            string Id = TxtUsuario.Text;
            string Password = TxtPassword.Text;

            if (Id != string.Empty && Password != string.Empty)
            {
                usuario = _autenticarUsuario.Autenticar(Id, Password, out errorMessage);
            }


            if (Id.Length != 10)
            {
                LabelError.Text = "El ID debe tener exactamente 10 caracteres.";
                LabelError.Visible = true;
                return;
            }

            if (usuario.Nombre != "Error")
            {
                Program.UsuarioLogueado = usuario;
                Program.RolActual = ObtenerRolEnum.ObtenerRol(usuario.Rol);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                LabelError.Text = errorMessage;
                LabelError.Visible = true;
            }
        }

        private void NavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
