using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using FormNewUIdesign.Formularios;
using System.Threading;

namespace FormNewUIdesign
{
    public partial class FormPrincipal : Form
    {
        public ObjetoUsuario objetoUsuario = new ObjetoUsuario();
        string elementoMenuActual = "Dashboard";
        string elementoMenuAnterior = "Dashboard";
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);

        public FormPrincipal()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblCalendario.Text = DateTime.Today.ToString("D").Split(',')[0].ToUpper() + ", " + DateTime.Today.ToString("d");
            this.Move += new EventHandler(formulario_Move);
        }

        #region "Eventos Cerrar, Minimizar, Maximizar, Restaurar y Mover"

        private void formulario_Move(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnResturar.Visible = true;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnResturar_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnResturar.Visible = false;
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int WParam, int lParam);
        private void tituloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(214, 100, 110);
            btnCerrar.Image = Image.FromFile("../../iconos/window_close/white.png");
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Image = Image.FromFile("../../iconos/window_close/grey.png");
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(200, 200, 200);
            btnMinimizar.Image = Image.FromFile("../../iconos/window_minimize/white.png");
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.Image = Image.FromFile("../../iconos/window_minimize/grey.png");
        }

        private void btnResturar_MouseEnter(object sender, EventArgs e)
        {
            btnResturar.BackColor = Color.FromArgb(200, 200, 200);
            btnResturar.Image = Image.FromFile("../../iconos/window_restore/white.png");
        }

        private void btnResturar_MouseLeave(object sender, EventArgs e)
        {
            btnResturar.BackColor = Color.Transparent;
            btnResturar.Image = Image.FromFile("../../iconos/window_restore/grey.png");
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(200, 200, 200);
            btnMaximizar.Image = Image.FromFile("../../iconos/window_maximize/white.png");
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.Image = Image.FromFile("../../iconos/window_maximize/grey.png");
        }

        #endregion

        #region "Funciones Menú"

        private void imgSlideMenu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 200)
            {
                logo.Visible = false;
                menuPanel.Width = 55;
                if (SubmenuReportes.Visible)
                {
                    SubmenuReportes.Visible = false;
                }
            }
            else
            {
                menuPanel.Width = 200;
                imgSlideMenu.Image = Image.FromFile("../../iconos/slide_left/white.png");
                logo.Visible = true;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Dashboard";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Dashboard";
            imgTitle.Image = Image.FromFile("../../iconos/dashboard/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Usuarios";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Usuarios";
            imgTitle.Image = Image.FromFile("../../iconos/account_group/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            contentPanel.Controls.Add(controlUsuarios);
            controlUsuarios.Dock = DockStyle.Fill;
            controlUsuarios.BringToFront();
        }

        private void btnPostulacion_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Postulación";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Postulación";
            imgTitle.Image = Image.FromFile("../../iconos/projects/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnPostulantes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Postulantes";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Postulantes";
            imgTitle.Image = Image.FromFile("../../iconos/clients/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Sistema";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Sistema";
            imgTitle.Image = Image.FromFile("../../iconos/system/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Ventas";
            imgTitle.Image = Image.FromFile("../../iconos/sales/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Configuración";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Configuración";
            imgTitle.Image = Image.FromFile("../../iconos/settings/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Reportes";
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }

            if (SubmenuReportes.Visible)
            {
                SubmenuReportes.Visible = false;
            }
            else
            {
                SubmenuReportes.Visible = true;
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Reporte Ventas";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Reporte Ventas";
            imgTitle.Image = Image.FromFile("../../iconos/sales_report/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Reporte Compras";
            elementoMenuAnterior = elementoMenuActual;
            elementoMenuActual = "Reporte Compras";
            imgTitle.Image = Image.FromFile("../../iconos/purchases_report/grey.png");
            colorActiveMenu(elementoMenuActual);
            if (elementoMenuActual != elementoMenuAnterior)
            {
                colorInactiveMenu(elementoMenuAnterior);
            }
        }

        private void colorActiveMenu(string elemento)
        {
            switch (elemento)
            {
                case "Dashboard":
                    btnDashboard.BackColor = Color.FromArgb(50, 137, 201);
                    btnDashboard.ForeColor = Color.White;
                    btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnDashboard.Image = Image.FromFile("../../iconos/dashboard/white.png");
                    break;
                case "Usuarios":
                    btnUsers.BackColor = Color.FromArgb(50, 137, 201);
                    btnUsers.ForeColor = Color.White;
                    btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnUsers.Image = Image.FromFile("../../iconos/account_group/white.png");
                    break;
                case "Postulación":
                    btnPostulacion.BackColor = Color.FromArgb(50, 137, 201);
                    btnPostulacion.ForeColor = Color.White;
                    btnPostulacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnPostulacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnPostulacion.Image = Image.FromFile("../../iconos/projects/white.png");
                    break;
                case "Postulantes":
                    btnPostulantes.BackColor = Color.FromArgb(50, 137, 201);
                    btnPostulantes.ForeColor = Color.White;
                    btnPostulantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnPostulantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnPostulantes.Image = Image.FromFile("../../iconos/system/white.png");
                    break;
                case "Sistema":
                    btnSystem.BackColor = Color.FromArgb(50, 137, 201);
                    btnSystem.ForeColor = Color.White;
                    btnSystem.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201); 
                    btnSystem.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnSystem.Image = Image.FromFile("../../iconos/clients/white.png");
                    break;
                case "Ventas":
                    btnVentas.BackColor = Color.FromArgb(50, 137, 201);
                    btnVentas.ForeColor = Color.White;
                    btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnVentas.Image = Image.FromFile("../../iconos/sales/white.png");
                    break;
                case "Configuración":
                    btnConfig.BackColor = Color.FromArgb(50, 137, 201);
                    btnConfig.ForeColor = Color.White;
                    btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnConfig.Image = Image.FromFile("../../iconos/settings/white.png");
                    break;
                case "Reportes":
                    btnReportes.BackColor = Color.FromArgb(50, 137, 201);
                    btnReportes.ForeColor = Color.White;
                    btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnReportes.Image = Image.FromFile("../../iconos/reports/white.png");
                    break;
                case "Reporte Ventas":
                    btnReporteVentas.BackColor = Color.FromArgb(50, 137, 201);
                    btnReporteVentas.ForeColor = Color.White;
                    btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnReporteVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnReporteVentas.Image = Image.FromFile("../../iconos/sales_report/white.png");
                    break;
                case "Reporte Compras":
                    btnReporteCompras.BackColor = Color.FromArgb(50, 137, 201);
                    btnReporteCompras.ForeColor = Color.White;
                    btnReporteCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 137, 201);
                    btnReporteCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 137, 201);
                    btnReporteCompras.Image = Image.FromFile("../../iconos/purchases_report/white.png");
                    break;
            }
        }

        private void colorInactiveMenu(string elemento)
        {
            switch (elemento)
            {
                case "Dashboard":
                    btnDashboard.BackColor = Color.FromArgb(235, 235, 235);
                    btnDashboard.ForeColor = Color.DimGray;
                    btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnDashboard.Image = Image.FromFile("../../iconos/dashboard/grey.png");
                    break;
                case "Usuarios":
                    btnUsers.BackColor = Color.FromArgb(235, 235, 235);
                    btnUsers.ForeColor = Color.DimGray;
                    btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnUsers.Image = Image.FromFile("../../iconos/account_group/grey.png");
                    break;
                case "Postulación":
                    btnPostulacion.BackColor = Color.FromArgb(235, 235, 235);
                    btnPostulacion.ForeColor = Color.DimGray;
                    btnPostulacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnPostulacion.Image = Image.FromFile("../../iconos/projects/grey.png");
                    break;
                case "Postulantes":
                    btnPostulantes.BackColor = Color.FromArgb(235, 235, 235);
                    btnPostulantes.ForeColor = Color.DimGray;
                    btnPostulantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnPostulantes.Image = Image.FromFile("../../iconos/clients/grey.png");
                    break;
                case "Sistema":
                    btnSystem.BackColor = Color.FromArgb(235, 235, 235);
                    btnSystem.ForeColor = Color.DimGray;
                    btnSystem.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnSystem.Image = Image.FromFile("../../iconos/system/grey.png");
                    break;
                case "Ventas":
                    btnVentas.BackColor = Color.FromArgb(235, 235, 235);
                    btnVentas.ForeColor = Color.DimGray;
                    btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnVentas.Image = Image.FromFile("../../iconos/sales/grey.png");
                    break;
                case "Configuración":
                    btnConfig.BackColor = Color.FromArgb(235, 235, 235);
                    btnConfig.ForeColor = Color.DimGray;
                    btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnConfig.Image = Image.FromFile("../../iconos/settings/grey.png");
                    break;
                case "Reportes":
                    btnReportes.BackColor = Color.FromArgb(235, 235, 235);
                    btnReportes.ForeColor = Color.DimGray;
                    btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnReportes.Image = Image.FromFile("../../iconos/reports/grey.png");
                    break;
                case "Reporte Ventas":
                    btnReporteVentas.BackColor = Color.FromArgb(235, 235, 235);
                    btnReporteVentas.ForeColor = Color.DimGray;
                    btnReporteVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnReporteVentas.Image = Image.FromFile("../../iconos/sales_report/grey.png");
                    break;
                case "Reporte Compras":
                    btnReporteCompras.BackColor = Color.FromArgb(235, 235, 235);
                    btnReporteCompras.ForeColor = Color.DimGray;
                    btnReporteCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
                    btnReporteCompras.Image = Image.FromFile("../../iconos/purchases_report/grey.png");
                    break;
            }
        }

        #endregion

        public void SetTextoUsername(string nombre)
        {
            lblUsername.Text = nombre;
        }

        private void btnDataUser_MouseEnter(object sender, EventArgs e)
        {
            btnDataUser.BackColor = Color.FromArgb(200, 200, 200);
            btnDataUser.Image = Image.FromFile("../../iconos/arrow_down/white.png");
        }

        private void btnDataUser_MouseLeave(object sender, EventArgs e)
        {
            btnDataUser.BackColor = Color.Transparent;
            btnDataUser.Image = Image.FromFile("../../iconos/arrow_down/grey.png");
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            List<OpcionesMenu> opciones = new List<OpcionesMenu>();
            OpcionesMenu opcion = new OpcionesMenu();
            opcion.id = "optActualizarDatos";
            opcion.texto = "Actualizar Datos";
            opcion.imagen = "../../iconos/edit/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "optCambiarPass";
            opcion.texto = "Cambiar Contraseña";
            opcion.imagen = "../../iconos/password/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "optCambiarIdioma";
            opcion.texto = "Idioma";
            opcion.imagen = "../../iconos/idioma/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "optAyuda";
            opcion.texto = "Centro de Ayuda";
            opcion.imagen = "../../iconos/help_center/grey.png";
            opciones.Add(opcion);

            opcion = new OpcionesMenu();
            opcion.id = "optCerrarSesion";
            opcion.texto = "Cerrar Sesión";
            opcion.imagen = "../../iconos/log_out/grey.png";
            opciones.Add(opcion);
            Point ubicacion = FormPrincipal.ActiveForm.PointToScreen(btnDataUser.Location);
            MenuContextual.ShowMenu(opciones, new Point(ubicacion.X + 200, ubicacion.Y + btnDataUser.Height), null);
        }
    }
}
