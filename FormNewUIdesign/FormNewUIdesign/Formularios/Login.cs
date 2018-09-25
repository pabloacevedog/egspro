using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FormNewUIdesign.Modelo;

namespace FormNewUIdesign
{
    public partial class FormLogin : Form
    {
        //*********************************
        //***** DISEÑO DEL FORMULARIO *****
        //*********************************

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        #region "Eventos Cerrar, Minimizar y Mover"

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarLogin_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarLogin.Image = Image.FromFile("../../iconos/window_close/white.png");
        }

        private void btnCerrarLogin_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarLogin.Image = Image.FromFile("../../iconos/window_close/grey.png");
        }

        private void btnMinimizarLogin_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizarLogin.Image = Image.FromFile("../../iconos/window_minimize/white.png");
        }

        private void btnMinimizarLogin_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarLogin.Image = Image.FromFile("../../iconos/window_minimize/grey.png");
        }

        //Con esto se puede mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region "Eventos txtUsuario"
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
            lineUser.BorderColor = Color.FromArgb(50, 137, 201);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
            lineUser.BorderColor = Color.DimGray;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                txtContrasena.Focus();
            }
        }

        #endregion

        #region "Eventos txtContraseña"

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals("Contraseña"))
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
            linePassword.BorderColor = Color.FromArgb(50, 137, 201);
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(""))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
            linePassword.BorderColor = Color.DimGray;
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this_login();
            }
        }

        #endregion

        #region "Funciones"

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this_login();
        }

        public void this_login()
        {
            if (LoginModel.Login(txtUsuario.Text, txtContrasena.Text))
            {
                ObjetoUsuario objetoUsuario = LoginModel.ObtenerDatosUsuario(txtUsuario.Text);
                FormPrincipal formulario = new FormPrincipal();
                if (objetoUsuario.sexo == "F")
                {
                    formulario.SetTextoUsername("Bienvenida " + objetoUsuario.nombre + " " + objetoUsuario.apellidos);
                }
                else
                {
                    formulario.SetTextoUsername("Bienvenido " + objetoUsuario.nombre + " " + objetoUsuario.apellidos);
                }
                formulario.objetoUsuario = objetoUsuario;
                this.Hide();
                formulario.Show();
            }
            else
            {
                Message.ShowMessage("Error al iniciar sesión", "Usuario o contraseña incorrectos! Por favor, intentelo nuevamente.", Message.MessageType.warning);
            }
        }


        #endregion

    }
}
